
namespace _2048WindowsFormsApp
{
    partial class MainForm
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
            this.label = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeFiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeSixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            this.sizeSevenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeEightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Score";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(136, 54);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(18, 20);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameRulesToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.sizeMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.gameRulesToolStripMenuItem.Text = "Правила игры";
            this.gameRulesToolStripMenuItem.Click += new System.EventHandler(this.gameRulesToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.restartToolStripMenuItem.Text = "Начать заново";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.resultsToolStripMenuItem.Text = "Результаты";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // sizeMapToolStripMenuItem
            // 
            this.sizeMapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeFiveToolStripMenuItem,
            this.sizeSixToolStripMenuItem,
            this.sizeSevenToolStripMenuItem,
            this.sizeEightToolStripMenuItem});
            this.sizeMapToolStripMenuItem.Name = "sizeMapToolStripMenuItem";
            this.sizeMapToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.sizeMapToolStripMenuItem.Text = "Изменить размер поля";
            // 
            // sizeFiveToolStripMenuItem
            // 
            this.sizeFiveToolStripMenuItem.Name = "sizeFiveToolStripMenuItem";
            this.sizeFiveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sizeFiveToolStripMenuItem.Text = "5X5";
            this.sizeFiveToolStripMenuItem.Click += new System.EventHandler(this.sizeFiveToolStripMenuItem_Click);
            // 
            // sizeSixToolStripMenuItem
            // 
            this.sizeSixToolStripMenuItem.Name = "sizeSixToolStripMenuItem";
            this.sizeSixToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sizeSixToolStripMenuItem.Text = "6X6";
            this.sizeSixToolStripMenuItem.Click += new System.EventHandler(this.sizeSixToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "The best score";
            // 
            // bestScoreLabel
            // 
            this.bestScoreLabel.AutoSize = true;
            this.bestScoreLabel.Location = new System.Drawing.Point(136, 93);
            this.bestScoreLabel.Name = "bestScoreLabel";
            this.bestScoreLabel.Size = new System.Drawing.Size(18, 20);
            this.bestScoreLabel.TabIndex = 4;
            this.bestScoreLabel.Text = "0";
            // 
            // sizeSevenToolStripMenuItem
            // 
            this.sizeSevenToolStripMenuItem.Name = "sizeSevenToolStripMenuItem";
            this.sizeSevenToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sizeSevenToolStripMenuItem.Text = "7X7";
            this.sizeSevenToolStripMenuItem.Click += new System.EventHandler(this.sizeSevenToolStripMenuItem_Click);
            // 
            // sizeEightToolStripMenuItem
            // 
            this.sizeEightToolStripMenuItem.Name = "sizeEightToolStripMenuItem";
            this.sizeEightToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sizeEightToolStripMenuItem.Text = "8X8";
            this.sizeEightToolStripMenuItem.Click += new System.EventHandler(this.sizeEightToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(478, 604);
            this.Controls.Add(this.bestScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "2048";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bestScoreLabel;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeFiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeSixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeSevenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeEightToolStripMenuItem;
    }
}

