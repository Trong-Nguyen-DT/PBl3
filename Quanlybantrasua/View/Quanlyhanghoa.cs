using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlybantrasua.BLL;

namespace Quanlybantrasua
{
    public partial class Quanlyhanghoa : Form
    {
        public Quanlyhanghoa()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
           danhsachhanghoa.DataSource = BLLQLTS.Instance.GetAllHHTinhtrang();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            Themmon tm = new Themmon();
            tm.ShowDialog();
            GUI();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            //if (danhsachhanghoa.SelectedRows.Count > 0)
            //{
            //    MessageBox.Show("Bạn có muốn xóa không ?");
            //}
        }
    }
}
