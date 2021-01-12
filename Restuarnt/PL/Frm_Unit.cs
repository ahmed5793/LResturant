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
    public partial class Frm_Unit : Form
    {
        Unit u = new Unit();
        public Frm_Unit()
        {
            InitializeComponent();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (txt_Unit.Text!=string.Empty)
            {


                u.AddUnit(txt_Unit.Text);
                MessageBox.Show("تم الاضافة بنجاح");
                Frm_Prodects.getmain.cmb_Unit.DataSource = u.SelectUnit();
                Frm_Prodects.getmain.cmb_Unit.ValueMember = "ID_Unit";
                Frm_Prodects.getmain.cmb_Unit.DisplayMember = "Name";

                txt_Unit.Clear();
            }
            else
            {
                MessageBox.Show("من فضلك قم بكتابه نوع الوحدة");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
