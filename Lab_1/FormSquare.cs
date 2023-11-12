using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class FormSquare : Form
    {
        private List<ClassSquare> _squares = new List<ClassSquare>();
        private Graphics gfx;
        private Bitmap bmp;
        private Random rand = new Random();
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

            if (first && second && third && x > 0 && x + squareSize < pictureBox1.Width && y > 0 && y + squareSize < pictureBox1.Height &&
                squareSize > 0 && squareSize > 0)
            {
                gfx.Clear(Color.White);
                _squares.Add(new ClassSquare(x, y, squareSize));
                foreach (var item in _squares)
                {
                    item?.Show(gfx);
                }
            }
            else
            {
                MesBox();
            }

            PictureBoxRefresh();

        }

        private void MesBox()
        {
            MessageBox.Show("Введены неверные параметры, повторите ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
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
                _squares.Add(new ClassSquare(rand.Next(0, pictureBox1.Width - 150), rand.Next(0, pictureBox1.Height - 150), rand.Next(1, 150)));
            }
            foreach (var item in _squares)
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
                foreach (var item in _squares)
                {
                    item?.MoveTo(gfx, rand.Next(1, pictureBox1.Width - item.SquareSize), rand.Next(1, pictureBox1.Height - item.SquareSize));
                }
            }
            else if (first && second && third)
            {
                gfx.Clear(Color.White);
                if (number >= _squares.Count() || _squares[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсуствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                for (int i = 0; i < _squares.Count(); i++)
                {
                    if (i == number && _squares[i] != null)
                    {
                        if (newX < 0 || newX + _squares[i].SquareSize > pictureBox1.Width || newY < 0 || newY + _squares[i].SquareSize 
                            > pictureBox1.Height)
                        {
                            MesBox();
                            _squares[i].Show(gfx);
                            continue;
                        }
                        _squares[i].MoveTo(gfx, newX, newY);
                    }
                    else if (_squares[i] != null)
                    {
                        _squares[i].Show(gfx);
                    }
                }
            }
            else
            {
                MesBox();
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
                foreach (var item in _squares)
                {
                    item?.ChangeSize(gfx, rand.Next(1, Math.Min(pictureBox1.Width - item.SquareSize - item.XStart, pictureBox1.Height - 
                        item.SquareSize - item.YStart)));
                }
            }
            else if (first && second)
            {
                gfx.Clear(Color.White);
                if (number >= _squares.Count() || _squares[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсуствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                for (int i = 0; i < _squares.Count(); i++)
                {
                    if (i == number && _squares[i] != null)
                    {
                        _squares[i].ChangeSize(gfx, newSize);
                    }
                    else if (_squares[i] != null)
                    {
                        _squares[i].Show(gfx);
                    }
                }
            }
            else
            {
                MesBox();
            }
            PictureBoxRefresh();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(Number.Text, out int number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                _squares = new List<ClassSquare>();
            }
            else if (first)
            {
                gfx.Clear(Color.White);
                if (number >= _squares.Count() || _squares[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсуствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                for (int i = 0; i < _squares.Count(); i++)
                {
                    if (i == number)
                    {
                        _squares[i] = null;
                    }
                }
                foreach (var item in _squares)
                {
                    item?.Show(gfx);
                }
            }
            else
            {
                MesBox();
            }
            PictureBoxRefresh();
        }
    }
}
