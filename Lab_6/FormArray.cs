using ClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class FormArray : Form
    {
        ClassArray classArray;
        private readonly Graphics gfx;
        private readonly Bitmap bmp;
        public FormArray()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gfx.Clear(Color.White);
        }

        private void PictureBoxRefresh()
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = (Bitmap)bmp.Clone();
        }

        private void MesBox()
        {
            MessageBox.Show("Массив пуст или не создан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (classArray == null)
            {
                classArray = new ClassArray();
            }
            else
            {
                MessageBox.Show("Массив уже создан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (classArray != null && !classArray.Null())
            {
                gfx.Clear(Color.White);
                classArray.Iterator(gfx, ClassArray.Method.Adding);
                PictureBoxRefresh();
            }
            else MesBox();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (classArray != null && classArray.Anny())
            {
                gfx.Clear(Color.White);
                classArray.Iterator(gfx, ClassArray.Method.Showing);
                PictureBoxRefresh();
            }
            else MesBox();
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (classArray != null && classArray.Anny())
            {
                gfx.Clear(Color.White);
                classArray.Iterator(gfx, ClassArray.Method.Moving);
                PictureBoxRefresh();
            }
            else MesBox();
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            PictureBoxRefresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            classArray.Iterator(gfx, ClassArray.Method.Deleting);
            classArray = null;
            PictureBoxRefresh();
        }
    }
}
