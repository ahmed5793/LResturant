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
            FromDate.EditValue = DateTime.Now;
            ToDate.EditValue = DateTime.Now;
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
            Frm_ShowUpdate fo = new Frm_ShowUpdate();
            if (e.Column.Name== "Updates")
            {
               
                //DataTable dt2 = new DataTable();
                //DataTable dt5 = new DataTable();

               

                if (gridView2.RowCount > 0)
                {
                    fo.grb_sala.Hide();
                    fo.grb_customer.Hide();
                    fo.grb_delivry.Hide();
                    fo.groupControl1.Enabled = false;

                    fo.grb_customer.Enabled = false;
                    fo.grb_delivry.Enabled = false;
                    fo.grb_sala.Enabled = false;



                    if (gridView2.GetFocusedRowCellValue(Statues).ToString() == "Delivery")
                    {
                       
                        fo.rdb_delivery.Checked = true;
                        //cmb_customer.Hide();
                        //textEdit1.Show();

                        //textEdit1.Enabled = false;
                        //rdb_clientsave.Enabled = false;
                        //rdb_newclient.Enabled = false;
                      

                        //txt_phones.Enabled = false;
                        //txt_address.Enabled = false;
                       fo.grb_customer.Show();
                       fo.grb_delivry.Show();

                        // fo.grb_customer.Enabled = false;
                        fo.dt2.Clear();
                        fo.dt2 = o.SELECTOrderDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));

                       fo.gridControl2.DataSource = fo.dt2;

                       fo.ID_Dep.Visible = false;
                       fo.Dep.Visible = false;
                       fo.ID_Items.Visible = false;


                        fo.dt5.Clear();
                        fo.dt5 = o.SELECTOrder(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));

                        foreach (DataRow dr in fo.dt5.Rows)
                        {




                           fo.Lable_Num.Text = dr[0].ToString();
                           fo.txt_cust.Text = dr[1].ToString();
                           fo.textEdit1.Text = dr[2].ToString();
                           fo.txt_phones.Text = dr[3].ToString();
                           fo.txt_address.Text = dr[4].ToString();
                           fo.lable_date.Text = dr[5].ToString();

                           fo.texT.Text = dr[6].ToString();

                           fo.cmb_delivery.Text = dr[9].ToString();
                           fo.txt_delivery.Text = dr[10].ToString();
                           fo.txt_discount.Text = dr[11].ToString();



                        }









                    }
                    else if (gridView2.GetFocusedRowCellValue(Statues).ToString() == "Table")
                    {


                        //  rdb_delivery.Enabled = false;
                        //    cmb_delivery.Enabled = false;
                        //   txt_delivery.Enabled = false;
                        //  txt_phones.Enabled = false;
                        //  textEdit1.Enabled = false;
                        // fo.rdb_sala.Enabled = true;
                        //textEdit1.Enabled = false;
                        fo.grb_sala.Show();
                        fo.rdb_sala.Checked = true;
                        //  cmb_Table.Enabled = false;
                      // fo.grb_sala.Show();
                      // fo.grb_sala.Enabled = false;
                        fo.grb_customer.Hide();
                        fo.grb_delivry.Hide();

                        fo.dt2.Clear();
                        fo.dt2 = o.SELECTOrderDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));

                       fo.gridControl2.DataSource = fo.dt2;
                       fo.ID_Items.Visible = false;
                       fo.Dep.Visible = false;
                       fo.ID_Items.Visible = false;

                        fo.dt5.Clear();
                        fo.dt5 = o.SELECTOrderSala(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));
                        foreach (DataRow dr in fo.dt5.Rows)
                        {



                           fo.Lable_Num.Text = dr[0].ToString();
                           fo.txt_cust.Text = dr[1].ToString();
                           fo.textEdit1.Text = dr[2].ToString();

                           fo.lable_date.Text = dr[3].ToString();


                           fo.texT.Text = dr[4].ToString();
                            //txt_pay.Text = dr[5].ToString();
                            //txt_mark.Text = dr[6].ToString();
                            // cmb_Table.Text = dr[7].ToString();
                           fo.cmb_Table.Text = dr[7].ToString();
                           fo.txt_discount.Text = dr[8].ToString();
                           fo.cmb_stuff.Text = dr[9].ToString();
                        }






                    }
                    else if (gridView2.GetFocusedRowCellValue(Statues).ToString() == "Take away")
                    {
                        //   rdb_delivery.Enabled = false;
                       fo.rdb_takeaway.Checked = true;
                    
                        // txt_phones.Enabled = false;
                        // textEdit1.Enabled = false;
                      
                         // fo.textEdit1.Show();
                        //textEdit1.Enabled = false;
                       fo.grb_customer.Show();
                       fo.grb_delivry.Hide();
                        
                        fo.grb_sala.Hide();


                        fo.dt2.Clear();
                        fo.dt2 = o.SELECTOrderDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));
                       fo.gridControl2.DataSource = fo.dt2;
                       fo.ID_Items.Visible = false;
                       fo.Dep.Visible = false;
                       fo.ID_Items.Visible = false;
                        fo.dt5.Clear();
                        fo.dt5 = o.SELECTOrderTakwAway(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));

                        foreach (DataRow dr in fo.dt5.Rows)
                        {



                           fo.Lable_Num.Text = dr[0].ToString();
                           fo.txt_cust.Text = dr[1].ToString();
                           fo.textEdit1.Text = dr[2].ToString();

                           fo.lable_date.Text = dr[3].ToString();

                           fo.texT.Text = dr[4].ToString();

                           fo.txt_discount.Text = dr[7].ToString();

                            fo.txt_phones.Text = dr[8].ToString();
                            fo.txt_address.Text = dr[9].ToString();
                        }

                    }
                   fo.totalInvoice();
                   fo.TOTALFINALYDELIVERY();
                   fo.TOTALFINALYDISCOUNT();
                    fo.ShowDialog();

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

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("هل تريد حذف جميع الفواتير في البرنامج","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
            {
                o.deleteAllOrder();
            }
      
        }
    }
}