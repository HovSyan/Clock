namespace Clock
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.circleProgressBarSecond = new Clock.Code.CircleProgressBarSecond();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.circleProgressBarMinute = new Clock.Code.CircleProgressBarMinute();
            this.circulusProgressBarHour = new Clock.Code.CircleProgressBarHour();
            this.circleProgressBarHour = new Clock.Code.CircleProgressBarHour();
            this.SuspendLayout();
            // 
            // circleProgressBarSecond
            // 
            this.circleProgressBarSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleProgressBarSecond.Location = new System.Drawing.Point(403, 12);
            this.circleProgressBarSecond.Name = "circleProgressBarSecond";
            this.circleProgressBarSecond.Size = new System.Drawing.Size(175, 183);
            this.circleProgressBarSecond.TabIndex = 0;
            this.circleProgressBarSecond.MouseDown += new System.Windows.Forms.MouseEventHandler(this.circleProgressBarSecond_MouseDown);
            this.circleProgressBarSecond.MouseMove += new System.Windows.Forms.MouseEventHandler(this.circleProgressBarSecond_MouseMove);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // circleProgressBarMinute
            // 
            this.circleProgressBarMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleProgressBarMinute.Location = new System.Drawing.Point(222, 12);
            this.circleProgressBarMinute.Name = "circleProgressBarMinute";
            this.circleProgressBarMinute.Size = new System.Drawing.Size(175, 183);
            this.circleProgressBarMinute.TabIndex = 1;
            this.circleProgressBarMinute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.circleProgressBarMinute_MouseDown);
            this.circleProgressBarMinute.MouseMove += new System.Windows.Forms.MouseEventHandler(this.circleProgressBarMinute_MouseMove);
            // 
            // circulusProgressBarHour
            // 
            this.circulusProgressBarHour.Location = new System.Drawing.Point(37, 25);
            this.circulusProgressBarHour.Name = "circulusProgressBarHour";
            this.circulusProgressBarHour.Size = new System.Drawing.Size(175, 183);
            this.circulusProgressBarHour.TabIndex = 2;
            // 
            // circleProgressBarHour
            // 
            this.circleProgressBarHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.circleProgressBarHour.Location = new System.Drawing.Point(51, 12);
            this.circleProgressBarHour.Name = "circleProgressBarHour";
            this.circleProgressBarHour.Size = new System.Drawing.Size(175, 183);
            this.circleProgressBarHour.TabIndex = 2;
            this.circleProgressBarHour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.circleProgressBarHour_MouseDown);
            this.circleProgressBarHour.MouseMove += new System.Windows.Forms.MouseEventHandler(this.circleProgressBarHour_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(590, 220);
            this.Controls.Add(this.circleProgressBarHour);
            this.Controls.Add(this.circleProgressBarMinute);
            this.Controls.Add(this.circleProgressBarSecond);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Clock";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Code.CircleProgressBarSecond circleProgressBarSecond;
        private System.Windows.Forms.Timer timer;
        private Code.CircleProgressBarMinute circleProgressBarMinute;
        private Code.CircleProgressBarHour circulusProgressBarHour;
        private Code.CircleProgressBarHour circleProgressBarHour;
    }
}

