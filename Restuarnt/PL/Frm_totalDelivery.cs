using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restuarnt.PL;


namespace Restuarnt.PL
{
    
    public partial class Frm_totalDelivery : Form
    {
        FOrder o = new FOrder();

        public Frm_totalDelivery()
        {
            InitializeComponent();
        }

        private void Txt_Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_totalDelivery_Load(object sender, EventArgs e)
        {
           
        }

        private void Label_prise_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
