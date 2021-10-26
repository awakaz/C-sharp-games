using GeniousIdiotCommon;
using System;
using System.Windows.Forms;

namespace GeniousIdiotWinFormsApp1
{
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            int answer = 0;
            if (QuestionTextBox.Text == "")
            {
                MessageBox.Show("Напишите вопрос ");
                return;
            }
            if (AnswerTextBox.Text == "")
            {
                MessageBox.Show("Напишите ответ");
                return;
            }
            if (AnswerTextBox.Text != string.Empty)
            {
                try
                {
                     answer = Convert.ToInt32(AnswerTextBox.Text);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Ответ должен быть числом");
                    return;
                }
                catch(OverflowException)
                {
                    MessageBox.Show("Ответ должен быть меньше 10^9");
                    return;
                }
            }
            var newQuestion = new Questions(QuestionTextBox.Text, answer);
            QuestionsStorage.Save(newQuestion);

            Close();
        }
    }
}
