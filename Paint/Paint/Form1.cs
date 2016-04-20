using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Drawer drawer;
        public Form1()
        {
            InitializeComponent();
            drawer = new Drawer(pictureBox1);
        }

        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawer.prev = e.Location;
                drawer.paintStarted = true;
                if (drawer.shape == Shape.Fill) 
                    drawer.fill(e.Location);
            }
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawer.paintStarted)
            {
                drawer.Draw(e.Location);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawer.paintStarted = false;
            drawer.saveLastPath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Pencil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Line;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Circle;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Rectangle;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            drawer.pen = new Pen(colorDialog1.Color);
            drawer.color = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Eraser;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.g.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawer.SaveImage(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawer.OpenImage(openFileDialog1.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Triangle;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Fill;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.Trapec;
        }
    }
}
