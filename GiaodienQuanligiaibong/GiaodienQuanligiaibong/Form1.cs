using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaodienQuanligiaibong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormDangkigiai f = new FormDangkigiai();
            f.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FormXeplichdau f = new FormXeplichdau();
            f.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FormKetqua f = new FormKetqua();
            f.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FormXephang f = new FormXephang();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
