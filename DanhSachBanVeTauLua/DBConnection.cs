using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachBanVeTauLua
{
    public class DBConnection
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DanhSachVe"].ConnectionString;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
