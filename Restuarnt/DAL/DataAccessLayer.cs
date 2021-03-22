using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Restuarnt.DAL
{
    class DataAccessLayer
    {

        SqlConnection con;
        internal DataAccessLayer()
        {
            //  con = new SqlConnection(@"Server =.\SQLExpress;  Database = DB_A54A03_Resturant; integrated security=true");
             // con = new SqlConnection(@" server =.; database=DB_A54A03_Resturant;integrated security=true");

              con = new SqlConnection("Data Source=SQL5103.site4now.net;Initial Catalog=DB_A54A03_Restuarnt;User Id=DB_A54A03_Restuarnt_admin;Password=Titonasser1994;MultipleActiveResultSets=True;Max Pool Size=200;");
          

        }

        internal void open()

        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }
        internal void close()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        SqlCommand cm = new SqlCommand();
        
        internal DataTable selected(string storedProcedure, SqlParameter[] param)
        {

            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = storedProcedure;
            cm.Connection = con;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cm.Parameters.Add(param[i]);
                }

            }
            SqlDataAdapter adabt = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adabt.Fill(dt);
            return dt;
        }

        internal void excutequery(string storedProcedure, SqlParameter[] param)
        {
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = storedProcedure;
            cm.Connection = con;
            if (param != null)
            {
                cm.Parameters.AddRange(param);
            }
            cm.ExecuteNonQuery();


        }
    }
}
