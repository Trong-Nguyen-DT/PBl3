using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybantrasua
{
    public partial class Quanlyhanghoa : Form
    {
        public Quanlyhanghoa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult db = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (db == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            Themmon tm = new Themmon();
            tm.ShowDialog();
        }
    }
}
