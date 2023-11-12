using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class FormCircle : Form
    {
        private List<ClassPoint> pointsCenter = new List<ClassPoint>();
        private List<ClassCircle> circles = new List<ClassCircle>();
        private readonly Graphics gfx;
        private readonly Bitmap bmp;
        private readonly Random rand = new Random();

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

            if (first && second && third && (x1 - radius) > 5 && (y1 - radius) > 5 && (x1 + radius) < pictureBox1.Width - 5
                && (y1 + radius) < pictureBox1.Height - 5 && radius > 0)
            {
                gfx.Clear(Color.White);
                pointsCenter.Add(new ClassPoint(x1, y1));
                circles.Add(new ClassCircle(pointsCenter.Last(), radius, Color.MediumAquamarine));
                foreach (var item in circles)
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
                foreach (var item in circles)
                {
                    item?.MoveTo(gfx, rand.Next(item.Radius + 5, pictureBox1.Width - item.Radius - 5), 
                        rand.Next(item.Radius + 5, pictureBox1.Height - item.Radius - 5));
                }
            }
            else if (first && second && third)
            {
                if (number >= circles.Count() || circles[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                else
                {
                    gfx.Clear(Color.White);
                    for (int i = 0; i < circles.Count(); i++)
                    {
                        if (i == number && circles[i] != null)
                        {
                            if (((newX - circles[i].Radius < 5) || (newX + circles[i].Radius > pictureBox1.Width - 5)) 
                                || ((newY - circles[i].Radius < 5) || (newY + circles[i].Radius > pictureBox1.Height - 5)))
                            {
                                MesBox("Введены неверные параметры, повторите ввод");
                                circles[i].Show(gfx);
                                continue;
                            }
                            circles[i].MoveTo(gfx, newX, newY);
                        }
                        else
                        {
                            circles[i]?.Show(gfx);
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

        private void MesBox(string str)
        {
            MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
        }

        private void ChangeRad_Click(object sender, EventArgs e)
        {
            bool first = int.TryParse(Newradius.Text, out int newRad);
            bool second = int.TryParse(Number.Text, out int  number);
            if (Number.Text == "")
            {
                gfx.Clear(Color.White);
                foreach (var item in circles)
                {
                    item?.ChangeRadius(gfx, rand.Next(1, Math.Min(Math.Min(item.Point.X - item.Radius, item.Point.Y - item.Radius), 
                        Math.Min(pictureBox1.Width - item.Point.X - item.Radius, pictureBox1.Height - item.Point.Y - item.Radius))));
                }
            }
            else if (first && second && newRad > 0)
            {
                gfx.Clear(Color.White);
                if (number >= circles.Count() || circles[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                for (int i = 0; i < circles.Count(); i++)
                {
                    if (i == number && circles[i] != null)
                    {
                        if (((circles[i].Point.X - newRad < 5) || (circles[i].Point.X + newRad > pictureBox1.Width - 5))
                                || ((circles[i].Point.Y - newRad < 5) || (circles[i].Point.Y + newRad > pictureBox1.Height - 5)))
                        {
                            MesBox("Введены неверные параметры, повторите ввод");
                            circles[i].Show(gfx);
                            continue;
                        }
                        circles[i].ChangeRadius(gfx, newRad);
                    }
                    else
                    {
                        circles[i]?.Show(gfx);
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
                circles = new List<ClassCircle>();
                pointsCenter = new List<ClassPoint>();
            }
            else if (first)
            {
                gfx.Clear(Color.White);
                if (number >= circles.Count() || circles[number] == null)
                {
                    MesBox("Фигура с таким номером отсутствует");
                }
                for (int i = 0; i < circles.Count(); i++)
                {
                    if (i == number)
                    {
                        circles[i] = null;
                        pointsCenter[i] = null;
                    }
                }
                foreach (var item in circles)
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
                circles.Add(new ClassCircle(pointsCenter.Last(), rand.Next(10, 100), Color.MediumAquamarine));
            }
            foreach (var item in circles)
            {
                item.Show(gfx);
            }
            PictureBoxRefresh();
        }
    }
}
