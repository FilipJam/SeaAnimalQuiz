
namespace SeaAnimalsQuiz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playerDropDown = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewScores = new System.Windows.Forms.Button();
            this.btnViewQuestions = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(45, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sea Animals Quiz";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(32, 537);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(396, 52);
            this.btnAddQuestion.TabIndex = 3;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "or choose existing player";
            // 
            // playerDropDown
            // 
            this.playerDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDropDown.FormattingEnabled = true;
            this.playerDropDown.Location = new System.Drawing.Point(76, 359);
            this.playerDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerDropDown.Name = "playerDropDown";
            this.playerDropDown.Size = new System.Drawing.Size(297, 39);
            this.playerDropDown.TabIndex = 9;
            this.playerDropDown.SelectedIndexChanged += new System.EventHandler(this.playerDropDown_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(33, 422);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(177, 64);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer.Location = new System.Drawing.Point(76, 275);
            this.txtPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(297, 38);
            this.txtPlayer.TabIndex = 7;
            this.txtPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Player Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewScores
            // 
            this.btnViewScores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScores.Location = new System.Drawing.Point(208, 422);
            this.btnViewScores.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewScores.Name = "btnViewScores";
            this.btnViewScores.Size = new System.Drawing.Size(219, 64);
            this.btnViewScores.TabIndex = 11;
            this.btnViewScores.Text = "View Scores";
            this.btnViewScores.UseVisualStyleBackColor = true;
            this.btnViewScores.Click += new System.EventHandler(this.btnViewScores_Click);
            // 
            // btnViewQuestions
            // 
            this.btnViewQuestions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuestions.Location = new System.Drawing.Point(33, 597);
            this.btnViewQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewQuestions.Name = "btnViewQuestions";
            this.btnViewQuestions.Size = new System.Drawing.Size(396, 52);
            this.btnViewQuestions.TabIndex = 12;
            this.btnViewQuestions.Text = "View Questions";
            this.btnViewQuestions.UseVisualStyleBackColor = true;
            this.btnViewQuestions.Click += new System.EventHandler(this.btnViewQuestions_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(463, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnViewQuestions);
            this.Controls.Add(this.btnViewScores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerDropDown);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sea Animals Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox playerDropDown;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewScores;
        private System.Windows.Forms.Button btnViewQuestions;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

