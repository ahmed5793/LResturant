using System;
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

namespace Restuarnt.RPT.Exstra_Report
{
    public partial class XtraReportCheck : DevExpress.XtraReports.UI.XtraReport
    {
        //FOrder fo = new FOrder();
        //Order o = new Order();
        //SettingPrint sp = new SettingPrint();
        //DataTable dt = new DataTable();
        
        public XtraReportCheck()
        {
            
            InitializeComponent();
          //dt= sp.SelectSettingPrintOrder();
          //  if (dt.Rows.Count>0)
          //  {

          //      Txt_CompanyName.Text = dt.Rows[0][0].ToString();
          //      TxtMessage.Text = dt.Rows[0][2].ToString();
          //      Txt_Delivery.Text = dt.Rows[0][3].ToString();
          //  }

                            
        }

    }
}
