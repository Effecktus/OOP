using System.Drawing;

namespace ClassLibrary
{
    public class ClassRing : ClassCircle
    {
        public ClassCircle Circle1 { get; set; }
        public ClassCircle Circle2 { get; set; }
        public ClassRing(ClassPoint Center, int radius) : base(Center, radius, Color.MediumAquamarine)
        {
            Circle1 = new ClassCircle(Center, radius, Color.MediumAquamarine);
            Circle2 = new ClassCircle(Center, (int)(radius * 0.8), Color.White);
            //MessageBox.Show($"Кольцо с координатами ({Center.X}, {Center.Y}) и радиусом {radius} создан.", "Уведомление!",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public override void Show(Graphics canvas)
        {
            Circle1.Show(canvas);
            Circle2.Show(canvas);
        }

        public new void MoveTo(Graphics canvas, int newX, int newY)
        {
            Circle1.MoveTo(canvas, newX, newY);
            Circle2.MoveTo(canvas, newX, newY);
            Show(canvas);
        }

        public new void ChangeRadius(Graphics canvas, int newRadius)
        {
            Circle1.ChangeRadius(canvas, newRadius);
            Circle2.ChangeRadius(canvas, (int)(newRadius * 0.8));
            Show(canvas);
        }
    }
}
