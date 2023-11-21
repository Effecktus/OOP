using System.Drawing;

namespace ClassLibrary
{
    public class ClassCircle : ClassFigure
    {
        public int Radius { get; set; }
        public Color Color { get; set; }
        public ClassCircle(ClassPoint Point, int radius, Color color) : base(Point)
        {
            Radius = radius;
            Color = color;
            //MessageBox.Show($"Круг с координатами ({Point.X}, {Point.Y}) и радиусом {Radius} создан.", "Уведомление", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public override void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color);
            canvas.DrawEllipse(pen, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
            canvas.FillEllipse(brush, Point.X - Radius, Point.Y - Radius, Radius * 2, Radius * 2);
        }

        public void ChangeRadius(Graphics canvas, int newRadius)
        {
            Radius = newRadius;
            Show(canvas);
        }

    }
}
