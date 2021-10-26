
namespace GeniousIdiotWinFormsApp1
{
    partial class AddQuestion
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
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.TipLabel = new System.Windows.Forms.Label();
            this.TipLabel2 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(31, 61);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(203, 26);
            this.QuestionTextBox.TabIndex = 0;
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(31, 146);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(203, 26);
            this.AnswerTextBox.TabIndex = 1;
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(51, 25);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(145, 20);
            this.TipLabel.TabIndex = 2;
            this.TipLabel.Text = "Напишите вопрос";
            // 
            // TipLabel2
            // 
            this.TipLabel2.AutoSize = true;
            this.TipLabel2.Location = new System.Drawing.Point(59, 110);
            this.TipLabel2.Name = "TipLabel2";
            this.TipLabel2.Size = new System.Drawing.Size(137, 20);
            this.TipLabel2.TabIndex = 3;
            this.TipLabel2.Text = "Напишите ответ";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(159, 192);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 36);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 250);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TipLabel2);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.QuestionTextBox);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label TipLabel2;
        private System.Windows.Forms.Button OkButton;
    }
}