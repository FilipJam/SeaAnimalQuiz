using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaAnimalsQuiz
{
    public partial class ListQuestionForm : Form
    {
        public ListQuestionForm()
        {
            InitializeComponent();
            CenterToScreen();
            List<Question> questions = DbConnectivity.Instance.LoadQuestions();
            for(int i = 0; i < questions.Count; i++)
            {
                // displays question text with the correct answer for this question
                lstQuestions.Items.Add("Q) " + questions[i].Text);
                lstQuestions.Items.Add("\tA) " + questions[i].CorrectAnswer.Text);

            }

        }

        private void ListQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Home.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
