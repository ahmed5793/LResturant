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
using Restuarnt.PL;
using System.Data.SqlClient;

namespace Restuarnt.PL
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            label6.Text = Program.salesman;
        }

        private void اضافهمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Menu m = new Frm_Menu();
            m.ShowDialog();
        }

        private void المصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

        }

        private void الاقسامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Category c = new Frm_Category();
            c.ShowDialog();
        }

        private void فاتورةمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FOrder f = new FOrder();
            f.ShowDialog();
        }

        private void ادارةالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RserveDetails d = new Frm_RserveDetails();
            d.Show();
        }

        private void ادارةالمصروفاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void اضافهطاولهToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PL.Table  t = new Table ();
            t.ShowDialog();
        }

        private void اضافهدليفرىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DeliveryInformation di = new Frm_DeliveryInformation();
            di.ShowDialog();
        }
        SqlConnection con = new SqlConnection(@" server =. ; database=Restuarnt;integrated security=true");
        
        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("هل تريد اخذ نسخه احتياطيه للبرنامج", "النسخه الاحتاطية", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {



                    string x = "D:\\backup\\Restuarnt" + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');

                    string str1 = "BACKUP DATABASE Restuarnt TO DISK = '" + x + ".Bak'";

                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    con.Open();

                    cmd2.ExecuteNonQuery();


                    MessageBox.Show("تم إنشاء نسخة إحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            Application.Exit();

        }

        private void انشاءنسخهاحتياطيهللبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUp b = new BackUp();
            b.ShowDialog();
        }

        private void استرجاعنسخهاحتياطيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore r = new Restore();
            r.ShowDialog();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ManagmentOrder m = new Frm_ManagmentOrder();
            m.Show();
        }

        private void اضافهمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagment u = new UserManagment();
            u.ShowDialog();

        }

        private void ادارةالمصروفاتToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frm_SearchReserve d = new Frm_SearchReserve();
            d.Show();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void حركهالانصافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MovedItems mv = new Frm_MovedItems();
            mv.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToShortDateString();
        }

        private void المصروفاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void فاتورةالمدخلاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Phrchise p = new Frm_Phrchise();
            p.ShowDialog();
        }

        private void ادارةالمدخلاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ManagmentProdect p = new Frm_ManagmentProdect();
            p.ShowDialog();
 ;        }

        private void ادارةالمدخلاتToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_managmentPHrchise h = new Frm_managmentPHrchise();
            h.ShowDialog();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void اضافةكابتنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Stuff fs = new Frm_Stuff();
            fs.ShowDialog();
        }

        private void ادارةالكابتنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ReportStuff rs = new frm_ReportStuff();
            rs.Show();
        }

        private void الايراداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReportIncome ri = new Frm_ReportIncome();
            ri.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Frm_Hold hf = new Frm_Hold();
            hf.Show();
        }
    }
}
