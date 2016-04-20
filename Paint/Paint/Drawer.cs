using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public enum Shape { Pencil, Rectangle, Circle, Line, Eraser, Triangle, Fill, Trapec}

    class Drawer
    {
        public Graphics g;
        private Bitmap btm;
        private PictureBox picture;
        public Shape shape;
        public Pen pen;
        public GraphicsPath path;
        public Color color;

        public Queue<Point> q = new Queue<Point>();
        public bool[,] used = new bool[501, 301];

        public bool paintStarted = false;
        public Point prev;

        public Drawer(PictureBox p)
        {
            this.picture = p;
            btm = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(btm);
            picture.Image = btm;
            pen = new Pen(Color.Red);
            color = Color.Orange;
            picture.Paint += Picture_Paint;
        }


        public void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (path != null)
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        public void saveLastPath()
        {
            if (path != null)
            {
                g.DrawPath(pen, path);
                path = null;
            }
        }


        public void Draw(Point cur)
        {

            switch (shape)
            {
                case Shape.Pencil:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.Eraser:
                    pen = new Pen(Color.White, pen.Width);
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.Rectangle:
                    path = new GraphicsPath();
                    Point[] arrRe = { prev, new Point(cur.X, prev.Y), cur, new Point(prev.X, cur.Y) };
                    path.AddPolygon(arrRe);
                    break;
                case Shape.Circle:
                    path = new GraphicsPath();
                    Rectangle r = new Rectangle(prev.X, prev.Y, (cur.X - prev.X), cur.Y - prev.Y);
                    path.AddEllipse(r);
                    break;
                case Shape.Line:
                    path = new GraphicsPath();
                    path.AddLine(prev, cur);
                    break;
                case Shape.Triangle:
                    path = new GraphicsPath();
                    Point[] arr = { prev, cur, new Point(cur.X - 2*(cur.X-prev.X), cur.Y) };
                    path.AddPolygon(arr);
                    break;
                case Shape.Trapec:
                    path = new GraphicsPath();
                    Point[] rr = { prev, new Point(cur.X - prev.X, prev.Y), cur, new Point(prev.X - prev.X, cur.Y) };
                    path.AddPolygon(rr);
                    break;
                default:
                    break;
            }
            picture.Refresh();
        }

        public void SaveImage(string filename)
        {
            btm.Save(filename);
        }

        public void OpenImage(string filename)
        {
            
            if (filename == "")
            {
                btm = new Bitmap(picture.Width, picture.Height);
            }
            else {
                btm = new Bitmap(filename);
            }
            g = Graphics.FromImage(btm);
            picture.Image = btm;
        }

        public void fill(Point cur)
        {
            Color clicked_color = btm.GetPixel(cur.X, cur.Y);
            check(cur.X, cur.Y, clicked_color);
            while (q.Count > 0)
            {
                Point p = q.Dequeue();
                check(p.X + 1, p.Y, clicked_color);
                check(p.X, p.Y + 1, clicked_color);
                check(p.X - 1, p.Y, clicked_color);
                check(p.X, p.Y - 1, clicked_color);
            }
            picture.Refresh();
        }

        public void check(int x, int y, Color clicked_color)
        {
            if (x > 0 && y > 0 && x < picture.Width && y < picture.Height)
            {
                if (used[x, y] == false && btm.GetPixel(x, y) == clicked_color)
                {
                    used[x, y] = true;
                    btm.SetPixel(x, y, color);
                    q.Enqueue(new Point(x,y));
                }
            }
        }
    }
}