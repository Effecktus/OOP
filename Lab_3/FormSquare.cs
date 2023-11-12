using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class FormSquare : Form
    {
        private List<ClassPoint> PointsStart = new List<ClassPoint>();
        private List<ClassSquare> squares = new List<ClassSquare>();
        private readonly Graphics gfx;
        private readonly Bitmap bmp;
        private readonly Random rand = new Random();
        public FormSquare()
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
            bool third = int.TryParse(SquareSize.Text, out int squareSize);

            if (first && second && third && x > 5 && x + squareSize < pictureBox1.Width - 5 && y > 5 && y + squareSize < pictureBox1.Height - 5 &&
                squareSize > 0)
            {
                gfx.Clear(Color.White);
                PointsStart.Add(new ClassPoint(x, y));
                squares.Add(new ClassSquare(PointsStart.Last(), squareSize));
                foreach (var item in squares)
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
                PointsStart.Add(new ClassPoint(rand.Next(0, pictureBox1.Width - 150), rand.Next(0, pictureBox1.Height - 150)));
                squares.Add(new ClassSquare(PointsStart.Last(), rand.Next(1, 150)));
            }
            foreach (var item in squares)
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
                foreach (var item in squares)
                {
                    item?.MoveTo(gfx, rand.Next(5, pictureBox1.Width - item.SquareSize - 5), 
                            rand.Next(5, pictureBox1.Height - item.SquareSize - 5));
                }
            }
            else if (first && second && third)
            {
                if (number >= squares.Count() || squares[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                else
                {
                    gfx.Clear(Color.White);
                    for (int i = 0; i < squares.Count(); i++)
                    {
                        if (i == number && squares[i] != null)
                        {
                            if (newX < 5 || newX + squares[i].SquareSize > pictureBox1.Width - 5 || newY < 5 || newY + squares[i].SquareSize
                                > pictureBox1.Height - 5)
                            {
                                MesBox("Введены неверные параметры, повторите ввод");
                                squares[i].Show(gfx);
                                continue;
                            }
                            squares[i].MoveTo(gfx, newX, newY);
                        }
                        else
                        {
                            squares[i]?.Show(gfx);
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
            bool first = int.TryParse(NewSize.Text, out int newSize);
            bool second = int.TryParse(Number.Text, out int number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in squares)
                {
                    item?.ChangeSize(gfx, rand.Next(1, Math.Min(pictureBox1.Width - item.SquareSize - item.Point.X, pictureBox1.Height -
                        item.SquareSize - item.Point.Y)));
                }
            }
            else if (first && second && newSize > 0 )
            {
                gfx.Clear(Color.White);
                if (number >= squares.Count() || squares[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                for (int i = 0; i < squares.Count(); i++)
                {
                    if (i == number && squares[i] != null)
                    {
                        if (((squares[i].Point.X - newSize < 5) || (squares[i].Point.X + newSize > pictureBox1.Width - 5))
                                || ((squares[i].Point.Y - newSize < 5) || (squares[i].Point.Y + newSize > pictureBox1.Height - 5)))
                        {
                            MesBox("Введены неверные параметры, повторите ввод");
                            squares[i].Show(gfx);
                            continue;
                        }
                        squares[i].ChangeSize(gfx, newSize);
                    }
                    else
                    {
                        squares[i]?.Show(gfx);
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
                squares = new List<ClassSquare>();
            }
            else if (first)
            {
                gfx.Clear(Color.White);
                if (number >= squares.Count() || squares[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                for (int i = 0; i < squares.Count(); i++)
                {
                    if (i == number)
                    {
                        squares[i] = null;
                        PointsStart[i] = null;
                    }
                }
                foreach (var item in squares)
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
