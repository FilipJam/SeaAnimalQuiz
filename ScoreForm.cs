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
    public partial class ScoreForm : Form
    {
        List<Player> players;
        public ScoreForm()
        {
            InitializeComponent();
            CenterToScreen();
            players = DbConnectivity.Instance.LoadPlayers();
            lstPlayers.DataSource = players;
            lstPlayers.DisplayMember = "Name";
            lblHighscore.Text = ""; // clears highscore text since no score is displayed at start
        }


        private void btnAllScores_Click(object sender, EventArgs e)
        {
            lblHighscore.Text = "";
            lstScores.Items.Clear();
            string bestPlayer = "";
            int highscore = -1; // highscore is set to -1 to allow for a highscore of 0
            foreach (Player player in players)
            {
                // gets scores for this instance of Player
                List<int> playerScores = player.GetPlayerScores();
                foreach (int score in playerScores)
                {
                    // adds scores to list with player's name
                    lstScores.Items.Add(player.Name + " - " + score);
                    if (score > highscore)
                    {
                        // calculates highscore and finds player with this highscore
                        highscore = score;
                        bestPlayer = player.Name;
                    }
                }
            }
            // only show information on highscore if players exist
            if (bestPlayer != "")
                lblHighscore.Text = bestPlayer + " achieved the Highest score of " + highscore + "\nCongratulations!";
        }

        private void btnPlayerScores_Click(object sender, EventArgs e)
        {
            lblHighscore.Text = "";
            lstScores.Items.Clear();
            // stores selected player in Player object
            Player selectedPlayer = (Player)lstPlayers.SelectedItem;
            List<int> scores = selectedPlayer.GetPlayerScores();
            if (scores.Count > 0)
            {
                foreach (int score in scores)
                    lstScores.Items.Add(score);
                int highscore = scores.Max();
                lblHighscore.Text = selectedPlayer.Name + " achieved a Highscore of " + highscore;
            }
            else // show appropriate message if player has no scores
                MessageBox.Show("There are no records of this player's scores");

        }

        private void ScoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Home.Show();

        }
    }
}
