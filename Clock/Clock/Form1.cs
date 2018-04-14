using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        Point position;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressUpgradeSecond(DateTime.Now.Second);
            ProgressUpgradeMinute(DateTime.Now.Minute);
            ProgressUpgradeHour(DateTime.Now.Hour);

        }

        public void ProgressUpgradeSecond(object progress)
        {
            circleProgressBarSecond.Invoke((MethodInvoker)delegate
                { circleProgressBarSecond.UpgradeProgress(Convert.ToInt32(progress)); });
        }

        public void ProgressUpgradeMinute(object progress)
        {
            circleProgressBarMinute.Invoke((MethodInvoker)delegate
            { circleProgressBarMinute.UpgradeProgress(Convert.ToInt32(progress)); });
        }

        public void ProgressUpgradeHour(object progress)
        {
            circleProgressBarHour.Invoke((MethodInvoker)delegate
            { circleProgressBarHour.UpgradeProgress(Convert.ToInt32(progress)); });
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ProgressUpgradeSecond(DateTime.Now.Second);
            if(DateTime.Now.Second == 0)
                ProgressUpgradeMinute(DateTime.Now.Minute);
            if (DateTime.Now.Hour == 0)
                ProgressUpgradeHour(DateTime.Now.Hour);
        }

        private void circleProgressBarHour_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                position = new Point(e.X, e.Y);
            }
        }

        private void circleProgressBarMinute_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                position = new Point(e.X, e.Y);
            }
        }

        private void circleProgressBarSecond_MouseDown(object sender, MouseEventArgs e)
        {
            position = new Point(e.X, e.Y);
        }

        private void circleProgressBarHour_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point newPosition = new Point(e.X - position.X, e.Y - position.Y);
                this.Location = new Point(this.Location.X + newPosition.X,
                    this.Location.Y + newPosition.Y);
            }
        }

        private void circleProgressBarMinute_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point newPosition = new Point(e.X - position.X, e.Y - position.Y);
                this.Location = new Point(this.Location.X + newPosition.X,
                    this.Location.Y + newPosition.Y);
            }
        }

        private void circleProgressBarSecond_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point newPosition = new Point(e.X - position.X, e.Y - position.Y);
                this.Location = new Point(this.Location.X + newPosition.X,
                    this.Location.Y + newPosition.Y);
            }
        }
    }
}
