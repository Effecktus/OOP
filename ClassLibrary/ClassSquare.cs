using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class ClassSquare : ClassQuadrangle
    {

        public ClassSquare(ClassPoint Point, int Square_Size, int height_size = 0) : base(Point, Square_Size, height_size)
        {
            Width_Size = Square_Size;
            Height_Size = Square_Size;
            //MessageBox.Show($"Квадрат с координатами ({Point.X}, {Point.Y}) и размером {SquareSize} создан.", "Уведомление", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public override void Show(Graphics canvas)
        {
            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.MediumAquamarine);
            canvas.DrawRectangle(pen, Point.X - Width_Size / 2, Point.Y - Width_Size / 2, Width_Size, Width_Size);
            canvas.FillRectangle(brush, Point.X - Width_Size / 2, Point.Y - Width_Size / 2, Width_Size, Width_Size);
        }

        public void ChangeSize(Graphics canvas, int newSize)
        {
            Width_Size = newSize;
            Show(canvas);
        }
    }
}
