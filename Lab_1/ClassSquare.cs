using System.Drawing;

namespace Lab_1
{
    internal class ClassSquare
    {
        public int XStart { get; set; }
        public int YStart { get; set; }
        public int SquareSize { get; set; }

        public ClassSquare(int xstart, int ystart, int squareSize)
        {
            XStart = xstart;
            YStart = ystart;
            SquareSize = squareSize;
        }

        public void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 6);
            Brush brush = new SolidBrush(Color.MediumAquamarine);
            canvas.DrawRectangle(pen, XStart, YStart, SquareSize, SquareSize);
            canvas.FillRectangle(brush, XStart, YStart, SquareSize, SquareSize);
        }

        public void MoveTo(Graphics canvas, int newX, int newY)
        {
            XStart = newX;
            YStart = newY;
            Show(canvas);
        }

        public void ChangeSize(Graphics canvas, int newSize)
        {
            SquareSize = newSize;
            Show(canvas);
        }
    }
}
