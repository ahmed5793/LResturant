using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Restuarnt.DAL;

namespace Restuarnt.BL
{
    class Delivery
    {

        internal void AddDeleiveryInformation(string name, string address, string phone)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[2].Value = phone;


            da.excutequery("AddDeleiveryInformation", param);
            da.close();
        }
        internal DataTable SelectDeliveryInformation()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectDeliveryInformation", null);
            da.close();
            return dt;
        }
        internal void DeleteDelivery(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;



            da.excutequery("DeleteDelivery", param);
            da.close();
        }
        internal void UpdateDeleiveryInformation(string name, string address, string phone, int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[2].Value = phone;
            param[3] = new SqlParameter("@idDelivery", SqlDbType.Int);
            param[3].Value = id;
            da.excutequery("UpdateDeleiveryInformation", param);
            da.close();


        }
        internal DataTable SelectDeliverycomp()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectDeliverycomp", null);
            da.close();
            return dt;
        }
    }
}

