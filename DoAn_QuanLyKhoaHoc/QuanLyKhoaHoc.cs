using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhoaHoc
{
    public partial class QuanLyKhoaHoc : Form
    {
        public QuanLyKhoaHoc()
        {
            InitializeComponent();
        }

        
        private void btnQLBH_Click(object sender, EventArgs e)
        {
            QuanLyBaiHoc dlg2 = new QuanLyBaiHoc();   // Gọi form quản lý bài học
            dlg2.ShowDialog();       ///


            //QuanLyBaiHoc dlg2 = new QuanLyBaiHoc(); /// them 1 form vao 1 panel
            //dlg2.TopLevel = false;
            //panel2.Controls.Add(dlg2);
            //dlg2.Dock = DockStyle.Fill;
            //dlg2.Show();
        }
    }
}
