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
    public partial class Frm_managmentPHrchise : Form
    {
        Suppliers s = new Suppliers();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        public Frm_managmentPHrchise()
        {
            InitializeComponent();

          



        }

        private void Frm_managmentPHrchise_Load(object sender, EventArgs e)
        {
            dataGridViewList.DataSource = s.SELECTPhrchiseView();
        }

        private void Btn_printCheken_Click(object sender, EventArgs e)
        {
          

            if (dataGridViewList.Rows.Count > 0)
            {
                Frm_ViewPhrchise v = new Frm_ViewPhrchise();
             
                dt = s.SELECTPhrchise(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value));
              v.dataGridView1.DataSource = dt;
                dt2 = s.SELECTPhrchiseSupplier(Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value));
                foreach (DataRow dr in dt2.Rows)
                {
                   v. label1.Text = dr[0].ToString();
                   v. txt_Name.Text = dr[1].ToString();
                  v.  txt_Date.Text = dr[2].ToString();



                }
                v.ShowDialog();
            }
        }
            private void Button1_Click(object sender, EventArgs e)
        {
      
            dt = s.SearchPhrchiseView(FromDate.Value, ToDate.Value);
            dataGridViewList.DataSource = dt;
        }
    }
}
