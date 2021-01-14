using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Restuarnt.PL;
using Restuarnt.DAL;
using DevExpress.XtraEditors.Controls;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace Restuarnt.PL
{
    public partial class Frm_MainNew : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private static Frm_MainNew farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_MainNew getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_MainNew();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;

            }
        }
        public Frm_MainNew()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
            txtDATETIME.Hide();
            txt_idLogin.Hide();
            Txt_IDUsers.Hide();
        }

     

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Bl.Login l = new Bl.Login();
            //txtDATETIME.Text = " الوقت:" + DateTime.Now.ToShortTimeString() + " / " + " التاريخ :" + DateTime.Now.ToShortDateString();
            //DataTable dt = new DataTable();
            //dt = l.SelectUsers();
            //Program.salesman = dt.Rows[0][0].ToString();
            //Txt_IDUsers.Text = Program.salesman;

            //txt_idLogin.Text = l.LastIDLogin().Rows[0][0].ToString();
            //l.ADDLogOut(Convert.ToInt32(txt_idLogin.Text), Txt_IDUsers.Text, txtDATETIME.Text);
            Application.Exit();
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }



    
   

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            barStaticItem1.Caption = Program.salesman;
        }
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            barCheckItem5.Caption = DateTime.Now.ToShortDateString();
            barCheckItem3.Caption = DateTime.Now.ToLongTimeString();
        }

        private void Btn_AddCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
          Frm_Category category = new Frm_Category();
            category.Show();
        }

        private void BtnAdd_Items_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Menu menu = new Frm_Menu();
            menu.Show();
        }

        private void Btn_AddTables_ItemClick(object sender, ItemClickEventArgs e)
        {
            Table table = new Table();
            table.Show();
        }

        private void Btn_AddDelivery_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DeliveryInformation frm_Delivery = new Frm_DeliveryInformation();
            frm_Delivery.Show();
        }

        private void Btn_AddCaptin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Stuff stuff = new Frm_Stuff();
            stuff.Show();
        }

        private void Btn_settingOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Setting setting = new Frm_Setting();
            setting.Show();
        }

        private void Btn_AddSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            FOrder Order = new FOrder();
            Order.Show();
        }

        private void Btn_OrderManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Frm_ManagmentOrder frm_ManagmentOrder = new Frm_ManagmentOrder();
            //frm_ManagmentOrder.Show();
            Sales_Management sales = new Sales_Management();
            sales.Show();
        }

        private void Btn_MoveItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_MovedItems frm_Moved = new Frm_MovedItems();
            frm_Moved.Show();
        }

        private void Btn_Masrofat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_RserveDetails d = new Frm_RserveDetails();
            d.Show();
        }

        private void Btn_reportmasrof_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_SearchReserve d = new Frm_SearchReserve();
            d.Show();
        }

        private void Btn_AddUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserManagment u = new UserManagment();
            u.ShowDialog();
        }

        private void btnBackUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            BackUp b = new BackUp();
            b.ShowDialog();
        }

        private void BtnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            Restore r = new Restore();
            r.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_UpdateOrrder uo = new Frm_UpdateOrrder();
            uo.Show();
        }

        private void Btn_UserPermession_ItemClick(object sender, ItemClickEventArgs e)
        {
            Validate_Users validate_Users = new Validate_Users();
            validate_Users.Show();
        }
    }
}