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

    public partial class frm_AddStuff : DevExpress.XtraEditors.XtraForm
    {
        Stuff s = new Stuff();
        public frm_AddStuff()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {



                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الكابتن");
                }
                else
                {


                    s.AddStuuf(txt_name.Text, txt_address.Text, txt_phone.Text);
                    MessageBox.Show("تم الاضافه  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clears();


                    gridControl1.DataSource = s.SelectStuuf();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void frm_AddStuff_Load(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_save.Enabled = true;
            gridControl1.DataSource = s.SelectStuuf();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            try
            {


                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الكابتن ");
                }



                if (MessageBox.Show("هل تريد تعديل البيانات ", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    s.UpdateStuuf(txt_name.Text, txt_address.Text, txt_phone.Text, Convert.ToInt32(lable_num.Text));
                    MessageBox.Show("تم تعديل البيانات  بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clears();


                    gridControl1.DataSource = s.SelectStuuf();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if (e.Column.Name == "update")
            {

                if (gridView1.RowCount > 0)
                {
                    lable_num.Text = gridView1.GetFocusedRowCellValue(ID_Stuff).ToString();
                    txt_name.Text = gridView1.GetFocusedRowCellValue(Name_Stuff).ToString();
                    txt_address.Text = gridView1.GetFocusedRowCellValue(Address).ToString();
                    txt_phone.Text = gridView1.GetFocusedRowCellValue(phone).ToString();

                    btn_save.Enabled = false;

                    btn_update.Enabled = true;
                }
            }
            else if (e.Column.Name == "delete")
            {
                try
                {
                    if (MessageBox.Show("هل تريد حذف الكابتن", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        s.DeleteStuff(Convert.ToInt32(gridView1.GetFocusedRowCellValue(ID_Stuff)));
                        MessageBox.Show("تم مسح الطيار بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);


                        gridControl1.DataSource = s.SelectStuuf();
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clears();
        }
    }
}