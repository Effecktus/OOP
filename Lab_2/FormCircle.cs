using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class FormCircle : Form
    {
        private List<ClassCircle> _circles = new List<ClassCircle>();
        private Graphics gfx;
        private Bitmap bmp;
        private Random rand = new Random();

        public FormCircle()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gfx.Clear(Color.White);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(CoordX.Text, out int x1);
            bool second = int.TryParse(CoordY.Text, out int y1);
            bool third = int.TryParse(Radius.Text, out int radius);

            if (first && second && third && (x1 - radius) > 0 && (y1 - radius) > 0 && (x1 + radius) < pictureBox1.Width
                && (y1 + radius) < pictureBox1.Height && radius > 0)
            {
                gfx.Clear(Color.White);
                _circles.Add(new ClassCircle(x1, y1, radius));
                foreach (var item in _circles)
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
        private void PictureBoxRefresh()
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = (Bitmap)bmp.Clone();
        }

        private void Move_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(NewcoordX.Text, out int newX);
            bool second = int.TryParse(NewcoordY.Text, out int newY);
            bool third = int.TryParse(Number.Text, out int number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in _circles)
                {
                    if (item != null)
                    {
                        item.MoveTo(gfx, rand.Next(item.Radius, pictureBox1.Width - item.Radius), rand.Next(item.Radius, pictureBox1.Height - item.Radius));
                    }
                }
            }
            else if (first && second && third)
            {
                gfx.Clear(Color.White);
                if (number >= _circles.Count() || _circles[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсуствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    for (int i = 0; i < _circles.Count(); i++)
                    {
                        if (i == number && _circles[i] != null)
                        {
                            if (((newX - _circles[i].Radius < 0) || (newX + _circles[i].Radius > pictureBox1.Width)) 
                                || ((newY - _circles[i].Radius < 0) || (newY + _circles[i].Radius > pictureBox1.Height)))
                            {
                                MesBox();
                                _circles[i].Show(gfx);
                                continue;
                            }
                            _circles[i].MoveTo(gfx, newX, newY);
                        }
                        else if (_circles[i] != null)
                        {
                            _circles[i].Show(gfx);
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

        private void MesBox()
        {
            MessageBox.Show("Введены неверные параметры, повторите ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
        }

        private void ChangeRad_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(Newradius.Text, out int newRad);
            bool second = int.TryParse(Number.Text, out int  number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in _circles)
                {
                    item?.ChangeRadius(gfx, rand.Next(1, Math.Min(Math.Min(item.XCenter - item.Radius, item.YCenter - item.Radius), 
                        Math.Min(pictureBox1.Width - item.XCenter - item.Radius, pictureBox1.Height - item.YCenter - item.Radius))));
                }
            }
            else if (first && second && newRad > 0)
            {
                gfx.Clear(Color.White);
                if (number >= _circles.Count() || _circles[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсуствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                for (int i = 0; i < _circles.Count(); i++)
                {
                    if (i == number && _circles[i] != null)
                    {
                        if (((_circles[i].XCenter - newRad < 0) || (_circles[i].XCenter + newRad > pictureBox1.Width))
                                || ((_circles[i].YCenter - newRad < 0) || (_circles[i].YCenter + newRad > pictureBox1.Height)))
                        {
                            MesBox();
                            _circles[i].Show(gfx);
                            continue;
                        }
                        _circles[i].ChangeRadius(gfx, newRad);
                    }
                    else if (_circles[i] != null)
                    {
                        _circles[i].Show(gfx);
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
                _circles = new List<ClassCircle>();
            }
            else if (first)
            {
                gfx.Clear(Color.White);
                if (number >= _circles.Count() || _circles[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсуствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                for (int i = 0; i < _circles.Count(); i++)
                {
                    if (i == number)
                    {
                        _circles[i] = null;
                    }
                }
                foreach (var item in _circles)
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

        private void Generation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                gfx.Clear(Color.White);
                _circles.Add(new ClassCircle(rand.Next(100, pictureBox1.Width - 100), rand.Next(100, pictureBox1.Height - 100), rand.Next(10, 100)));
            }
            foreach (var item in _circles)
            {
                item.Show(gfx);
            }
            PictureBoxRefresh();
        }
    }
}
