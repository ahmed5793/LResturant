using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Restuarnt.DAL;


namespace Restuarnt.BL
{
    class Stuff
    {

        internal void AddStuuf(string name, string phone, string address)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@stuufName", SqlDbType.NVarChar, 250);
            param[0].Value = name;
            param[1] = new SqlParameter("@phone", SqlDbType.VarChar,50);
            param[1].Value = phone;
            param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 250);
            param[2].Value = address;
          
            da.excutequery("AddStuuf", param);
            da.close();


        }
        internal DataTable SelectStuuf()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectStuuf", null);
            da.close();
            return dt;
        }
        internal void DeleteStuff(int idStuff)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idStuff", SqlDbType.Int);
            param[0].Value = idStuff;



            da.excutequery("DeleteStuff", param);
            da.close();
        }
        internal void UpdateStuuf(string name , string phone, string address, int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@stuufName", SqlDbType.NVarChar, 100);
            param[0].Value = name;
            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[1].Value = phone;
            param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 250);
            param[2].Value = address;
            param[3] = new SqlParameter("@iDStuff", SqlDbType.Int);
            param[3].Value = id;
            da.excutequery("UpdateStuuf", param);
            da.close();


        }
        internal DataTable REPORTStuff(int idStuff,DateTime fromDate, DateTime todate)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idStuff", SqlDbType.Int);
            param[0].Value = idStuff;
            param[1] = new SqlParameter("@fromDate", SqlDbType.DateTime);
            param[1].Value = fromDate;
            param[2] = new SqlParameter("@todate", SqlDbType.DateTime);
            param[2].Value = todate;
            dt = da.selected("REPORTStuff", param);
            da.close();
            return dt;
        }
    }
}
