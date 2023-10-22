using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaAnimalsQuiz
{
    public class Answer
    {
        private string answer;
        private int id;
        public Answer(string answer, int id)
        {
            this.answer = answer;
            this.id = id;
        }

        public string Text { get => answer; }
        public int ID { get => id; }
    }
}
