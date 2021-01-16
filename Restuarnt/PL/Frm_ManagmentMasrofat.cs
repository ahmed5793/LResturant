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
using Restuarnt.Bl;

namespace Restuarnt.PL
{
    public partial class Frm_ManagmentMasrofat : DevExpress.XtraEditors.XtraForm
    {
        BL.Reserve r = new BL.Reserve();
        public Frm_ManagmentMasrofat()
        {
            InitializeComponent();
           
            gridControl1.DataSource = r.SelectReserveDetails();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name=="update")
            {
                comboBox1.DataSource = r.SelectReserve();

                comboBox1.DisplayMember = "masrof_type";
                comboBox1.ValueMember = "ID_masrof";

                if (gridView1.RowCount> 0)
                {
                    lablel_num.Text = gridView1.GetFocusedRowCellValue(ID_Masrof).ToString();
                    comboBox1.Text = gridView1.GetFocusedRowCellValue(type_Masrof).ToString();
                    txt_description.Text = gridView1.GetFocusedRowCellValue(note).ToString();
                    txt_amont.Text = gridView1.GetFocusedRowCellValue(money).ToString();
                    dateTimePicker1.Text = gridView1.GetFocusedRowCellValue(date).ToString();

                }
            }
            else if (e.Column.Name == "delete")
            {
                if (MessageBox.Show("هل تريد حذف المصروف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    r.DeleteReserveDetails(Convert.ToInt32(gridView1.GetFocusedRowCellValue("masrofat_details_ID")));
                    MessageBox.Show("تم المسح بنجاح");
                    gridControl1.DataSource = r.SelectReserveDetails();
                    Clear();
              

                }

                else
                {
                    MessageBox.Show("تم الغاء عمليه المسح");

                }
            }
        }
        internal void Clear()
        {
            txt_amont.Text = "";
            txt_description.Text = "";
            comboBox1.DataSource = null;
            lablel_num.Text = "0";

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

           
            if (lablel_num.Text != "")
            {





                r.UpdateResrveDetails(Convert.ToInt32(lablel_num.Text), Convert.ToInt32(comboBox1.SelectedValue), txt_description.Text,
                    Convert.ToDecimal(txt_amont.Text), Convert.ToDateTime(dateTimePicker1.EditValue));
                if (MessageBox.Show("هل تريد تعديل المصروف ", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show(" تم العديل بنجاح");
                    gridControl1.DataSource = r.SelectReserveDetails();
                    Clear();


                }

            }
            else
            {
                    MessageBox.Show("اختيار فاتورة اولا");
            }
            }
            catch (Exception)
            {

               
            }


        }

        private void Frm_ManagmentMasrofat_Load(object sender, EventArgs e)
        {
            FromDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_TypeMasrof rm = new Frm_TypeMasrof();
            rm.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            lablel_num.Text = "0";
            txt_amont.Text = "";
            txt_description.Text = "";
            FromDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            comboBox1.DataSource = null;
            gridControl1.DataSource = r.SearchMasrofatFromDate(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));
       
        }
    }
}