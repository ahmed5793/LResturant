using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restuarnt.Bl;
namespace Restuarnt.PL
{
    public partial class Validate_Users : Form
    {
        //Frm_Main Frm = new Frm_Main();
     
        BL.Login l = new BL.Login();
        DataTable dt = new DataTable();
        DataTable dt10 = new DataTable();
        DataTable dt2 = new DataTable();

        

        public Validate_Users()
        {
            InitializeComponent();
            selectUser();




        } 
        void selectUser()
        {
            try
            {

            cmb_Users1.DataSource = l.SelectComboUsers();
            cmb_Users1.DisplayMember = "UserName";
            cmb_Users1.ValueMember = "ID_User";
                cmb_Users1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void cmb_Users1_SelectionChangeCommitted(object sender, EventArgs e)
        {          
            try
            {
                if (cmb_Users1.Text != "")
                {



                    dt2.Clear();
                    dt2 = l.Select_UserPermession(Convert.ToInt32(cmb_Users1.SelectedValue));
                    if (dt2.Rows.Count >= 1)
                    {
                        if (Convert.ToInt32(dt2.Rows[0][1]) == 0) { check_AddCategory.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][1]) == 1) { check_AddCategory.Checked = true; }
                        ///////
                        if (Convert.ToInt32(dt2.Rows[0][2]) == 0) { Check_AddItem.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][2]) == 1) { Check_AddItem.Checked = true; }
                        ////////
                        if (Convert.ToInt32(dt2.Rows[0][3]) == 0) { check_AddTable.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][3]) == 1) { check_AddTable.Checked = true; }
                        ///////
                        if (Convert.ToInt32(dt2.Rows[0][4]) == 0) { Check_AddDelivery.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][4]) == 1) { Check_AddDelivery.Checked = true; }
                        /////////

                        if (Convert.ToInt32(dt2.Rows[0][5]) == 0) { check_AddCaptin.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][5]) == 1) { check_AddCaptin.Checked = true; }
                        /////////
                        ///
                        if (Convert.ToInt32(dt2.Rows[0][6]) == 0) { Check_SettingOrder.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][6]) == 1) { Check_SettingOrder.Checked = true; }
                        /////////

                        if (Convert.ToInt32(dt2.Rows[0][7]) == 0) { Check_ManagementOrder.Checked = false; }

                        else if (Convert.ToInt32(dt2.Rows[0][7]) == 1) { Check_ManagementOrder.Checked = true; }
                        ///////
                        if (Convert.ToInt32(dt2.Rows[0][8]) == 0) { check_Order.Checked = false; }

                        else if (Convert.ToInt32(dt2.Rows[0][8]) == 1) { check_Order.Checked = true; }
                        ////////
                        if (Convert.ToInt32(dt2.Rows[0][9]) == 0) { Check_MoveItem.Checked = false; }

                        else if (Convert.ToInt32(dt2.Rows[0][9]) == 1) { Check_MoveItem.Checked = true; }

                        /////////
                        if (Convert.ToInt32(dt2.Rows[0][10]) == 0) { check_UpdateOrders.Checked = false; }

                        else if (Convert.ToInt32(dt2.Rows[0][10]) == 1) { check_UpdateOrders.Checked = true; }
                        ///////
                        if (Convert.ToInt32(dt2.Rows[0][11]) == 0) { check_AddMasrof.Checked = false; }

                        else if (Convert.ToInt32(dt2.Rows[0][11]) == 1) { check_AddMasrof.Checked = true; }
                        //////////

                        if (Convert.ToInt32(dt2.Rows[0][12]) == 0) { check_ReportMasrofat.Checked = false; }

                        else if (Convert.ToInt32(dt2.Rows[0][12]) == 1) { check_ReportMasrofat.Checked = true; }
                        ////////

                        if (Convert.ToInt32(dt2.Rows[0][13]) == 0) { check_AddUser.Checked = false; }

                        else if (Convert.ToInt32(dt2.Rows[0][13]) == 1) { check_AddUser.Checked = true; }
                        /////////

                        if (Convert.ToInt32(dt2.Rows[0][14]) == 0) { check_Permession.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][14]) == 1) { check_Permession.Checked = true; }
                        ///////
                        if (Convert.ToInt32(dt2.Rows[0][15]) == 0) { check_BAckUp.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][15]) == 1) { check_BAckUp.Checked = true; }
                        ////////
                        if (Convert.ToInt32(dt2.Rows[0][16]) == 0) { check_Restore.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][16]) == 1) { check_Restore.Checked = true; }

                        ////////////

                        if (Convert.ToInt32(dt2.Rows[0][17]) == 0) { check_DeletedOrder.Checked = false; }
                        else if (Convert.ToInt32(dt2.Rows[0][17]) == 1) { check_DeletedOrder.Checked = true; }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }


        private void Validate_Users_Load(object sender, EventArgs e)
        {
           
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Users1.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد إسم المستخدم");
                    return;
                }
                else
                {
                    int AddCategory = 0, AddItem = 0, AddTable = 0, AddDelivery = 0, AddCaptin = 0
                        ,SettingOrder=0, order=0,orderManagement=0 , MoveProduct=0,RecieveMoney=0,AddMasrof=0,ReportMasrofat=0
                       ,AddUser=0 , Permesion=0,BackUp=0,Restore=0,permession_Update=0,permession_Delete=0;

                    if (check_AddCategory.Checked == true){ AddCategory = 1;}
                    else if (check_AddCategory.Checked == false){ AddCategory = 0;}
                    //////
                    if (Check_AddItem.Checked == true){ AddItem = 1;}
                    else if (Check_AddItem.Checked == false){ AddItem = 0;}
                    //////
                    if (check_AddTable.Checked == true){ AddTable = 1;}
                    else if (check_AddTable.Checked == false){ AddTable = 0;}
                    //////
                    if (Check_AddDelivery.Checked == true){ AddDelivery = 1;}
                    else if (Check_AddDelivery.Checked == false){ AddDelivery = 0;}


                    if (check_AddCaptin.Checked == true) { AddCaptin = 1; }
                    else if (check_AddCaptin.Checked == false) { AddCaptin = 0; }

                    if (Check_SettingOrder.Checked == true) { SettingOrder = 1; }
                    else if (Check_SettingOrder.Checked == false) { SettingOrder = 0; }


                    if (Check_ManagementOrder.Checked == true) { orderManagement = 1; }
                    else if (Check_ManagementOrder.Checked == false) { orderManagement = 0; }


                    if (check_Order.Checked == true) { order = 1; }
                    else if (check_Order.Checked == false) { order = 0; }


                    if (Check_MoveItem.Checked == true) { MoveProduct = 1; }
                    else if (Check_MoveItem.Checked == false) { MoveProduct = 0; }


                    if (check_UpdateOrders.Checked == true) { RecieveMoney = 1; }
                    else if (check_UpdateOrders.Checked == false) { RecieveMoney = 0; }


                    if (check_AddMasrof.Checked == true) { AddMasrof = 1; }
                    else if (check_AddMasrof.Checked == false) { AddMasrof = 0; }


                    if (check_ReportMasrofat.Checked == true) { ReportMasrofat = 1; }
                    else if (check_ReportMasrofat.Checked == false) { ReportMasrofat = 0; }


                    if (check_AddUser.Checked == true) { AddUser = 1; }
                    else if (check_AddUser.Checked == false) { AddUser = 0; }


                    if (check_Permession.Checked == true) { Permesion = 1; }
                    else if (check_Permession.Checked == false) { Permesion = 0; }


                    if (check_BAckUp.Checked == true) { BackUp = 1; }
                    else if (check_BAckUp.Checked == false) { BackUp = 0; }



                    if (check_Restore.Checked == true) { Restore = 1; }
                    else if (check_Restore.Checked == false) { Restore = 0; }



                    if (check_DeletedOrder.Checked == true) { permession_Update = 1; }
                    else if (check_DeletedOrder.Checked == false) { permession_Update = 0; }

                    l.Update_UserPermession(Convert.ToInt32(cmb_Users1.SelectedValue), AddCategory, AddItem, AddTable, AddDelivery, 
                        AddCaptin, SettingOrder, orderManagement,order,MoveProduct, RecieveMoney, AddMasrof, ReportMasrofat, AddUser,
                        Permesion, BackUp, Restore, permession_Update, permession_Delete);

                    MessageBox.Show(" تم حفظ الصلاحيات للمستخدم");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }









    }
}
