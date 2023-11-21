using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class ClassArray
    {
        private List<ClassFigure> figures;
        private readonly Random rand = new Random();
        public enum Method
        {
            Adding,
            Showing,
            Moving,
            Deleting
        }
        private enum TypeFigure
        {
            Circle,
            Ellipse,
            Ring,
            Rectangle,
            Rhombus,
            Square,
            Trapezium
        }
        public ClassArray()
        {
            figures = new List<ClassFigure>();
            MessageBox.Show("Динамический массив создан", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Iterator(Graphics graphics, Method method)
        {
            switch (method)
            {
                case Method.Adding:
                    Add(graphics);
                    break;
                case Method.Showing:
                    Show(graphics);
                    break;
                case Method.Moving:
                    Move(graphics);
                    break;
                case Method.Deleting:
                    Delete();
                    break;
            }
        }
        private void Add(Graphics graphics)
        {
            ClassPoint point = new ClassPoint(rand.Next(50, 1110), rand.Next(50, 700));
            TypeFigure type = (TypeFigure)rand.Next(0, 7);
            int sizeF1 = rand.Next(20, 100);
            int sizeF2 = rand.Next(20, 100);
            switch (type)
            {
                case TypeFigure.Circle:
                    figures.Add(new ClassCircle(point, sizeF1 / 2, Color.MediumAquamarine));
                    break;
                case TypeFigure.Ellipse:
                    figures.Add(new ClassEllipse(point, sizeF1, sizeF2));
                    break;
                case TypeFigure.Ring:
                    figures.Add(new ClassRing(point, sizeF1 / 2));
                    break;
                case TypeFigure.Rectangle:
                    figures.Add(new ClassRectangle(point, sizeF1, sizeF2));
                    break;
                case TypeFigure.Rhombus:
                    figures.Add(new ClassRhombus(point, sizeF1, sizeF2));
                    break;
                case TypeFigure.Square:
                    figures.Add(new ClassSquare(point, sizeF1));
                    break;
                case TypeFigure.Trapezium:
                    figures.Add(new ClassTrapezium(point, sizeF1, sizeF2));
                    break;
            }
            Show(graphics);
        }
        private void Show(Graphics graphics)
        {
            foreach (var figure in figures)
            {
                figure.Show(graphics);
            }
        }
        private void Move(Graphics graphics)
        {
            foreach (var figure in figures)
            {
                if (figure is ClassEllipse ellipse)
                {
                    figure.MoveTo(graphics, rand.Next(ellipse.Width_Size / 2 + 10, 1160 - ellipse.Width_Size - 10),
                        rand.Next(ellipse.Height_Size / 2 + 10, 750 - ellipse.Height_Size - 10));
                }
                else if (figure is ClassSquare square)
                {
                    figure.MoveTo(graphics, rand.Next(square.Width_Size / 2 + 5, 1160 - square.Width_Size - 5),
                            rand.Next(square.Width_Size / 2 + 5, 750 - square.Width_Size - 5));
                }
                else if (figure is ClassCircle circle)
                {
                    figure.MoveTo(graphics, rand.Next(circle.Radius + 5, 1160 - circle.Radius - 5),
                        rand.Next(circle.Radius + 5, 750 - circle.Radius - 5));
                }
                else
                {
                    figure.MoveTo(graphics, rand.Next((figure as ClassQuadrangle).Width_Size / 2 + 10, 1160 - (figure as ClassQuadrangle).Width_Size - 10),
                            rand.Next((figure as ClassQuadrangle).Height_Size / 2 + 10, 750 - (figure as ClassQuadrangle).Height_Size - 10));
                }
            }
        }
        private void Delete()
        {
            figures.Clear();
            figures = null;
        }
        public bool Anny()
        {
            if (!Null()) return figures.Any();
            else return false;
        }
        public bool Null()
        {
            return figures == null;
        }
    }
}
