using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Restuarnt.BL;

namespace Restuarnt.PL
{
    public partial class frm_pay : DevExpress.XtraEditors.XtraForm
    {
        Customer cu = new Customer();
      
        Order o = new Order();
        BL.Tables t = new Tables();
        DataTable dt = new DataTable();
       
       
       public frm_pay()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            try
            {

                if (FOrder.getmain.Lable_Num.Text != "")
                {
                    if (MessageBox.Show("هل تريد دفع الفاتورة", "عمليه الدفع", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {


                        o.UpdateOrder(Convert.ToInt32(FOrder.getmain.Lable_Num.Text), Convert.ToDecimal(FOrder.getmain.txt_delivery.Text), Convert.ToDecimal(FOrder.getmain.txt_invo.Text),
                              Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, Convert.ToDecimal(FOrder.getmain.txt_discount.Text));
                        MessageBox.Show("تم دفع الفاتورة بنجاح");




                        t.UpdateTablesInOrder(Convert.ToInt32(FOrder.getmain.cmb_Table.SelectedValue), 0);
                        dt.Clear();
                        dt = o.SELECTOrderRentALLORDER();

                        FOrder.getmain.simpleButton4.Text = $"({dt.Rows.Count}) الفواتير المتعلقة";

                    }

                    else
                    {
                        MessageBox.Show("تم الغاء عمليه الدفع");
                    }
                }
                else
                {


                    if (FOrder.getmain.gridView2.RowCount > 0)
                    {
                        DataTable dt = new DataTable();

                        if (FOrder.getmain.rdb_takeaway.Checked == true)
                        {

                            if (FOrder.getmain.rdb_clientsave.Checked == true)
                            {

                                if (FOrder.getmain.cmb_customer.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }


                                dt = cu.VildateCustomer(Convert.ToInt32(FOrder.getmain.cmb_customer.EditValue), FOrder.getmain.cmb_customer.Text);
                                if (dt.Rows.Count > 0)
                                {

                                    if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الجفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                    {

                                        cu.UpdateCustomer(Convert.ToInt32(FOrder.getmain.cmb_customer.EditValue), FOrder.getmain.txt_address.Text, FOrder.getmain.txt_phones.Text);

                                        dt = o.AddOrder(Convert.ToInt32(FOrder.getmain.cmb_customer.EditValue), Convert.ToDateTime(FOrder.getmain.lable_date.Text), Convert.ToDecimal(FOrder.getmain.txt_delivery.Text), Convert.ToDecimal(FOrder.getmain.txt_invo.Text),
                                     Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, Convert.ToDecimal(FOrder.getmain.txt_discount.Text), " Take away");
                                        FOrder.getmain.Lable_Num.Text = dt.Rows[0][0].ToString();

                                        for (int i = 0; i < FOrder.getmain.gridView2.RowCount; i++)
                                        {
                                            DataRow row = FOrder.getmain.gridView2.GetDataRow(i);
                                            o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                                Convert.ToInt32(row[5]), Convert.ToInt32(FOrder.getmain.Lable_Num.Text),
                                                Convert.ToDecimal(row[6]));


                                        }

                                        MessageBox.Show("تم حفظ وسداد الفاتوره بنجاح", "عمليه الحفظ والسداد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                                        o.AddTakeAway(Convert.ToInt32(FOrder.getmain.Lable_Num.Text));
                                        //dataGridView2.DataSource = o.SELECTOrderRentTkeAway();
                                        //rdb_totalTakeAway.Checked = true;
                                       



                                    }
                                }
                            }


                            else if (FOrder.getmain.rdb_newclient.Checked == true)
                            {


                                //else if (dt.Rows.Count == 0)
                                //{
                                if (FOrder.getmain.textEdit1.Text == "" || FOrder.getmain.txt_phones.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }

                                if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الجفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                {
                                    cu.AddCustomer(FOrder.getmain.textEdit1.Text, FOrder.getmain.txt_address.Text, FOrder.getmain.txt_phones.Text);
                                    FOrder.getmain.txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                                    dt = o.AddOrder(Convert.ToInt32(FOrder.getmain.txt_cust.Text), Convert.ToDateTime(FOrder.getmain.lable_date.Text), Convert.ToDecimal(FOrder.getmain.txt_delivery.Text), Convert.ToDecimal(FOrder.getmain.txt_invo.Text),
                 Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, Convert.ToDecimal(FOrder.getmain.txt_discount.Text), " Take away");
                                    FOrder.getmain.Lable_Num.Text = dt.Rows[0][0].ToString();

                                    for (int i = 0; i < FOrder.getmain.gridView2.RowCount; i++)
                                    {
                                        DataRow row = FOrder.getmain.gridView2.GetDataRow(i);
                                        o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                            Convert.ToInt32(row[5]), Convert.ToInt32(FOrder.getmain.Lable_Num.Text),
                                            Convert.ToDecimal(row[6]));


                                    }
                                    MessageBox.Show("تم حفظ وسداد الفاتوره بنجاح", "عمليه الحفظ والسداد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    o.AddTakeAway(Convert.ToInt32(FOrder.getmain.Lable_Num.Text));
                                    //dataGridView2.DataSource = o.SELECTOrderRentTkeAway();
                                    //rdb_totalTakeAway.Checked = true;
                                   


                                }


                                else
                                {
                                    MessageBox.Show("تم الغاء عمليه الحفظ والسداد");
                                    return;
                                }
                                //}

                                //rdb_TotalDelivery.Checked = true;
                                //dataGridView2.DataSource = o.SELECTOrderRent();
                            }

                        }



                        else if (FOrder.getmain.rdb_delivery.Checked == true)
                        {

                            if (FOrder.getmain.cmb_delivery.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتسجيل اسم الطيار ");
                                return;
                            }




                            if (FOrder.getmain.rdb_clientsave.Checked == true)
                            {

                                if (FOrder.getmain.cmb_customer.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }


                                dt = cu.VildateCustomer(Convert.ToInt32(FOrder.getmain.cmb_customer.EditValue), FOrder.getmain.cmb_customer.Text);
                                if (dt.Rows.Count > 0)
                                {

                                    if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الجفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                    {

                                        cu.UpdateCustomer(Convert.ToInt32(FOrder.getmain.cmb_customer.EditValue), FOrder.getmain.txt_address.Text, FOrder.getmain.txt_phones.Text);

                                        dt = o.AddOrder(Convert.ToInt32(FOrder.getmain.cmb_customer.EditValue), Convert.ToDateTime(FOrder.getmain.lable_date.Text), Convert.ToDecimal(FOrder.getmain.txt_delivery.Text), Convert.ToDecimal(FOrder.getmain.txt_invo.Text),
                                     Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, Convert.ToDecimal(FOrder.getmain.txt_discount.Text), "Delivery");
                                        FOrder.getmain.Lable_Num.Text = dt.Rows[0][0].ToString();

                                        for (int i = 0; i < FOrder.getmain.gridView2.RowCount; i++)
                                        {
                                            DataRow row = FOrder.getmain.gridView2.GetDataRow(i);
                                            o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                                Convert.ToInt32(row[5]), Convert.ToInt32(FOrder.getmain.Lable_Num.Text),
                                                Convert.ToDecimal(row[6]));


                                        }

                                        MessageBox.Show("تم حفظ وسداد الفاتوره بنجاح", "عمليه الحفظ والسداد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                        o.AddDelivery(Convert.ToInt32(FOrder.getmain.Lable_Num.Text), Convert.ToInt32(FOrder.getmain.cmb_delivery.SelectedValue));

                                    



                                    }
                                }
                            }


                            else if (FOrder.getmain.rdb_newclient.Checked == true)
                            {


                                //else if (dt.Rows.Count == 0)
                                //{
                                if (FOrder.getmain.textEdit1.Text == "" || FOrder.getmain.txt_phones.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }

                                if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الجفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                {
                                    cu.AddCustomer(FOrder.getmain.textEdit1.Text, FOrder.getmain.txt_address.Text, FOrder.getmain.txt_phones.Text);
                                    FOrder.getmain.txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                                    dt = o.AddOrder(Convert.ToInt32(FOrder.getmain.txt_cust.Text), Convert.ToDateTime(FOrder.getmain.lable_date.Text), Convert.ToDecimal(FOrder.getmain.txt_delivery.Text), Convert.ToDecimal(FOrder.getmain.txt_invo.Text),
                 Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, Convert.ToDecimal(FOrder.getmain.txt_discount.Text), "Delivery");
                                    FOrder.getmain.Lable_Num.Text = dt.Rows[0][0].ToString();

                                    for (int i = 0; i < FOrder.getmain.gridView2.RowCount; i++)
                                    {
                                        DataRow row = FOrder.getmain.gridView2.GetDataRow(i);
                                        o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                            Convert.ToInt32(row[5]), Convert.ToInt32(FOrder.getmain.Lable_Num.Text),
                                            Convert.ToDecimal(row[6]));


                                    }
                                    MessageBox.Show("تم حفظ وسداد الفاتوره بنجاح", "عمليه الحفظ والسداد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    o.AddDelivery(Convert.ToInt32(FOrder.getmain.Lable_Num.Text), Convert.ToInt32(FOrder.getmain.cmb_delivery.SelectedValue));
                                 

                                }


                                else
                                {
                                    MessageBox.Show("تم الغاء عمليه الحفظ والسداد");
                                    return;
                                }
                                
                            }

                        }



                        else if (FOrder.getmain.rdb_sala.Checked == true)
                        {
                            FOrder.getmain.textEdit1.Text = "عميل نقدى";
                            if (FOrder.getmain.cmb_Table.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتسجيل رقم الطاولة ");
                                return;
                            }

                            if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الحفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {

                                cu.AddCustomerTakeAway(FOrder.getmain.textEdit1.Text);
                                FOrder.getmain.txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();
                                dt = o.AddOrder(Convert.ToInt32(FOrder.getmain.txt_cust.Text), Convert.ToDateTime(FOrder.getmain.lable_date.Text), Convert.ToDecimal(FOrder.getmain.txt_delivery.Text), Convert.ToDecimal(FOrder.getmain.txt_invo.Text),
                                   Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, Convert.ToDecimal(FOrder.getmain.txt_discount.Text), "Table");
                                FOrder.getmain.Lable_Num.Text = dt.Rows[0][0].ToString();
                                for (int i = 0; i < FOrder.getmain.gridView2.RowCount; i++)
                                {
                                    DataRow row = FOrder.getmain.gridView2.GetDataRow(i);
                                    o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                        Convert.ToInt32(row[5]), Convert.ToInt32(FOrder.getmain.Lable_Num.Text),
                                        Convert.ToDecimal(row[6]));


                                }


                                MessageBox.Show("تم حفظ وسداد الفاتوره بنجاح", "عمليه الحفظ والسداد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                                o.AddSala(Convert.ToInt32(FOrder.getmain.Lable_Num.Text), Convert.ToInt32(FOrder.getmain.cmb_Table.SelectedValue),
                                    Convert.ToInt32(FOrder.getmain.cmb_stuff.SelectedValue));
                             


                            }

                            else
                            {
                                MessageBox.Show("تم الغاء عمليه الحفظ والسداد");

                            }

                        }





                        else
                        {
                            MessageBox.Show("من فضلك فم بااختيار اصناف الفاتورة اولا");

                        }


                 
                    }
                    dt.Clear();
                    dt = o.SELECTOrderRentALLORDER();

                    FOrder.getmain.simpleButton4.Text = $"({dt.Rows.Count}) الفواتير المتعلقة";
                }



                if (FOrder.getmain.Lable_Num.Text != string.Empty)
                {


                    if (FOrder.getmain.rdb_delivery.Checked == true)
                    {
                        RPT.rptOrders ro = new RPT.rptOrders();
                        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                        s.crystalReportViewer1.RefreshReport();
                        ro.SetDatabaseLogon("", "", ".", "Restuarnt");
                        ro.SetParameterValue("@ID", (Convert.ToInt32(FOrder.getmain.Lable_Num.Text)));
                        s.crystalReportViewer1.ReportSource = ro;
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        ro.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                        ro.PrintToPrinter(1, true, 0, 0);

                        ro.Close();
                        s.Dispose();
                        //GC.Collect();
                        //GC.WaitForPendingFinalizers();


                    }
                    else if (FOrder.getmain.rdb_sala.Checked == true)
                    {
                        RPT.rptOrderSala rs = new RPT.rptOrderSala();
                        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                        s.crystalReportViewer1.RefreshReport();
                        rs.SetDatabaseLogon("", "", ".", "Restuarnt");
                        rs.SetParameterValue("@ID", (Convert.ToInt32(FOrder.getmain.Lable_Num.Text)));
                        s.crystalReportViewer1.ReportSource = rs;
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rs.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                        rs.PrintToPrinter(1, true, 0, 0);

                        rs.Close();
                        s.Dispose();
                        //GC.Collect();
                        //GC.WaitForPendingFinalizers();
                    }
                    else if (FOrder.getmain.rdb_takeaway.Checked == true)
                    {

                        RPT.rptOrderTakeAway rt = new RPT.rptOrderTakeAway();
                        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                        s.crystalReportViewer1.RefreshReport();
                        rt.SetDatabaseLogon("", "", ".", "Restuarnt");
                        rt.SetParameterValue("@ID", (Convert.ToInt32(FOrder.getmain.Lable_Num.Text)));
                        s.crystalReportViewer1.ReportSource = rt;
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                        rt.PrintToPrinter(1, true, 0, 0);

                        rt.Close();
                        s.Dispose();
                        //GC.Collect();
                        //GC.WaitForPendingFinalizers();

                    }

                    if (FOrder.getmain.rdb_delivery.Checked == true)
                    {
                        RPT.rptCheckenDeliveryMakolat ro = new RPT.rptCheckenDeliveryMakolat();
                        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                        s.crystalReportViewer1.RefreshReport();
                        ro.SetDatabaseLogon("", "", ".", "Restuarnt");
                        ro.SetParameterValue("@ID", (Convert.ToInt32(FOrder.getmain.Lable_Num.Text)));
                        if (ro.Rows.Count > 0)
                        {

                            s.crystalReportViewer1.ReportSource = ro;
                            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                            ro.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                            ro.PrintToPrinter(1, true, 0, 0);

                            ro.Close();
                            s.Dispose();
                        }

                        RPT.rptCheckenDelivery deldrinks = new RPT.rptCheckenDelivery();
                        RPT.Frm_ReportOrder sa = new RPT.Frm_ReportOrder();

                        sa.crystalReportViewer1.RefreshReport();
                        deldrinks.SetDatabaseLogon("", "", ".", "Restuarnt");
                        deldrinks.SetParameterValue("@ID", (Convert.ToInt32(FOrder.getmain.Lable_Num.Text)));
                        if (deldrinks.Rows.Count > 0)
                        {


                            sa.crystalReportViewer1.ReportSource = deldrinks;
                            System.Drawing.Printing.PrintDocument printDocuments = new System.Drawing.Printing.PrintDocument();
                            deldrinks.PrintOptions.PrinterName = printDocuments.PrinterSettings.PrinterName;
                            deldrinks.PrintToPrinter(1, true, 0, 0);

                            deldrinks.Close();
                            sa.Dispose();
                        }
                        //GC.Collect();
                        //GC.WaitForPendingFinalizers();
                    }
                    else if (FOrder.getmain.rdb_sala.Checked == true)
                    {
                        RPT.rptCheckenSalaMakolat rs = new RPT.rptCheckenSalaMakolat();
                        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                        s.crystalReportViewer1.RefreshReport();
                        rs.SetDatabaseLogon("", "", ".", "Restuarnt");
                        rs.SetParameterValue("@ID", (Convert.ToInt32(FOrder.getmain.Lable_Num.Text)));
                        if (rs.Rows.Count > 0)
                        {


                            s.crystalReportViewer1.ReportSource = rs;
                            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                            rs.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                            rs.PrintToPrinter(1, true, 0, 0);

                            rs.Close();
                            s.Dispose();
                        }


                        RPT.rptCheckenSala sala = new RPT.rptCheckenSala();
                        RPT.Frm_ReportOrder sa = new RPT.Frm_ReportOrder();

                        sa.crystalReportViewer1.RefreshReport();
                        sala.SetDatabaseLogon("", "", ".", "Restuarnt");
                        sala.SetParameterValue("@ID", (Convert.ToInt32(FOrder.getmain.Lable_Num.Text)));
                        if (sala.Rows.Count > 0)
                        {


                            sa.crystalReportViewer1.ReportSource = sala;
                            System.Drawing.Printing.PrintDocument printDocumentsala = new System.Drawing.Printing.PrintDocument();
                            sala.PrintOptions.PrinterName = printDocumentsala.PrinterSettings.PrinterName;
                            sala.PrintToPrinter(1, true, 0, 0);

                            sala.Close();
                            sa.Dispose();
                        }
                        //GC.Collect();
                        //GC.WaitForPendingFinalizers();
                    }
                    else if (FOrder.getmain.rdb_takeaway.Checked == true)
                    {
                        RPT.rptChekenTakeAway rt = new RPT.rptChekenTakeAway();
                        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();


                        s.crystalReportViewer1.RefreshReport();
                        rt.SetDatabaseLogon("", "", ".", "Restuarnt");
                        rt.SetParameterValue("@ID", (Convert.ToInt32(FOrder.getmain.Lable_Num.Text)));
                        if (rt.Rows.Count > 0)
                        {


                            s.crystalReportViewer1.ReportSource = rt;
                            System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                            rt.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                            rt.PrintToPrinter(1, true, 0, 0);
                            rt.Close();
                            s.Dispose();
                        }

                        RPT.rptChekenTakeAwayDrinks rtake = new RPT.rptChekenTakeAwayDrinks();
                        RPT.Frm_ReportOrder stake = new RPT.Frm_ReportOrder();


                        stake.crystalReportViewer1.RefreshReport();
                        rtake.SetDatabaseLogon("", "", ".", "Restuarnt");
                        rtake.SetParameterValue("@ID", (Convert.ToInt32(FOrder.getmain.Lable_Num.Text)));
                        if (rtake.Rows.Count > 0)
                        {
                            stake.crystalReportViewer1.ReportSource = rtake;
                            System.Drawing.Printing.PrintDocument printDocumenttake = new System.Drawing.Printing.PrintDocument();
                            rtake.PrintOptions.PrinterName = printDocumenttake.PrinterSettings.PrinterName;
                            rtake.PrintToPrinter(1, true, 0, 0);
                            rtake.Close();
                            stake.Dispose();
                        }



                    }



                    FOrder.getmain.clear2();
                    this.Close();
                }
            }





            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }
    }
}