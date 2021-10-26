
namespace _2048WindowsFormsApp
{
    partial class resultsForm
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
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestDataGridView = new System.Windows.Forms.DataGridView();
            this.BestPlayerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.resultColumn});
            this.resultsDataGridView.Location = new System.Drawing.Point(2, 177);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersWidth = 62;
            this.resultsDataGridView.RowTemplate.Height = 28;
            this.resultsDataGridView.Size = new System.Drawing.Size(918, 380);
            this.resultsDataGridView.TabIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 8;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 150;
            // 
            // resultColumn
            // 
            this.resultColumn.HeaderText = "Result";
            this.resultColumn.MinimumWidth = 8;
            this.resultColumn.Name = "resultColumn";
            this.resultColumn.Width = 150;
            // 
            // bestDataGridView
            // 
            this.bestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BestPlayerNameColumn,
            this.BestResultColumn});
            this.bestDataGridView.Location = new System.Drawing.Point(2, 0);
            this.bestDataGridView.Name = "bestDataGridView";
            this.bestDataGridView.RowHeadersWidth = 62;
            this.bestDataGridView.RowTemplate.Height = 28;
            this.bestDataGridView.Size = new System.Drawing.Size(918, 150);
            this.bestDataGridView.TabIndex = 1;
            // 
            // BestPlayerNameColumn
            // 
            this.BestPlayerNameColumn.HeaderText = "Best player";
            this.BestPlayerNameColumn.MinimumWidth = 8;
            this.BestPlayerNameColumn.Name = "BestPlayerNameColumn";
            this.BestPlayerNameColumn.Width = 150;
            // 
            // BestResultColumn
            // 
            this.BestResultColumn.HeaderText = "Result";
            this.BestResultColumn.MinimumWidth = 8;
            this.BestResultColumn.Name = "BestResultColumn";
            this.BestResultColumn.Width = 150;
            // 
            // resultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 569);
            this.Controls.Add(this.bestDataGridView);
            this.Controls.Add(this.resultsDataGridView);
            this.Name = "resultsForm";
            this.Text = "resultsForm";
            this.Load += new System.EventHandler(this.resultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultColumn;
        private System.Windows.Forms.DataGridView bestDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestPlayerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestResultColumn;
    }
}