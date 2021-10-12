using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snowflake
{
    public partial class Form1 : Form
    {
        private double x;
        private double y;
        private double alfa;
        public Form1()
        {
            InitializeComponent();
        }
        private int RisaniX(double rx)
        {
            return (int)Math.Round(this.Width * rx);
        }
        private int RisaniY(double ry)
        {
            return (int)Math.Round(this.Height - this.Height * ry);
        }

        public void ObratLevo(double kot)
        {
            alfa = alfa + kot;
        }

        public void Premik(double d, Graphics g)
        {
            double stariX = x;
            double stariY = y;
            x = x + d*Math.Cos(alfa * Math.PI/180);
            y = y + d*Math.Sin(alfa * Math.PI / 180);
            int x1 = RisaniX(stariX);
            int y1 = RisaniY(stariY);
            int x2 = RisaniX(x);
            int y2 = RisaniY(y);
            g.DrawLine(new Pen(Color.Red, 3), x1, y1, x2, y2);

        }

        public void Koch(int n, double korak, Graphics g)
        {
            if (n == 0)
            {
                Premik(korak, g);
                return;
            }

            Koch(n - 1, korak, g);
            ObratLevo(-60);
            Koch(n - 1, korak, g);
            ObratLevo(120);
            Koch(n - 1, korak, g);
            ObratLevo(-60);
            Koch(n - 1, korak, g);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            /*   x = 0.0; y = 0.1; alfa = 0;
               for(int k = 0; k < 3; k++)
               {
                   double korak = 0.5;
                   Premik(korak, g);
                   ObratLevo(360 / 3);
                }*/
            //Random r = new Random();
            //x = 0.5;y = 0.5;alfa = 0;
            //for(int k = 0; k < 10000; k++) {

            //    ObratLevo(r.Next(360));
            //    Premik(0.1, g);
            //}
            x = 0.0;y = 0.95;alfa = 0;
            int n = 10;
            Koch(n, 1 / Math.Pow(3, n), g);
            ObratLevo(240);
            Koch(n, 1 / Math.Pow(3, n), g);
            ObratLevo(240);
            Koch(n, 1 / Math.Pow(3, n), g);
        }
        }
    }

