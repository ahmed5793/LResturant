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
using Restuarnt.Bl;

namespace Restuarnt.PL
{
    public partial class Frm_Masrofat : DevExpress.XtraEditors.XtraForm
    {
        BL.Reserve r = new BL.Reserve();
        public Frm_Masrofat()
        {
            InitializeComponent();
            comboBox1.DataSource = r.SelectReserve();

            comboBox1.DisplayMember = "masrof_type";
            comboBox1.ValueMember = "ID_masrof";
            gridControl1.DataSource = r.SelectReserveDetails();
        }

        private void Frm_Masrofat_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

        }
        internal void Clear()
        {
            txt_amont.Text="";
            txt_description.Text="";

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (txt_amont.Text == "")
            {
                MessageBox.Show("من فضلك ادخال المبلغ ");
                return;

            }
            if (comboBox1.Text != string.Empty)
            {

                r.AddReserveDetails(Convert.ToInt32(comboBox1.SelectedValue), txt_description.Text,
                    Convert.ToDecimal(txt_amont.Text), Convert.ToDateTime(dateTimePicker1.EditValue), Program.Id_USer);
                MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل");
                gridControl1.DataSource = r.SelectReserveDetails();
                Clear();




            }
            else
            {
                MessageBox.Show("من فضلك قم بااختيار نوع المصروف");
            }

        }

        private void txt_amont_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            //{
            //    e.Handled = true;
            //}
            //else if (e.KeyChar == '.' && txt_amont.Text.ToString().IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}

        }
    }
}