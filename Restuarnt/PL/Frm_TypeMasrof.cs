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
    public partial class Frm_TypeMasrof : DevExpress.XtraEditors.XtraForm
    {
        BL.Reserve r = new Reserve();
        public Frm_TypeMasrof()
        {
            InitializeComponent();
            gridControl1.DataSource = r.selectTypeMasrof();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != string.Empty)
            {
                r.AddReserve(txt_name.Text);
                MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل", MessageBoxButtons.OK);
                gridControl1.DataSource = r.selectTypeMasrof();
                txt_name.Text = "";

            }

            else
            {
                MessageBox.Show("من فضلك لابد من كتابه نوع المصروف");
            }
        }

        private void Frm_TypeMasrof_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
            if (e.Column.Name == "delete")
            {
                if (MessageBox.Show("هل تريد حذف المصروف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    r.DeleteTypeMasrof(Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID_masrof")));
                    MessageBox.Show("تم المسح بنجاح");
                    gridControl1.DataSource = r.selectTypeMasrof();



                }

                else
                {
                    MessageBox.Show("تم الغاء عمليه المسح");

                }
            }
        }
    }
}