using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class FormList : Form
    {
        ClassList classList;
        private readonly Graphics gfx;
        private readonly Bitmap bmp;
        public FormList()
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
            gfx.Clear(Color.White);
            classList = new ClassList(gfx);
            PictureBoxRefresh();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (classList != null)
            {
                gfx.Clear(Color.White);
                classList.Iterator(gfx, ClassList.Method.Adding);
                PictureBoxRefresh();
            }
            else MesBox();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (classList != null && !classList.Null())
            {
                gfx.Clear(Color.White);
                classList.Iterator(gfx, ClassList.Method.Showing);
                PictureBoxRefresh();
            }
            else MesBox();
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (classList != null && !classList.Null())
            {
                gfx.Clear(Color.White);
                classList.Iterator(gfx, ClassList.Method.Moving);
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
            classList.Iterator(gfx, ClassList.Method.Deleting);
            classList = null;
            PictureBoxRefresh();
        }
    }
}
