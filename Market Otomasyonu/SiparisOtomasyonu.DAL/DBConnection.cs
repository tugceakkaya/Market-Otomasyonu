using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SiparisOtomasyonu.DAL
{
   public class DBConnection
    {
        private readonly string _connectionString;

       public DBConnection()
        {
            _connectionString = "Data Source=DESKTOP-OB0RJ4P;Initial Catalog=satici;Integrated Security=True";
        }
        private SqlConnection GetSqlConnection()

        {
            SqlConnection con = new SqlConnection(_connectionString);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            else
            {
                con.Open();

            }
            return con;

        }
        public SqlCommand GetSqlCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetSqlConnection();
            return cmd;


        }
    }
}
