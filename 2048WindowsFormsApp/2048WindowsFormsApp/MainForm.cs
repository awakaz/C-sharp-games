using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private User user;
        private User bestUser;
        private Label[,] labelsMap;
        private string pathSize = "size.txt";
        private int sizeMap = 4;
        private int score = 0;
        private static Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User("",0);
            FioForm fio = new FioForm(user);
            var result = fio.ShowDialog(this);
            if (result == DialogResult.OK && user.name != string.Empty)
            {
                InitMap();
                GenerateNumber();
                bestUser = ResultsStorage.GetBestPlayer();
                ShowScores();
            }
            else
            {
                Close();
            }
        }
        private void ShowScores()
        {
            scoreLabel.Text = score.ToString();
            bestScoreLabel.Text = bestUser.result.ToString();
        }

        private void InitMap()
        {
            sizeMap = GetSizeMap();
            ClientSize = new Size(sizeMap * 76 + 35, sizeMap * 76 + 100);
            labelsMap = new Label[sizeMap, sizeMap];

            for (int i = 0; i < sizeMap; i++)
            {
                for (int j = 0; j < sizeMap; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private int GetSizeMap()
        {
            if (File.Exists(pathSize))
            {
                var reader = new StreamReader(pathSize);
                int size = Convert.ToInt32(reader.ReadLine());
                reader.Close();
                File.Delete(pathSize);
                return size;
            }
            else
            {
                return 4;
            }  
        }

        private void GenerateNumber()
        {
            while (!isFullMap())
            {
                var numberRandomLabel = random.Next(sizeMap * sizeMap);
                var row = numberRandomLabel / sizeMap;
                var column = numberRandomLabel % sizeMap;
                if (labelsMap[row, column].Text == string.Empty)
                {
                    var randomNumber = random.Next(2);
                    var twoOrFour = Math.Pow(2, Math.Pow(2, randomNumber));
                    labelsMap[row, column].Text = twoOrFour.ToString();
                    break;
                }
            }
        }

        private Label CreateLabel(int row, int column)
        {
            var label = new Label();
            label.BackColor = SystemColors.ControlDark;
            label.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 15 + column * 76;
            int y = 80 + row * 76;
            label.Location = new Point(x, y);
            label.TextChanged += Label_TextChanged;
            return label;
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            var label = (Label)sender;
            UpdateLabelBackColour(label);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }
            bool isMerged = false;
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < sizeMap; i++)
                {
                    for (int j = sizeMap - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = Convert.ToInt32(labelsMap[i, j].Text);
                                        score = score + number * 2;
                                        isMerged = true;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[i, k].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < sizeMap; i++)
                {
                    for (int j = sizeMap - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < sizeMap; i++)
                {
                    for (int j = 0; j < sizeMap; j++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < sizeMap; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = Convert.ToInt32(labelsMap[i, j].Text);
                                        score = score + number * 2;
                                        isMerged = true;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[i, k].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < sizeMap; i++)
                {
                    for (int j = 0; j < sizeMap; j++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < sizeMap; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                for (int j = 0; j < sizeMap; j++)
                {
                    for (int i = 0; i < sizeMap; i++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < sizeMap; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[k, j].Text == labelsMap[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(labelsMap[i, j].Text);
                                        score = score + number * 2;
                                        isMerged = true;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[k, j].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < sizeMap; j++)
                {
                    for (int i = 0; i < sizeMap; i++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < sizeMap; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int j = 0; j < sizeMap; j++)
                {
                    for (int i = sizeMap - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[k, j].Text == labelsMap[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(labelsMap[i, j].Text);
                                        score = score + number * 2;
                                        isMerged = true;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[k, j].Text = string.Empty;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < sizeMap; j++)
                {
                    for (int i = sizeMap - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text;
                                    labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            TryUpdateBestScore();
            ShowScores();
            if(isFullMap() == true || exist2048()) // && isMerged
            {
                MessageBox.Show("Game over");
                MessageBox.Show(user.name + " your result is " + score);
                Close();
            }
            GenerateNumber();
        }

        private void UpdateLabelBackColour(Label label)
        {
            int exponent = 0;
            if(label.Text == string.Empty)
            {
                exponent = 0;
            }
            else
            {
                var number = Convert.ToInt32(label.Text);
                exponent = (int)Math.Log(number, 2);
            }

            Color[] colors = new Color[12];
            colors[0] = SystemColors.ControlDark;
            colors[1] = Color.Gray;
            colors[2] = Color.Turquoise;
            colors[3] = Color.Brown;
            colors[4] = Color.Magenta;
            colors[5] = Color.Yellow;
            colors[6] = Color.Cyan;
            colors[7] = Color.Green;
            colors[8] = Color.Orange;
            colors[9] = Color.Lime;
            colors[10] = Color.Navy;
            colors[11] = Color.Pink;

            label.BackColor = colors[exponent];
        }

        private void TryUpdateBestScore()
        {
            if(score > bestUser.result)
            {
                bestUser.result = score;
                bestUser.name = user.name;
            }
        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rules = "Нажатием стрелки игрок может скинуть все плитки игрового поля в одну из 4 сторон.Если при сбрасывании две плитки одного номинала «налетают» одна на другую, то они превращаются в одну, номинал которой равен сумме соединившихся плиток.";
            MessageBox.Show(rules);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool isFullMap()
        {
            for (int i = 0; i < sizeMap; i++)
            {
                for (int j = 0; j < sizeMap; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool exist2048()
        {
            for (int i = 0; i < sizeMap; i++)
            {
                for (int j = 0; j < sizeMap; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ResultsStorage.SaveBest(bestUser);
                user.result = score;
                ResultsStorage.Save(user);
            }
            catch(NullReferenceException)
            {
                Application.Exit();
            }
            catch(IOException)
            {
                Application.Exit();
            }
        }
        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultsForm results = new resultsForm();
            results.ShowDialog(this);
        }

        private void sizeFiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var writer = new StreamWriter(pathSize, false);
            writer.WriteLine(5);
            writer.Close();
            Application.Restart();
        }

        private void sizeSixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var writer = new StreamWriter(pathSize, false);
            writer.WriteLine(6);
            writer.Close();
            Application.Restart();
        }

        private void sizeSevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var writer = new StreamWriter(pathSize, false);
            writer.WriteLine(7);
            writer.Close();
            Application.Restart();
        }

        private void sizeEightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var writer = new StreamWriter(pathSize, false);
            writer.WriteLine(8);
            writer.Close();
            Application.Restart();
        }
    }
}
