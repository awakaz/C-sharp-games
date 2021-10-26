using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class FioForm : Form
    {
        private User user;
        public FioForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (fioTextBox.Text != string.Empty)
            {
                user.name = fioTextBox.Text;
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
