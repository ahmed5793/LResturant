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
using Restuarnt.RPT.Exstra_Report;
namespace Restuarnt.PL
{
    public partial class Sales_Management : Form
    {

        Order o = new Order();


        public Sales_Management()
        {
            InitializeComponent();
            selectUser();


        } 
        void selectUser()
        {
            try
            {

            //cmb_Users1.DataSource = l.SelectUsers();
            //cmb_Users1.DisplayMember = "اسم المستخدم";
            //cmb_Users1.ValueMember = "اسم المستخدم";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void cmb_Users1_SelectionChangeCommitted(object sender, EventArgs e)
        {          
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }


        private void Validate_Users_Load(object sender, EventArgs e)
        {
           
        }



        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {


                DataTable dt = new DataTable();
                if (Rdb_orders.Checked == true)
                {
                    //btn_PrintOrder.Hide();
                    //btn_report.Show();
                    dt = o.SearchMangmentOrders(FromDate.Value, ToDate.Value);
                    gridControl1.DataSource = dt;


                }
                else if (rdb_delivery.Checked == true)
                {
                
                    dt = o.SearchManamentTOrderDelivery(FromDate.Value, ToDate.Value);
                    gridControl1.DataSource = dt;

                   
                }
                else if (rdb_sala.Checked == true)
                {
                   
                    dt = o.SearchManagmentOrderSala(FromDate.Value, ToDate.Value);
                    gridControl1.DataSource = dt;

                }
                else if (rdb_takeaway.Checked == true)
                {                 
                    dt = o.SearchManagmentOrderTakwAway(FromDate.Value, ToDate.Value);
                    gridControl1.DataSource = dt;                   
                }
                decimal total = 0;
                for (int i = 0; i < gridView1.RowCount - 1; i++)
                {
                    DataRow r = gridView1.GetDataRow(i);
                    total += Convert.ToDecimal(r[3]);
                }
                txt_rent.Text = Math.Round(total, 1).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
        }

        private void Cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {

          
        }

        private void cmb_Users1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void Rdb_orders_CheckedChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            txt_rent.Text = "0.0";
        }

        private void rdb_delivery_CheckedChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            txt_rent.Text = "0.0";
        }

        private void rdb_sala_CheckedChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            txt_rent.Text = "0.0";
        }

        private void rdb_takeaway_CheckedChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            txt_rent.Text = "0.0";
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                gridView1.ShowRibbonPrintPreview();
            }
            else
            {
                MessageBox.Show("لا يوجد داتا لطباعة التقرير");
            }
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                   
                    DataTable dt5 = new DataTable();
                    XtraReport1Order ro = new XtraReport1Order();
                    DataSet1 ds = new DataSet1();
                    dt5.Clear();
                    dt5 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (dt5.Rows[0][11].ToString() == "Delivery")
                    {
                        dt5.Clear();
                        dt5 = o.Select_DeliveyMan(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        ro.xrLabel11.Visible = true;
                        ro.xrLabel10.Visible = true;
                        ro.xrLabel18.Visible = true;
                        ro.xrLabel19.Visible = true;
                        ro.xrLabel19.Text = dt5.Rows[0][1].ToString();
                    }

                    if (dt5.Rows[0][11].ToString() == "Table")
                    {

                        dt5.Clear();
                        dt5 = o.PrintOrderSala(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        ro.xrLabel20.Visible = true;
                        ro.xrLabel21.Visible = true;
                        ro.xrLabel21.Text = dt5.Rows[0][1].ToString();
                    }
                    dt5.Clear();
                    dt5 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                   
                    ds.Tables["Order"].Clear();
                    for (int i = 0; i < dt5.Rows.Count; i++)
                    {
                        ds.Tables["Order"].Rows.Add(dt5.Rows[i][0], dt5.Rows[i][1], dt5.Rows[i][4],
                        dt5.Rows[i][5], dt5.Rows[i][7], dt5.Rows[i][6], dt5.Rows[i][9], dt5.Rows[i][8],
                        dt5.Rows[i][2], (dt5.Rows[i][3]), dt5.Rows[i][11], dt5.Rows[i][10], dt5.Rows[i][12]);
                    }
                    ro.Txt_Delivery.Visible = true;
                    ro.DataSource = ds;
                    ro.Parameters["Id"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة"));
                    ro.Parameters["Id"].Visible = false;
                    System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                    // ro.PrinterName = Properties.Settings.Default.PrinterName;
                    ro.Print();

                    //كود طباعة امر التشغيل للمطبخ//////////////

                    DataTable dt6 = new DataTable();
                    XtraReportCheck rc = new XtraReportCheck();
                    DataSet1 ds1 = new DataSet1();
                    dt6.Clear();
                    dt6 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (dt5.Rows[0][11].ToString() == "Table")
                    {
                        dt6.Clear();

                        dt6 = o.PrintOrderSala(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        rc.Label_TableNum.Visible = true;
                        rc.Txt_TableNum.Visible = true;
                        rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                    }

                    dt6.Clear();
                    dt6 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    ds.Tables["Order"].Clear();
                    for (int i = 0; i < dt6.Rows.Count; i++)
                    {
                        ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                        dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                        dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                    }
                    rc.DataSource = ds;
                    rc.Parameters["Id"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة"));
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
    }
}
