using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestDBConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection("Data Source=faysals-pc\\SQLEXPRESS;Initial Catalog=Test;User ID=sa;Password=p@ssword;Encrypt=False;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine($"ID: {ds.Tables[0].Rows[i][0].ToString()}");
                Console.WriteLine($"Name: {ds.Tables[0].Rows[i][1].ToString()}");
                Console.WriteLine($"Email: {ds.Tables[0].Rows[i][2].ToString()}");
                Console.WriteLine($"Password: {ds.Tables[0].Rows[i][3].ToString()}\n");
            }
        }
    }
}
