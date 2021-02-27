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
using DevExpress.XtraGrid.Columns;

namespace Restuarnt.PL
{
    public partial class Frm_Hold : DevExpress.XtraEditors.XtraForm
    {
        //private static Frm_Hold farm;

        //static void STATUESCllosed(object sender, FormClosedEventArgs e)
        //{
        //    farm = null;
        //}
        //public static Frm_Hold getmain
        //{
        //    get
        //    {
        //        if (farm == null)
        //        {
        //            farm = new Frm_Hold();
        //            farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
        //        }
        //        return farm;

        //    }
        //}

        Order o = new Order();


        public Frm_Hold()
        {
            InitializeComponent();
            //if (farm==null)
            //{
            //    farm = this;
            //}
            permision();

            Name_Cust.Caption = "اسم العميل";
            Name_Cust.FieldName = "اسم العميل";
            id_take.Caption = "رقم الطلب";
            id_take.FieldName = "رقم الطلب";
            id_take.Visible = false;

          
           
        }
        void permision()
        {
            BL.Login l = new BL.Login();
            DataTable dperm = new DataTable();
            dperm.Clear();
            dperm = l.Select_UserPermession(Program.Id_USer);
            if (dperm.Rows.Count >= 1)
            {
              
               

                if (Convert.ToInt32(dperm.Rows[0][21]) == 0)
                {
                    delete.Visible = false;

                }
                else if (Convert.ToInt32(dperm.Rows[0][21]) == 1)
                {
                    delete.Visible = true;
                }

            }
        }

      
        private void labelControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rdb_all.Checked == true)
            {
              
                gridControl2.DataSource = null;
                DeliveryService.Visible = false;
                DeliveryService.VisibleIndex = -1;
                Name_Cust.Caption = "اسم العميل";
                Name_Cust.FieldName = "اسم العميل";
                id_take.Caption = "رقم الطلب";
                id_take.FieldName = "رقم الطلب";
                id_take.Visible = false;
              
                gridControl2.DataSource = o.SELECTOrderRentALLORDER();
            }
        }

        private void عرض_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }

        private void عرض_DoubleClick(object sender, EventArgs e)
        {
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            
           
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }
       
        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Caption == "عرض")

            {
          

               
                this.Close();
               
                

            }
            else if (e.Column.Name == "delete")
            {
                if (MessageBox.Show("هل تريد حذف الفاتورة ونقلها الي سلة المهملات", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    o.DeleteOrder(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));
                    MessageBox.Show("تم الحذف بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dt = new DataTable();

                    dt.Clear();
                    dt = o.SELECTOrderRentALLORDER();
                   FOrder.getmain.simpleButton4.Text = $"({dt.Rows.Count}) الفواتير المتعلقة";



                    if (rdb_all.Checked==true)
                    {
                        gridControl2.DataSource = o.SELECTOrderRentALLORDER();
                    }
                    else if(rdb_delivery.Checked==true)
                    {
                        gridControl2.DataSource = o.SELECTOrderRent();
                    }
                    else if(rdb_sala.Checked==true)
                    {
                        gridControl2.DataSource = o.SELECTOrderRentSala();
                    }
                    else if(rdb_takeaway.Checked==true)
                    {
                        gridControl2.DataSource = o.SELECTOrderRentTkeAway();
                    }
                }
            }

            
        }

        private void rdb_takeaway_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_takeaway.Checked == true)
            {
                gridControl2.DataSource = null;
                DeliveryService.Visible = false;
                DeliveryService.VisibleIndex = -1;
                Name_Cust.Caption = "اسم العميل";
                Name_Cust.FieldName = "اسم العميل";
                id_take.Caption = "رقم الطلب";
                id_take.FieldName = "رقم الطلب";
                id_take.Visible = false;
            
             
                gridControl2.DataSource = o.SELECTOrderRentTkeAway();


            }
        }

        private void rdb_sala_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sala.Checked==true)
            {
                gridControl2.DataSource = null;
                id_take.Visible = true;
                DeliveryService.Visible = false;
                DeliveryService.VisibleIndex = -1;
                Name_Cust.Caption = "رقم الطاوله";
                Name_Cust.FieldName = "رقم الطاوله";
                id_take.Caption = "الكابتن";
                id_take.FieldName = "الكابتن";
                gridControl2.DataSource = o.SELECTOrderRentSala();
               
                //GridColumn myCol = new GridColumn()
                //{ Caption = "رقم الطاوله", Visible = true, FieldName = "رقم الطاوله" };
                //gridView2.Columns.Add(myCol);
                //myCol.VisibleIndex = 1;
                //GridColumn myCol2 = new GridColumn()
                //{ Caption = "الكابتن", Visible = true, FieldName = "الكابتن" };
                //gridView2.Columns.Add(myCol2);
                //myCol.VisibleIndex = 3;
            }
        }

        private void rdb_delivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_delivery.Checked==true)
            {
                gridControl2.DataSource = null;
                id_take.Visible = true;
                DeliveryService.Visible = true;
                DeliveryService.VisibleIndex = 6;
                Name_Cust.Caption = "اسم العميل";
                Name_Cust.FieldName = "اسم العميل";
                id_take.Caption = "اسم الطيار";
                id_take.FieldName = "اسم الطيار";
                gridControl2.DataSource = o.SELECTOrderRent();
            }
           
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Hold_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = o.SELECTOrderRentALLORDER();
            rdb_all.Checked = true;
            DeliveryService.VisibleIndex = -1;
            DeliveryService.Visible = false;
        }

        private void Frm_Hold_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = null;

            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           // WindowState = FormWindowState.Minimized;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //rdb_all.Checked = true;
            //   // gridControl2.DataSource = null;
            //    DeliveryService.Visible = false;
            //    DeliveryService.VisibleIndex = -1;
            //    Name_Cust.Caption = "اسم العميل";
            //    Name_Cust.FieldName = "اسم العميل";
            //    id_take.Caption = "رقم الطلب";
            //    id_take.FieldName = "رقم الطلب";
            //    id_take.Visible = false;

            //    gridControl2.DataSource = o.SELECTOrderRentALLORDER();
            
        }
    }
}