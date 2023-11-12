using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class FormRectangle : Form
    {
        private List<ClassRectangle> _rectangles = new List<ClassRectangle>();
        private Graphics gfx;
        private Bitmap bmp;
        private Random rand = new Random();
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

            if (first && second && third && fourth && x > 0 && x + widthSize < pictureBox1.Width && y > 0 && y + heightSize < pictureBox1.Height &&
                widthSize > 0 && heightSize > 0)
            {
                gfx.Clear(Color.White);
                _rectangles.Add(new ClassRectangle(x, y, widthSize, heightSize));
                foreach (var item in _rectangles)
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
                _rectangles.Add(new ClassRectangle(rand.Next(0, pictureBox1.Width - 150), rand.Next(0, pictureBox1.Height - 150), 
                    rand.Next(5, 150), rand.Next(5, 150)));
            }
            foreach (var item in _rectangles)
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
                foreach (var item in _rectangles)
                {
                    item?.MoveTo(gfx, rand.Next(1, pictureBox1.Width - item.WidthSize), rand.Next(1, pictureBox1.Height - item.HeightSize));
                }
            }
            else if (first && second && third)
            {
                gfx.Clear(Color.White);
                if (number >= _rectangles.Count() || _rectangles[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсуствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    for (int i = 0; i < _rectangles.Count(); i++)
                    {
                        if (i == number && _rectangles[i] != null)
                        {
                            if (newX < 0 || newX + _rectangles[i].WidthSize > pictureBox1.Width || newY < 0 || newY + _rectangles[i].HeightSize 
                                > pictureBox1.Height)
                            {
                                MesBox();
                                _rectangles[i].Show(gfx);
                                continue;
                            }
                            _rectangles[i].MoveTo(gfx, newX, newY);
                        }
                        else if (_rectangles[i] != null)
                        {
                            _rectangles[i].Show(gfx);
                        }
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
            bool first = int.TryParse(NewWigthSize.Text, out int newWigth);
            bool second = int.TryParse(NewHeigthSize.Text, out int newHeight);
            bool third = int.TryParse(Number.Text, out int number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in _rectangles)
                {
                    item?.ChangeSize(gfx, rand.Next(1, pictureBox1.Width - item.WidthSize - item.XStart), 
                        rand.Next(1, pictureBox1.Height - item.HeightSize - item.YStart));
                }
            }
            else if (first && second && third)
            {
                gfx.Clear(Color.White);
                if (number >= _rectangles.Count() || _rectangles[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсуствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                for (int i = 0; i < _rectangles.Count(); i++)
                {
                    if (i == number && _rectangles[i] != null)
                    {
                        if (newWigth < 0 || newHeight < 0 || _rectangles[i].XStart + newWigth > pictureBox1.Width || 
                            _rectangles[i].YStart + newHeight > pictureBox1.Height)
                        {
                            MesBox();
                            _rectangles[i].Show(gfx);
                            continue;
                        }
                        _rectangles[i].ChangeSize(gfx, newWigth, newHeight);
                    }
                    else if (_rectangles[i] != null)
                    {
                        _rectangles[i].Show(gfx);
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
                _rectangles = new List<ClassRectangle>();
            }
            else if (first)
            {
                gfx.Clear(Color.White);
                if (number >= _rectangles.Count() || _rectangles[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсуствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                for (int i = 0; i < _rectangles.Count(); i++)
                {
                    if (i == number)
                    {
                        _rectangles[i] = null;
                    }
                }
                foreach (var item in _rectangles)
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
