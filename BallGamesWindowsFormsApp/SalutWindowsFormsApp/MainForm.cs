using System;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public partial class MainForm : Form
    {
        static Random random = new Random();
        FirstSalutBall firstBall;

        Timer firingTimer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            firingTimer.Interval = 100;
            firingTimer.Tick += FiringTimer_Tick;
            firingTimer.Start();
        }

        private void FiringTimer_Tick(object sender, EventArgs e)
        {
            firstBall = new FirstSalutBall(this);
            firstBall.OnEndFiring += FirstBall_OnEndFiring;
            firstBall.Start();
            firingTimer.Interval = random.Next(1000, 3000);
        }
        private void FirstBall_OnEndFiring(object sender, System.Drawing.PointF e)
        {
            var count = random.Next(4, 11);
            for (int i = 0; i < count; i++)
            {
                var salut = new SalutBall(this, e.X, e.Y);
                salut.Start();
            }
        }
    }
}
