using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace TCPIPClient
{
    public partial class Joy : Form
    {
        joystation js = new joystation();
        enum Button
        {
            Ping, Release, Power, L1, L2, L3, R1, R2, R3, LJLS, LJRS, LJU, LJD, RJLS, RJRS, RJU, RJD
        }
        Button btn = Button.Ping;
        public string message="0";
        public Joy()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int timeout = 100;//100ms
            bool IsPing = false;
            while (true)
            {
                if (js.L1)
                {
                    sw.Restart();
                    btn_l1.BackColor = Color.Blue;
                    btn = Button.L1;
                    IsPing = false;
                }
                else
                {
                    btn_l1.BackColor = Color.Gray;
                }
                if (js.L2)
                {
                    sw.Restart();
                    btn_l2.BackColor = Color.Blue;
                    btn = Button.L2;
                    IsPing = false;
                }
                else
                {
                    btn_l2.BackColor = Color.Gray;
                }
                
                if (js.OPTIONS)
                {
                    sw.Restart();
                    btn_op.BackColor = Color.Blue;
                    btn = Button.R3;
                    IsPing = false;
                }
                else
                {
                    btn_op.BackColor = Color.Gray;
                }
                if (js.PS)
                {
                    sw.Restart();
                    btn_ps.BackColor = Color.Blue;
                    btn = Button.Release;
                    IsPing = false;
                }
                else
                {
                    btn_ps.BackColor = Color.Gray;
                }
                if (js.R1)
                {
                    sw.Restart();
                    btn_r1.BackColor = Color.Blue;
                    btn = Button.R1;
                    IsPing = false;
                }
                else
                {
                    btn_r1.BackColor = Color.Gray;
                }
                if (js.R2)
                {
                    sw.Restart();
                    btn_r2.BackColor = Color.Blue;
                    btn = Button.R2;
                    IsPing = false;
                }
                else
                {
                    btn_r2.BackColor = Color.Gray;
                }
                if (js.SHARE)
                {
                    sw.Restart();
                    btn_sh.BackColor = Color.Blue;
                    btn = Button.L3;
                    IsPing = false;
                }
                else
                {
                    btn_sh.BackColor = Color.Gray;
                }
                if (js.SPACE)
                {
                    sw.Restart();
                    btn_sp.BackColor = Color.Blue;
                    btn = Button.Power;
                    IsPing = false;
                }
                else
                {
                    btn_sp.BackColor = Color.Gray;
                }
                if (js.三角形)
                {
                    sw.Restart();
                    btn_tri.BackColor = Color.Blue;
                    btn = Button.RJU;
                    IsPing = false;
                }
                else
                {
                    btn_tri.BackColor = Color.Gray;
                }
                if (js.上)
                {
                    sw.Restart();
                    btn_up.BackColor = Color.Blue;
                    btn = Button.LJU;
                    IsPing = false;
                }
                else
                {
                    btn_up.BackColor = Color.Gray;
                }
                if (js.下)
                {
                    sw.Restart();
                    btn_down.BackColor = Color.Blue;
                    btn = Button.LJD;
                    IsPing = false;
                }
                else
                {
                    btn_down.BackColor = Color.Gray;
                }
                if (js.叉)
                {
                    sw.Restart();
                    btn_cross.BackColor = Color.Blue;
                    btn = Button.RJD;
                    IsPing = false;
                }
                else
                {
                    btn_cross.BackColor = Color.Gray;
                }
                if (js.右)
                {
                    sw.Restart();
                    btn_right.BackColor = Color.Blue;
                    btn = Button.LJRS;
                    IsPing = false;
                }
                else
                {
                    btn_right.BackColor = Color.Gray;
                }
                if (js.圈)
                {
                    sw.Restart();
                    btn_circle.BackColor = Color.Blue;
                    btn = Button.RJRS;
                    IsPing = false;
                }
                else
                {
                    btn_circle.BackColor = Color.Gray;
                }
                if (js.左)
                {
                    sw.Restart();
                    btn_left.BackColor = Color.Blue;
                    btn = Button.LJLS;
                    IsPing = false;
                }
                else
                {
                    btn_left.BackColor = Color.Gray;
                }
                if (js.正方形)
                {
                    sw.Restart();
                    btn_square.BackColor = Color.Blue;
                    btn = Button.RJLS;
                    IsPing = false;
                }
                else
                {
                    btn_square.BackColor = Color.Gray;
                }
                if (IsPing)
                {
                    btn = Button.Ping;
                }
                message = ((int)btn).ToString();

                label1.Invoke(new EventHandler(delegate { label1.Text = js.str; }));

                pbl.Invoke(new EventHandler(delegate { pbl.Refresh(); }));

                pbr.Invoke(new EventHandler(delegate { pbr.Refresh(); }));
                
                Thread.Sleep(10);
                if (sw.Elapsed.TotalMilliseconds>=timeout)
                {
                    IsPing = true;
                    sw.Restart();
                }
            }
        }

        private void pbl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            int size = 25;

            if (js.L3)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Blue), new Rectangle(new Point(pbl.Width / 2 - size, pbl.Height / 2 - size), new Size(2 * size, 2 * size)));

            }
            else
            {
                e.Graphics.DrawEllipse(new Pen(Color.Gray), new Rectangle(new Point(pbl.Width / 2 - size, pbl.Height / 2 - size), new Size(2 * size, 2 * size)));

            }

            double X = -js.JoyStick_LY;
            double Y = js.JoyStick_LX;
            double rad = Math.Atan2(X, Y);
            double len = Math.Sqrt(X * X + Y * Y) * 50.0;
            Point point = new Point((int)(len*Math.Cos(rad)) + pbl.Width / 2, (int)(len * Math.Sin(rad))+ pbl.Height / 2);
            e.Graphics.DrawLine(new Pen(Color.Red), pbl.Width / 2, pbl.Height / 2, point.X, point.Y);


        }

        private void pbr_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            int size = 25;

            if (js.R3)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Blue), new Rectangle(new Point(pbl.Width / 2 - size, pbl.Height / 2 - size), new Size(2 * size, 2 * size)));

            }
            else
            {
                e.Graphics.DrawEllipse(new Pen(Color.Gray), new Rectangle(new Point(pbl.Width / 2 - size, pbl.Height / 2 - size), new Size(2 * size, 2 * size)));
            }
            double X = -js.JoyStick_RY;
            double Y = js.JoyStick_RX;
            double rad = Math.Atan2(X, Y);
            double len =Math.Sqrt( X*X+Y*Y)*50.0;
            Point point = new Point((int)(len * Math.Cos(rad)) + pbl.Width / 2, (int)(len * Math.Sin(rad)) + pbl.Height / 2);
            e.Graphics.DrawLine(new Pen(Color.Red), pbl.Width / 2, pbl.Height / 2, point.X, point.Y);

        }
    }
}
