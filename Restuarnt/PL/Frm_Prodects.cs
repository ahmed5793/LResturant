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
    public partial class Frm_Prodects : Form
    {
        Product p = new Product();
        private static Frm_Prodects farm;
        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Prodects getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Prodects();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }

        public Frm_Prodects()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
            dataGridView2.DataSource = p.SelectProdec();
            btn_update.Enabled = false;
            btn_save.Enabled = true;

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (txt_NameProd.Text=="")
            {
                MessageBox.Show("من فضلك قم باادخال اسم الصنف");
                return;
            }
            if (cmb_Unit.Text == "")
            {
                MessageBox.Show("من فضلك قم باادخال نوع الوحدة");
                return;
            }
            p.AddProduct(txt_NameProd.Text, Convert.ToDecimal(txt_quantity.Text),Convert.ToInt32(cmb_Unit.SelectedValue));
            MessageBox.Show("تم تسجيبل الصنف بنجاح");
            txt_quantity.Text = "0";
            txt_NameProd.Text = "";
            dataGridView2.DataSource = p.SelectProdec();
            Frm_Phrchise.getmain.cmb_Proudect.DataSource = p.SelectProdec();
            Frm_Phrchise.getmain.cmb_Proudect.DisplayMember = "اسم الصنف";
            Frm_Phrchise.getmain.cmb_Proudect.ValueMember = "رقم الصنف";

        }

        private void Txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_quantity.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_quantity_Leave(object sender, EventArgs e)
        {
            if (txt_quantity.Text=="")
            {
                txt_quantity.Text = "0";
            }
        }
        Unit u = new Unit();
        private void Frm_Prodects_Load(object sender, EventArgs e)
        {
            cmb_Unit.DataSource = u.SelectUnit();
            cmb_Unit.DisplayMember = "Name";
            cmb_Unit.ValueMember = "ID_Unit";
        }

        private void Btn_addItem_Click(object sender, EventArgs e)
        {
            Frm_Unit su = new Frm_Unit();
            su.ShowDialog();
        }

        private void DataGridView2_DoubleClick(object sender, EventArgs e)
        {
            btn_update.Enabled = true;
            btn_save.Enabled = false;
            if (dataGridView2.Rows.Count>0)
            {
                txt_NameProd.Text=dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txt_quantity.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                cmb_Unit.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (txt_NameProd.Text == "")
            {
                MessageBox.Show("من فضلك قم باادخال اسم الصنف");
                return;
            }
            if (cmb_Unit.Text == "")
            {
                MessageBox.Show("من فضلك قم باادخال نوع الوحدة");
                return;
            }
            p.updateProduct(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value),txt_NameProd.Text, Convert.ToDecimal(txt_quantity.Text), Convert.ToInt32(cmb_Unit.SelectedValue));
            MessageBox.Show("تم التعديل بنجاح");
            dataGridView2.DataSource = p.SelectProdec();
            Frm_Phrchise.getmain.cmb_Proudect.DataSource = p.SelectProdec();
            Frm_Phrchise.getmain.cmb_Proudect.DisplayMember = "اسم الصنف";
            Frm_Phrchise.getmain.cmb_Proudect.ValueMember = "رقم الصنف";
            btn_update.Enabled = false;
            btn_save.Enabled = true;
            txt_NameProd.Clear();
            txt_quantity.Text = "0";
            
        }
    }
}
