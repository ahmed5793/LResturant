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
using Restuarnt.pl;
using System.Data.SqlClient;

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
            //if (Properties.Settings.Default.BackupPath != "")
            //{

                
            //     string fileName = Properties.Settings.Default.BackupPath + "\\DB_A54A03_Resturant " + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
            //    string sqlQuary = "BackUp Database DB_A54A03_Resturant to Disk= '" + fileName + ".bak '";
               
            //    cmd = new SqlCommand(sqlQuary, con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    //MessageBox.Show("تم إنشاء نسخة إحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //this.Close();

            //}
            
            Application.Exit();
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Properties.Settings.Default.BackupPath != "")
            {

                SqlConnection con = new SqlConnection(@" server =.; database=DB_A54A03_Resturant;integrated security=true");
                SqlCommand cmd;
                string fileName = Properties.Settings.Default.BackupPath + "\\DB_A54A03_Resturant " + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string sqlQuary = "BackUp Database DB_A54A03_Resturant to Disk= '" + fileName + ".bak '";

                cmd = new SqlCommand(sqlQuary, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("تم إنشاء نسخة إحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();

            }
        }



    
   

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            barCheckItem1.Caption= Program.salesman;
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
            Frm_Tables table = new Frm_Tables();
            table.Show();
        }

        private void Btn_AddDelivery_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DeliveryInformations frm_Delivery = new Frm_DeliveryInformations();
            frm_Delivery.Show();
        }

        private void Btn_AddCaptin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_AddStuff stuff = new frm_AddStuff();
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
            Frm_Masrofat d = new Frm_Masrofat();
            d.Show();
        }

        private void Btn_reportmasrof_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ManagmentMasrofat mm = new Frm_ManagmentMasrofat();
            mm.Show();
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

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void Btn_ReciveMoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ReportDelete rd = new Frm_ReportDelete();
            rd.Show();
        }

        private void Frm_MainNew_Load(object sender, EventArgs e)
        {
            barCheckItem1.Caption = Program.salesman.ToString();

        }

       

        private void tileItem15_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_MovedItems frm_Moved = new Frm_MovedItems();
            frm_Moved.Show();
        }

        private void tileItem16_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Masrofat d = new Frm_Masrofat();
            d.Show();
        }

        private void tileItem17_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Category category = new Frm_Category();
            category.Show();
        }

        private void tileItem18_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Sales_Management sales = new Sales_Management();
            sales.Show();
        }

        private void tileItem19_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Frm_Menu menu = new Frm_Menu();
            menu.Show();
        }

        private void tileItem14_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FOrder Order = new FOrder();
            Order.Show();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_DetailsPhone dp = new Frm_DetailsPhone();
                dp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            Serila.About ab = new Serila.About();
            ab.ShowDialog();
        }
    }
}