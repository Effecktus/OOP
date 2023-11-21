using System.Drawing;

namespace ClassLibrary
{
    public class ClassQuadrangle : ClassFigure
    {
        public int Width_Size { get; set; }
        public int Height_Size { get; set; }
        public ClassQuadrangle(ClassPoint point, int width_size, int height_size) : base(point)
        {
            Width_Size = width_size;
            Height_Size = height_size;
        }
        public override void Show(Graphics canvas)
        {
            //MessageBox.Show($"Четырёхугольник с координатами {Point.X} и {Point.Y} создана!", "Уведомление", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        public void ChangeSize(Graphics canvas, int newWidth, int newHeight)
        {
            Width_Size = newWidth;
            Height_Size = newHeight;
            Show(canvas);
        }
    }
}
