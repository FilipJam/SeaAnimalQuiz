using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaAnimalsQuiz
{
    public class CurrentPlayer : Player 
    {
        private static CurrentPlayer instance;

        public static CurrentPlayer Instance
        {
            // CurrentPlayer has the same functionality of Player but only one instance can be used
            get
            {
                if (instance == null)
                    instance = new CurrentPlayer();
                return instance;
            }
        }
    }
}
