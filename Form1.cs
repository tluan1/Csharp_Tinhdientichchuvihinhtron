using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Tinhdientichchuvihinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void C_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R, ketqua, pi = Math.PI;
            R = Convert.ToDouble(txtR.Text);
            ketqua = R * 2 * pi;
            txtketqua.Text = ketqua.ToString();

        }

        private void btndientich_Click(object sender, EventArgs e)
        {
            double R, ketqua, pi = Math.PI;
            R = Convert.ToDouble(txtR.Text);
            ketqua = R * R * pi;
            txtketqua.Text = ketqua.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double R, ketqua;
        }

        private void btntinh1_Click(object sender, EventArgs e)
        {
            double R = Convert.ToDouble(txtR.Text);
            if (rdbchuvi.Checked)
            {
                double chuvi = R * 2 * Math.PI;
                string thongbao = " chuvi " + Convert.ToString(chuvi);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbdientich.Checked)
            {
                double dientich = R * R * Math.PI;
                string thongbao = " dientich " + Convert.ToString(dientich);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btntinh2_Click(object sender, EventArgs e)
        {
            double R = Convert.ToDouble(txtR.Text);
            string thongbao = "";
            if (chkchuvi.Checked)
            {
                double chuvi = R * 2 * Math.PI;
                thongbao = thongbao + "Chu vi" + Convert.ToString(chuvi) + Environment.NewLine;
            }
            if (chkdientich.Checked)
            {
                double dientich = R * R * Math.PI;
                thongbao = thongbao + "Diện tích" + Convert.ToString(dientich) + Environment.NewLine;
            }
            if (thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tính năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

