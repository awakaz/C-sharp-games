using System;
using GeniousIdiotCommon;
using System.Windows.Forms;

namespace GeniousIdiotWinFormsApp1
{
    public partial class FioForm : Form
    {
        private User user;
        public FioForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(FioTextBox.Text != string.Empty)
            {
                user.Name = FioTextBox.Text;
                Close();
            }
            else
            {
               MessageBox.Show("Введите ФИО");
               return;
            }
        }
    }
}
