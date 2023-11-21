using System.Drawing;

namespace ClassLibrary
{
    public class ClassTrapezium : ClassQuadrangle
    {
        public Point[] Points { get; set; }
        public ClassTrapezium(ClassPoint Point, int width_size, int height_size) : base(Point, width_size, height_size)
        {
            //MessageBox.Show($"Трапеция с координатами ({Point.X},{Point.Y}). высотой {Height_Size} и шириной нижнего основания {Width_Size} создан", "Уведомление",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        public override void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.MediumAquamarine);
            Points = new Point[4]
            {
                new Point(Point.X - Width_Size / 4, Point.Y - Height_Size / 2),
                new Point(Point.X + Width_Size / 4, Point.Y - Height_Size / 2),
                new Point(Point.X + Width_Size / 2, Point.Y + Height_Size / 2),
                new Point(Point.X - Width_Size / 2, Point.Y + Height_Size / 2)
            };
            canvas.DrawPolygon(pen, Points);
            canvas.FillPolygon(brush, Points);
        }
    }
}
