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
    public partial class Frm_DeliveryInformation : Form
    {
        Delivery d = new Delivery();

        public Frm_DeliveryInformation()
        {
            InitializeComponent();
            dataGridView1.DataSource = d.SelectDeliveryInformation();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_new.Hide();
            btn_save.Show();
            btn_delete.Hide();
        }
        void clears()
        {
            txt_phone.Text = "";
            txt_name.Text = "";
            txt_address.Text = "";
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_phone.Text.Length < 11 && txt_phone.Text != "")
                {
                    MessageBox.Show(" يرجي التاكد من رقم الهاتف لابد ان يكون (11) رقم");
                    txt_phone.Focus();
                }
                else if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الطيار");
                }
                else
                {


                    d.AddDeleiveryInformation(txt_name.Text, txt_address.Text, txt_phone.Text);
                    MessageBox.Show("تم اضافه الطيار بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clears();


                    dataGridView1.DataSource = d.SelectDeliveryInformation();

                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {

              
                if (txt_name.Text == "")
                {
                    MessageBox.Show("يرجي التاكد من اسم الطيار");
                }



                if (MessageBox.Show("هل تريد تعديل بيانات الطيار", "عمليه التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    d.UpdateDeleiveryInformation(txt_name.Text, txt_address.Text, txt_phone.Text, int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم تعديل بيانات الطيار بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clears();


                    dataGridView1.DataSource = d.SelectDeliveryInformation();
                  
                    btn_update.Enabled = false;
                    btn_save.Enabled = true;

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
    }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حذف الطيار", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                 
                    d.DeleteDelivery(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم مسح الطيار بنجاح", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.None);
                 
                   
                    dataGridView1.DataSource = d.SelectDeliveryInformation();
                    clears();
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه الحذف");
                    clears();
                }




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
          
                btn_save.Hide();
                btn_new.Show();
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }
        }
        private void Txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {

                e.Handled = true;


            }
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            clears();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_new.Hide();
            btn_save.Show();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_DeliveryInformation_Load(object sender, EventArgs e)
        {

        }
    } }
    
