using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock.Code
{
    public partial class CircleProgressBarSecond : UserControl
    {
        int progress;

        public CircleProgressBarSecond()
        {
            progress = DateTime.Now.Second;
            InitializeComponent();
        }

        private void CircleProgressBarSecond_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(-90);

            Rectangle rect = new Rectangle(0 - this.Width / 2 + 20, 0 - this.Height / 2 + 20,
                this.Width - 40, this.Height - 40);
            e.Graphics.DrawPie(new Pen(Color.GreenYellow), rect, 0, (int)(this.progress * 6));
            e.Graphics.FillPie(new SolidBrush(Color.GreenYellow), rect, 0, (int)(this.progress * 6));

            rect = new Rectangle(0 - this.Width / 2 + 30, 0 - this.Height / 2 + 30,
                this.Width - 60, this.Height - 60);
            e.Graphics.DrawPie(new Pen(Color.Green), rect, 0, 360);
            e.Graphics.FillPie(new SolidBrush(Color.Green), rect, 0, 360);

            e.Graphics.RotateTransform(90);
            StringFormat f = new StringFormat();
            f.LineAlignment = StringAlignment.Center;
            f.Alignment = StringAlignment.Center;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawString(DateTime.Now.Second.ToString(),
                new Font("Arial", 24), new SolidBrush(Color.Black), rect, f);

           
            
        }

        public void UpgradeProgress(int progress)
        {
            this.progress = progress;
            this.Invalidate();
        }
    }
}
