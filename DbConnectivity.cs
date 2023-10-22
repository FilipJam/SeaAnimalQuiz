using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SeaAnimalsQuiz
{
    public class DbConnectivity : IDatabase // inherits interface to ensure structure
    {
        private static DbConnectivity instance = null;

        //public static DbConnectivity Instance { get => instance ?? (instance = new DbConnectivity()); }
        //                                                    Short hand for the code below
        public static DbConnectivity Instance
        {
            get
            {
                if (instance == null)
                    instance = new DbConnectivity(); // creates an instance if it is not instantiated
                return instance; // return instance if it exists
                // this ensures only one instance is used throughout the program
            }
        }

        
        private DbConnectivity() { }

        // this delegate is used to simplify the code
        private delegate object SelectDelegate(OleDbDataReader r);

        public OleDbConnection GetConnection()
        {
            string path = PathManager.GetMyDirectory();
            // path ensures the database file is found regardless of the project's location
            string connString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + path + @"/data/database.mdb";
            return new OleDbConnection(connString);
        }

        // Select queries have the same code structure with a different execution.
        // SelectDelegate is used to handle this execution.
        private object MySelectQuery(string sql, SelectDelegate getItems)
        {
            // stores the connection to the database
            OleDbConnection myConnection = GetConnection();
            // sql and myConnection is passed to command to ensure the query is executed onto connected database
            OleDbCommand command = new OleDbCommand(sql, myConnection);
            try
            {
                myConnection.Open(); // Opens connection to database to give access for sql commands
                // command.ExecuteReader() encapsulates the selected data from database in a reader object
                return getItems(command.ExecuteReader()); // executes delegate function with OleDbDataReader
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                // finally block ensures the connection always closes for security
                myConnection.Close();
            }
        }

        private void MyNonQuery(string sql)
        {
            OleDbConnection myConnection = GetConnection();
            OleDbCommand command = new OleDbCommand(sql, myConnection);
            try
            {
                myConnection.Open();
                command.ExecuteNonQuery(); // executes insert query
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }

        //DELETE FROM table_name WHERE condition;
        public void DeleteQuestion(int questionID)
        {
            // inserts player into database with specific playerName
            string sql = $"DELETE FROM question WHERE ID={questionID};";
            MyNonQuery(sql);
        }

        public void AddPlayer(string playerName)
        {
            // inserts player into database with specific playerName
            string sql = "INSERT INTO player(playerName) VALUES('" + playerName + "')";
            MyNonQuery(sql);
        }

        public List<Player> LoadPlayers()
        {
            // selects all players from database
            string sql = "SELECT * FROM player";
            // MySelectQuery has a cast because return type of method is an object
            return (List<Player>)MySelectQuery(sql, CreatePlayerList);// passed method as delegate
        }

        public void AddScore(int playerID, int score)
        {
            string sql = "INSERT INTO score(score, playerID) VALUES(" + score + ',' + playerID + ")";
            MyNonQuery(sql);
        }
        public List<int> LoadScores(int playerID)
        {
            // selects scores of a particular playerID
            string sql = "SELECT * FROM score WHERE playerID = " + playerID;
            return (List<int>)MySelectQuery(sql, CreateScoreList);
        }

        public void AddQuestion(string question, int categoryID, int typeID, string[] answers, string correctAnswer)
        {
            // defined return type as 'object' because there were problems with 'int' return type
            object GetID(OleDbDataReader myReader) // method signature matches signature of delegate
            {
                myReader.Read();
                return int.Parse(myReader["ID"].ToString());
            }
            string sql = "INSERT INTO question(question, correctAnswerID, categoryID, typeID, imageName)" +
                            "VALUES('" + question + "', 0, " + categoryID + ", " + typeID + ", 'blank.png')";
            // inserts the question into 'question' table
            MyNonQuery(sql);

            sql = "SELECT ID FROM question WHERE question = '" + question + "'";
            // gets questionID of the recently added question
            int questionID = (int)MySelectQuery(sql, GetID);

            // inserts all multiple choice answers for this questionID
            foreach (string answer in answers)
            {
                sql = "INSERT INTO answer(answer, questionID) VALUES('" + answer + "', " + questionID + ")";
                MyNonQuery(sql);
            }
            
            sql = "SELECT ID FROM answer WHERE answer = '" + correctAnswer + "'";
            // selects ID from the recently added answer which represents the correct answer
            int correctAnswerID = (int)MySelectQuery(sql, GetID);

            // uses this correctAnswerID to update the recently added question
            sql = "UPDATE question SET correctAnswerID = " + correctAnswerID + " WHERE ID = " + questionID;
            MyNonQuery(sql);

            // this complicated process may be due to poor design of database
        }
        public List<Question> LoadQuestions()
        {
            string sql = "SELECT * FROM question";
            return (List<Question>)MySelectQuery(sql, CreateQuestionList);
        }

        public List<Answer> LoadAnswers(int questionID)
        {
            // selects answers of a particular question
            string sql = "SELECT * FROM answer WHERE questionID = " + questionID.ToString();
            return (List<Answer>)MySelectQuery(sql, CreateAnswerList);
        }

        public Answer LoadCorrectAnswer(int answerID)
        {
            Answer GetAnswer(OleDbDataReader myReader)
            {
                myReader.Read(); // reads the row of data
                                    // passing a field name, myReader returns the data for that field
                Answer answer = new Answer(myReader["answer"].ToString(), int.Parse(myReader["ID"].ToString()));
                return answer;
            }
            // selects a specific answer using an ID that represents the correct answer
            string sql = "SELECT * FROM answer WHERE ID = " + answerID;
            return (Answer)MySelectQuery(sql, GetAnswer);
        }

        

        private List<Question> CreateQuestionList(OleDbDataReader myReader)
        {
            List<Question> questions = new List<Question>();
            // after execution of Read() method, myReader goes to the next table rwo
            while (myReader.Read()) // while loop terminates when no more rows are left to read
            {
                // stores data from the table row as variables for simplicity
                string q = myReader["question"].ToString();
                int qID = int.Parse(myReader["ID"].ToString());
                int aID = int.Parse(myReader["correctAnswerID"].ToString());
                int cID = int.Parse(myReader["categoryID"].ToString());
                int tID = int.Parse(myReader["typeID"].ToString());
                string imageName = myReader["imageName"].ToString();

                // instantiates Question object with data from table row of the 'question' table
                Question question = new Question(q, qID, aID, cID, tID, imageName);
                questions.Add(question);
            }
            
            return questions;
        }

        private List<Answer> CreateAnswerList(OleDbDataReader myReader)
        {
            List<Answer> answers = new List<Answer>();
            while (myReader.Read())
                answers.Add(new Answer(myReader["answer"].ToString(), 
                            int.Parse(myReader["ID"].ToString())));
            return answers;
        }

        private List<Player> CreatePlayerList(OleDbDataReader myReader)
        {
            List<Player> players = new List<Player>();
            while (myReader.Read())
                players.Add(new Player(myReader["playerName"].ToString(), 
                                int.Parse(myReader["ID"].ToString())));
            return players;
        }

        private List<int> CreateScoreList(OleDbDataReader myReader)
        {
            List<int> scores = new List<int>();
            while (myReader.Read())
                scores.Add(int.Parse(myReader["score"].ToString()));
            return scores;
        }
    }
}
