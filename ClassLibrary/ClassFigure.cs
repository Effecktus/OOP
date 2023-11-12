using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary
{
    public abstract class ClassFigure
    {
        public ClassPoint Point { get; set; }
        public ClassFigure(ClassPoint point)
        {
            Point = point;
            //MessageBox.Show($"Фигура с координатами {Point.X} и {Point.Y} создана!", "Уведомление", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        public virtual void Show(Graphics canvas)
        {

        }
        public virtual void MoveTo(Graphics canvas, int newX, int newY) 
        {
            Point.ChangeCords(newX, newY);
            Show(canvas);
        }
    }
}
