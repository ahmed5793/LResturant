﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Restuarnt.BL;
using System.Data;
using Restuarnt.DAL;
using DevExpress.XtraBars.Customization;

namespace Restuarnt.BL
{
    class Login
    {
        

            internal DataTable Logins(string UserName, string pass)
            {
           DataAccessLayer da = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                param[0].Value = UserName;

                param[1] = new SqlParameter("@PASS", SqlDbType.VarChar, 50);
                param[1].Value = pass;
                da.open();
                DataTable dt = new DataTable();
                dt = da.selected("st_login", param);

                return dt;

            }
         internal DataTable SelectComboUsers()
         {
            DataAccessLayer da = new DataAccessLayer();
         
            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("SelectComboUsers", null);

            return dt;

        }
        internal DataTable AddUser(string Username, string pass, string fullName, string Show)
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                DataTable dt = new DataTable();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
                param[0].Value = Username;
                param[1] = new SqlParameter("@PASS", SqlDbType.VarChar, 50);
                param[1].Value = pass;
                param[2] = new SqlParameter("@FullName", SqlDbType.VarChar, 100);
                param[2].Value = fullName;
                param[3] = new SqlParameter("@show", SqlDbType.NVarChar, 50);
                param[3].Value = Show;
              dt=  da.selected("AddUser", param);
                da.close();
            return dt;
            }




            internal DataTable SelectUsers()
            {
                DataAccessLayer da = new DataAccessLayer();

                da.open();
                DataTable dt = new DataTable();
                dt = da.selected("SelectUsers", null);

                return dt;

            }

            internal void UpdateUsers(int id_User, string user_Name, string pass,string FullName)
            {

                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@id_User", SqlDbType.Int);
                param[0].Value = id_User;
                param[1] = new SqlParameter("@USerName", SqlDbType.NVarChar, 50);
                param[1].Value = user_Name;
                param[2] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
                param[2].Value = pass;
                param[3] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
                param[3].Value = FullName;
            da.excutequery("UpdateUsers", param);
                da.close();
            }

