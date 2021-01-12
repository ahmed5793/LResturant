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
    public partial class Frm_Reserve : Form
    {
        Reserve r = new Reserve();
        public Frm_Reserve()
        {
            InitializeComponent();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {

            if (txt_name.Text != string.Empty)
            {
                r.AddReserve(txt_name.Text);
                MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل", MessageBoxButtons.OK);

                Frm_RserveDetails.getmain.comboBox1.DataSource = r.SelectReserve();

                Frm_RserveDetails. getmain.comboBox1.DisplayMember = "masrof_type";
                Frm_RserveDetails. getmain.comboBox1.ValueMember = "ID_masrof";
                this.Close();
            }
         
            else
            {
                MessageBox.Show("من فضلك لابد من كتابه نوع المصروف");
            }
        }
    }
}
    

