using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Restuarnt.BL;
using Restuarnt.RPT;
using Restuarnt.RPT.Exstra_Report;

namespace Restuarnt.PL
{
    public partial class Frm_ManagmentOrder : Form
    {
        Order o = new Order();
        public Frm_ManagmentOrder()
        {
            InitializeComponent();
            btn_report.Hide();
            dataGridViewList.DataSource = o.SelectMangmentOrders();
            decimal total = 0;
            for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[3].Value);

            }
            txt_rent.Text = Math.Round(total, 2).ToString();


        }

        private void TextBox3_Validated(object sender, EventArgs e)
        {
           
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

          
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
           
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sala.Checked == true)
            {
                button3.Show();
                btn_PrintOrder.Show();
                btn_report.Hide();
                dataGridViewList.DataSource = o.SELECTManagmentOrderSala();
                decimal total = 0;
                for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[4].Value);

                }
                txt_rent.Text = Math.Round(total, 2).ToString();
            }
        }

        private void Rdb_date_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_orders.Checked==true)
            {
                button3.Hide();
                btn_report.Hide();
                btn_PrintOrder.Hide();
                dataGridViewList.DataSource = o.SelectMangmentOrders();
                decimal total = 0;
                for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[3].Value);

                }
                txt_rent.Text = Math.Round(total, 2).ToString();
            }
        }

        private void Rdb_takeaway_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_takeaway.Checked == true)
            {
                button3.Show();
                btn_PrintOrder.Show();
                btn_report.Hide();
                dataGridViewList.DataSource = o.SELECTManagmentOrderTakwAway();
                decimal total = 0;
                for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[4].Value);

                }
                txt_rent.Text = Math.Round(total, 2).ToString();
            }
        }

        private void Rdb_delivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_delivery.Checked == true)
            {
                button3.Show();
                btn_PrintOrder.Show();
                btn_report.Hide();
                dataGridViewList.DataSource = o.SELECManamentTOrderDelivery();
                decimal total = 0;
                for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[4].Value);

                }
                txt_rent.Text = Math.Round(total, 2).ToString();
            }
        }

        private void Frm_ManagmentOrder_Load(object sender, EventArgs e)
        {
            button3.Hide();
            btn_PrintOrder.Hide();
            FromDate.Text = DateTime.Now.ToString();
            ToDate.Text = DateTime.Now.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          

            

            DataTable dt = new DataTable();
                if (Rdb_orders.Checked == true)
                {
                    btn_PrintOrder.Hide();
                    btn_report.Show();
                    dt = o.SearchMangmentOrders(FromDate.Value, ToDate.Value);
                    dataGridViewList.DataSource = dt;

                    decimal total = 0;
                    for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[3].Value);

                    }
                    txt_rent.Text = Math.Round(total, 2).ToString();
                }
                else if (rdb_delivery.Checked == true)
                {
                    btn_report.Hide();
                    btn_PrintOrder.Show();
                    dt = o.SearchManamentTOrderDelivery(FromDate.Value, ToDate.Value);
                    dataGridViewList.DataSource = dt;

                    decimal total = 0;
                    for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[4].Value);

                    }
                    txt_rent.Text = Math.Round(total, 2).ToString();

                }
                else if (rdb_sala.Checked == true)
                {
                    btn_report.Hide();
                    btn_PrintOrder.Show();
                    dt = o.SearchManagmentOrderSala(FromDate.Value, ToDate.Value);
                    dataGridViewList.DataSource = dt;

                    decimal total = 0;
                    for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[4].Value);

                    }
                    txt_rent.Text = Math.Round(total, 2).ToString();
                }
                else if (rdb_takeaway.Checked == true)
                {
                    btn_report.Hide();
                    btn_PrintOrder.Show();
                    dt = o.SearchManagmentOrderTakwAway(FromDate.Value, ToDate.Value);
                    dataGridViewList.DataSource = dt;

                    decimal total = 0;
                    for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
                    {
                        total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[4].Value);

                    }
                    txt_rent.Text = Math.Round(total, 2).ToString();

                }
            
           
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (dataGridViewList.Rows.Count > 0)
            {
                if (Rdb_orders.Checked == true)
            {

               

                    RPT.rptTotalDay ro = new RPT.rptTotalDay();
                    RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                    s.crystalReportViewer1.RefreshReport();
                    ro.SetDatabaseLogon("", "", ".", "Restuarnt");
                    ro.SetParameterValue("@FromDate", FromDate.Value);
                    ro.SetParameterValue("@ToDate", ToDate.Value);
                    ro.SetParameterValue("@total", txt_rent.Text);
                    s.crystalReportViewer1.ReportSource = ro;

                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    ro.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                    ro.PrintToPrinter(1, true, 0, 0);
                    ro.Close();
                    s.Dispose();
                }
               
            }
            else
            {
                MessageBox.Show("لايوجد بيانات للطباعه ");
            }
        }

        private void Btn_PrintOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewList.Rows.Count > 0)
                {
                    //if (rdb_delivery.Checked == true)
                    //{
                    //    RPT.rptOrders ro = new RPT.rptOrders();
                    //    RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                    //    s.crystalReportViewer1.RefreshReport();
                    //    ro.SetDatabaseLogon("", "", ".", "Restuarnt");
                    //    ro.SetParameterValue("@ID", (Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value)));
                    //    s.crystalReportViewer1.ReportSource = ro;
                    //    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //    ro.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                    //    ro.PrintToPrinter(1, true, 0, 0);

                    //    ro.Close();
                    //    s.Dispose();

                    //}
                    //else if (rdb_sala.Checked == true)
                    //{
                    //    RPT.rptOrderSala rs = new RPT.rptOrderSala();
                    //    RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                    //    s.crystalReportViewer1.RefreshReport();
                    //    rs.SetDatabaseLogon("", "", ".", "Restuarnt");
                    //    rs.SetParameterValue("@ID", (Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value)));
                    //    s.crystalReportViewer1.ReportSource = rs;
                    //    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //    rs.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                    //    rs.PrintToPrinter(1, true, 0, 0);
                    //    rs.Close();
                    //    s.Dispose();
                    //}
                    //else if (rdb_takeaway.Checked == true)
                    //{
                    //    RPT.rptOrderTakeAway rt = new RPT.rptOrderTakeAway();
                    //    RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                    //    s.crystalReportViewer1.RefreshReport();
                    //    rt.SetDatabaseLogon("", "", ".", "Restuarnt");
                    //    rt.SetParameterValue("@ID", (Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value)));
                    //    s.crystalReportViewer1.ReportSource = rt;
                    //    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //    rt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                    //    rt.PrintToPrinter(1, true, 0, 0);
                    //    rt.Close();

                    //    s.Dispose();
                    //}
                    DataTable dt5 = new DataTable();
                    XtraReport1Order ro = new XtraReport1Order();
                    DataSet1 ds = new DataSet1();

                    if (dt5.Rows[0][11].ToString() == "Delivery")
                    {
                        dt5.Clear();
                        dt5 = o.PrintOrderSala(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value));
                        ro.xrLabel11.Visible = true;
                        ro.xrLabel10.Visible = true;
                        ro.xrLabel18.Visible = true;
                        ro.xrLabel19.Visible = true;
                        ro.xrLabel19.Text = dt5.Rows[0][1].ToString();
                    }

                    if (dt5.Rows[0][11].ToString() == "Table")
                    {
                        dt5.Clear();
                        dt5 = o.Select_DeliveyMan(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value));
                        ro.xrLabel20.Visible = true;
                        ro.xrLabel21.Visible = true;
                        ro.xrLabel21.Text = dt5.Rows[0][1].ToString();
                    }
                    dt5.Clear();
                    dt5 = o.PrintOrder(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value));

                    ds.Tables["Order"].Clear();
                    for (int i = 0; i < dt5.Rows.Count; i++)
                    {
                        ds.Tables["Order"].Rows.Add(dt5.Rows[i][0], dt5.Rows[i][1], dt5.Rows[i][4],
                        dt5.Rows[i][5], dt5.Rows[i][7], dt5.Rows[i][6], dt5.Rows[i][9], dt5.Rows[i][8],
                        dt5.Rows[i][2], (dt5.Rows[i][3]), dt5.Rows[i][11], dt5.Rows[i][10], dt5.Rows[i][12]);
                    }
                    ro.Txt_Delivery.Visible = true;
                    ro.DataSource = ds;
                    ro.Parameters["Id"].Value = Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value);
                    ro.Parameters["Id"].Visible = false;
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                    // ro.PrinterName = Properties.Settings.Default.PrinterName;
                    ro.Print();


                    DataTable dt6 = new DataTable();
                    XtraReportCheck rc = new XtraReportCheck();
                    DataSet1 ds1 = new DataSet1();
                    dt6.Clear();
                    dt6 = o.PrintOrder(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value));


                    ds.Tables["Order"].Clear();
                    for (int i = 0; i < dt6.Rows.Count; i++)
                    {
                        ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                        dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                        dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                    }
                    rc.DataSource = ds;
                    rc.Parameters["Id"].Value = Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value);
                    rc.Parameters["Id"].Visible = false;
                    //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                    // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                    rc.PrinterName = Properties.Settings.Default.PrinterName;
                    rc.Print();
                }
                else
                {
                    MessageBox.Show("لايوجد بيانات للطباعه");
                }

            
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewList.Rows.Count > 0)
                {


                    if (MessageBox.Show("هل تريد مسح فواتير البرنامج كلها ", "مسح الفواتير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        o.deleteAllOrder();
                        MessageBox.Show("تم مسح الفواتير بنجاح ", "",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        dataGridViewList.DataSource = o.SelectMangmentOrders();
                        decimal total = 0;
                        for (int i = 0; i <= dataGridViewList.Rows.Count - 1; i++)
                        {
                            total += Convert.ToDecimal(dataGridViewList.Rows[i].Cells[3].Value);

                        }
                        txt_rent.Text = Math.Round(total, 2).ToString();

                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عملية المسح");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                //if (dataGridViewList.Rows.Count > 0)
                //{
                //    if (rdb_delivery.Checked == true)
                //    {
                //        RPT.rptOrders ro = new RPT.rptOrders();
                //        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                //        s.crystalReportViewer1.RefreshReport();
                //        ro.SetDatabaseLogon("", "", ".", "Restuarnt");
                //        ro.SetParameterValue("@ID", (Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value)));
                //        s.crystalReportViewer1.ReportSource = ro;
                //        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //        ro.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //       // ro.PrintToPrinter(1, true, 0, 0);
                //        s.ShowDialog();
                //        ro.Close();
                //        s.Dispose();

                //    }
                //    else if (rdb_sala.Checked == true)
                //    {
                //        RPT.rptOrderSala rs = new RPT.rptOrderSala();
                //        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                //        s.crystalReportViewer1.RefreshReport();
                //        rs.SetDatabaseLogon("", "", ".", "Restuarnt");
                //        rs.SetParameterValue("@ID", (Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value)));
                //        s.crystalReportViewer1.ReportSource = rs;
                //        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //        rs.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //      //  rs.PrintToPrinter(1, true, 0, 0);
                //        s.ShowDialog();
                //        rs.Close();
                //        s.Dispose();
                //    }
                //    else if (rdb_takeaway.Checked == true)
                //    {
                //        RPT.rptOrderTakeAway rt = new RPT.rptOrderTakeAway();
                //        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                //        s.crystalReportViewer1.RefreshReport();
                //        rt.SetDatabaseLogon("", "", ".", "Restuarnt");
                //        rt.SetParameterValue("@ID", (Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value)));
                //        s.crystalReportViewer1.ReportSource = rt;
                //        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //        rt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                //      //  rt.PrintToPrinter(1, true, 0, 0);
                //        s.ShowDialog();
                //        rt.Close();

                //        s.Dispose();
                //    }


                //}
                //else
                //{
                //    MessageBox.Show("لايوجد بيانات للطباعه");
                //}

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    }
