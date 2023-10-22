
namespace SeaAnimalsQuiz
{
    partial class ScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.lstScores = new System.Windows.Forms.ListBox();
            this.btnPlayerScores = new System.Windows.Forms.Button();
            this.btnAllScores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.BackColor = System.Drawing.Color.SpringGreen;
            this.lstPlayers.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 24;
            this.lstPlayers.Location = new System.Drawing.Point(27, 233);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(225, 292);
            this.lstPlayers.TabIndex = 1;
            // 
            // lstScores
            // 
            this.lstScores.BackColor = System.Drawing.Color.Cyan;
            this.lstScores.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 24;
            this.lstScores.Location = new System.Drawing.Point(286, 233);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(179, 292);
            this.lstScores.TabIndex = 2;
            // 
            // btnPlayerScores
            // 
            this.btnPlayerScores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerScores.Location = new System.Drawing.Point(29, 140);
            this.btnPlayerScores.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayerScores.Name = "btnPlayerScores";
            this.btnPlayerScores.Size = new System.Drawing.Size(223, 83);
            this.btnPlayerScores.TabIndex = 9;
            this.btnPlayerScores.Text = "Show Player Score";
            this.btnPlayerScores.UseVisualStyleBackColor = true;
            this.btnPlayerScores.Click += new System.EventHandler(this.btnPlayerScores_Click);
            // 
            // btnAllScores
            // 
            this.btnAllScores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllScores.Location = new System.Drawing.Point(286, 162);
            this.btnAllScores.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllScores.Name = "btnAllScores";
            this.btnAllScores.Size = new System.Drawing.Size(179, 64);
            this.btnAllScores.TabIndex = 10;
            this.btnAllScores.Text = "Show All";
            this.btnAllScores.UseVisualStyleBackColor = true;
            this.btnAllScores.Click += new System.EventHandler(this.btnAllScores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 48);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select a player from the list \r\nto view their scores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "View all scores";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leaderboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHighscore
            // 
            this.lblHighscore.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHighscore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHighscore.Location = new System.Drawing.Point(39, 546);
            this.lblHighscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(411, 81);
            this.lblHighscore.TabIndex = 13;
            this.lblHighscore.Text = "Leaderboard";
            this.lblHighscore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(489, 676);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAllScores);
            this.Controls.Add(this.btnPlayerScores);
            this.Controls.Add(this.lstScores);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScoreForm";
            this.Text = "Leaderboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScoreForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.Button btnPlayerScores;
        private System.Windows.Forms.Button btnAllScores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHighscore;
    }
}