using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeaAnimalsQuiz
{
    public partial class QuizForm : Form
    {
        List<Question> questionList;

        // this will store questions the player got wrong
        List<string> wrongQuestions;
        Button[] buttons;

        // this number is used to get current question from questionList
        int questionIndex = 0;
        int score;
        int percentage;

        public QuizForm()
        {
            InitializeComponent();
            CenterToScreen();
            wrongQuestions = new List<string>();
            // DbConnectivity loads questions which are then randomized for the quiz
            questionList = RandomizeQuestions(DbConnectivity.Instance.LoadQuestions());
            buttons = new Button[4] { btn1, btn2, btn3, btn4 };
            ShowQuestion();
            
        }


        private List<Question> RandomizeQuestions(List<Question> questions)
        {
            Random rand = new Random();
            List<Question> shuffledQuestions = new List<Question>();
            // loops until initial question list is empty
            while (questions.Count > 0)
            {
                // generates random index value
                int i = rand.Next(questions.Count);
                // Adds randomly selected question
                shuffledQuestions.Add(questions[i]);

                // removes selected question to avoid duplicates for the remainder of the loop
                questions.RemoveAt(i);
            }
            return shuffledQuestions;
        }
        private void NextQuestion()
        {

            questionIndex++; // increments index for next question
            // checks if this is last question
            if (questionIndex == questionList.Count)
            {
                // calculate percentage
                percentage = (int)Math.Round((score * 100.0) / questionList.Count);
                string message = "Quiz Finished!\n" +
                                "You have answered " + score + " questions correctly.\n" +
                                "Your total percentage is " + percentage + "%\n\n" +
                                "These are the questions you got wrong:\n";
                // shows the player what questions they got wrong
                foreach (string txt in wrongQuestions)
                    message += txt + '\n';

                // uses id of current player to add their score to database
                DbConnectivity.Instance.AddScore(CurrentPlayer.Instance.ID, score*10);
                MessageBox.Show(message);               // score is multiplied by 10 for visual purposes

                this.Close();
            }
            else ShowQuestion();
        }
        private void ShowQuestion()
        {
            // stores the current question in simple variable for readability
            Question question = questionList[questionIndex];
            // displays question to user with appropriate question number
            lblQuestion.Text = questionIndex + 1 + ") " + question.Text;

            imgQuestion.Image = question.Image;

            // QuestionType enumerator is used to avoid confusion and maintain structure
            if (question.TypeID == (int)QuestionType.FillBlank)
                pnlBlank.Visible = true;
            else if(question.TypeID == (int)QuestionType.MultipleChoice)
            {
                pnlBlank.Visible = false;
                // displays multiple choices on buttons if question type is multiple choice
                question.ShowChoices(buttons);
            }
        }

        private void checkAnswerEvent(object sender, EventArgs e) // all 4 buttons use this event
        {
            // using sender object we specify which button called this event
            Button btn = (Button)sender;
            // btnTag represents the id for this selected answer
            int btnTag = Convert.ToInt32(btn.Tag);
            Question currentQuestion = questionList[questionIndex];

            if (btnTag == currentQuestion.CorrectAnswer.ID)
                score++; // increments score if player answerd correctly
            else
                wrongQuestions.Add(lblQuestion.Text);

            NextQuestion();
        }
        private void btnSubmit_Click(object sender, EventArgs e)// checks answer for fill in the blank
        {
            Question currentQuestion = questionList[questionIndex];
            string playerAnswer = txtAnswer.Text.Trim();
            txtAnswer.Clear(); // clears the text box after player submits answer
            if (playerAnswer == "")
                MessageBox.Show("Type your answer in the text box");
            else
            {
                // compares the player's answer with the correct answer
                if (playerAnswer.ToLower() == currentQuestion.CorrectAnswer.Text.ToLower())
                    score++;
                else
                    wrongQuestions.Add(lblQuestion.Text);
                NextQuestion();
            }
            
        }

        private void QuizForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Home.Show();
        }
    }
}
