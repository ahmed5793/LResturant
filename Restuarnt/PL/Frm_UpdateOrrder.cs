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
  
    public partial class Frm_UpdateOrrder : DevExpress.XtraEditors.XtraForm
    {
        Order o = new Order();
        public Frm_UpdateOrrder()
        {
            InitializeComponent();
            gridControl2.DataSource = o.SELECtALLORDER(DateTime.Now.Date,DateTime.Now.Date);

        }

        private void Frm_UpdateOrrder_Load(object sender, EventArgs e)
        {
           
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = o.SELECtALLORDER(Convert.ToDateTime(FromDate.EditValue),Convert.ToDateTime(ToDate.EditValue));
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            FOrder fo = new FOrder();
            if (e.Column.Name== "Update")
            {
                fo.ShowDialog();
                DataTable dt2 = new DataTable();
                DataTable dt5 = new DataTable();

                

                if (gridView2.RowCount > 0)
                {


                   


                    if (gridView2.GetFocusedRowCellValue("نوع الطلب").ToString() == "Delivery")
                    {

                        FOrder.getmain.rdb_delivery.Checked = true;
                        //cmb_customer.Hide();
                        //textEdit1.Show();

                        //textEdit1.Enabled = false;
                        //rdb_clientsave.Enabled = false;
                        //rdb_newclient.Enabled = false;


                        //txt_phones.Enabled = false;
                        //txt_address.Enabled = false;
                        FOrder.getmain.grb_customer.Show();
                        FOrder.getmain.grb_delivry.Show();
                        FOrder.getmain.grb_customer.Enabled = false;
                        dt2.Clear();
                        dt2 = o.SELECTOrderDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));

                        FOrder.getmain.gridControl2.DataSource = dt2;

                        FOrder.getmain.ID_Dep.Visible = false;
                        FOrder.getmain.Dep.Visible = false;
                        FOrder.getmain.ID_Items.Visible = false;


                        dt5.Clear();
                        dt5 = o.SELECTOrder(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));

                        foreach (DataRow dr in dt5.Rows)
                        {




                            FOrder.getmain.Lable_Num.Text = dr[0].ToString();
                            FOrder.getmain.txt_cust.Text = dr[1].ToString();
                            FOrder.getmain.textEdit1.Text = dr[2].ToString();
                            FOrder.getmain.txt_phones.Text = dr[3].ToString();
                            FOrder.getmain.txt_address.Text = dr[4].ToString();
                            FOrder.getmain.timer1.Enabled = false;
                            FOrder.getmain.lable_date.Text = dr[5].ToString();

                            FOrder.getmain.texT.Text = dr[6].ToString();

                            FOrder.getmain.cmb_delivery.Text = dr[9].ToString();
                            FOrder.getmain.txt_delivery.Text = dr[10].ToString();
                            FOrder.getmain.txt_discount.Text = dr[11].ToString();



                        }









                    }
                    else if (gridView2.GetFocusedRowCellValue("نوع الطلب").ToString() == "Table")
                    {


                        //  rdb_delivery.Enabled = false;
                        //    cmb_delivery.Enabled = false;
                        //   txt_delivery.Enabled = false;
                        //  txt_phones.Enabled = false;
                        //  textEdit1.Enabled = false;
                        FOrder.getmain.rdb_sala.Enabled = true;
                        //textEdit1.Enabled = false;
                        FOrder.getmain.rdb_sala.Checked = true;
                        //  cmb_Table.Enabled = false;
                        FOrder.getmain.grb_sala.Show();
                        FOrder.getmain.grb_sala.Enabled = false;

                        dt2.Clear();
                        dt2 = o.SELECTOrderDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));

                        FOrder.getmain.gridControl2.DataSource = dt2;
                        FOrder.getmain.ID_Items.Visible = false;
                        FOrder.getmain.Dep.Visible = false;
                        FOrder.getmain.ID_Items.Visible = false;

                        dt5.Clear();
                        dt5 = o.SELECTOrderSala(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));
                        foreach (DataRow dr in dt5.Rows)
                        {



                            FOrder.getmain.Lable_Num.Text = dr[0].ToString();
                            FOrder.getmain.txt_cust.Text = dr[1].ToString();
                            FOrder.getmain.textEdit1.Text = dr[2].ToString();

                            FOrder.getmain.timer1.Enabled = false;
                            FOrder.getmain.lable_date.Text = dr[3].ToString();


                            FOrder.getmain.texT.Text = dr[4].ToString();
                            //txt_pay.Text = dr[5].ToString();
                            //txt_mark.Text = dr[6].ToString();
                            // cmb_Table.Text = dr[7].ToString();
                            FOrder.getmain.cmb_Table.Text = dr[7].ToString();
                            FOrder.getmain.txt_discount.Text = dr[8].ToString();
                            FOrder.getmain.cmb_stuff.Text = dr[9].ToString();
                        }






                    }
                    else if (gridView2.GetFocusedRowCellValue("نوع الطلب").ToString() == "Take away")
                    {
                        //   rdb_delivery.Enabled = false;
                        FOrder.getmain.rdb_takeaway.Checked = true;
                        FOrder.getmain.rdb_takeaway.Enabled = true;
                        // txt_phones.Enabled = false;
                        // textEdit1.Enabled = false;
                        //   cmb_customer.Hide();
                        //  textEdit1.Show();
                        //textEdit1.Enabled = false;
                        FOrder.getmain.grb_customer.Show();
                        FOrder.getmain.grb_delivry.Hide();
                        FOrder.getmain.grb_customer.Enabled = false;

                        dt2.Clear();
                        dt2 = o.SELECTOrderDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));
                        FOrder.getmain.gridControl2.DataSource = dt2;
                        FOrder.getmain.ID_Items.Visible = false;
                        FOrder.getmain.Dep.Visible = false;
                        FOrder.getmain.ID_Items.Visible = false;
                        dt5.Clear();
                        dt5 = o.SELECTOrderTakwAway(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));

                        foreach (DataRow dr in dt5.Rows)
                        {



                            FOrder.getmain.Lable_Num.Text = dr[0].ToString();
                            FOrder.getmain.txt_cust.Text = dr[1].ToString();
                            FOrder.getmain.textEdit1.Text = dr[2].ToString();

                            FOrder.getmain.timer1.Enabled = false;
                            FOrder.getmain.lable_date.Text = dr[3].ToString();

                            FOrder.getmain.texT.Text = dr[4].ToString();

                            FOrder.getmain.txt_discount.Text = dr[7].ToString();


                        }

                    }
                    FOrder.getmain.totalInvoice();
                    FOrder.getmain.TOTALFINALYDELIVERY();
                    FOrder.getmain.TOTALFINALYDISCOUNT();
                }


            }
            else if(e.Column.Name == "Delete")
            {
               if( XtraMessageBox.Show("هل تريد حذف الفاتورة ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    o.DeleteOrder(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));
                    gridControl2.DataSource = o.SELECtALLORDER(Convert.ToDateTime(FromDate.Text), Convert.ToDateTime(ToDate.Text));
                }
            }
        }
    }
}