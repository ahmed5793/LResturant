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
    public partial class Login : Form
    {
      BL.Login l = new BL.Login();
        public Login()
        {
            InitializeComponent();
           
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {

            Frm_Main fm = new Frm_Main();
            try
            {
                if (Txt_name.Text=="")
                {
                    MessageBox.Show("من فضلك قم باادخال اسم المستخدم");
                    return;
                }
              else  if (Txt_Pass.Text == "")
                {
                    MessageBox.Show("من فضلك قم باادخال الباسورد");
                    return;
                }
                else
                {



                    DataTable dt = l.Logins(Txt_name.Text, Txt_Pass.Text);

                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][2].ToString() == "ADMIN")
                        {

                            Program.salesman = dt.Rows[0]["FullName"].ToString();





                           

                            Console.Beep();

                            this.Hide();
                            fm.ShowDialog();






                        }
                        else if (dt.Rows[0][2].ToString() == "SALES")
                        {




                            fm.المنتجاتToolStripMenuItem.Enabled = false;
                            fm.الملفاتToolStripMenuItem.Enabled = true;
                            fm.انشاءنسخهاحتياطيهللبرنامجToolStripMenuItem.Enabled = false;
                            fm.استرجاعنسخهاحتياطيهToolStripMenuItem.Enabled = false;
                            fm.المستخدمونToolStripMenuItem.Enabled = false;
                            fm.المبيعاتToolStripMenuItem.Enabled = true;
                            fm.ادارةالمبيعاتToolStripMenuItem.Enabled = false;

                            fm.فاتورةمبيعاتToolStripMenuItem.Enabled = true;

                          

                            Program.salesman = dt.Rows[0]["FullName"].ToString();



                            this.Hide();
                            fm.ShowDialog();



                            Console.Beep();




                        }
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم او كلمه المرور غير صحيحه");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
