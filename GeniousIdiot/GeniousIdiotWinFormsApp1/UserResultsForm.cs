using GeniousIdiotCommon;
using System;
using System.Windows.Forms;

namespace GeniousIdiotWinFormsApp1
{
    public partial class UserResultsForm : Form
    {
        public UserResultsForm()
        {
            InitializeComponent();
        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            var results = ResultsStorage.GetAll();
            for (int i = 0; i < results.Count; i++)
            {
                ResultsDataGridView.Rows.Add(results[i].Name, results[i].CountRightAnswers, results[i].Diagnose);
            }
        }
    }
}
