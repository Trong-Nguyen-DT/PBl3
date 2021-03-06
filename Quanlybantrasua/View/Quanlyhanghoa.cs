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
using Quanlybantrasua.View;

namespace Quanlybantrasua
{
    public partial class Quanlyhanghoa : Form
    {
        public Quanlyhanghoa()
        {
            InitializeComponent();
            Timer.Start();
        }
        private void Them_Click(object sender, EventArgs e)
        {
            Themmon tm = new Themmon();
            tm.ShowDialog();
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
        private void Thanhlucchon(Control tlc)
        {
            TLC.Top = tlc.Top;
            TLC.Height = tlc.Height;
        }

        private void btHH_Click(object sender, EventArgs e)
        {
            Thanhlucchon(btHH);
            var myControl = new Quanlybantrasua.View.Tankbar();
            panel1.Controls.Add(myControl);
        }

        private void btNV_Click(object sender, EventArgs e)
        {
            Thanhlucchon(btNV);
        }

        private void btDT_Click(object sender, EventArgs e)
        {
            Thanhlucchon(btDT);
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            TG.Text = dt.ToString("HH:mm:ss");
        }

       
    }
}
