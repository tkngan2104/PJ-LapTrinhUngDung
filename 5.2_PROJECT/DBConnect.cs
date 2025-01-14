using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_PROJECT
{
    internal class DBConnect
    {
        public DBConnect() { }
        SqlConnection conn = KetNoi("DESKTOP-FQR7ETF\\SQLEXPRESS", "QLSV");

        public static SqlConnection KetNoi(string tensever, string tendb)
        {
            string chuoi = "Data Source=" + tensever + ";Initial Catalog=" + tendb + ";Integrated Security=True";
            return new SqlConnection(chuoi);
        }

        public void MoKetNoi()
        {
            if (conn.State.ToString() == "Close")
            {
                conn.Open();
            }
        }

        public void DongKetNoi()
        {
            if (conn.State.ToString() == "Open")
            {
                conn.Close();
            }
        }

        public DataTable ExeTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            finally
            {
                DongKetNoi();
            }
            return dt;
        }
    }
}

