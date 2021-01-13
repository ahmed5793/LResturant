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
        }

        private void Frm_UpdateOrrder_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = o.SELECtALLORDER();
        }
    }
}