            internal void deleteusers(int id)
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                da.excutequery("deleteusers", param);
                da.close();
            }

            internal void ADDLogin(string id, string login)
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[0].Value = id;
                param[1] = new SqlParameter("LogIn", SqlDbType.NVarChar, 50);
                param[1].Value = login;
                da.excutequery("ADDLogin", param);
                da.close();
            }

            internal DataTable LastIDLogin()
            {
                DataAccessLayer da = new DataAccessLayer();

                da.open();
                DataTable dt = new DataTable();
                dt = da.selected("LastIDLogin", null);

                return dt;

            }
         


            internal DataTable SelectLogin(string id)
            {
                DataAccessLayer da = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[0].Value = id;

                da.open();
                DataTable dt = new DataTable();
                dt = da.selected("SelectLogin", param);

                return dt;

            }

            internal DataTable selectIDUser()
            {
                DataAccessLayer da = new DataAccessLayer();

                da.open();
                DataTable dt = new DataTable();
                dt = da.selected("selectIDUser", null);

                return dt;

            }
        internal DataTable vidldateUser(string id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            da.open();
            DataTable dt = new DataTable();
            dt = da.selected("vidldateUser", param);

            return dt;

        }
        internal DataTable Select_UserPermession(int Id_User)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_User", SqlDbType.Int);
            param[0].Value = Id_User;
            da.open();
            dt = da.selected("Select_UserPermession", param);
            return dt;
            }
        internal void Add_UserPermession(int Id_User , int Add_Category , int Add_Item ,int Add_Table , int add_Delivery,
            int Add_Captin ,int SettingOrder, int management_Oreder , int Order ,int Move_Product , int Recive_Money,
            int Add_Masrof, int Report_Masrofat, int add_User,
          int USer_Permession, int Add_BackUp, int Add_Restore, int UpdateOrder, int DeleteOrder,
        int  minsQuantity ,int DeleteItemHold ,int DeleteOrderHold )
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[22];
            param[0] = new SqlParameter("@Id_User", SqlDbType.Int);
            param[0].Value = Id_User;
            param[1] = new SqlParameter("@Add_Category", SqlDbType.Int);
            param[1].Value = Add_Category;
            param[2] = new SqlParameter("@Add_Item", SqlDbType.Int);
            param[2].Value = Add_Item;
            param[3] = new SqlParameter("@Add_Table", SqlDbType.Int);
            param[3].Value = Add_Table;
            param[4] = new SqlParameter("@Add_Delivery", SqlDbType.Int);
            param[4].Value = add_Delivery;
            param[5] = new SqlParameter("@Add_Captin", SqlDbType.Int);
            param[5].Value = Add_Captin;
            param[6] = new SqlParameter("@Setting_Order", SqlDbType.Int);
            param[6].Value = SettingOrder;
            param[7] = new SqlParameter("@Managemt_Order", SqlDbType.Int);
            param[7].Value = management_Oreder;
            param[8] = new SqlParameter("@Orders", SqlDbType.Int);
            param[8].Value = Order;
            param[9] = new SqlParameter("@Move_Product", SqlDbType.Int);
            param[9].Value = Move_Product;
            param[10] = new SqlParameter("@Recive_Money", SqlDbType.Int);
            param[10].Value = Recive_Money;
            param[11] = new SqlParameter("@Add_masrof", SqlDbType.Int);
            param[11].Value = Add_Masrof;
            param[12] = new SqlParameter("@Report_Masrofat", SqlDbType.Int);
            param[12].Value = Report_Masrofat;
            param[13] = new SqlParameter("@Add_User", SqlDbType.Int);
            param[13].Value = add_User;
            param[14] = new SqlParameter("@USer_Permession", SqlDbType.Int);
            param[14].Value = USer_Permession;
            param[15] = new SqlParameter("@Add_BackUp", SqlDbType.Int);
            param[15].Value = Add_BackUp;
            param[16] = new SqlParameter("@Add_Restore", SqlDbType.Int);
            param[16].Value = Add_Restore;
            param[17] = new SqlParameter("@Update_Order", SqlDbType.Int);
            param[17].Value = UpdateOrder;
            param[18] = new SqlParameter("@Delete_Order", SqlDbType.Int);
            param[18].Value = DeleteOrder;
            param[19] = new SqlParameter("@minsQuantity", SqlDbType.Int);
            param[19].Value = minsQuantity;
            param[20] = new SqlParameter("@DeleteItemHold", SqlDbType.Int);
            param[20].Value = DeleteItemHold;
            param[21] = new SqlParameter("@DeleteOrderHold", SqlDbType.Int);
            param[21].Value = DeleteOrderHold;
            da.excutequery("Add_UserPermession", param);
            da.close();
        }
       

        internal void Update_UserPermession(int Id_User, int Add_Category, int Add_Item, int Add_Table, int add_Delivery,
         int Add_Captin, int SettingOrder, int management_Oreder, int Order, int Move_Product, int Recive_Money,
         int Add_Masrof, int Report_Masrofat, int add_User,
       int USer_Permession, int Add_BackUp, int Add_Restore, int UpdateOrder, int DeleteOrder,
       int minsQuantity, int DeleteItemHold, int DeleteOrderHold)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[22];
            param[0] = new SqlParameter("@Id_User", SqlDbType.Int);
            param[0].Value = Id_User;
            param[1] = new SqlParameter("@Add_Category", SqlDbType.Int);
            param[1].Value = Add_Category;
            param[2] = new SqlParameter("@Add_Item", SqlDbType.Int);
            param[2].Value = Add_Item;
            param[3] = new SqlParameter("@Add_Table", SqlDbType.Int);
            param[3].Value = Add_Table;
            param[4] = new SqlParameter("@Add_Delivery", SqlDbType.Int);
            param[4].Value = add_Delivery;
            param[5] = new SqlParameter("@Add_Captin", SqlDbType.Int);
            param[5].Value = Add_Captin;
            param[6] = new SqlParameter("@Setting_Order", SqlDbType.Int);
            param[6].Value = SettingOrder;
            param[7] = new SqlParameter("@Managemt_Order", SqlDbType.Int);
            param[7].Value = management_Oreder;
            param[8] = new SqlParameter("@Orders", SqlDbType.Int);
            param[8].Value = Order;
            param[9] = new SqlParameter("@Move_Product", SqlDbType.Int);
            param[9].Value = Move_Product;
            param[10] = new SqlParameter("@Recive_Money", SqlDbType.Int);
            param[10].Value = Recive_Money;
            param[11] = new SqlParameter("@Add_masrof", SqlDbType.Int);
            param[11].Value = Add_Masrof;
            param[12] = new SqlParameter("@Report_Masrofat", SqlDbType.Int);
            param[12].Value = Report_Masrofat;
            param[13] = new SqlParameter("@Add_User", SqlDbType.Int);
            param[13].Value = add_User;
            param[14] = new SqlParameter("@USer_Permession", SqlDbType.Int);
            param[14].Value = USer_Permession;
            param[15] = new SqlParameter("@Add_BackUp", SqlDbType.Int);
            param[15].Value = Add_BackUp;
            param[16] = new SqlParameter("@Add_Restore", SqlDbType.Int);
            param[16].Value = Add_Restore;
            param[17] = new SqlParameter("@Update_Order", SqlDbType.Int);
            param[17].Value = UpdateOrder;
            param[18] = new SqlParameter("@Delete_Order", SqlDbType.Int);
            param[18].Value = DeleteOrder;
            param[19] = new SqlParameter("@minsQuantity", SqlDbType.Int);
            param[19].Value = minsQuantity;
            param[20] = new SqlParameter("@DeleteItemHold", SqlDbType.Int);
            param[20].Value = DeleteItemHold;
            param[21] = new SqlParameter("@DeleteOrderHold", SqlDbType.Int);
            param[21].Value = DeleteOrderHold;
            da.excutequery("Update_UserPermession", param);
            da.close();
        }
        internal DataTable SelectUserAllOrddr(DateTime FromDate, DateTime ToDate, int ID_User)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@fromDte", SqlDbType.DateTime);
            param[0].Value = FromDate;

            param[1] = new SqlParameter("@todate", SqlDbType.DateTime);
            param[1].Value = ToDate;

            param[2] = new SqlParameter("@ID_User", SqlDbType.Int);
            param[2].Value = ID_User;

            dt = da.selected("SelectUserAllOrddr", param);
            da.close();
            return dt;
        }

    }
}
