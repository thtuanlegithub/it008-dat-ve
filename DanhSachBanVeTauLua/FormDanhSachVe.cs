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
    public partial class FormDanhSachVe : Form
    {
        public FormDanhSachVe()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            lvDSVe.Columns.Add("Mã KH", 100);
            lvDSVe.Columns.Add("Tên KH",150);
            lvDSVe.Columns.Add("Nghề nghiệp",150);
            lvDSVe.Columns.Add("Số lượng vé", 120);
            lvDSVe.Columns.Add("Tổng tiền",145);
            lvDSVe.View = View.Details;

            DBConnection dbConnection = new DBConnection();
            DataTable dataTable;
            using (var connection = dbConnection.GetConnection())
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Ve",connection);
                SqlDataAdapter dataAdapter= new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Ve");
                connection.Close();
                dataTable = dataSet.Tables["Ve"];
            }
            for(int i=0; i < dataTable.Rows.Count; i++)
            {
                lvDSVe.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
                lvDSVe.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[1].ToString());
                lvDSVe.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[3].ToString());
                lvDSVe.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[4].ToString());
                lvDSVe.Items[i].SubItems.Add(dataTable.Rows[i].ItemArray[9].ToString());
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            using (FormDatVe formDatVe = new FormDatVe())
            {
                formDatVe.ShowDialog();
            }    
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            lvDSVe.Clear();
            LoadData();
        }

        private void lvDSVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSVe.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDSVe.SelectedItems[0];

                string MaKH = lvi.SubItems[0].Text;
                FormThongTinVe formThongTinVe = new FormThongTinVe(MaKH); 
                formThongTinVe.ShowDialog();
            }
        }
    }
}
