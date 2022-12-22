using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhSachBanVeTauLua
{
    public partial class FormDatVe : Form
    {
        public FormDatVe()
        {
            InitializeComponent();
        }
        private bool isNumber(char c)
        {
            if(c>='0' && c <= '9')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {

            }
            else
            {
                MessageBox.Show("Vui lòng nhập kí tự số!", "Thông báo nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void tbDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập kí tự số!", "Thông báo nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {

            if (tbDonGia.Text != "" && tbSoLuong.Text != "")
            {
                tbThanhTien.Text = (int.Parse(tbDonGia.Text) * int.Parse(tbSoLuong.Text)).ToString();
                double TienThue = double.Parse((int.Parse(tbThanhTien.Text) / 10).ToString());
                tbThue.Text = TienThue.ToString();
                if (rBtnSV.Checked)
                {
                    double Tien = double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text);
                    tbGiamGia.Text = (Tien / 10).ToString();
                }
                else if(rBtnKhac.Checked)
                {
                    double Tien = double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text);
                    tbGiamGia.Text = (Tien / 5).ToString();
                    tbTongTien.Text = (double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text) - double.Parse(tbGiamGia.Text)).ToString();
                }
                else
                {
                    tbGiamGia.Text = "";
                    tbTongTien.Text = "";
                }
            }
            else
            {
                tbThanhTien.Text = "";
                tbThue.Text = "";
                tbGiamGia.Text = "";
                tbTongTien.Text = "";
            }
        }

        private void tbDonGia_TextChanged(object sender, EventArgs e)
        {

            if (tbDonGia.Text != "" && tbSoLuong.Text != "")
            {
                tbThanhTien.Text = (int.Parse(tbDonGia.Text) * int.Parse(tbSoLuong.Text)).ToString();
                double TienThue = double.Parse((int.Parse(tbThanhTien.Text) / 10).ToString());
                tbThue.Text = TienThue.ToString();
                if (rBtnSV.Checked)
                {
                    double Tien = double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text);
                    tbGiamGia.Text = (Tien / 10).ToString();
                    tbTongTien.Text = (double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text) - double.Parse(tbGiamGia.Text)).ToString();
                }
                else if (rBtnKhac.Checked)
                {
                    double Tien = double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text);
                    tbGiamGia.Text = (Tien / 5).ToString();
                    tbTongTien.Text = (double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text) - double.Parse(tbGiamGia.Text)).ToString();
                }
                else
                {
                    tbGiamGia.Text = "";
                    tbTongTien.Text = "";
                }
            }
            else
            {
                tbThanhTien.Text = "";
                tbThue.Text = "";
                tbGiamGia.Text = "";
                tbTongTien.Text = "";
            }
        }

        private void rBtnSV_Click(object sender, EventArgs e)
        {
            if (tbThanhTien.Text != "")
            {
                double Tien = double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text);
                tbGiamGia.Text = (Tien / 10).ToString();
                tbTongTien.Text = (double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text) - double.Parse(tbGiamGia.Text)).ToString();
            }
        }
        private void rBtnKhac_Click(object sender, EventArgs e)
        {
            if (tbThanhTien.Text != "")
            {
                double Tien = double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text);
                tbGiamGia.Text = (Tien / 5).ToString();
                tbTongTien.Text = (double.Parse(tbThanhTien.Text) + double.Parse(tbThue.Text) - double.Parse(tbGiamGia.Text)).ToString();
            }
        }
        private string GetMaKH()
        {
            string MaKH="0";
            DBConnection dBConnection = new DBConnection();
            using (var connection = dBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT TOP 1 MaKH FROM Ve ORDER BY MaKH DESC", connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    MaKH = reader[0].ToString();
                }
                reader.Close();
                connection.Close();
            }
            int x = int.Parse(MaKH);
            x = x + 1;
            MaKH = x.ToString();
            return MaKH;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
            DBConnection dBConnection = new DBConnection();
            using(var connection = dBConnection.GetConnection())
            {
                connection.Open();
                Ve ve = new Ve();
                ve.MaKH = GetMaKH();
                ve.TenKH = tbTenKH.Text;
                ve.DiaChi = tbDC.Text;
                if (rBtnSV.Checked)
                {
                    ve.NgheNghiep = "Sinh viên";
                }
                else
                {
                    ve.NgheNghiep = "Khác";
                }
                ve.SoLuongVe = tbSoLuong.Text;
                ve.DonGia = tbDonGia.Text;
                ve.ThanhTien = tbThanhTien.Text;
                ve.Thue = tbThue.Text;
                ve.GiamGia = tbGiamGia.Text;
                ve.TongTien = tbTongTien.Text;
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Ve VALUES('" + ve.MaKH + "',N'" + ve.TenKH + "',N'" + ve.DiaChi + "',N'" + ve.NgheNghiep + "','" + ve.SoLuongVe + "','" + ve.DonGia + "','" + ve.ThanhTien + "','" + ve.Thue + "','"+ve.GiamGia+"','" + ve.TongTien + "')", connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
        }
    }
}
