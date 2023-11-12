using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class FormEllipse : Form
    {
        private List<ClassEllipse> _ellipses = new List<ClassEllipse>();
        private Graphics gfx;
        private Bitmap bmp;
        private Random rand = new Random();

        public FormEllipse()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gfx.Clear(Color.White);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(CoordXCenter.Text, out int x);
            bool second = int.TryParse(CoordYCenter.Text, out int y);
            bool third = int.TryParse(Width_size.Text, out int w);
            bool fourth = int.TryParse(Height_size.Text,out int h);

            if (first && second && third && fourth && (x - (w / 2)) > 0 && (y - (h / 2)) > 0 && (x + (w / 2)) < pictureBox1.Width
                && (y + (h / 2)) < pictureBox1.Height && w > 0 && h > 0)
            {
                gfx.Clear(Color.White);
                _ellipses.Add(new ClassEllipse(x, y, w, h));
                foreach (var item in _ellipses)
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

        private void MesBox()
        {
            MessageBox.Show("Введены неверные параметры, повторите ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
        }

        private void ChangeSize_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(NewWidth.Text, out int newWid);
            bool second = int.TryParse(Number.Text, out int number);
            bool third = int.TryParse(NewHeight.Text, out int newHei);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in _ellipses)
                {
                    item?.ChangeSize(gfx, rand.Next(1, Math.Min(item.XCenter - (item.Width_Size/2), pictureBox1.Width - item.XCenter - (item.Width_Size/2))), 
                        rand.Next(1, Math.Min(item.YCenter - (item.Height_Size / 2), pictureBox1.Height - item.YCenter - (item.Height_Size / 2))));
                }
            }
            else if (first && second && third && newWid > 0 && newHei > 0)
            {
                gfx.Clear(Color.White);
                if (number >= _ellipses.Count() || _ellipses[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсутствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                for (int i = 0; i < _ellipses.Count(); i++)
                {
                    if (i == number && _ellipses[i] != null)
                    {
                        if (((_ellipses[i].XCenter - (newWid / 2) < 0) || (_ellipses[i].XCenter + (newWid / 2) > pictureBox1.Width))
                                || ((_ellipses[i].YCenter - (newHei / 2) < 0) || (_ellipses[i].YCenter + (newHei / 2) > pictureBox1.Height)))
                        {
                            MesBox();
                            _ellipses[i].Show(gfx);
                            continue;
                        }
                        _ellipses[i].ChangeSize(gfx, newWid, newHei);
                    }
                    else if (_ellipses[i] != null)
                    {
                        _ellipses[i].Show(gfx);
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
                _ellipses = new List<ClassEllipse>();
            }
            else if (first)
            {
                gfx.Clear(Color.White);
                if (number >= _ellipses.Count() || _ellipses[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсутствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                for (int i = 0; i < _ellipses.Count(); i++)
                {
                    if (i == number)
                    {
                        _ellipses[i] = null;
                    }
                }
                foreach (var item in _ellipses)
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
                _ellipses.Add(new ClassEllipse(rand.Next(50, pictureBox1.Width - 50), rand.Next(50, pictureBox1.Height - 50), rand.Next(10, 100), rand.Next(10, 100)));
            }
            foreach (var item in _ellipses)
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
                foreach (var item in _ellipses)
                {
                    if (item != null)
                    {
                        item.MoveTo(gfx, rand.Next(item.Width_Size / 2, pictureBox1.Width - item.Width_Size), rand.Next(item.Height_Size / 2,
                            pictureBox1.Height - item.Height_Size));
                    }
                }
            }
            else if (first && second && third)
            {
                gfx.Clear(Color.White);
                if (number >= _ellipses.Count() || _ellipses[number] == null)
                {
                    MessageBox.Show("Фигура с таким номером отсутствует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    for (int i = 0; i < _ellipses.Count(); i++)
                    {
                        if (i == number && _ellipses[i] != null)
                        {
                            if (((newX - (_ellipses[i].Width_Size / 2) < 0) || (newX + (_ellipses[i].Width_Size / 2) > pictureBox1.Width))
                                || ((newY - (_ellipses[i].Height_Size / 2) < 0) || (newY + (_ellipses[i].Height_Size / 2) > pictureBox1.Height)))
                            {
                                MesBox();
                                _ellipses[i].Show(gfx);
                                continue;
                            }
                            _ellipses[i].MoveTo(gfx, newX, newY);
                        }
                        else if (_ellipses[i] != null)
                        {
                            _ellipses[i].Show(gfx);
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
    }
}
