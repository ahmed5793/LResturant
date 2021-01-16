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
    class Reserve
    {
        internal void AddReserve(string TypeReserve)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@TypeReserve", SqlDbType.NVarChar, 200);
            param[0].Value = TypeReserve;

            da.excutequery("AddReserve", param);
            da.close();
        }
        internal DataTable SelectReserve()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("SelectReserve", null);
            da.close();
            return dt;
        }

        internal void AddReserveDetails(int IdReserve, string decription, decimal amount, DateTime date,int Id_USer)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            da.open();
            param[0] = new SqlParameter("@idReserve", SqlDbType.Int);
            param[0].Value = IdReserve;
            param[1] = new SqlParameter("@decraiption", SqlDbType.NVarChar, 500);
            param[1].Value = decription;
            param[2] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[2].Value = amount;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@Id_User", SqlDbType.Int);
            param[4].Value = Id_USer;
            da.excutequery("AddReserveDetails", param);
            da.close();
        }

        internal void DeleteReserveDetails(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            da.excutequery("DeleteReserveDetails", param);
            da.close();
        }

        internal void UpdateResrveDetails(int id, int IdReserve, string decription, decimal amount, DateTime date)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            da.open();
            param[0] = new SqlParameter("@idReserve", SqlDbType.Int);
            param[0].Value = IdReserve;
            param[1] = new SqlParameter("@decraiption", SqlDbType.NVarChar, 400);
            param[1].Value = decription;
            param[2] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[2].Value = amount;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@id", SqlDbType.Int);
            param[4].Value = id;

            da.excutequery("UpdateResrveDetails", param);
            da.close();
        }
        internal DataTable SelectReserveDetails()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("SelectReserveDetails", null);
            da.close();
            return dt;
        }
        internal DataTable SelectTotallReserve()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("SelectTotallReserve", null);
            da.close();
            return dt;
        }
        internal DataTable SearchMasrofatFromDate(DateTime FromDate, DateTime ToDate)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DataTable dt = new DataTable();
            param[0] = new SqlParameter("@FromDate", SqlDbType.Date);
            param[0].Value = FromDate;
            param[1] = new SqlParameter("@ToDate", SqlDbType.Date);
            param[1].Value = ToDate;
            dt = da.selected("SearchMasrofatFromDate", param);
            return dt;

        }
        internal DataTable selectTypeMasrof()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("selectTypeMasrof", null);
            da.close();
            return dt;
        }

        internal void DeleteTypeMasrof(int idType)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@idType", SqlDbType.Int);
            param[0].Value = idType;
            
          

            da.excutequery("DeleteTypeMasrof", param);
            da.close();
        }
    }
}

