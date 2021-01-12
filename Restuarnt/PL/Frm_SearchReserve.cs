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
    public partial class Frm_SearchReserve : Form
    {
        Reserve r = new Reserve();
        DataTable dt = new DataTable();
        public Frm_SearchReserve()
        {
            InitializeComponent();
           
           
        }

        private void Frm_SearchReserve_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            dt = r.SearchFromDate(FromDate.Value, ToDate.Value);
            gridControl1.DataSource = dt;
            total();

        }
        internal void total()
        {
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[2].ToString());

            }

            txt_rent.Text = total.ToString("₱ #,##0.0");
        }
    }
}
