using System.Drawing;

namespace Lab_1
{
    internal class ClassEllipse
    {
        public int XCenter { get; set; }
        public int YCenter { get; set; }
        public int Width_Size { get; set; }
        public int Height_Size { get; set; }

        public ClassEllipse(int xcenter, int ycenter, int width_size, int height_size)
        {
            XCenter = xcenter;
            YCenter = ycenter;
            Width_Size = width_size;
            Height_Size = height_size;
        }

        public void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 6);
            Brush brush = new SolidBrush(Color.MediumAquamarine);
            canvas.DrawEllipse(pen, XCenter - (Width_Size/ 2), YCenter - (Height_Size / 2), Width_Size, Height_Size);
            canvas.FillEllipse(brush, XCenter - (Width_Size / 2), YCenter - (Height_Size / 2), Width_Size, Height_Size);
        }

        public void MoveTo(Graphics canvas, int newX, int newY)
        {
            XCenter = newX;
            YCenter = newY;
            Show(canvas);
        }

        public void ChangeSize(Graphics canvas, int new_width, int new_height)
        {
            Width_Size = new_width;
            Height_Size = new_height;
            Show(canvas);
        }
    }
}
