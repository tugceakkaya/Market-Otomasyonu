using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SiparisOtomasyonu.DAL
{
    public class Urunler
    {
        private DBConnection dbConnection;

        public Urunler()
        {
            dbConnection = new DBConnection();
        }
        public DataTable GetAllItems()
        {
            SqlCommand cmd = dbConnection.GetSqlCommand();
            cmd.CommandText = "Select *from dbo.urunler";

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());


            return dt;
        }
    }
}
