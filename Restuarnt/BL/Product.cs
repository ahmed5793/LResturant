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
    class Product
    {
        internal void AddProduct( string name, decimal quantity ,int id_unit)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
          
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 150);
            param[0].Value = name;
            param[1] = new SqlParameter("@quantity", SqlDbType.Decimal);
            param[1].Value = quantity;
            param[2] = new SqlParameter("@id_Unit", SqlDbType.Int);
            param[2].Value = id_unit;



            da.excutequery("AddProduct", param);
            da.close();
        }
        internal void updateProduct(int id_prod,string name, decimal quantity, int id_unit)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id_prod", SqlDbType.Int);
            param[0].Value = id_prod;
            param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 150);
            param[1].Value = name;
            param[2] = new SqlParameter("@quantity", SqlDbType.Decimal);
            param[2].Value = quantity;
            param[3] = new SqlParameter("@id_Unit", SqlDbType.Int);
            param[3].Value = id_unit;



            da.excutequery("updateProduct", param);
            da.close();
        }
        internal DataTable SelectProdec()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectProdec", null);
            da.close();
            return dt;
        }
        internal DataTable SearchProduct(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;



            dt = da.selected("SearchProduct", param);
            da.close();
            return dt;
        }
    }
}
