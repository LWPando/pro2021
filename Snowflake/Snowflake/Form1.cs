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
        
        public void Drevo(int n, double x, double y, double a, double dolzina, Graphics g)
        {
            int kot = 50;
            double pojemek = 0.65;
            int kotPogiba = 0;
            double cx = x + dolzina * Math.Cos(a * Math.PI / 180);
            double cy = y + dolzina * Math.Sin(a * Math.PI / 180);
            int x1 = RisaniX(cx);
            int y1 = RisaniY(cy);
            int x2 = RisaniX(x);
            int y2 = RisaniY(y);
            Random r = new Random();
            Color c = Color.FromArgb(0, r.Next(255), 100);
            Pen p = new Pen(c,(float)(Math.Pow(n,1.2)));
            g.DrawLine(p, x1, y1, x2, y2);
            if (n == 0)
                return;
            Drevo(n - 1, cx, cy, a - 45, dolzina * 0.65, g);
            Drevo(n - 1, cx, cy, a + 45, dolzina * 0.65, g);
            Drevo(n - 1, cx, cy, a, dolzina * (1 - 0.65), g);
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
            //x = 0.0;y = 0.95;alfa = 0;
            //int n = 10;
            //Koch(n, 1 / Math.Pow(3, n), g);
            //ObratLevo(240);
            //Koch(n, 1 / Math.Pow(3, n), g);
            //ObratLevo(240);
            //Koch(n, 1 / Math.Pow(3, n), g);
            int n = 3;
            Drevo(n, 0.5, 0, 90, 0.5, g);
        }
        }
    }

