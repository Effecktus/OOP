using ClassLibrary_Lab_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class FormTrapezium : Form
    {
        private List<ClassPoint> pointsCenter = new List<ClassPoint>();
        private List<ClassTrapezium> trapeziums = new List<ClassTrapezium>();
        private readonly Graphics gfx;
        private readonly Bitmap bmp;
        private readonly Random rand = new Random();
        public FormTrapezium()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gfx.Clear(Color.White);
        }
        private void PictureBoxRefresh()
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = (Bitmap)bmp.Clone();
        }
        private void MesBox(string str)
        {
            MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(CoordXCenter.Text, out int x);
            bool second = int.TryParse(CoordYCenter.Text, out int y);
            bool third = int.TryParse(Width_size.Text, out int w);
            bool fourth = int.TryParse(Height_size.Text, out int h);

            if (first && second && third && fourth && (y - h/2 > 5) && (x + w/2 < pictureBox1.Width - 5) && (x - w/2 > 5) 
                && (y + h/2 < pictureBox1.Height - 5))
            {
                gfx.Clear(Color.White);
                pointsCenter.Add(new ClassPoint(x, y));
                trapeziums.Add(new ClassTrapezium(pointsCenter.Last(), w, h));
                foreach (var item in trapeziums)
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

        private void Generation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                gfx.Clear(Color.White);
                pointsCenter.Add(new ClassPoint(rand.Next(105, pictureBox1.Width - 105), rand.Next(55, pictureBox1.Height - 55)));
                trapeziums.Add(new ClassTrapezium(pointsCenter.Last(), rand.Next(10, 200), rand.Next(10, 100)));
            }
            foreach (var item in trapeziums)
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
                foreach (var item in trapeziums)
                {
                    item?.MoveTo(gfx, rand.Next(item.Width_Size / 2 + 10, pictureBox1.Width - item.Width_Size - 10),
                            rand.Next(item.Height_Size / 2 + 10, pictureBox1.Height - item.Height_Size - 10));
                }
            }
            else if (first && second && third)
            {
                if (number >= trapeziums.Count() || trapeziums[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует"); ;
                }
                else
                {
                    gfx.Clear(Color.White);
                    for (int i = 0; i < trapeziums.Count(); i++)
                    {
                        if (i == number && trapeziums[i] != null)
                        {
                            if (((newX - (trapeziums[i].Width_Size / 2) < 0) || (newX + (trapeziums[i].Width_Size / 2) > pictureBox1.Width))
                                || ((newY - (trapeziums[i].Height_Size / 2) < 0) || (newY + (trapeziums[i].Height_Size / 2) > pictureBox1.Height)))
                            {
                                MesBox("Введены неверные параметры, повторите ввод");
                                trapeziums[i].Show(gfx);
                                continue;
                            }
                            trapeziums[i].MoveTo(gfx, newX, newY);
                        }
                        else
                        {
                            trapeziums[i]?.Show(gfx);
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
            bool first = int.TryParse(NewWidth.Text, out int newWid);
            bool second = int.TryParse(Number.Text, out int number);
            bool third = int.TryParse(NewHeight.Text, out int newHei);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in trapeziums)
                {
                    item?.ChangeSize(gfx, rand.Next(5, Math.Min(item.Point.X - (item.Width_Size / 2) + 5, pictureBox1.Width - item.Point.X - (item.Width_Size / 2) - 5)),
                        rand.Next(5, Math.Min(item.Point.Y - (item.Height_Size / 2) + 5, pictureBox1.Height - item.Point.Y - (item.Height_Size / 2) - 5)));
                }
            }
            else if (first && second && third && newWid > 0 && newHei > 0)
            {
                if (number >= trapeziums.Count() || trapeziums[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                else
                {
                    gfx.Clear(Color.White);
                    for (int i = 0; i < trapeziums.Count(); i++)
                    {
                        if (i == number && trapeziums[i] != null)
                        {
                            if (((pointsCenter[i].X - (newWid / 2) < 5) || (pointsCenter[i].X + (newWid / 2) > pictureBox1.Width - 5))
                                    || ((pointsCenter[i].Y - (newHei / 2) < 5) || (pointsCenter[i].Y + (newHei / 2) > pictureBox1.Height - 5)))
                            {
                                MesBox("Введены неверные параметры, повторите ввод");
                                trapeziums[i].Show(gfx);
                                continue;
                            }
                            trapeziums[i].ChangeSize(gfx, newWid, newHei);
                        }
                        else
                        {
                            trapeziums[i]?.Show(gfx);
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

        private void Del_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(Number.Text, out int number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                trapeziums = new List<ClassTrapezium>();
                pointsCenter = new List<ClassPoint>();
            }
            else if (first)
            {
                gfx.Clear(Color.White);
                if (number >= trapeziums.Count() || trapeziums[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                for (int i = 0; i < trapeziums.Count(); i++)
                {
                    if (i == number)
                    {
                        trapeziums[i] = null;
                        pointsCenter[i] = null;
                    }
                }
                foreach (var item in trapeziums)
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
