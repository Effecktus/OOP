using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class ClassList : IEnumerable
    {
        public ClassList(Graphics graphics) 
        {
            MessageBox.Show("Односвязный список создан!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private readonly Random rand = new Random();
        public ClassNode Head {  get; set; }
        public void AddLast(ClassFigure data)
        {
            if (Head == null)
            {
                Head = new ClassNode(data);
            }
            else
            {
                ClassNode current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new ClassNode(data);
            }
        }
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
                    AddLast(new ClassCircle(point, sizeF1 / 2, Color.MediumAquamarine));
                    break;
                case TypeFigure.Ellipse:
                    AddLast(new ClassEllipse(point, sizeF1, sizeF2));
                    break;
                case TypeFigure.Ring:
                    AddLast(new ClassRing(point, sizeF1 / 2));
                    break;
                case TypeFigure.Rectangle:
                    AddLast(new ClassRectangle(point, sizeF1, sizeF2));
                    break;
                case TypeFigure.Rhombus:
                    AddLast(new ClassRhombus(point, sizeF1, sizeF2));
                    break;
                case TypeFigure.Square:
                    AddLast(new ClassSquare(point, sizeF1));
                    break;
                case TypeFigure.Trapezium:
                    AddLast(new ClassTrapezium(point, sizeF1, sizeF2));
                    break;
            }
            Show(graphics);
        }
        private void Show(Graphics graphics)
        {
            ClassNode current = Head;
            while (current != null)
            {
                current.Data.Show(graphics);
                current = current.Next;
            }
        }
        private void Move(Graphics graphics)
        {
            ClassNode current = Head;
            while (current != null)
            {
                if (current.Data is ClassEllipse ellipse)
                {
                    current.Data.MoveTo(graphics, rand.Next(ellipse.Width_Size / 2 + 10, 1160 - ellipse.Width_Size - 10),
                        rand.Next(ellipse.Height_Size / 2 + 10, 750 - ellipse.Height_Size - 10));
                }
                else if (current.Data is ClassSquare square)
                {
                    current.Data.MoveTo(graphics, rand.Next(square.Width_Size / 2 + 5, 1160 - square.Width_Size - 5),
                            rand.Next(square.Width_Size / 2 + 5, 750 - square.Width_Size - 5));
                }
                else if (current.Data is ClassCircle circle)
                {
                    current.Data.MoveTo(graphics, rand.Next(circle.Radius + 5, 1160 - circle.Radius - 5),
                        rand.Next(circle.Radius + 5, 750 - circle.Radius - 5));
                }
                else
                {
                    current.Data.MoveTo(graphics, rand.Next((current.Data as ClassQuadrangle).Width_Size / 2 + 10, 1160 - 
                        (current.Data as ClassQuadrangle).Width_Size - 10), rand.Next((current.Data as ClassQuadrangle).Height_Size / 2 + 10, 750 - 
                        (current.Data as ClassQuadrangle).Height_Size - 10));
                }
                current = current.Next;
            }
        }
        private void Delete()
        {
            ClassNode current = Head;
            while (current != null)
            {
                current.Data = null;
                current = current.Next;
            }
            Head = null;
        }
        public IEnumerator GetEnumerator()
        {
            ClassNode current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public bool Null()
        {
            return Head == null;
        }
    }
}
