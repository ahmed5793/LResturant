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
        Order o = new Order();


        public Frm_Hold()
        {
            InitializeComponent();
         

            Name_Cust.Caption = "اسم العميل";
            Name_Cust.FieldName = "اسم العميل";
            id_take.Caption = "رقم الطلب";
            id_take.FieldName = "رقم الطلب";
            id_take.Visible = false;
            

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_all.Checked == true)
            {
                gridControl2.DataSource = null;
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
        }

        private void rdb_takeaway_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_takeaway.Checked == true)
            {
                gridControl2.DataSource = null;
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
        }

        private void Frm_Hold_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = null;

            this.Close();
        }
    }
}