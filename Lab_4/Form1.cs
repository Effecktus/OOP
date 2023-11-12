using System;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var formCircle = new FormCircle();
            formCircle.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var formSquare = new FormSquare();
            formSquare.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var formRectangle = new FormRectangle();
            formRectangle.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var formEllipse = new FormEllipse();
            formEllipse.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var formRing = new FormRing();
            formRing.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var formRhombus = new FormRhombus();
            formRhombus.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var formTrapezium = new FormTrapezium();
            formTrapezium.Show();
        }
    }
}
