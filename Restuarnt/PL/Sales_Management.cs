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
    public partial class Validate_Users : Form
    {

        Order o = new Order();


        public Validate_Users()
        {
            InitializeComponent();
            selectUser();




        } 
        void selectUser()
        {
            try
            {

            //cmb_Users1.DataSource = l.SelectUsers();
            //cmb_Users1.DisplayMember = "اسم المستخدم";
            //cmb_Users1.ValueMember = "اسم المستخدم";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }


        private void Validate_Users_Load(object sender, EventArgs e)
        {
           
        }



        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {


                DataTable dt = new DataTable();
                if (Rdb_orders.Checked == true)
                {
                    //btn_PrintOrder.Hide();
                    //btn_report.Show();
                    dt = o.SearchMangmentOrders(FromDate.Value, ToDate.Value);
                    gridControl1.DataSource = dt;


                }
                else if (rdb_delivery.Checked == true)
                {
                
                    dt = o.SearchManamentTOrderDelivery(FromDate.Value, ToDate.Value);
                    gridControl1.DataSource = dt;

                   
                }
                else if (rdb_sala.Checked == true)
                {
                   
                    dt = o.SearchManagmentOrderSala(FromDate.Value, ToDate.Value);
                    gridControl1.DataSource = dt;

                }
                else if (rdb_takeaway.Checked == true)
                {                 
                    dt = o.SearchManagmentOrderTakwAway(FromDate.Value, ToDate.Value);
                    gridControl1.DataSource = dt;                   
                }
                decimal total = 0;
                for (int i = 0; i < gridView1.RowCount - 1; i++)
                {
                    DataRow r = gridView1.GetDataRow(i);
                    total += Convert.ToDecimal(r[3]);
                }
                txt_rent.Text = Math.Round(total, 1).ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
        }

        private void Cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {

          
        }

        private void cmb_Users1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
