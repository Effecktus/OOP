using System.Drawing;

namespace Lab_1
{
    public class ClassCircle
    {
        public int XCenter { get; set; }
        public int YCenter { get; set; }
        public int Radius { get; set; }

        public ClassCircle(int xcenter, int ycenter, int radius)
        {
            XCenter = xcenter;
            YCenter = ycenter;
            Radius = radius;
        }

        public void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 6);
            Brush brush = new SolidBrush(Color.MediumAquamarine);
            canvas.DrawEllipse(pen, XCenter - Radius, YCenter - Radius, Radius * 2, Radius * 2);
            canvas.FillEllipse(brush, XCenter - Radius, YCenter - Radius, Radius * 2, Radius * 2);
        }

        public void MoveTo(Graphics canvas, int newX, int newY)
        {
            XCenter = newX;
            YCenter = newY;
            Show(canvas);
        }

        public void ChangeRadius(Graphics canvas, int newRadius)
        {
            Radius = newRadius;
            Show(canvas);
        }
    }
}
