using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace SeaAnimalsQuiz
{
    public class Question
    {
        private string question;
        private int id;
        private Answer correctAnswer;
        private int categoryID;
        private int typeID;
        private Image image;
        
        public Question(string question, int id, int correctAnswerID, int categoryID, int typeID, string imageName)
        {
            this.question = question;
            this.id = id;
            // stores the correct answer for this question
            this.correctAnswer = DbConnectivity.Instance.LoadCorrectAnswer(correctAnswerID);
            this.categoryID = categoryID;
            this.typeID = typeID;

            // finds the path for my images and data folder
            string path = PathManager.GetMyDirectory();
            this.image = Image.FromFile(path + "\\images\\" + imageName);
        }



        public string Text { get => question; }
        public int ID { get => id; }
        public Answer CorrectAnswer { get => correctAnswer; }
        public int CategoryID { get => categoryID; }
        public int TypeID { get => typeID; }
        public Image Image { get => image; set => image = value; }

        public void ShowChoices(Button[] btns)// takes buttons by reference to change their text
        {
            // stores the multiple choices for this question
            List<Answer> answerList = DbConnectivity.Instance.LoadAnswers(this.id);

            
            for (int i = 0; i < answerList.Count; i++)
            {
                btns[i].Text = answerList[i].Text; // show one of the choices
                btns[i].Tag = answerList[i].ID; // asign the answer id of that choice
            }
        }
    }
}
