using System.Drawing;

namespace ClassLibrary
{
    public class ClassRectangle : ClassQuadrangle
    {
        public ClassRectangle(ClassPoint Point, int width_size, int height_size) : base(Point, width_size, height_size)
        {
            //MessageBox.Show($"Прямоугольник с координатами ({Point.X}, {Point.Y}), шириной {Width_Size} и высотой {Height_Size} создан.", "Уведомление", 
            //    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public override void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.MediumAquamarine);
            canvas.DrawRectangle(pen, Point.X - Width_Size / 2, Point.Y - Height_Size / 2, Width_Size, Height_Size);
            canvas.FillRectangle(brush, Point.X - Width_Size / 2, Point.Y - Height_Size / 2, Width_Size, Height_Size);
        }
    }
}
