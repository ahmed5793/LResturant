﻿using System;
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
    class Customer
    {
        internal DataTable AddCustomer(string name, string address, string phone)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;
            param[1] = new SqlParameter("@Adsress", SqlDbType.NVarChar, 250);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 100);
            param[2].Value = phone;


          dt=  da.selected("AddCustomer", param);
            da.close();
            return dt;
        }
        internal void UpdateCustomer(int id, string address, string phone,string Name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Adsress", SqlDbType.NVarChar, 250);
            param[1].Value = address;
            param[2] = new SqlParameter("@phone", SqlDbType.VarChar, 100);
            param[2].Value = phone;
            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[3].Value = Name;

            da.excutequery("UpdateCustomer", param);
            da.close();
        }
        internal DataTable AddCustomerTakeAway(string name)
        {
            DataTable dt = new DataTable();
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;
     


           dt= da.selected("AddCustomerTakeAway", param);
            da.close();
            return dt;
        }

        internal DataTable VildateCustomer(int id,string @Phone)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Phone", SqlDbType.VarChar,50);
            param[1].Value = Phone;


            dt = da.selected("VildateCustomer", param);
            da.close();
            return dt;
        }
        internal DataTable SelectCompoCustomer()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
     

            dt = da.selected("SelectCompoCustomer", null);
            da.close();
            return dt;
        }
        internal DataTable LastIdCustomer()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();


            dt = da.selected("LastIdCustomer", null);
            da.close();
            return dt;
        }
        internal DataTable SelectPhoneAdress(int id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = da.selected("SelectPhoneAdress", param);
            da.close();
            return dt;
        }
        internal DataTable SEARCHClientPhone(string id)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@phone", SqlDbType.VarChar, 100);
            param[0].Value = id;



            dt = da.selected("SEARCHClientPhone", param);
            da.close();
            return dt;
        }
        internal DataTable SlectClientPhone()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();


            dt = da.selected("SlectClientPhone", null);
            da.close();
            return dt;
        }
    }
}


