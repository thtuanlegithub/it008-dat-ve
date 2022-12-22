using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhSachBanVeTauLua
{
    public partial class FormThongTinVe : Form
    {
        private string MaKH;
        public FormThongTinVe(string MaKH)
        {
            InitializeComponent();
            this.MaKH = MaKH;
            LoadData();
            this.ActiveControl = lbTitle;
        }
        private void LoadData()
        {
            try
            { 
                DBConnection dBConnection = new DBConnection();
                using (var connection = dBConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "SELECT * FROM Ve WHERE MaKH = '" + MaKH + "'";
                    sqlCommand.Connection = connection;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        tbTenKH.Text = sqlDataReader[1].ToString();
                        tbDC.Text = sqlDataReader[2].ToString();
                        if (sqlDataReader[3].ToString()=="Sinh viên")
                        {
                            rBtnSV.Checked = true;
                        }
                        else
                        {
                            rBtnKhac.Checked = true;
                        }
                        tbSoLuong.Text = sqlDataReader[4].ToString();
                        tbDonGia.Text = sqlDataReader[5].ToString();
                        tbThanhTien.Text = sqlDataReader[6].ToString();
                        tbThue.Text = sqlDataReader[7].ToString();
                        tbGiamGia.Text = sqlDataReader[8].ToString();
                        tbTongTien.Text = sqlDataReader[9].ToString();
                    }
                    sqlDataReader.Close();
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            { 
                DBConnection dBConnection = new DBConnection();
                using (var connection = dBConnection.GetConnection())
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = "DELETE FROM Ve WHERE MaKH = '" + MaKH + "'";
                    sqlCommand.Connection = connection;
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                }
                this.Close();
            }
            else
            {
                return;
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
