using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restuarnt.DAL;
using System.Data;
using System.Data.SqlClient;

namespace Restuarnt.BL
{
    class Suppliers
    {
        internal void addSuppliers(string name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
   


            da.excutequery("addSuppliers", param);
            da.close();
        }
        internal void AddPhrichise(int IdSuppliers, DateTime Date)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];




            param[0] = new SqlParameter("@Id_Sup", SqlDbType.Int);
            param[0].Value = IdSuppliers;


            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;


            
          



            da.excutequery("AddPhrichise", param);
            da.close();

        }
        internal void AddPhrichiseDetails(int IdOrder,int id_prod,  decimal Quantity )
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Id_Purchise", SqlDbType.Int);
            param[0].Value = IdOrder;
            param[1] = new SqlParameter("@Id_prod", SqlDbType.Int);
            param[1].Value = id_prod;
     
            param[2] = new SqlParameter("@quantity", SqlDbType.Decimal);
            param[2].Value = Quantity;
          
            da.excutequery("AddPhrichiseDetails", param);
            da.close();

        }
        internal DataTable LastsuppliersID()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
         

            dt = da.selected("LastsuppliersID", null);
            da.close();
            return dt;
        }
        internal DataTable LastsuppliersNameID()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();


            dt = da.selected("LastsuppliersNameID", null);
            da.close();
            return dt;
        }
        internal DataTable SelectCompoSupplier()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();


            dt = da.selected("SelectCompoSupplier", null);
            da.close();
            return dt;
        }
        internal DataTable VildateSUppliers(int id, string name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;


            dt = da.selected("VildateSUppliers", param);
            da.close();
            return dt;
        }

        internal DataTable SELECTPhrchiseView()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();


            dt = da.selected("SELECTPhrchiseView", null);
            da.close();
            return dt;
        }
        internal DataTable SELECTPhrchise(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
         


            dt = da.selected("SELECTPhrchise", param);
            da.close();
            return dt;
        }

        internal DataTable SELECTPhrchiseSupplier(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;



            dt = da.selected("SELECTPhrchiseSupplier", param);
            da.close();
            return dt;
        }
        internal DataTable SearchPhrchiseView(DateTime FromDate, DateTime ToDate)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DataTable dt = new DataTable();
            param[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
            param[0].Value = FromDate;
            param[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
            param[1].Value = ToDate;
            dt = da.selected("SearchPhrchiseView", param);
            return dt;

        }

       
    }
}
