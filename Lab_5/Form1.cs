using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        private List<ClassFigure> figures = new List<ClassFigure>();
        private List<int> types = new List<int>();
        private readonly Graphics gfx;
        private readonly Bitmap bmp;
        private readonly Random rand = new Random();
        private int sel_type = -1;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gfx.Clear(Color.White);
            pictureBox1.PreviewKeyDown += PictureBox1_Moving;
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Focus();
        }
        
        private void PictureBox1_Moving(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                gfx.Clear(Color.White);
                for (int i = 0; i < figures.Count; i++)
                {
                    if (figures[i] is ClassCircle circle && figures[i].Point.X - circle.Radius >= 15 && (sel_type == 1 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X - 10, figures[i].Point.Y);
                    }
                    else if (figures[i] is ClassEllipse ellipse && figures[i].Point.X - ellipse.Width_Size / 2 >= 15 && (sel_type == 1 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X - 10, figures[i].Point.Y);
                    }
                    else if (figures[i] is ClassQuadrangle quadrangle && figures[i].Point.X - quadrangle.Width_Size >= 15 && (sel_type == 2 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X - 10, figures[i].Point.Y);
                    }
                    else
                    {
                        figures[i].Show(gfx);
                    }
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                gfx.Clear(Color.White);
                for (int i = 0; i < figures.Count; i++)
                {
                    if (figures[i] is ClassCircle circle && figures[i].Point.X + circle.Radius <= 1145 && (sel_type == 1 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X + 10, figures[i].Point.Y);
                    }
                    else if (figures[i] is ClassEllipse ellipse && figures[i].Point.X + ellipse.Width_Size / 2 <= 1145 && (sel_type == 1 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X + 10, figures[i].Point.Y);
                    }
                    else if (figures[i] is ClassQuadrangle quadrangle && figures[i].Point.X + quadrangle.Width_Size / 2 <= 1145 && (sel_type == 2 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X + 10, figures[i].Point.Y);
                    }
                    else
                    {
                        figures[i].Show(gfx);
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                gfx.Clear(Color.White);
                for (int i = 0; i < figures.Count; i++)
                {
                    if (figures[i] is ClassCircle circle && figures[i].Point.Y - circle.Radius >= 15 && (sel_type == 1 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X, figures[i].Point.Y - 10);
                    }
                    else if (figures[i] is ClassEllipse ellipse && figures[i].Point.Y - ellipse.Height_Size / 2 >= 15 && (sel_type == 1 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X, figures[i].Point.Y - 10);
                    }
                    else if (figures[i] is ClassQuadrangle quadrangle && figures[i].Point.Y - quadrangle.Height_Size / 2 >= 15 && (sel_type == 2 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X, figures[i].Point.Y - 10);
                    }
                    else
                    {
                        figures[i].Show(gfx);
                    }
                }
            }
            else if (e.KeyData == Keys.Down)
            {
                gfx.Clear(Color.White);
                for (int i = 0; i < figures.Count; i++)
                {
                    if (figures[i] is ClassCircle circle && figures[i].Point.Y + circle.Radius <= 735 && (sel_type == 1 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X, figures[i].Point.Y + 10);
                    }
                    else if (figures[i] is ClassEllipse ellipse && figures[i].Point.Y + ellipse.Height_Size / 2 <= 735 && (sel_type == 1 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X, figures[i].Point.Y + 10);
                    }
                    else if (figures[i] is ClassQuadrangle quadrangle && figures[i].Point.Y + quadrangle.Height_Size / 2 <= 735 && (sel_type == 2 || sel_type == -1))
                    {
                        figures[i].MoveTo(gfx, figures[i].Point.X, figures[i].Point.Y + 10);
                    }
                    else
                    {
                        figures[i].Show(gfx);
                    }
                }
            }
            PictureBoxRefresh();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            int num, size1, size2;
            ClassPoint point;
            for (int i = 0; i < 20;  i++)
            {
                point = new ClassPoint(rand.Next(50, pictureBox1.Width - 50), rand.Next(50, pictureBox1.Height - 50));
                num = rand.Next(0, 7);
                size1 = rand.Next(20, 100);
                size2 = rand.Next(20, 100);
                switch (num) 
                {
                    case 0:
                        figures.Add(new ClassCircle(point, size1 / 2, Color.MediumAquamarine));
                        break;
                    case 1:
                        figures.Add(new ClassEllipse(point, size1, size2));
                        break;
                    case 2:
                        figures.Add(new ClassRing(point, size1 / 2));
                        break;
                    case 3:
                        figures.Add(new ClassRectangle(point, size1, size2));
                        break;
                    case 4:
                        figures.Add(new ClassRhombus(point, size1, size2));
                        break;
                    case 5:
                        figures.Add(new ClassSquare(point, size1));
                        break;
                    case 6:
                        figures.Add(new ClassTrapezium(point, size1, size2));
                        break;
                }
                types.Add(num);
            }
        }
        private void PictureBoxRefresh()
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = (Bitmap)bmp.Clone();
        }

        private void Showing_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            foreach (var figure in figures)
            {
                figure.Show(gfx);
            }
            PictureBoxRefresh();
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            PictureBoxRefresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            figures = new List<ClassFigure>();
            PictureBoxRefresh();
        }

        private void CheckCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCircles.Checked)
            {
                sel_type = 1;
                CheckQuadrangles.Checked = false;
            }
            else if (!CheckCircles.Checked && !CheckQuadrangles.Checked)
            {
                sel_type = -1;
            }
            pictureBox1.Focus();
        }

        private void CheckEllipse_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckQuadrangles.Checked)
            {
                sel_type = 2;
                CheckCircles.Checked = false;
            }
            else if (!CheckCircles.Checked && !CheckQuadrangles.Checked)
            {
                sel_type = -1;
            }
            pictureBox1.Focus();
        }

        private void ChangeCircles_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i] is ClassEllipse ellipse)
                {
                    ellipse.ChangeSize(gfx, rand.Next(5, Math.Min(ellipse.Point.X - (ellipse.Width_Size / 2) + 5, pictureBox1.Width - ellipse.Point.X - (ellipse.Width_Size / 2) - 5)),
                        rand.Next(5, Math.Min(ellipse.Point.Y - (ellipse.Height_Size / 2) + 5, pictureBox1.Height - ellipse.Point.Y - (ellipse.Height_Size / 2) - 5)));
                }
                else if (figures[i] is ClassCircle circle)
                {
                    circle.ChangeRadius(gfx, rand.Next(1, Math.Min(Math.Min(circle.Point.X - circle.Radius, circle.Point.Y - circle.Radius),
                        Math.Min(pictureBox1.Width - circle.Point.X - circle.Radius, pictureBox1.Height - circle.Point.Y - circle.Radius))));
                }
                else
                {
                    figures[i].Show(gfx);
                }
            }
            PictureBoxRefresh();
        }

        private void ChangeQuadrangles_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i] is ClassQuadrangle quadrangle)
                {
                    quadrangle.ChangeSize(gfx, rand.Next(5, Math.Min(quadrangle.Point.X - (quadrangle.Width_Size / 2) + 5, pictureBox1.Width - quadrangle.Point.X - (quadrangle.Width_Size / 2) - 5)),
                        rand.Next(5, Math.Min(quadrangle.Point.Y - (quadrangle.Height_Size / 2) + 5, pictureBox1.Height - quadrangle.Point.Y - (quadrangle.Height_Size / 2) - 5)));
                }
                else
                {
                    figures[i].Show(gfx);
                }
            }
            PictureBoxRefresh();
        }
    }
}
