using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Restuarnt.DAL;
using System.Data.SqlClient;

namespace Restuarnt.BL
{
    class Category
    {
      
        internal void AddCategory(string name,string Departement,byte [] Images)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;
            param[1] = new SqlParameter("@Departement", SqlDbType.NVarChar,50);
            param[1].Value = Departement;
            param[2] = new SqlParameter("@Images", SqlDbType.Image);
            param[2].Value = Images;

            da.excutequery("AddCategory", param);
            da.close();
        }
        internal DataTable SelectCategory()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCategory", null);
            da.close();
            return dt;
        }
        internal DataTable SelectCategoryCompo()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectCategoryCompo", null);
            da.close();
            return dt;
        }
        internal DataTable VildateDepartmentCategory(int idCategory)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idCategory", SqlDbType.Int);
            param[0].Value = idCategory;
            dt = da.selected("VildateDepartmentCategory", param);
            da.close();
            return dt;
        }
        internal DataTable VildateDepartmentCategoryEaiting(int idCategory)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idCategory", SqlDbType.Int);
            param[0].Value = idCategory;
            dt = da.selected("VildateDepartmentCategoryEaiting", param);
            da.close();
            return dt;
        }
        internal void UpdateCtegory(int id,string name,string Departement,byte [] Images)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;
            param[2] = new SqlParameter("@Departement", SqlDbType.NVarChar, 50);
            param[2].Value = Departement;
            param[3] = new SqlParameter("@Images", SqlDbType.Image);
            param[3].Value = Images;

            da.excutequery("UpdateCtegory", param);
            da.close();
        }
        internal void deleteCategory(int ID_Category)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Category", SqlDbType.Int);
            param[0].Value = ID_Category;
     


            da.excutequery("deleteCategory", param);
            da.close();
        }
    }
}
