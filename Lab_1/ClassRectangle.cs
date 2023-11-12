using System.Drawing;

namespace Lab_1
{
    internal class ClassRectangle
    {
        public int XStart { get; set; }
        public int YStart { get; set; }
        public int WidthSize { get; set; }
        public int HeightSize { get; set; }

        public ClassRectangle(int xstart, int ystart, int widthSize, int heightSize)
        {
            XStart = xstart;
            YStart = ystart;
            WidthSize = widthSize;
            HeightSize = heightSize;
        }

        public void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 6);
            Brush brush = new SolidBrush(Color.MediumAquamarine);
            canvas.DrawRectangle(pen, XStart, YStart, WidthSize, HeightSize);
            canvas.FillRectangle(brush, XStart, YStart, WidthSize, HeightSize);
        }

        public void MoveTo(Graphics canvas, int newX, int newY)
        {
            XStart = newX;
            YStart = newY;
            Show(canvas);
        }

        public void ChangeSize(Graphics canvas, int newWidth, int newHeight)
        {
            WidthSize = newWidth;
            HeightSize = newHeight;
            Show(canvas);
        }
    }
}
