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
    class Menu
    {
        internal void AddMenu(string ItemName, decimal price, int IdCategory, byte [] Images)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@item_name", SqlDbType.NVarChar, 600);
            param[0].Value = ItemName;
            param[1] = new SqlParameter("@price", SqlDbType.Decimal);
            param[1].Value = price;
            param[2] = new SqlParameter("@id_category", SqlDbType.Int);
            param[2].Value = IdCategory;
            param[3] = new SqlParameter("@Images", SqlDbType.Image);
            param[3].Value = Images;

            da.excutequery("AddMenu", param);
            da.close();
        }
        internal void UpdateMenu(string ItemName, decimal price, int IdItem,int idcategory,byte [] Images)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@item_name", SqlDbType.NVarChar, 600);
            param[0].Value = ItemName;
            param[1] = new SqlParameter("@price", SqlDbType.Decimal);
            param[1].Value = price;
            param[2] = new SqlParameter("@Item_ID", SqlDbType.Int);
            param[2].Value = IdItem;
            param[3] = new SqlParameter("@idcategory", SqlDbType.Int);
            param[3].Value = idcategory;
            param[4] = new SqlParameter("@Images", SqlDbType.Image);
            param[4].Value = Images;

            da.excutequery("UpdateMenu", param);
            da.close();
        }
        internal void deleteMenu( int IdItem)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
         
            param[0] = new SqlParameter("@Item_ID", SqlDbType.Int);
            param[0].Value = IdItem;
     

            da.excutequery("deleteMenu", param);
            da.close();
        }
        internal DataTable SelectMenu()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectMenu", null);
            da.close();
            return dt;
        }
       
     

        internal DataTable PriceMenu(int idItem)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@itemId", SqlDbType.Int);
            param[0].Value = idItem;

            dt = da.selected("PriceMenu", param);
            da.close();
            return dt;
        }
        internal DataTable VildateItem(int idCtegory, int idItem)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idCategory", SqlDbType.Int);
            param[0].Value = idCtegory;
            param[1] = new SqlParameter("@IDItem", SqlDbType.Int);
            param[1].Value = idItem;
        

            dt = da.selected("VildateItem", param);
            da.close();
            return dt;
        }
        internal DataTable SearchMenue(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[0].Value = id;
        


            dt = da.selected("SearchMenue", param);
            da.close();
            return dt;
        }

    }
}
