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
    public partial class Frm_RserveDetails : Form
    {
        Reserve r = new Reserve();
        private static Frm_RserveDetails farm;
       


        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_RserveDetails getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_RserveDetails();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
        public Frm_RserveDetails()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
            comboBox1.DataSource = r.SelectReserve();

            comboBox1.DisplayMember = "masrof_type";
            comboBox1.ValueMember = "ID_masrof";
            dataGridView1.DataSource = r.SelectReserveDetails();

            btn_delete.Enabled = false;
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            dataGridView1.Columns[0].Visible = false;

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    
        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (txt_amont.Text=="")
            {
                MessageBox.Show("من فضلك ادخال المبلغ ");
                return;

            }
            if (comboBox1.Text != string.Empty)
            {
              
                r.AddReserveDetails(Convert.ToInt32(comboBox1.SelectedValue), txt_description.Text,
                    Convert.ToDecimal(txt_amont.Text), dateTimePicker1.Value,Program.Id_USer);
                MessageBox.Show("تم التسجيل بنجاح", "عمليه التسجيل");
                dataGridView1.DataSource = r.SelectReserveDetails();
                Clear();
              



            }
            else
            {
                MessageBox.Show("من فضلك قم بااختيار نوع المصروف");
            }

        }

        private void Btn_update_Click(object sender, EventArgs e)
        {

            if (txt_amont.Text == "")
            {
                MessageBox.Show("من فضلك ادخال المبلغ ");
                return;

            }

            if (comboBox1.Text != string.Empty)
            {
                r.UpdateResrveDetails(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(comboBox1.SelectedValue), txt_description.Text,
                    Convert.ToDecimal(txt_amont.Text), dateTimePicker1.Value);
                if (MessageBox.Show("هل تريد تعديل المصروف ", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MessageBox.Show(" تم العديل بنجاح");
                    dataGridView1.DataSource = r.SelectReserveDetails();
                    Clear();
                    btn_delete.Enabled = false;
                    btn_save.Enabled = true;
                    btn_update.Enabled = false;
               
                }



            }
            else
            {
                MessageBox.Show("تم الغاء عمليه التعديل");

            }

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المصروف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                r.DeleteReserveDetails(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم المسح بنجاح");
                dataGridView1.DataSource = r.SelectReserveDetails();
                Clear();
                btn_delete.Enabled = false;
                btn_save.Enabled = true;
                btn_update.Enabled = false;
              
            }

            else
            {
                MessageBox.Show("تم الغاء عمليه المسح");

            }

        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {

                comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_description.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_amont.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                btn_save.Enabled = false;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }
        }

        private void Txt_amont_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {



                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == '.' && txt_amont.Text.ToString().IndexOf('.') > -1)
                {
                    e.Handled = true;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal void Clear()
        {
            txt_amont.Clear();
            txt_description.Clear();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_Reserve r = new Frm_Reserve();
            r.ShowDialog();
        }

        private void Frm_RserveDetails_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Frm_SearchReserve s = new Frm_SearchReserve();
            s.ShowDialog();
        }
    }
}
