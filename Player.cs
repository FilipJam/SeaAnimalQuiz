using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaAnimalsQuiz
{
    public class Player
    {
        private string playerName;
        private int id;

        public Player() { }
        public Player(string name, int id)
        {
            this.playerName = name;
            this.id = id;
        }

        public string Name { get => playerName; set => playerName = value; }
        public int ID { get => id; set => id = value; }

        public List<int> GetPlayerScores()
        {
            // loads the scores for this Player instance
            return DbConnectivity.Instance.LoadScores(this.id);
        }
    }
}
