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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form_array = new FormArray();
            form_array.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form form_list = new FormList();
            form_list.Show();
        }
    }
}
