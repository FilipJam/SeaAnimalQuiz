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
    public partial class AddQuestionForm : Form
    {
        TextBox[] txts;
        RadioButton[] radioBtns;
        string correctAnswer = "";
        int typeID = 0;
        public AddQuestionForm()
        {
            InitializeComponent();
            CenterToScreen();
            pnlMultChoice.Hide(); // hide answer options since question type is not selected
            // using Category enumerator, Items will show as category names but contain a value of enumerator
            comboCategory.Items.Add(Category.Bird);
            comboCategory.Items.Add(Category.Fish);
            comboCategory.Items.Add(Category.Reptile);

            // store multiple choice text boxes for easier use
            txts = new TextBox[] { txtOpt1, txtOpt2, txtOpt3, txtOpt4 };
            // store correct answer radio buttons for easier use
            radioBtns = new RadioButton[] { radioOpt1, radioOpt2, radioOpt3, radioOpt4 };
        } 

        private void radioQuestionType_CheckedChanged(object sender, EventArgs e)
        {
            pnlMultChoice.Show();
            if (radioMultChoice.Checked)
            {
                // store interger value of MultipleChoice enumerator
                typeID = (int)QuestionType.MultipleChoice;
                pnlFillBlank.Hide(); // hiding this, uncovers multiple choice panel
            }
            else if (radioFillBlank.Checked)
            {
                // store interger value of FillBlank enumerator
                typeID = (int)QuestionType.FillBlank;
                pnlFillBlank.Show(); // showing this, covers multiple choice panel
            }

        }
        private void radioOpt_CheckedChanged(object sender, EventArgs e)
        {
            // loops 4 times because there will always be 4 buttons for multiple choice
            for (int i = 0; i < 4; i++)
                if (radioBtns[i].Checked)
                {
                    // selected option turns green
                    txts[i].BackColor = Color.PaleGreen;
                    correctAnswer = txts[i].Text; // assigns the selected text to be the correct answer
                }
                else // unselected options turn red
                    txts[i].BackColor = Color.LightCoral;
        }

        private bool ValidateTextBoxes()
        {
            // checks if every text box is filled in for multiple choice
            foreach (var txt in txts)
                if (txt.Text == "") 
                    return false;
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                txts[i].Text = txts[i].Text.Trim(); // Trim method removes whitespace around the string
            txtAnswer.Text = txtAnswer.Text.Trim();
            // general validation checks for controls
            if (txtQuestion.Text != "" && comboCategory.SelectedIndex >= 0 && typeID > 0)
            {
                string question = txtQuestion.Text.Trim();
                // stores category ID the user selected
                int categoryID = (int)comboCategory.SelectedItem;
                switch (typeID)
                {
                    case 1: // vallidation checks for Multiple Choice panel
                        if (ValidateTextBoxes() && correctAnswer != "")
                        {
                            // stores the text of all multiple choice text boxes in an array
                            string[] answers = { txtOpt1.Text, txtOpt2.Text, txtOpt3.Text, txtOpt4.Text };
                            // Add question to database using values the user entered as arguments
                            DbConnectivity.Instance.AddQuestion(question, categoryID, typeID, answers, correctAnswer);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Please fill in the multiple choice text boxes and select correct answer");
                        break;
                    case 2: // vallidation checks for Fill in the Blank panel
                        if (txtAnswer.Text != "")
                        {
                            // storing one string in an array is redundant
                            // but the AddQuestion() method requires an array
                            string[] answers = { txtAnswer.Text };
                            DbConnectivity.Instance.AddQuestion(question, categoryID, typeID, answers, txtAnswer.Text);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Please enter an answer to submit question");
                        break;
                }
            } else MessageBox.Show("Please fill in all required fields");
        }
        private void AddQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Home.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
