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
    public partial class Frm_Tables : DevExpress.XtraEditors.XtraForm
    {
        Tables t = new Tables();
        public Frm_Tables()
        {
            InitializeComponent();
            gridControl1.DataSource = t.SelectTables();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (txt_number.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال رقم الطاولة");
                return;

            }

            t.AddTables((txt_number.Text));
            MessageBox.Show("تم الاضافه  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_number.Text = "";
            gridControl1.DataSource = t.SelectTables();

        }

        private void Frm_Tables_Load(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_save.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_number.Text = "";
            lable_num.Text = "0";
            btn_update.Enabled = false;
            btn_save.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (txt_number.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال رقم الطاولة");
                return;

            }
            if (lable_num.Text == "0")
            {
                MessageBox.Show("من فضلك يرجي اختيار فاتورة");
                return;

            }

            t.UpdateTables(Convert.ToInt32(lable_num.Text), (txt_number.Text));
            MessageBox.Show("تم التعديل  بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_number.Text = "";
            lable_num.Text = "0";
            gridControl1.DataSource = t.SelectTables();
            btn_update.Enabled = false;
            btn_save.Enabled = true;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if (e.Column.Name == "update")
            {
                btn_update.Enabled = true;
                btn_save.Enabled = false;
                lable_num.Text = gridView1.GetFocusedRowCellValue(ID_Tables).ToString();
                txt_number.Text = gridView1.GetFocusedRowCellValue(Tables_Number).ToString();
            }
            else if (e.Column.Name == "delete")
            {

                try
                {
                    if (MessageBox.Show("هل تريد حذف الطيار", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        t.DeleteTables(Convert.ToInt32(gridView1.GetFocusedRowCellValue(ID_Tables)));
                        MessageBox.Show("تم مسح الطاولة بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);


                    
                        gridControl1.DataSource = t.SelectTables();
                        txt_number.Text = "";
                        lable_num.Text = "0";
                        gridControl1.DataSource = t.SelectTables();
                        btn_update.Enabled = false;
                        btn_save.Enabled = true;


                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عمليه الحذف");
                        txt_number.Text = "";
                        lable_num.Text = "0";
                        gridControl1.DataSource = t.SelectTables();
                        btn_update.Enabled = false;
                        btn_save.Enabled = true;
                    }




                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}