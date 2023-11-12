using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class FormRing : Form
    {
        private List<ClassPoint> pointsCenter = new List<ClassPoint>();
        private List<ClassRing> rings = new List<ClassRing>();
        private readonly Graphics gfx;
        private readonly Bitmap bmp;
        private readonly Random rand = new Random();
        public FormRing()
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
            MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(CoordX.Text, out int x1);
            bool second = int.TryParse(CoordY.Text, out int y1);
            bool third = int.TryParse(Radius.Text, out int radius);

            if (first && second && third && (x1 - radius) > 5 && (y1 - radius) > 5 && (x1 + radius) < pictureBox1.Width - 5
                && (y1 + radius) < pictureBox1.Height - 5 && radius > 0)
            {
                gfx.Clear(Color.White);
                pointsCenter.Add(new ClassPoint(x1, y1));
                rings.Add(new ClassRing(pointsCenter.Last(), radius));
                foreach (var item in rings)
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
                pointsCenter.Add(new ClassPoint(rand.Next(100, pictureBox1.Width - 100), rand.Next(100, pictureBox1.Height - 100)));
                rings.Add(new ClassRing(pointsCenter.Last(), rand.Next(10, 100)));
            }
            foreach (var item in rings)
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
                foreach (var item in rings)
                {
                    item?.MoveTo(gfx, rand.Next(item.Circle1.Radius + 5, pictureBox1.Width - item.Circle1.Radius - 5), rand.Next(item.Circle1.Radius + 5, pictureBox1.Height - item.Circle1.Radius - 5));
                }
            }
            else if (first && second && third)
            {
                if (number >= rings.Count() || rings[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                else
                {
                    gfx.Clear(Color.White);
                    for (int i = 0; i < rings.Count(); i++)
                    {
                        if (i == number && rings[i] != null)
                        {
                            if (((newX - rings[i].Circle1.Radius < 5) || (newX + rings[i].Circle1.Radius > pictureBox1.Width - 5))
                                || ((newY - rings[i].Circle1.Radius < 5) || (newY + rings[i].Circle1.Radius > pictureBox1.Height - 5)))
                            {
                                MesBox("Введены неверные параметры, повторите ввод");
                                rings[i].Show(gfx);
                                continue;
                            }
                            rings[i].MoveTo(gfx, newX, newY);
                        }
                        else
                        {
                            rings[i]?.Show(gfx);
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

        private void ChangeRad_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(Newradius.Text, out int newRad);
            bool second = int.TryParse(Number.Text, out int number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in rings)
                {
                    item?.ChangeRadius(gfx, rand.Next(1, Math.Min(Math.Min(item.Point.X - item.Circle1.Radius, item.Point.Y - item.Circle1.Radius),
                        Math.Min(pictureBox1.Width - item.Point.X - item.Circle1.Radius, pictureBox1.Height - item.Point.Y - item.Circle1.Radius))));
                }
            }
            else if (first && second && newRad > 0)
            {
                gfx.Clear(Color.White);
                if (number >= rings.Count() || rings[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                for (int i = 0; i < rings.Count(); i++)
                {
                    if (i == number && rings[i] != null)
                    {
                        if (((rings[i].Point.X - newRad < 5) || (rings[i].Point.X + newRad > pictureBox1.Width - 5))
                                || ((rings[i].Point.Y - newRad < 5) || (rings[i].Point.Y + newRad > pictureBox1.Height - 5)))
                        {
                            MesBox("Введены неверные параметры, повторите ввод");
                            rings[i].Show(gfx);
                            continue;
                        }
                        rings[i].ChangeRadius(gfx, newRad);
                    }
                    else
                    {
                        rings[i]?.Show(gfx);
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
                rings = new List<ClassRing>();
                pointsCenter = new List<ClassPoint>();
            }
            else if (first)
            {
                gfx.Clear(Color.White);
                if (number >= rings.Count() || rings[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                for (int i = 0; i < rings.Count(); i++)
                {
                    if (i == number)
                    {
                        rings[i] = null;
                        pointsCenter[i] = null;
                    }
                }
                foreach (var item in rings)
                {
                    item?.Show(gfx);
                }
            }
            else
            {
                MesBox("Введены неверные параметры, повторите ввод" );
            }
            PictureBoxRefresh();
        }
    }
}
