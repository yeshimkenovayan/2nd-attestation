using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risunki
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        SolidBrush fill;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.White);
            pen.Width = 2;
            g = this.CreateGraphics();
            fill = new SolidBrush(Color.Blue);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(fill, new Rectangle(0, 0, this.Width, this.Height));
            g.DrawRectangle(pen, new Rectangle(0, 0, this.Width, this.Height));
            g.DrawEllipse(pen, new Rectangle(50, 70, 20, 20));
            g.DrawEllipse(pen, new Rectangle(60, 300, 20, 20));
            g.DrawEllipse(pen, new Rectangle(280, 50, 20, 20));
            g.DrawEllipse(pen, new Rectangle(450, 90, 20, 20));
            g.DrawEllipse(pen, new Rectangle(650, 150, 20, 20));
            g.DrawEllipse(pen, new Rectangle(550, 250, 20, 20));
            g.DrawEllipse(pen, new Rectangle(620, 350, 20, 20));
            g.DrawEllipse(pen, new Rectangle(270, 280, 20, 20));

            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(50, 70, 20, 20));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(60, 300, 20, 20));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(280, 50, 20, 20));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(450, 90, 20, 20));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(650, 150, 20, 20));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(550, 250, 20, 20));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(620, 350, 20, 20));
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(270, 280, 20, 20));

            pen = new Pen(Color.Red);
            pen.Width = 2;
            Point[] points =
            {
                new Point(140,130),
                new Point(150,140),
                new Point(160,140),
                new Point(155,150),
                new Point(160,160),
                new Point(150, 160),
                new Point(140, 170),
                new Point(130, 160),
                new Point(120, 160),
                new Point(125,150),
                new Point(120, 140),
                new Point(130, 140) 
            };
            g.DrawPolygon(pen, points);

            Point[] pointss =
            {
                new Point(140+450,130-20),
                new Point(150+450,140-20),
                new Point(160+450,140-20),
                new Point(155+450,150-20),
                new Point(160+450,160-20),
                new Point(150+450, 160-20),
                new Point(140+450, 170-20),
                new Point(130+450, 160-20),
                new Point(120+450, 160-20),
                new Point(125+450,150-20),
                new Point(120+450, 140-20),
                new Point(130+450, 140-20)
            };
            g.DrawPolygon(pen, pointss);

            Point[] pointsss =
            {
                new Point(140+340,130+160),
                new Point(150+340,140+160),
                new Point(160+340,140+160),
                new Point(155+340,150+160),
                new Point(160+340,160+160),
                new Point(150+340, 160+160),
                new Point(140+340, 170+160),
                new Point(130+340, 160+160),
                new Point(120+340, 160+160),
                new Point(125+340,150+160),
                new Point(120+340, 140+160),
                new Point(130+340, 140+160)
            };
            g.DrawPolygon(pen, pointsss);

            Point[] pointssss =
           {
                new Point(140+70,130+100),
                new Point(150+70,140+100),
                new Point(160+70,140+100),
                new Point(155+70,150+100),
                new Point(160+70,160+100),
                new Point(150+70, 160+100),
                new Point(140+70, 170+100),
                new Point(130+70, 160+100),
                new Point(120+70, 160+100),
                new Point(125+70,150+100),
                new Point(120+70, 140+100),
                new Point(130+70, 140+100)
            };
            g.DrawPolygon(pen, pointssss);

            g.FillPolygon(new SolidBrush(Color.Red), points);
            g.FillPolygon(new SolidBrush(Color.Red), pointss);
            g.FillPolygon(new SolidBrush(Color.Red), pointsss);
            g.FillPolygon(new SolidBrush(Color.Red), pointssss);

            pen = new Pen(Color.Yellow);
            Point[] shest =
            {
                new Point(396,151),
                new Point(445, 170),
                new Point(445, 205),
                new Point(396, 225),
                new Point(347, 205),
                new Point(347, 170)
            };
            g.DrawPolygon(pen, shest);
            g.FillPolygon(new SolidBrush(Color.Yellow), shest);


            pen = new Pen(Color.Green);
            Point[] strelochka =
            {
                new Point(396, 168),
                new Point(410, 190),
                new Point(402, 190),
                new Point(402, 213),
                new Point(392, 213),
                new Point(392, 190),
                new Point(384, 190)
            };
            g.DrawPolygon(pen, strelochka);
            g.FillPolygon(new SolidBrush(Color.Green), strelochka);

            g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(420, 112, 5, 30));
            g.FillEllipse(new SolidBrush(Color.Green), 408, 124, 30, 5);

            g.FillRectangle(new SolidBrush(Color.White), 459, 8, 220, 30);
            pen = new Pen(Color.Yellow);
            pen.Width = 3;
            g.DrawRectangle(pen, 458, 8, 221, 31);

           using (Font font1 = new Font("Arial", 12, FontStyle.Italic))
            {
                Rectangle rect = new Rectangle(458, 8, 221, 31);
                g.DrawString("Level: 1 Score 200 Live: ***", font1, Brushes.Black, rect);
            }

            pen = new Pen(Color.Black);
            pen.Width = 5; 
           g.DrawRectangle(pen, 0, 0, 696, 400);


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }
    }
}
