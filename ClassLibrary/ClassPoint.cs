using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class ClassPoint 
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ClassPoint(int x, int y)
        {
            X = x;
            Y = y;
            //MessageBox.Show($"Точка с координатами {X} и {Y} создана!", "Уведомление", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public void ChangeCords(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }
    }
}
