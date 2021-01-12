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
    class Unit
    {
        internal void AddUnit(string UnitName)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name",SqlDbType.NVarChar,150);
            param[0].Value = UnitName;
          


            da.excutequery("AddUnit", param);
            da.close();
        }
        internal DataTable SelectUnit()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("SelectUnit", null);
            da.close();
            return dt;
        }
        internal DataTable VildateSelectUnit(int id, string name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_unit", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 150);
            param[1].Value = name;


            dt = da.selected("VildateSelectUnit", param);
            da.close();
            return dt;
        }
    }
}
