using BallsCommon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public class FirstSalutBall : RandomPointBall
    {
        public event EventHandler<PointF> OnEndFiring;
        public FirstSalutBall(Form form) : base(form)
        {
            radius = 15;
            centerY = DownSide() + radius;
            vx = 0;
            vy = -4;
        }

        protected override void Go()
        {
            base.Go();
            if (2 * centerY < TopSide() + DownSide())
            {
                Stop();
                Clear();
                OnEndFiring.Invoke(this, new PointF(centerX, centerY));
            }
        }
    }
}
