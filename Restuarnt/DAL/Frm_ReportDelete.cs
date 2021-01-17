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

namespace Restuarnt.DAL
{
    public partial class Frm_ReportDelete : DevExpress.XtraEditors.XtraForm
    {
        Order o = new Order();
        public Frm_ReportDelete()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rdb_hold.Checked==true)
            {
                gridControl2.DataSource = o.SELECTOrderShowFalse(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));  
            }
            else
            {
                gridControl2.DataSource = o.SELECTOrderAfterPayShowFalse(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));

            }
        }

        private void rdb_hold_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_hold.Checked == true)
            {
                gridControl2.DataSource = null;
            }
        }

        private void rdb_order_CheckedChanged(object sender, EventArgs e)
        {

            if (rdb_order.Checked == true)
            {
                gridControl2.DataSource = null;
            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name== "Update")
            {
                if (MessageBox.Show("هل تريد استرجاع الفاتورة", "عمليه استرجاع", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    o.updateShwo(Convert.ToInt32(gridView2.GetFocusedRowCellValue(ID_Order)));
                    MessageBox.Show("تم استرجاع الفاتورة");
                    if (rdb_hold.Checked == true)
                    {
                        gridControl2.DataSource = o.SELECTOrderShowFalse(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));
                    }
                    else
                    {
                        gridControl2.DataSource = o.SELECTOrderAfterPayShowFalse(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));

                    }
                }
             }
        }
    }
}