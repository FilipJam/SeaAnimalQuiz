
namespace SeaAnimalsQuiz
{
    public partial class AddQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.radioMultChoice = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioFillBlank = new System.Windows.Forms.RadioButton();
            this.pnlMultChoice = new System.Windows.Forms.Panel();
            this.pnlFillBlank = new System.Windows.Forms.Panel();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioOpt4 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOpt4 = new System.Windows.Forms.TextBox();
            this.radioOpt3 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOpt3 = new System.Windows.Forms.TextBox();
            this.radioOpt2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpt2 = new System.Windows.Forms.TextBox();
            this.radioOpt1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOpt1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMultChoice.SuspendLayout();
            this.pnlFillBlank.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type your Question :";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(247, 248);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(313, 62);
            this.txtQuestion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category :";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(247, 334);
            this.comboCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(313, 33);
            this.comboCategory.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(264, 698);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(213, 71);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(16, 15);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 101);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home Page";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // radioMultChoice
            // 
            this.radioMultChoice.AutoSize = true;
            this.radioMultChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMultChoice.Location = new System.Drawing.Point(249, 416);
            this.radioMultChoice.Name = "radioMultChoice";
            this.radioMultChoice.Size = new System.Drawing.Size(167, 29);
            this.radioMultChoice.TabIndex = 15;
            this.radioMultChoice.TabStop = true;
            this.radioMultChoice.Text = "Multiple Choice";
            this.radioMultChoice.UseVisualStyleBackColor = true;
            this.radioMultChoice.CheckedChanged += new System.EventHandler(this.radioQuestionType_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select the Question Type";
            // 
            // radioFillBlank
            // 
            this.radioFillBlank.AutoSize = true;
            this.radioFillBlank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFillBlank.Location = new System.Drawing.Point(249, 451);
            this.radioFillBlank.Name = "radioFillBlank";
            this.radioFillBlank.Size = new System.Drawing.Size(163, 29);
            this.radioFillBlank.TabIndex = 17;
            this.radioFillBlank.TabStop = true;
            this.radioFillBlank.Text = "Fill in the Blank";
            this.radioFillBlank.UseVisualStyleBackColor = true;
            this.radioFillBlank.CheckedChanged += new System.EventHandler(this.radioQuestionType_CheckedChanged);
            // 
            // pnlMultChoice
            // 
            this.pnlMultChoice.Controls.Add(this.pnlFillBlank);
            this.pnlMultChoice.Controls.Add(this.label10);
            this.pnlMultChoice.Controls.Add(this.radioOpt4);
            this.pnlMultChoice.Controls.Add(this.label9);
            this.pnlMultChoice.Controls.Add(this.txtOpt4);
            this.pnlMultChoice.Controls.Add(this.radioOpt3);
            this.pnlMultChoice.Controls.Add(this.label8);
            this.pnlMultChoice.Controls.Add(this.txtOpt3);
            this.pnlMultChoice.Controls.Add(this.radioOpt2);
            this.pnlMultChoice.Controls.Add(this.label7);
            this.pnlMultChoice.Controls.Add(this.txtOpt2);
            this.pnlMultChoice.Controls.Add(this.radioOpt1);
            this.pnlMultChoice.Controls.Add(this.label6);
            this.pnlMultChoice.Controls.Add(this.txtOpt1);
            this.pnlMultChoice.Location = new System.Drawing.Point(31, 486);
            this.pnlMultChoice.Name = "pnlMultChoice";
            this.pnlMultChoice.Size = new System.Drawing.Size(712, 205);
            this.pnlMultChoice.TabIndex = 19;
            // 
            // pnlFillBlank
            // 
            this.pnlFillBlank.Controls.Add(this.txtAnswer);
            this.pnlFillBlank.Controls.Add(this.label5);
            this.pnlFillBlank.Location = new System.Drawing.Point(3, 4);
            this.pnlFillBlank.Name = "pnlFillBlank";
            this.pnlFillBlank.Size = new System.Drawing.Size(706, 199);
            this.pnlFillBlank.TabIndex = 20;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(213, 71);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(313, 43);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Answer :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(182, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(403, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Select a Radio button to set the Correct Answer";
            // 
            // radioOpt4
            // 
            this.radioOpt4.AutoSize = true;
            this.radioOpt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOpt4.Location = new System.Drawing.Point(650, 131);
            this.radioOpt4.Name = "radioOpt4";
            this.radioOpt4.Size = new System.Drawing.Size(17, 16);
            this.radioOpt4.TabIndex = 29;
            this.radioOpt4.TabStop = true;
            this.radioOpt4.UseVisualStyleBackColor = true;
            this.radioOpt4.CheckedChanged += new System.EventHandler(this.radioOpt_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Option 4";
            // 
            // txtOpt4
            // 
            this.txtOpt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpt4.Location = new System.Drawing.Point(385, 121);
            this.txtOpt4.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpt4.Multiline = true;
            this.txtOpt4.Name = "txtOpt4";
            this.txtOpt4.Size = new System.Drawing.Size(251, 40);
            this.txtOpt4.TabIndex = 27;
            this.txtOpt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioOpt3
            // 
            this.radioOpt3.AutoSize = true;
            this.radioOpt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOpt3.Location = new System.Drawing.Point(99, 131);
            this.radioOpt3.Name = "radioOpt3";
            this.radioOpt3.Size = new System.Drawing.Size(17, 16);
            this.radioOpt3.TabIndex = 26;
            this.radioOpt3.TabStop = true;
            this.radioOpt3.UseVisualStyleBackColor = true;
            this.radioOpt3.CheckedChanged += new System.EventHandler(this.radioOpt_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Option 3";
            // 
            // txtOpt3
            // 
            this.txtOpt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpt3.Location = new System.Drawing.Point(123, 121);
            this.txtOpt3.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpt3.Multiline = true;
            this.txtOpt3.Name = "txtOpt3";
            this.txtOpt3.Size = new System.Drawing.Size(235, 40);
            this.txtOpt3.TabIndex = 24;
            this.txtOpt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioOpt2
            // 
            this.radioOpt2.AutoSize = true;
            this.radioOpt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOpt2.Location = new System.Drawing.Point(650, 52);
            this.radioOpt2.Name = "radioOpt2";
            this.radioOpt2.Size = new System.Drawing.Size(17, 16);
            this.radioOpt2.TabIndex = 23;
            this.radioOpt2.TabStop = true;
            this.radioOpt2.UseVisualStyleBackColor = true;
            this.radioOpt2.CheckedChanged += new System.EventHandler(this.radioOpt_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Option 2";
            // 
            // txtOpt2
            // 
            this.txtOpt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpt2.Location = new System.Drawing.Point(385, 42);
            this.txtOpt2.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpt2.Multiline = true;
            this.txtOpt2.Name = "txtOpt2";
            this.txtOpt2.Size = new System.Drawing.Size(251, 40);
            this.txtOpt2.TabIndex = 21;
            this.txtOpt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioOpt1
            // 
            this.radioOpt1.AutoSize = true;
            this.radioOpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOpt1.Location = new System.Drawing.Point(97, 52);
            this.radioOpt1.Name = "radioOpt1";
            this.radioOpt1.Size = new System.Drawing.Size(17, 16);
            this.radioOpt1.TabIndex = 20;
            this.radioOpt1.TabStop = true;
            this.radioOpt1.UseVisualStyleBackColor = true;
            this.radioOpt1.CheckedChanged += new System.EventHandler(this.radioOpt_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Option 1";
            // 
            // txtOpt1
            // 
            this.txtOpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpt1.Location = new System.Drawing.Point(121, 42);
            this.txtOpt1.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpt1.Multiline = true;
            this.txtOpt1.Name = "txtOpt1";
            this.txtOpt1.Size = new System.Drawing.Size(235, 40);
            this.txtOpt1.TabIndex = 4;
            this.txtOpt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(792, 783);
            this.Controls.Add(this.pnlMultChoice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.radioFillBlank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioMultChoice);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuestionForm";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuestionForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMultChoice.ResumeLayout(false);
            this.pnlMultChoice.PerformLayout();
            this.pnlFillBlank.ResumeLayout(false);
            this.pnlFillBlank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.RadioButton radioMultChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioFillBlank;
        private System.Windows.Forms.Panel pnlMultChoice;
        private System.Windows.Forms.RadioButton radioOpt4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOpt4;
        private System.Windows.Forms.RadioButton radioOpt3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOpt3;
        private System.Windows.Forms.RadioButton radioOpt2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOpt2;
        private System.Windows.Forms.RadioButton radioOpt1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOpt1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlFillBlank;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label5;
    }
}