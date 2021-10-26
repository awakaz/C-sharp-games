using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class resultsForm : Form
    {
        public resultsForm()
        {
            InitializeComponent();
        }
        private void resultsForm_Load(object sender, EventArgs e)
        {
           User dataBest = ResultsStorage.GetBestPlayer();
           bestDataGridView.Rows.Add(dataBest.name, dataBest.result);
           List<User> data = ResultsStorage.Get();
           for (int i = 0; i < data.Count; i++)
           {
              resultsDataGridView.Rows.Add(data[i].name, data[i].result);
           }    
        }
    }
}
