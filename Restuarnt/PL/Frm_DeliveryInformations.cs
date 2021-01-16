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
    public partial class Frm_DeliveryInformations : DevExpress.XtraEditors.XtraForm
    {
        Delivery d = new Delivery();

        public Frm_DeliveryInformations()
        {
            InitializeComponent();

            gridControl1.DataSource = d.SelectDeliveryInformation();
        }
        void clears()
        {
            txt_phone.Text = "";
            txt_name.Text = "";
            txt_address.Text = "";
            btn_update.Enabled = false;
            btn_save.Enabled = true;
            lable_num.Text = "0";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {

                
                 if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الطيار");
                    return;
                }
              

                    d.AddDeleiveryInformation(txt_name.Text, txt_address.Text, txt_phone.Text);
                    MessageBox.Show("تم اضافه الطيار بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clears();


                    gridControl1.DataSource = d.SelectDeliveryInformation();

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_DeliveryInformations_Load(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_save.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            try
            {


                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الطيار");
                }



                if (MessageBox.Show("هل تريد تعديل بيانات الطيار", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    d.UpdateDeleiveryInformation(txt_name.Text, txt_address.Text, txt_phone.Text, Convert.ToInt32(lable_num.Text));
                    MessageBox.Show("تم تعديل بيانات الطيار بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clears();


                    gridControl1.DataSource = d.SelectDeliveryInformation();
                   
                    //btn_update.Enabled = false;
                    //btn_save.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name=="update")
            {

                if (gridView1.RowCount > 0)
                {
                    lable_num.Text= gridView1.GetFocusedRowCellValue(ID_Delivery).ToString();
                    txt_name.Text = gridView1.GetFocusedRowCellValue(Name_Delivery).ToString();
                    txt_address.Text = gridView1.GetFocusedRowCellValue(Address).ToString();
                    txt_phone.Text = gridView1.GetFocusedRowCellValue(phone).ToString();

                    btn_save.Enabled = false;
                    
                    btn_update.Enabled = true;
                }
            }
            else if(e.Column.Name== "delete")
            {
                try
                {
                    if (MessageBox.Show("هل تريد حذف الطيار", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        d.DeleteDelivery(Convert.ToInt32(gridView1.GetFocusedRowCellValue(ID_Delivery)));
                        MessageBox.Show("تم مسح الطيار بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);


                        gridControl1.DataSource = d.SelectDeliveryInformation();
                        clears();
                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عمليه الحذف");
                        clears();
                    }




                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            clears();
        }
    }
}