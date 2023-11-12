using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class FormRectangle : Form
    {
        private List<ClassPoint> PointsStart = new List<ClassPoint>();
        private List<ClassRectangle> rectangles = new List<ClassRectangle>();
        private readonly Graphics gfx;
        private readonly Bitmap bmp;
        private readonly Random rand = new Random();
        public FormRectangle()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gfx.Clear(Color.White);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(CoordX.Text, out int x);
            bool second = int.TryParse(CoordY.Text, out int y);
            bool third = int.TryParse(WidthSize.Text, out int widthSize);
            bool fourth = int.TryParse(HeigthSize.Text, out int heightSize);

            if (first && second && third && fourth && x > 5 && x + widthSize < pictureBox1.Width - 5 && y > 5 && y + heightSize < pictureBox1.Height - 5 &&
                widthSize > 0 && heightSize > 0)
            {
                gfx.Clear(Color.White);
                PointsStart.Add(new ClassPoint(x, y));
                rectangles.Add(new ClassRectangle(PointsStart.Last(), widthSize, heightSize));
                foreach (var item in rectangles)
                {
                    item?.Show(gfx);
                }
            }
            else
            {
                MesBox("Введены неверные параметры, повторите ввод");
            }

            PictureBoxRefresh();

        }

        private void MesBox(string str)
        {
            MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
        }

        private void PictureBoxRefresh()
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = (Bitmap)bmp.Clone();
        }

        private void Generation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                gfx.Clear(Color.White);
                PointsStart.Add(new ClassPoint(rand.Next(5, pictureBox1.Width - 150), rand.Next(5, pictureBox1.Height - 150)));
                rectangles.Add(new ClassRectangle(PointsStart.Last(), rand.Next(5, 150), rand.Next(5, 150)));
            }
            foreach (var item in rectangles)
            {
                item.Show(gfx);
            }
            PictureBoxRefresh();
        }

        private void MoveTo_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(NewcoordX.Text, out int newX);
            bool second = int.TryParse(NewcoordY.Text, out int newY);
            bool third = int.TryParse(Number.Text, out int number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in rectangles)
                {
                    item?.MoveTo(gfx, rand.Next(5, pictureBox1.Width - item.Width_Size - 5),
                            rand.Next(5, pictureBox1.Height - item.Height_Size - 5));
                }
            }
            else if (first && second && third)
            {
                if (number >= rectangles.Count() || rectangles[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                else
                {
                    gfx.Clear(Color.White);
                    for (int i = 0; i < rectangles.Count(); i++)
                    {
                        if (i == number && rectangles[i] != null)
                        {
                            if (newX < 5 || newX + rectangles[i].Width_Size > pictureBox1.Width - 5 || newY < 5 || newY + rectangles[i].Height_Size 
                                > pictureBox1.Height - 5)
                            {
                                MesBox("Введены неверные параметры, повторите ввод");
                                rectangles[i].Show(gfx);
                                continue;
                            }
                            rectangles[i].MoveTo(gfx, newX, newY);
                        }
                        else
                        {
                            rectangles[i]?.Show(gfx);
                        }
                    }
                }
            }
            else
            {
                MesBox("Введены неверные параметры, повторите ввод");
            }
            PictureBoxRefresh();
        }

        private void ChangeSize_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(NewWigthSize.Text, out int newWidth);
            bool second = int.TryParse(NewHeigthSize.Text, out int newHeight);
            bool third = int.TryParse(Number.Text, out int number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in rectangles)
                {
                    item?.ChangeSize(gfx, rand.Next(1, pictureBox1.Width - item.Width_Size - item.Point.X), 
                        rand.Next(1, pictureBox1.Height - item.Height_Size - item.Point.Y));
                }
            }
            else if (first && second && third && newWidth > 0 && newHeight > 0)
            {
                gfx.Clear(Color.White);
                if (number >= rectangles.Count() || rectangles[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                for (int i = 0; i < rectangles.Count(); i++)
                {
                    if (i == number && rectangles[i] != null)
                    {
                        if (newWidth < 5 || newHeight < 5 || rectangles[i].Point.X + newWidth > pictureBox1.Width - 5 || 
                            rectangles[i].Point.Y + newHeight > pictureBox1.Height - 5)
                        {
                            MesBox("Введены неверные параметры, повторите ввод");
                            rectangles[i].Show(gfx);
                            continue;
                        }
                        rectangles[i].ChangeSize(gfx, newWidth, newHeight);
                    }
                    else
                    {
                        rectangles[i]?.Show(gfx);
                    }
                }
            }
            else
            {
                MesBox("Введены неверные параметры, повторите ввод");
            }
            PictureBoxRefresh();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(Number.Text, out int number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                PointsStart = new List<ClassPoint>();
                rectangles = new List<ClassRectangle>();
            }
            else if (first)
            {
                gfx.Clear(Color.White);
                if (number >= rectangles.Count() || rectangles[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                for (int i = 0; i < rectangles.Count(); i++)
                {
                    if (i == number)
                    {
                        rectangles[i] = null;
                        PointsStart[i] = null;
                    }
                }
                foreach (var item in rectangles)
                {
                    item?.Show(gfx);
                }
            }
            else
            {
                MesBox("Введены неверные параметры, повторите ввод");
            }
            PictureBoxRefresh();
        }
    }
}
