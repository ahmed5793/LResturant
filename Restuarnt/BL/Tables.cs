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
    class Tables
    {
        internal DataTable VildateTable(int idTable)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@idTable", SqlDbType.Int);
            param[0].Value = idTable;
         
            dt = da.selected("VildateTable", param);
            da.close();
            return dt;
        }
        internal void AddTables(string tableNumber)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TablesNumber", SqlDbType.NVarChar,100);
            param[0].Value = tableNumber;



            da.excutequery("AddTables", param);
            da.close();
        }
        internal DataTable SelectTables()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectTables", null);
            da.close();
            return dt;
        }
        internal DataTable SelectTablesCompo()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectTablesCompo", null);
            da.close();
            return dt;
        }
        
        internal void UpdateTables(int idTable, string TableNumber)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idTables", SqlDbType.Int);
            param[0].Value = idTable;
            param[1] = new SqlParameter("@TablesNumber", SqlDbType.NVarChar,100);
            param[1].Value = TableNumber;



            da.excutequery("UpdateTables", param);
            da.close();
        }
        internal void UpdateSala(int idorder, int idTable)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = idorder;
            param[1] = new SqlParameter("@idTable", SqlDbType.Int);
            param[1].Value = idTable;



            da.excutequery("UpdateSala", param);
            da.close();
        }
        internal void UpdateSalaStuff(int idorder, int idTable)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = idorder;
            param[1] = new SqlParameter("@ID_Stuff", SqlDbType.Int);
            param[1].Value = idTable;



            da.excutequery("UpdateSalaStuff", param);
            da.close();
        }
        internal void UpdateTablesInOrder(int idTable, int Booking)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@idTables", SqlDbType.Int);
            param[0].Value = idTable;
            param[1] = new SqlParameter("@Booking", SqlDbType.Int);
            param[1].Value = Booking;



            da.excutequery("UpdateTablesInOrder", param);
            da.close();
        }

        internal DataTable DeleteTables(int iD_Table)
        {
            DataTable dt = new DataTable();
         
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@iD_Table", SqlDbType.Int);
            param[0].Value = iD_Table;
            dt = da.selected("DeleteTables", param);
            da.close();
            return dt;
        }

        internal DataTable validateTableOrder(int iD_Table)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@iD_Table", SqlDbType.Int);
            param[0].Value = iD_Table;
            dt = da.selected("validateTableOrder", param);
            da.close();
            return dt;
        }

    }
}

