using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace SeaAnimalsQuiz
{
    public partial class Form1 : Form
    {
        List<Player> players;
        private static Form1 home;
        public Form1()
        {
            InitializeComponent();
            UpdatePlayerList();
            //This will ensure the Player name will be displayed in the drop down instead of whole object
            playerDropDown.DisplayMember = "Name";
            home = this;
            //ensures the text is empty after list is updated
            txtPlayer.Text = "";
            //Aligns the Form to the center of the screen
            CenterToScreen();

            // deleting questions for testing purposes
           /* DbConnectivity.Instance.DeleteQuestion(40);
            DbConnectivity.Instance.DeleteQuestion(41);*/
        }
        //made this property so that other Forms can access this Main Form
        public static Form1 Home { get => home; }


        private void UpdatePlayerList()
        {
            //Stores all player objects in this list
            players = DbConnectivity.Instance.LoadPlayers();
            //Updates the drop down list
            playerDropDown.DataSource = players;
            
        }

        
        private bool VerifyPlayer(string name) // Checks if inputted name is in player list
        {
            foreach(Player player in players)
                if(player.Name == name) // if the player names match, they are verified
                    return true;
            // if no match was found in the loop, they are a new player
            return false;
        }
        private void btnPlay_Click(object sender, EventArgs e) // starts quiz
        {
            
            // whitespace is trimmed and capitalization ignored
            // so that e.g. '   Dave   ' and 'dave' are the same
            string playerName = txtPlayer.Text.Trim().ToLower();
            txtPlayer.Text = playerName;

            //prompts the user to type if text is empty
            if (playerName == "")
                MessageBox.Show("Please enter your player name to play the Quiz");
            else
            {
                // sets the CurrentPlayer name so that QuizForm has access
                CurrentPlayer.Instance.Name = playerName;
                if (VerifyPlayer(playerName) == false)
                {
                    // Add new player to database if unverified
                    DbConnectivity.Instance.AddPlayer(playerName);
                    UpdatePlayerList();
                    // selects the newest entry to the list
                    playerDropDown.SelectedIndex = players.Count - 1;
                }
                
                // gets the selected player from the list
                Player currentPlayer = (Player)playerDropDown.SelectedItem;

                // sets the current player id so that QuizForm has access
                CurrentPlayer.Instance.ID = currentPlayer.ID;
                
                QuizForm quiz = new QuizForm();
                quiz.Show();
                this.Hide();
            }
        }
        private void playerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player player = (Player)playerDropDown.SelectedItem;
            txtPlayer.Text = player.Name;
            
        }
        private void btnViewScores_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm();
            scoreForm.Show();
            this.Hide();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestion = new AddQuestionForm();
            addQuestion.Show();
            this.Hide();
        }

        private void btnViewQuestions_Click(object sender, EventArgs e)
        {
            ListQuestionForm listQuestion = new ListQuestionForm();
            listQuestion.Show();
            this.Hide();
        }
    }
}
