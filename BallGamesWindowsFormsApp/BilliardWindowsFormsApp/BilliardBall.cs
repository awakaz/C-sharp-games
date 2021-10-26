using BallsCommon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BilliardWindowsFormsApp
{
    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BilliardBall(Form form) : base(form)
        {
        }
        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                vx = -vx;
                ChangeColor();
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vx = -vx;
                ChangeColor();
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                vy = -vy;
                ChangeColor();
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                vy = -vy;
                ChangeColor();
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }

        private void ChangeColor()
        {
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            color = new SolidBrush(randomColor);
        }
    }
}
