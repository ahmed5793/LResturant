﻿using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.SqlClient;
using Restuarnt.DAL;
using Restuarnt.BL;
using Restuarnt.PL;
using DevExpress.ClipboardSource.SpreadsheetML;
using Restuarnt.Bl;
using System.IO;

namespace Restuarnt.RPT.Exstra_Report
{
    public partial class XtraReport1Order : DevExpress.XtraReports.UI.XtraReport
    {
      
        SettingPrint sp = new SettingPrint();
        DataTable dt = new DataTable();
        
        public XtraReport1Order()
        {
            
            InitializeComponent();
            dt.Clear();
            dt= sp.SelectSettingPrintOrder();
            if (dt.Rows.Count>0)
            {
                byte[] image = (byte[])dt.Rows[0][0];
                MemoryStream f = new MemoryStream(image);
                xrPictureBox1.Image = Image.FromStream(f);

                xrLabel10.Text = dt.Rows[0][1].ToString();
                TxtMessage.Text = dt.Rows[0][2].ToString();
                Txt_Delivery.Text = dt.Rows[0][3].ToString();
            }

            //if (fo.rdb_delivery.Checked==true)
            //{
            //    xrLabel10.Visible = true;
            //    xrLabel11.Visible = true;
            //}
            
                
        }

        private void xrTableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
