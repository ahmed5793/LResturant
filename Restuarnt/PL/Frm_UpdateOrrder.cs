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
  
    public partial class Frm_UpdateOrrder : DevExpress.XtraEditors.XtraForm
    {
        Order o = new Order();
        public Frm_UpdateOrrder()
        {
            InitializeComponent();
            gridControl2.DataSource = o.SELECtALLORDER(DateTime.Now.Date,DateTime.Now.Date);

        }

        private void Frm_UpdateOrrder_Load(object sender, EventArgs e)
        {
           
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = o.SELECtALLORDER(Convert.ToDateTime(FromDate.EditValue),Convert.ToDateTime(ToDate.EditValue));
        }
    }
}