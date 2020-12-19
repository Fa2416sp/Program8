using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Program8
{
    public partial class Form1 : Form
    {

        Graphics Graph1;
        Bitmap image1 = new Bitmap(500, 800);
        Bitmap image2 = new Bitmap("D:/Алёша/Учёба/ОПиБД/C#/Program8/textura.jpg");
        Pen Pen1 = new Pen(Color.Black, 1);
        Pen Pen2 = new Pen(Color.Brown, 2);
        Pen Pen3 = new Pen(Color.Cyan, 4);
        Font drawFont = new Font("Arial", 12);
        SolidBrush Brush1 = new SolidBrush(Color.Blue);
        SolidBrush Brush2 = new SolidBrush(Color.LightGoldenrodYellow);
        HatchBrush hatchbrush1 = new HatchBrush(HatchStyle.SolidDiamond, Color.Gray, Color.DarkGreen);

        int i = 0;
        Point point1 = new Point(-100, -100);
        Point point2 = new Point(-50, 50);
        Point point3 = new Point(50, -100);
        Point point4 = new Point(-50, -50);

        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.Clear(Color.White);
            for (i = -250; i <= 250; i += 50)
            {
                Graph1.DrawString(Convert.ToString(i), drawFont, Brush1, i + 250, 410);
            }
            for (i = -400; i <= 400; i += 50)
            {
                Graph1.DrawString(Convert.ToString(i), drawFont, Brush1, 260, 400 - i);
            }
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            Graph1.DrawLine(Pen1, -250, 0, 250, 0);
            Graph1.DrawLine(Pen1, 0, -400, 0, 400);
            for (int i = -250; i <= 250; i += 50)
            {
                Graph1.DrawRectangle(Pen3, i, 0, 1, 1);
            }
            for (int i = -400; i <= 400; i += 50)
            {
                Graph1.DrawRectangle(Pen3, 0, i, 1, 1);
            }
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.DrawEllipse(Pen1, 5, 5, 180, 260);
            Graph1.Dispose();
        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            Graph1.DrawRectangle(Pen2, 5, 5, 180, 260);
            Graph1.Dispose();
        }

        private void ToolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            Point[] lomannays = { point1, point2, point3, point4, point1 };
            Graph1.DrawPolygon(Pen3, lomannays);
            Graph1.Dispose();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "BMP(*.bmp) | *.bmp";
            saveFileDialog1.ShowDialog();
            image1.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void ToolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Brush1.Color = colorDialog1.Color;
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.FillEllipse(Brush1, 5, 5, 180, 260);
        }

        private void ToolStripMenuItem12_Click_1(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            Graph1.FillRectangle(hatchbrush1, 5, 5, 180, 260);
        }

        private void ToolStripMenuItem13_Click_1(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            Point[] lomannaya = { point1, point2, point3, point4, point1 };
            TextureBrush TextureBrushl = new TextureBrush(image2);
            Graph1.FillPolygon(TextureBrushl, lomannaya);
        }

        private void ToolStripMenuItem14_Click_1(object sender, EventArgs e)
        {
            Graph1 = Graphics.FromImage(image1);
            pictureBox1.Image = image1;
            Graph1.ScaleTransform(1, -1);
            Graph1.TranslateTransform(250, -400);
            Point[] lomannaya = { point1, point2, point3, point4, point1 };
            TextureBrush TextureBrushl = new TextureBrush(image2);
            TextureBrushl.Transform = new Matrix(75.0f / 640.0f, 0.0f, 0.0f, 75.0f / 480.0f, 0.0f, 0.0f);
            Graph1.FillPolygon(TextureBrushl, lomannaya);
            Graph1.Dispose();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void ToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
