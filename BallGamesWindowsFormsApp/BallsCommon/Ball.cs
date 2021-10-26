using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsCommon
{
    public class Ball
    {
        private Form form;
        private Timer timer;
        protected float vx = 10;
        protected float vy = 10;
        protected float centerX = 10;
        protected float centerY = 10;
        protected int radius = 25;
        protected Brush color = Brushes.Green;
        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public bool IsMovable()
        {
            return timer.Enabled;
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void Show()
        {
            Draw(color);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }
        public bool OnForm()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }
        public bool Exists(int pointX, int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;
            return dx * dx + dy * dy <= radius * radius;
        }
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }
        protected void Clear()
        {
            var brush = Brushes.White;
            Draw(brush);
        }
        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
