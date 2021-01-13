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
       
       
       
       public frm_pay()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
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
                else if (FOrder.getmain.Lable_Num.Text == "")
                {


                    if (FOrder.getmain.gridView2.RowCount > 0)
                    {
                      

                        if (FOrder.getmain.rdb_takeaway.Checked == true)
                        {

                            if (FOrder.getmain.rdb_clientsave.Checked == true)
                            {

                                if (FOrder.getmain.cmb_customer.Text == "" && FOrder.getmain.txt_phones.Text=="" && FOrder.getmain.txt_address.Text == "")
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
                               Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, Convert.ToDecimal(FOrder.getmain.txt_discount.Text)
                               , "Take away", Program.Id_USer, "true");
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
                                if (FOrder.getmain.textEdit1.Text == "" && FOrder.getmain.txt_phones.Text == "" && FOrder.getmain.txt_address.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }

                                if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الجفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                {
                                    cu.AddCustomer(FOrder.getmain.textEdit1.Text, FOrder.getmain.txt_address.Text, FOrder.getmain.txt_phones.Text);
                                    FOrder.getmain.txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                                    dt = o.AddOrder(Convert.ToInt32(FOrder.getmain.txt_cust.Text), Convert.ToDateTime(FOrder.getmain.lable_date.Text), Convert.ToDecimal(FOrder.getmain.txt_delivery.Text), Convert.ToDecimal(FOrder.getmain.txt_invo.Text),
                                   Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0,
                                   Convert.ToDecimal(FOrder.getmain.txt_discount.Text), "Take away", Program.Id_USer, "true");
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

                                if (FOrder.getmain.cmb_customer.Text == "" && FOrder.getmain.txt_phones.Text == "" && FOrder.getmain.txt_address.Text == "")
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
                                Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, Convert.ToDecimal(FOrder.getmain.txt_discount.Text),
                                "Delivery", Program.Id_USer, "true");
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
                                if (FOrder.getmain.textEdit1.Text == "" && FOrder.getmain.txt_phones.Text == "" && FOrder.getmain.txt_address.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }

                                if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الجفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                                {
                                    cu.AddCustomer(FOrder.getmain.textEdit1.Text, FOrder.getmain.txt_address.Text, FOrder.getmain.txt_phones.Text);
                                    FOrder.getmain.txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                                    dt = o.AddOrder(Convert.ToInt32(FOrder.getmain.txt_cust.Text), Convert.ToDateTime(FOrder.getmain.lable_date.Text), Convert.ToDecimal(FOrder.getmain.txt_delivery.Text), Convert.ToDecimal(FOrder.getmain.txt_invo.Text),
                                    Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, 
                                    Convert.ToDecimal(FOrder.getmain.txt_discount.Text), "Delivery", Program.Id_USer, "true");
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

                            if (FOrder.getmain.cmb_stuff.Text=="")
                            {
                                MessageBox.Show("من فضلك قم بااختيار اسم الكابتن  ");
                                return;
                            }

                            if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الحفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {

                                cu.AddCustomerTakeAway(FOrder.getmain.textEdit1.Text);
                                FOrder.getmain.txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();
                                dt = o.AddOrder(Convert.ToInt32(FOrder.getmain.txt_cust.Text), Convert.ToDateTime(FOrder.getmain.lable_date.Text), Convert.ToDecimal(FOrder.getmain.txt_delivery.Text), Convert.ToDecimal(FOrder.getmain.txt_invo.Text),
                                   Convert.ToDecimal(FOrder.getmain.txt_invo.Text), 0, Convert.ToDecimal(FOrder.getmain.txt_discount.Text)
                                   , "Table", Program.Id_USer, "true");
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


                    }
                    else
                    {
                        MessageBox.Show("من فضلك فم بااختيار اصناف الفاتورة اولا");

                    }

                }


                   




                    FOrder.getmain.clear2();
                    this.Close();
                





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);


            }
        }
    }
}