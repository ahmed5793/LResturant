using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restuarnt.BL;

namespace Restuarnt.PL
{
    public partial class Frm_ReportIncome : Form
    {
        Order o = new Order();

        public Frm_ReportIncome()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text=="")
                {
                    MessageBox.Show("من فضلك قم بااختيار القسم");
                    return;
                }
              gridControl1.DataSource=  o.ReportOrderDepartment(comboBox1.Text, FromDate.Value, ToDate.Value);
                decimal total = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    total += Convert.ToDecimal(row[1].ToString());

                }
                txt_TotalPurshacing.Text = total.ToString("₱ #,##0.0");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
