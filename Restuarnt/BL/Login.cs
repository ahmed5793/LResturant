using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Restuarnt.BL;
using System.Data;
using Restuarnt.DAL;

namespace Restuarnt.BL
{
    class Login
    {
        

            internal DataTable Logins(string id, string pass)
            {
           DataAccessLayer da = new DataAccessLayer();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
                param[0].Value = id;

                param[1] = new SqlParameter("@PASS", SqlDbType.VarChar, 50);
                param[1].Value = pass;
                da.open();
                DataTable dt = new DataTable();
                dt = da.selected("st_login", param);

                return dt;

            }
            internal void AddUser(string id, string pass, string userType, string fullName)
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[0].Value = id;
                param[1] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
                param[1].Value = pass;
                param[2] = new SqlParameter("@userType", SqlDbType.VarChar, 50);
                param[2].Value = userType;
                param[3] = new SqlParameter("@FullName", SqlDbType.NVarChar, 100);
                param[3].Value = fullName;
                da.excutequery("AddUser", param);
                da.close();
            }




            internal DataTable SelectUsers()
            {
                DataAccessLayer da = new DataAccessLayer();

                da.open();
                DataTable dt = new DataTable();
                dt = da.selected("SelectUsers", null);

                return dt;

            }

            internal void UpdateUsers(string id, string pass, string user)
            {

                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                param[0].Value = id;
                param[1] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
                param[1].Value = pass;
                param[2] = new SqlParameter("@userType", SqlDbType.VarChar, 50);
                param[2].Value = user;
                da.excutequery("UpdateUsers", param);
                da.close();
            }

            internal void deleteusers(string id)
            {
                DataAccessLayer da = new DataAccessLayer();
                da.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
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

        }
    }
