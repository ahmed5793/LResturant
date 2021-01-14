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
    public partial class UserManagment : Form
    {
        BL.Login l = new BL.Login();
        DataTable dt2 = new DataTable();
        public UserManagment()
        {
            InitializeComponent();

      
         
            dataGridViewList.DataSource = l.SelectUsers();
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

        }

        void delete()
        {
            txt_Fullname.Text = "";
            txt_User.Text = "";
            txt_Pass.Text = "";
            txt_PassRealy.Text = "";
            Txt_IdUser.Text = "";
            


        }

        private void UserManagment_Load(object sender, EventArgs e)
        {

        }

        private void Btn_save_Click(object sender, EventArgs e)
        {

            
         
            dt2 = l.vidldateUser(txt_User.Text);

            try
            {



                if (dt2.Rows.Count > 0)
                {
                    MessageBox.Show("من فضلك اسم المستخدم موجود مسبقا");
                    txt_User.Focus();
                    return;

                }
                if (txt_User.Text == string.Empty || txt_Pass.Text == string.Empty ||
                    txt_PassRealy.Text == string.Empty || txt_Fullname.Text == string.Empty)
                {
                    MessageBox.Show("من فضلك ادخل البيانات كامله");
                    return;

                }

                if (txt_Pass.Text != txt_PassRealy.Text)
                {
                    MessageBox.Show("كلمه السر غير متطابقه");
                    txt_PassRealy.Focus();

                    return;
                }
                dt2.Clear();
                dt2 = l.AddUser(txt_User.Text, txt_Pass.Text, txt_Fullname.Text, "true");
                int x = Convert.ToInt32(dt2.Rows[0][0]);
                l.Add_UserPermession(x,1,1,1,1,1,1,1,1,1,1);
                l.Add_UserPermession(1,1,1,1,1,1,1,1);
                MessageBox.Show("تم اضافه المستخدم بنجاح");
                dataGridViewList.DataSource = l.SelectUsers();
                txt_Fullname.Text = "";
                txt_Pass.Text = "";
                txt_PassRealy.Text = "";
                txt_User.Text = "";

                txt_Fullname.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



        }

        private void Txt_PassRealy_Validated(object sender, EventArgs e)
        {
            if (txt_Pass.Text != txt_PassRealy.Text)
            {
                MessageBox.Show("كلمه السر غير متطابقه");

                return;

            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {

            try
            {
               

                if (txt_Pass.Text == "")
                {
                    MessageBox.Show("يرجى كتابة الباسورد");
                    txt_Pass.Focus();
                }
                else if (MessageBox.Show("هل تريد تعديل بيانات المستخدم", "تعديل بيانات المستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txt_Pass.Text != txt_PassRealy.Text)
                    {
                        MessageBox.Show("كلمه السر غير متطابقه");
                        return;

                    }
                    l.UpdateUsers(Convert.ToInt32(Txt_IdUser.Text),txt_User.Text, txt_Pass.Text);
                    MessageBox.Show("تم التعديل بنجاح", "تعديل بيانات المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dataGridViewList.DataSource = l.SelectUsers();

                    delete();
                    btn_save.Enabled = true;
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    txt_Fullname.Enabled = true;
                    txt_User.Enabled = true;


                }

                else
                {
                    MessageBox.Show("لم يتم التعديل ", "تعديل بيانات المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    delete();
                    btn_save.Enabled = true;
                    btn_delete.Enabled = false;
                    btn_update.Enabled = false;
                    txt_Fullname.Enabled = true;
                    txt_User.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewList_DoubleClick(object sender, EventArgs e)
        {
            Txt_IdUser.Text = dataGridViewList.CurrentRow.Cells[0].Value.ToString();
            txt_User.Text = dataGridViewList.CurrentRow.Cells[1].Value.ToString();
            txt_Pass.Text = dataGridViewList.CurrentRow.Cells[2].Value.ToString();
            txt_Fullname.Text = dataGridViewList.CurrentRow.Cells[3].Value.ToString();
            txt_PassRealy.Text = txt_Pass.Text;
            txt_Fullname.Enabled = false;
            txt_User.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (MessageBox.Show("هل تريد مسح هذا المستخدم", "عملية مسح مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    l.deleteusers(Convert.ToInt32(Txt_IdUser.Text));
                    MessageBox.Show("تم مسح المستخدم بنجاح", "عملية مسح مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewList.DataSource = l.SelectUsers();
                    delete();
                    btn_update.Enabled = false;
                    btn_save.Enabled = true;
                    btn_delete.Enabled = false;
                    txt_Fullname.Enabled = true;
                    txt_Pass.Enabled = true;
                    txt_PassRealy.Enabled = true;
                    txt_User.Enabled = true;
                }
                else
                {
                    MessageBox.Show("لم يتم مسح المستخدم", "عملية مسح مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    delete();
                    btn_update.Enabled = false;
                    btn_save.Enabled = true;
                    btn_delete.Enabled = false;
                    txt_Fullname.Enabled = true;
                    txt_Pass.Enabled = true;
                    txt_PassRealy.Enabled = true;
                    txt_User.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_PassRealy_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
