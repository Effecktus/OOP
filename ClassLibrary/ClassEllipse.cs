using System.Drawing;

namespace ClassLibrary
{
    public class ClassEllipse : ClassCircle
    {
        public int Width_Size { get; set; }
        public int Height_Size { get; set; }

        public ClassEllipse(ClassPoint Point, int width_size, int height_size) : base(Point, width_size, Color.MediumAquamarine)
        {
            Width_Size = width_size;
            Height_Size = height_size;
            //MessageBox.Show($"Эллипс с координатами ({Point.X}, {Point.Y}), шириной {Width_Size} и высотой {Height_Size} создан.", "Уведомление",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public override void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.MediumAquamarine);
            canvas.DrawEllipse(pen, Point.X - (Width_Size / 2), Point.Y - (Height_Size / 2), Width_Size, Height_Size);
            canvas.FillEllipse(brush, Point.X - (Width_Size / 2), Point.Y - (Height_Size / 2), Width_Size, Height_Size);
        }

        public void ChangeSize(Graphics canvas, int new_width, int new_height)
        {
            Width_Size = new_width;
            Height_Size = new_height;
            Show(canvas);
        }
        public void Pivot(Graphics canvas)
        {
            (Width_Size, Height_Size) = (Height_Size, Width_Size);
            Show(canvas);
        }
    }
}
