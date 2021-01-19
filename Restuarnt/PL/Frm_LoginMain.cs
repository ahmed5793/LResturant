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
using System.Windows.Input;
using System.Data.SqlClient;
using System.IO;


namespace Restuarnt.PL
{
    public partial class Frm_LoginMain : DevExpress.XtraEditors.XtraForm
    {
        BL.Login l = new BL.Login();
        public Frm_LoginMain()
        {
            InitializeComponent();
            txt_User.Focus();
        }



        private void txt_User_Leave(object sender, EventArgs e)
        {

        }




        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          

        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {

        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Frm_MainNew fm = new Frm_MainNew();
        DataTable DT88 = new DataTable();
        private void bunifuThinButton2_Click(object sender, EventArgs e)
        {

        }

        DataTable dt2 = new DataTable();

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                dt2.Clear();
                dt2 = l.Select_UserPermession(Program.Id_USer);
                if (dt2.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(dt2.Rows[0][1]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_AddCategory.Enabled = false;
                        Frm_MainNew.getmain.item_Category.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][1]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_AddCategory.Enabled = true;
                        Frm_MainNew.getmain.item_Category.Enabled = true;
                    }
                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][2]) == 0)
                    {
                        Frm_MainNew.getmain.BtnAdd_Items.Enabled = false;
                        Frm_MainNew.getmain.Item_Proudct.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][2]) == 1)
                    {
                        Frm_MainNew.getmain.BtnAdd_Items.Enabled = true;
                        Frm_MainNew.getmain.Item_Proudct.Enabled = true;

                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][3]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_AddTables.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][3]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_AddTables.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][4]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_AddDelivery.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][4]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_AddDelivery.Enabled = true;
                    }
                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][5]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_AddCaptin.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][5]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_AddCaptin.Enabled = true;
                    }
                    //////////

                    if (Convert.ToInt32(dt2.Rows[0][6]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_settingOrder.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][6]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_settingOrder.Enabled = true;
                    }

                    //////

                    if (Convert.ToInt32(dt2.Rows[0][7]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_OrderManagement.Enabled = false;
                        Frm_MainNew.getmain.Item_Mangment.Enabled = false;

                    }
                    else if (Convert.ToInt32(dt2.Rows[0][7]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_OrderManagement.Enabled = true;
                        Frm_MainNew.getmain.Item_Mangment.Enabled = true;
                    }

                    /////////
                    if (Convert.ToInt32(dt2.Rows[0][8]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_AddOrder.Enabled = false;
                        Frm_MainNew.getmain.Item_Order.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][8]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_AddOrder.Enabled = true;
                        Frm_MainNew.getmain.Item_Order.Enabled = true;
                    }
                    ///////////
                    if (Convert.ToInt32(dt2.Rows[0][9]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_MoveItems.Enabled = false;
                        Frm_MainNew.getmain.Item_Move.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][9]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_MoveItems.Enabled = true;
                        Frm_MainNew.getmain.Item_Move.Enabled = true;
                    }

                    /////////

                    if (Convert.ToInt32(dt2.Rows[0][10]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_ReciveMoney.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][10]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_ReciveMoney.Enabled = true;
                    }
                    ////////

                    if (Convert.ToInt32(dt2.Rows[0][11]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_Masrofat.Enabled = false;
                        Frm_MainNew.getmain.item_Masrod.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][11]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_Masrofat.Enabled = true;
                        Frm_MainNew.getmain.item_Masrod.Enabled = true;
                    }

                    ///////
                    if (Convert.ToInt32(dt2.Rows[0][12]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_reportmasrof.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][12]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_reportmasrof.Enabled = true;
                    }
                    //////////

                    ///////////
                    if (Convert.ToInt32(dt2.Rows[0][13]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_AddUser.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][13]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_AddUser.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][14]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_UserPermession.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][14]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_UserPermession.Enabled = true;
                    }
                    //////
                    if (Convert.ToInt32(dt2.Rows[0][15]) == 0)
                    {
                        Frm_MainNew.getmain.btnBackUp.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][15]) == 1)
                    {
                        Frm_MainNew.getmain.btnBackUp.Enabled = true;
                    }
                    ////////
                    if (Convert.ToInt32(dt2.Rows[0][16]) == 0)
                    {
                        Frm_MainNew.getmain.BtnRestore.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][16]) == 1)
                    {
                        Frm_MainNew.getmain.BtnRestore.Enabled = true;
                    }

                    ///////////////////////
                    if (Convert.ToInt32(dt2.Rows[0][17]) == 0)
                    {
                        Frm_MainNew.getmain.Btn_UpdateOrder.Enabled = false;
                    }
                    else if (Convert.ToInt32(dt2.Rows[0][17]) == 1)
                    {
                        Frm_MainNew.getmain.Btn_UpdateOrder.Enabled = true;
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_LoginMain_Load(object sender, EventArgs e)
        {
            CreateDataBase();
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            //if (txt_Pass.Text != "PASSWORD")
            //{
            //    if (checkBox1.Checked == true)
            //    {
            //        checkBox1.Checked = false;
            //        txt_Pass.UseSystemPasswordChar = true;
            //    }


            //}
        }
        private bool CheckDataBase()
        {
          
          
            SqlConnection con = new SqlConnection(@" server =.;integrated security=true");

            SqlCommand cm = new SqlCommand("",con);
            SqlDataReader sdr;
            try
            {

                cm.CommandText = "exec sys.sp_databases";
            con.Open();
            sdr = cm.ExecuteReader();
            while (sdr.Read())
            {
                if (sdr.GetString(0)== "DB_A54A03_Resturant")
                {

                        return true;
                }
            }
            }
            catch (Exception)
            {

                return false;
            }
            con.Close();
            cm.Dispose();
            sdr.Dispose();


            return false;
        }
        private void CreateDataBase()
        {
            bool check = CheckDataBase();
            try
            {

           
            if (check==false)
            {
            

                var script = File.ReadAllText(Application.StartupPath + @"\scripts.sql");
                    var sqlQuary = script.Split(new[] {"GO"}, StringSplitOptions.RemoveEmptyEntries);
              
                    
                    var CONN = new SqlConnection(@"server =.;integrated security=true");
                    var cmd = new SqlCommand("query",CONN);
                    CONN.Open();
                    foreach (var query in sqlQuary)
                    {
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                    }
                    CONN.Close();
            }
            }
            catch (Exception)
            {

                
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {


                if (Properties.Settings.Default.ProudectKey == "NO")
                {
                    frm_SerielNumber FS = new frm_SerielNumber();
                    FS.ShowDialog();
                }
                else
                {





                    if (txt_User.Text == "")
                    {
                        MessageBox.Show("PLEASE INSERT USER NAME");
                        return;
                    }
                    if (txt_Pass.Text == "")
                    {
                        MessageBox.Show("PLEASE INSERT PASSWORD");
                        return;
                    }

                    else
                    {


                        DT88.Clear();
                        DT88 = l.Logins(txt_User.Text, txt_Pass.Text);

                        if (DT88.Rows.Count > 0)
                        {

                            backgroundWorker1.RunWorkerAsync();

                            Program.salesman = "";
                            Program.salesman = DT88.Rows[0][3].ToString();
                            Program.Id_USer = Convert.ToInt32(DT88.Rows[0][0]);
                            Console.Beep();
                            this.Hide();


                            fm.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect password or username");
                        }

                    }




                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void txt_Pass_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Pass_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {


                    if (Properties.Settings.Default.ProudectKey == "NO")
                    {
                        frm_SerielNumber FS = new frm_SerielNumber();
                        FS.ShowDialog();
                    }
                    else
                    {





                        if (txt_User.Text == "")
                        {
                            MessageBox.Show("PLEASE INSERT USER NAME");
                            return;
                        }
                        if (txt_Pass.Text == "")
                        {
                            MessageBox.Show("PLEASE INSERT PASSWORD");
                            return;
                        }

                        else
                        {


                            DT88.Clear();
                            DT88 = l.Logins(txt_User.Text, txt_Pass.Text);

                            if (DT88.Rows.Count > 0)
                            {

                                backgroundWorker1.RunWorkerAsync();

                                Program.salesman = "";
                                Program.salesman = DT88.Rows[0][3].ToString();
                                Program.Id_USer = Convert.ToInt32(DT88.Rows[0][0]);
                                Console.Beep();
                                this.Hide();


                                fm.ShowDialog();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect password or username");
                            }

                        }

                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void txt_User_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }

        private void txt_Pass_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
        }

        private void txt_Pass_MouseClick_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Pass_Properties_Click(object sender, EventArgs e)
        {

        }

        private void txt_Pass_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton4_MouseHover(object sender, EventArgs e)
        {
            txt_Pass.Properties.PasswordChar =  '\0' ;
            txt_Pass.Properties.UseSystemPasswordChar = false;
        }

        private void simpleButton4_MouseLeave(object sender, EventArgs e)
        {
            txt_Pass.Properties.PasswordChar =  '*';
            txt_Pass.Properties.UseSystemPasswordChar = true;
            //txt_Pass.Properties.PasswordChar = checkBox1.Checked ? '\0' : '*';
            //txt_Pass.Properties.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
    }
