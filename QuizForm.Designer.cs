
namespace SeaAnimalsQuiz
{
    partial class QuizForm
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
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnlMultiple = new System.Windows.Forms.Panel();
            this.pnlBlank = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.imgQuestion = new System.Windows.Forms.PictureBox();
            this.pnlMultiple.SuspendLayout();
            this.pnlBlank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(496, 133);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(446, 96);
            this.btn4.TabIndex = 12;
            this.btn4.Tag = "4";
            this.btn4.Text = "button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(28, 133);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(446, 96);
            this.btn3.TabIndex = 11;
            this.btn3.Tag = "3";
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(496, 15);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(446, 96);
            this.btn2.TabIndex = 10;
            this.btn2.Tag = "2";
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(28, 15);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(446, 96);
            this.btn1.TabIndex = 9;
            this.btn1.Tag = "1";
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(47, 385);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(979, 36);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "Questions";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMultiple
            // 
            this.pnlMultiple.Controls.Add(this.pnlBlank);
            this.pnlMultiple.Controls.Add(this.btn1);
            this.pnlMultiple.Controls.Add(this.btn4);
            this.pnlMultiple.Controls.Add(this.btn2);
            this.pnlMultiple.Controls.Add(this.btn3);
            this.pnlMultiple.Location = new System.Drawing.Point(47, 438);
            this.pnlMultiple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMultiple.Name = "pnlMultiple";
            this.pnlMultiple.Size = new System.Drawing.Size(979, 239);
            this.pnlMultiple.TabIndex = 13;
            // 
            // pnlBlank
            // 
            this.pnlBlank.Controls.Add(this.btnSubmit);
            this.pnlBlank.Controls.Add(this.txtAnswer);
            this.pnlBlank.Location = new System.Drawing.Point(9, 5);
            this.pnlBlank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBlank.Name = "pnlBlank";
            this.pnlBlank.Size = new System.Drawing.Size(960, 226);
            this.pnlBlank.TabIndex = 14;
            this.pnlBlank.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(312, 121);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(331, 64);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(312, 65);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(331, 38);
            this.txtAnswer.TabIndex = 0;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgQuestion
            // 
            //this.imgQuestion.Image = global::SeaAnimalsQuiz.Properties.Resources.Yarzxl;
            this.imgQuestion.Location = new System.Drawing.Point(47, 12);
            this.imgQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgQuestion.Name = "imgQuestion";
            this.imgQuestion.Size = new System.Drawing.Size(979, 366);
            this.imgQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQuestion.TabIndex = 7;
            this.imgQuestion.TabStop = false;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 678);
            this.Controls.Add(this.pnlMultiple);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.imgQuestion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuizForm";
            this.Text = "Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizForm_FormClosed);
            this.pnlMultiple.ResumeLayout(false);
            this.pnlBlank.ResumeLayout(false);
            this.pnlBlank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox imgQuestion;
        private System.Windows.Forms.Panel pnlMultiple;
        private System.Windows.Forms.Panel pnlBlank;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}