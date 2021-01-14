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
    public partial class frm_ReportStuff : Form
    {
        Stuff s = new Stuff();
        public frm_ReportStuff()
        {
            InitializeComponent();

            cmb_stuff.DataSource = s.SelectStuuf();
            cmb_stuff.DisplayMember = "اسم الكابتن";
            cmb_stuff.ValueMember = "رقم الكابتن";
        }
        private void frm_ReportStuff_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_stuff.Text=="")
                {
                    MessageBox.Show("من فضلك قم بااختيار اسم الكابتن");
                    return;
                }
               gridControl1.DataSource= s.REPORTStuff(Convert.ToInt32(cmb_stuff.SelectedValue),FromDate.Value,ToDate.Value);
                decimal total = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    total += Convert.ToDecimal(row[4].ToString());

                }
                txt_TotalPurshacing.Text = total.ToString("₱ #,##0.0");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridView1.RowCount > 0)
                {
                  
                   
                        RPT.rptOrderSala rs = new RPT.rptOrderSala();
                        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                        //s.crystalReportViewer1.RefreshReport();
                        rs.SetDatabaseLogon("", "", ".", "Restuarnt");
                        rs.SetParameterValue("@ID", Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                      //  s.crystalReportViewer1.ReportSource = rs;
                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        rs.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                        //  rs.PrintToPrinter(1, true, 0, 0);
                        s.ShowDialog();
                        rs.Close();
                        s.Dispose();
                   

                }
                else
                {
                    MessageBox.Show("لايوجد بيانات للطباعه");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
