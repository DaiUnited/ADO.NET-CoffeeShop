using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataConnection
    {
        public string connectionString = "Data Source=LAPTOP-FUS6MOH2;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;TrustServerCertificate=true;";
        //public string connectionString = "Server=(local);Database=QuanLyQuanCafe;User Id=sa;Password=123;TrustServerCertificate=true;";

        public DataConnection()
        {

        }
    }
}