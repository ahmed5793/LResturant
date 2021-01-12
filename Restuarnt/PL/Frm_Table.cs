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
    public partial class Table : Form
    {
        Tables t = new Tables();
        public Table()
        {
            InitializeComponent();
            dataGridViewPR.DataSource = t.SelectTables();
            dataGridViewPR.Columns[0].Visible = false;
            btn_update.Enabled = false;
            btn_add.Enabled = true;

        }

        private void Txt_phr_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //if  (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
            //{
            //    e.Handled = true;
            //}
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {

            if (txt_number.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال رقم الطاولة");
                return;

            }
            if (txt_number.Text == "0")
            {
                MessageBox.Show("من فضلك يرجي ادخال رقم الطاولة");
                return;

            }
            t.AddTables((txt_number.Text));
            MessageBox.Show("تم الاضافه  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            txt_number.Clear();
            dataGridViewPR.DataSource = t.SelectTables();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {

            if (txt_number.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال رقم الطاولة");
                return;

            }
            if (txt_number.Text == "0")
            {
                MessageBox.Show("من فضلك يرجي ادخال رقم الطاولة");
                return;

            }
            t.UpdateTables(Convert.ToInt32(dataGridViewPR.CurrentRow.Cells[0].Value),(txt_number.Text));
            MessageBox.Show("تم التعديل  بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            txt_number.Clear();
            dataGridViewPR.DataSource = t.SelectTables();
            btn_update.Enabled = false;
            btn_add.Enabled = true;
        }

        private void DataGridViewPR_DoubleClick(object sender, EventArgs e)
        {
            btn_update.Enabled = true;
            btn_add.Enabled = false;
            txt_number.Text = dataGridViewPR.CurrentRow.Cells[1].Value.ToString();

           
        }
    }
}
