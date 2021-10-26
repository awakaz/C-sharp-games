using GeniousIdiotCommon;
using System;
using System.Windows.Forms;

namespace GeniousIdiotWinFormsApp1
{
    public partial class MainForm : Form
    {
        private Game game;
        private User user;
        private int countQuestions;
        private int questionNumber;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            user = new User("", 0, "");
            game = new Game(user);
            FioForm fio = new FioForm(user);
            var result = fio.ShowDialog(this);
            if (result == DialogResult.OK && user.Name != string.Empty)
            {
                countQuestions = game.GetQuestionsCount();
                questionNumber = 0;
                ShowNextQuestion();
            }
            else
            {
                Close();
            }
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.PopRandomQuestion();
            questionTextLabel.Text = currentQuestion.Text;
            questionNumber++;
            questionNumberLabel.Text = "Вопрос №" + questionNumber;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var test = AnswerChecking.Test(userAnswerTextBox.Text, out int userAnswerInt, out string message);
            if(test == false)
            {
                MessageBox.Show(message);
                return;
            }
            game.AcceptAnswer(userAnswerInt);
            if (game.End())
            {
                var mail = game.CalculateDiagnose();
                MessageBox.Show(mail);
                ResultsStorage.Save(user);
                return;
            }

            ShowNextQuestion();
            userAnswerTextBox.Text = "";
        }

        private void StartGameMenuItem_Click(object sender, EventArgs e)
        {
            userAnswerTextBox.Text = "";
            MainForm_Load(sender, e); 
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResultsMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new UserResultsForm();
            resultsForm.ShowDialog(this);
        }

        private void AddQuestionMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestion = new AddQuestion();
            addQuestion.ShowDialog(this);
        }
    }
}
