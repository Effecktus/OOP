using ClassLibrary;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class ClassRhombus : ClassQuadrangle
    {
        protected Point[] Points;

        public ClassRhombus(ClassPoint Point, int width_size, int height_size) : base(Point, width_size, height_size)
        {
            //MessageBox.Show($"Ромб с координатами ({Point.X},{Point.Y}), шириной {Width_Size} и высотой {Height_Size} создан", "Уведомление", 
            //    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        public override void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.MediumAquamarine);
            Points = new Point[4]
            {
                new Point(Point.X, Point.Y - (Height_Size / 2)),
                new Point(Point.X + (Width_Size / 2), Point.Y),
                new Point(Point.X, Point.Y + (Height_Size / 2)),
                new Point(Point.X - (Width_Size / 2), Point.Y)
            };
            canvas.DrawPolygon(pen, Points);
            canvas.FillPolygon(brush, Points);
        }
        public void Pivot(Graphics canvas)
        {
            (Width_Size, Height_Size) = (Height_Size, Width_Size);
            Show(canvas);
        }
    }
}
