using System;
using System.Windows.Forms;

namespace Lab_1
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
            var fornRectangle = new FormRectangle();
            fornRectangle.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var formLine = new FormEllipse();
            formLine.Show();
        }
    }
}
