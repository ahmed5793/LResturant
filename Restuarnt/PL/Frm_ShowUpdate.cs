using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Restuarnt.BL;
using Restuarnt.RPT;

namespace Restuarnt.PL
{
    public partial class Frm_ShowUpdate : Form
    {
        Category c = new Category();
        DataTable dt = new DataTable();
        public DataTable dt2 = new DataTable();


       public DataTable dt5 = new DataTable();
        Order o = new Order();
        BL.Menu m = new BL.Menu();
        Delivery d = new Delivery();
        Tables t = new Tables();
        Customer cu = new Customer();
        Stuff s = new Stuff();


        


        public Frm_ShowUpdate()
        {
            InitializeComponent();

           
            texT.Hide();
            SelectdataTable();


           

            ID_Dep.Visible = false;
            Dep.Visible = false;
            ID_Items.Visible = false;

            cmb_Table.DataSource = t.SelectTablesCompo();
            cmb_Table.DisplayMember = "Tables_Number";
            cmb_Table.ValueMember = "ID_Tables";





            //cmb_customer.Properties.DataSource = cu.SelectCompoCustomer();
            //cmb_customer.Properties.DisplayMember = "Client_Name";
            //cmb_customer.Properties.ValueMember = "Client_ID";

            cmb_stuff.DataSource = s.SelectStuuf();
            cmb_stuff.DisplayMember = "اسم الكابتن";
            cmb_stuff.ValueMember = "رقم الكابتن";


            //InformationClient();


            //textEdit1.Text = "";
            //txt_phones.Text = "";
            //txt_delivery.Enabled = false;
            //// btn_update.Hide();
            //textEdit1.Text = "";

        }



    

        public void SelectdataTable()
        {

            dt2.Columns.Add("رقم القسم");
            dt2.Columns.Add("القسم");
            dt2.Columns.Add("رقم الصنف");
            dt2.Columns.Add("اسم الصنف");


            dt2.Columns.Add("السعر");

            dt2.Columns.Add("الكمية");
            dt2.Columns.Add("الأجمالي");
            dt2.Columns.Add("زيادة");
            gridControl2.DataSource = dt2;








        }


        internal void totalInvoice()
        {
            decimal x = 0;

            for (int i = 0; i <= gridView2.RowCount - 1; i++)
            {
                DataRow row = gridView2.GetDataRow(i);
                x += Convert.ToDecimal(row[6]);

            }
            texT.Text = Math.Round(x, 2).ToString();


        }

        internal void totalProudect()
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {

                DataRow row = gridView2.GetDataRow(i);
                //        total += Convert.ToDecimal(row[1].ToString());
                decimal x = Convert.ToDecimal(row[4]) * Convert.ToDecimal(row[5]);
                row[6] = x.ToString();
            }
        }



        //internal void InformationClient()
        //{
        //    if (cmb_customer.Text != "")
        //    {



        //        dt = cu.SelectPhoneAdress(Convert.ToInt32(cmb_customer.EditValue));
        //        if (dt.Rows.Count > 0)
        //        {


        //            txt_phones.Text = dt.Rows[0][0].ToString();
        //            txt_address.Text = dt.Rows[0][1].ToString();
        //        }
        //        else
        //        {
        //            txt_phones.Text = "";
        //            txt_phones.Text = "";
        //        }
        //    }
        //}

        private void FOrder_Load(object sender, EventArgs e)
        {
       

           

            ButtonSelectCategory();


            txt_cust.Hide();
            txt_num.Hide();



            //rezizse();



            // grb_sala.Hide();




            

        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
               

        }

        private void Rdb_takeaway_CheckedChanged(object sender, EventArgs e)
        {


            if (rdb_takeaway.Checked == true)
            {

                grb_sala.Hide();
                grb_customer.Show();
            
                totalInvoice();
                txt_discount.Text = "0";
                textEdit1.Show();
                //cmb_customer.Hide();
                txt_phones.Enabled = false;
                textEdit1.Enabled = false;
                textEdit1.Text = "";
                txt_phones.Text = "";

                textEdit1.Text = "عميل نقدى";


                grb_sala.Hide();

                grb_delivry.Hide();
                txt_delivery.Enabled = false;
                txt_delivery.Text = "0";

            }
        }

        private void Rdb_delivery_CheckedChanged(object sender, EventArgs e)
        {

            //if (rdb_delivery.Checked == true)
            //{

            //    grb_sala.Hide();
            //    grb_customer.Show();
               
            //    cmb_customer.Properties.DataSource = cu.SelectCompoCustomer();
            //    cmb_customer.Properties.DisplayMember = "Client_Name";
            //    cmb_customer.Properties.ValueMember = "Client_ID";

            //    txt_discount.Text = "0";

            //    txt_delivery.Enabled = true;
            //    textEdit1.Hide();
            //    cmb_customer.Show();

            //    InformationClient();




            //    grb_sala.Hide();

            //    grb_delivry.Show();




            //    txt_phones.Enabled = false;
            //    textEdit1.Enabled = false;






            //    cmb_delivery.DataSource = d.SelectDeliverycomp();
            //    cmb_delivery.DisplayMember = "Name";
            //    cmb_delivery.ValueMember = "ID_Delivery";




            //}
        }

        private void Rdb_sala_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sala.Checked == true)
            {
      

                txt_discount.Text = "0";
                textEdit1.Text = "عميل نقدى";

                txt_delivery.Text = "0";
                totalInvoice();

                grb_customer.Hide();

                grb_sala.Show();


                grb_delivry.Hide();







                textEdit1.Show();
                //cmb_customer.Hide();
                txt_phones.Enabled = false;
                textEdit1.Enabled = false;
                textEdit1.Text = "";
                txt_phones.Text = "";

                txt_delivery.Text = "0";

                txt_delivery.Enabled = false;


                cmb_Table.DataSource = t.SelectTablesCompo();
                cmb_Table.DisplayMember = "Tables_Number";
                cmb_Table.ValueMember = "ID_Tables";








            }
        }

        private void ListBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {



        }

        private void ListBox2_MouseUp(object sender, MouseEventArgs e)
        {



        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void ListBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ListBox2_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void ListBox2_KeyDown(object sender, KeyEventArgs e)
        {
        }
        Frm_Prise p = new Frm_Prise();
        Frm_Quantity q = new Frm_Quantity();
        Frm_Notes n = new Frm_Notes();

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {






        }
        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totalInvoice();
            TOTALFINALYDISCOUNT();
            TOTALFINALYDELIVERY();

        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void DataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //InformationClient();
        }
        public void TOTALFINALYDELIVERY()
        {
            Decimal X = 0;
            Decimal TEXT;
            Decimal Y;
            if (txt_delivery.Text != "")
            {
                TEXT = Convert.ToDecimal(texT.Text) + Convert.ToDecimal(txt_delivery.Text) - Convert.ToDecimal(txt_discount.Text);
                txt_invo.Text = TEXT.ToString();


            }

            else
            {
                txt_delivery.Text = "0";
                Y = (Convert.ToDecimal(texT.Text) + X) - Convert.ToDecimal(txt_discount.Text);
                txt_invo.Text = Y.ToString();

            }
        }
        public void TOTALFINALYDISCOUNT()
        {
            Decimal X = 0;
            Decimal Y;
            Decimal TEXT;
            if (txt_discount.Text != "")
            {
                TEXT = (Convert.ToDecimal(texT.Text) + Convert.ToDecimal(txt_delivery.Text)) - Convert.ToDecimal(txt_discount.Text);
                txt_invo.Text = TEXT.ToString();



            }

            else
            {
                txt_discount.Text = "0";
                Y = (Convert.ToDecimal(texT.Text) + X) - Convert.ToDecimal(txt_discount.Text);
                txt_invo.Text = Y.ToString();
            }
        }

        private void Txt_invo_KeyUp(object sender, KeyEventArgs e)
        {



        }

        private void Txt_mark_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_mark_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Txt_pay_KeyUp(object sender, KeyEventArgs e)
        {



        }

        private void Txt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_delivery_KeyUp(object sender, KeyEventArgs e)
        {



        }

        private void Txt_delivery_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_delivery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_delivery.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }

        }

        private void Txt_invo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_delivery_Leave(object sender, EventArgs e)
        {
            if (txt_delivery.Text == "")
            {
                txt_delivery.Text = "0";
            }
        }

        private void Txt_pay_Leave(object sender, EventArgs e)
        {

        }





        public void clear()
        {
            txt_delivery.Text = "0";
            textEdit1.Text = "";

            //txt_pay.Text = "0";
            //txt_mark.Text = "0";
            txt_invo.Text = "0";
            txt_phones.Text = "";
            txt_delivery.Clear();
            Lable_Num.Text = "";
            rdb_takeaway.Checked = true;


            textEdit1.Text = "";






            dt2.Clear();









        }
        public void clear2()
        {

            grb_customer.Hide();
            grb_delivry.Hide();
            grb_customer.Enabled = true;
            grb_sala.Enabled = true;
            grb_delivry.Enabled = true;
            grb_sala.Show();
            rdb_sala.Checked = true;
            txt_delivery.Enabled = false;
            rdb_takeaway.Enabled = true;
            rdb_sala.Enabled = true;
            rdb_delivery.Enabled = true;
            txt_address.Text = "";
            textEdit1.Text = "";
            txt_phones.Text = "";
            txt_discount.Text = "0";
            flowLayoutPanel1.Enabled = true;
            flowLayoutPanel2.Enabled = true;
            dt2.Clear();
            txt_delivery.Text = "0";
            txt_invo.Text = "0";
            Lable_Num.Text = "";






        }



        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_new_Click(object sender, EventArgs e)
        {



        }



        private void DataGridView2_DoubleClick(object sender, EventArgs e)
        {




        }

        private void Rdb_totalSala_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rdb_TotalDelivery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Txt_delivery_Leave_1(object sender, EventArgs e)
        {
            if (txt_delivery.Text == "")
            {
                txt_delivery.Text = "0";
            }
        }



        private void Txt_delivery_KeyUp_1(object sender, KeyEventArgs e)
        {


            TOTALFINALYDELIVERY();

            TOTALFINALYDISCOUNT();



        }

        private void Btn_save_Click(object sender, EventArgs e)
        {


        }
        DataTable dt10 = new DataTable();
        private void Btn_update_Click(object sender, EventArgs e)
        {






        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rdb_TotalTakeAway_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rdb_totalTakeAway_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void Btn_pay_Click(object sender, EventArgs e)
        {
        }

        private void Btn_hold_Click(object sender, EventArgs e)
        {

        }
        void Enable()
        {


            flowLayoutPanel1.Enabled = false;
            flowLayoutPanel2.Controls.Clear();
          
            gridControl2.Enabled = false;

            //cmb_customer.Enabled = false;
            txt_delivery.Enabled = false;
            textEdit1.Enabled = false;
            txt_phones.Enabled = false;
            cmb_delivery.Enabled = false;
            cmb_Table.Enabled = false;
            rdb_delivery.Enabled = false;
            rdb_sala.Enabled = false;
            rdb_takeaway.Enabled = false;
            txt_discount.Enabled = false;
            textEdit1.Enabled = false;
        }


        private void Txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_discount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Txt_discount_Leave(object sender, EventArgs e)
        {
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
                //totalInvoice();
                //pay();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {

        }

        private void Txt_discount_KeyUp(object sender, KeyEventArgs e)
        {

            //Discount();





            TOTALFINALYDISCOUNT();
            TOTALFINALYDELIVERY();



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Frm_RserveDetails d = new Frm_RserveDetails();
            d.Show();
        }


        public void ButtonSelectCategory()
        {
            flowLayoutPanel1.Controls.Clear();


            dt = c.SelectCategoryCompo();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button();

                byte[] image = (byte[])dt.Rows[i][2];
                MemoryStream f = new MemoryStream(image);





                btn.Image = Image.FromStream(f);

                btn.Image = (Image)(new Bitmap(Image.FromStream(f), new Size(130, 60)));
                btn.ImageAlign = ContentAlignment.MiddleCenter;
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                // btn2.TextAlign = ContentAlignment.BottomCenter;





                btn.Name = "btn" + dt.Rows[i][0];
                btn.Tag = dt.Rows[i][0];
                btn.Text = dt.Rows[i][1].ToString();
                btn.Font = new Font("AL-Mateen", 24f, FontStyle.Bold);
                btn.UseCompatibleTextRendering = true;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.Yellow;
                btn.Height = 105;
                btn.Width = 150;

                btn.Click += items;

                flowLayoutPanel1.Controls.Add(btn);



            }

        }

        public void DataRow(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            Button btn2 = sender as Button;



            int quantity = 1;
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                DataRow row = gridView2.GetDataRow(i);
                if (btn2.Tag.ToString() == row[2].ToString())
                {
                    //MessageBox.Show("هذا الصنف متسجل حاليا");
                    //return;

                    row[5] = Convert.ToInt32(row[5]) + quantity;
                    totalProudect();
                    totalInvoice();
                    TOTALFINALYDELIVERY();
                    TOTALFINALYDISCOUNT();

                    Console.Beep();

                    return;

                }

            }




            DataRow r = dt2.NewRow();



            r[0] = btn.Tag;
            r[1] = btn.Text;
            r[2] = btn2.Tag;
            r[3] = btn2.Text;

            r[4] = m.PriceMenu(Convert.ToInt32(btn2.Tag)).Rows[0][0];
            r[5] = quantity;


            dt2.Rows.Add(r);
            Console.Beep();
            gridControl2.DataSource = dt2;


            ID_Dep.Visible = false;
            Dep.Visible = false;
            ID_Items.Visible = false;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            totalProudect();

            totalInvoice();

            TOTALFINALYDELIVERY();
            TOTALFINALYDISCOUNT();















        }
        public void items(object sender, EventArgs E)
        {
            try
            {
                flowLayoutPanel2.Controls.Clear();
                Button btn = sender as Button;




                dt = o.SelectCtegoryOrder(Convert.ToInt32(btn.Tag));


                // btn2.BackgroundImageLayout = ImageLayout.Stretch;
                //  btn2.Size = btn2.BackgroundImage.Size;
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    Button btn2 = new Button();

                    byte[] image = (byte[])dt.Rows[i][2];
                    MemoryStream f = new MemoryStream(image);





                    btn2.Image = Image.FromStream(f);

                    btn2.Image = (Image)(new Bitmap(Image.FromStream(f), new Size(162, 110)));
                    btn2.ImageAlign = ContentAlignment.MiddleCenter;
                    btn2.TextImageRelation = TextImageRelation.ImageAboveText;
                    // btn2.TextAlign = ContentAlignment.BottomCenter;





                    btn2.Name = "btn" + dt.Rows[i][0];
                    btn2.Tag = dt.Rows[i][0];
                    btn2.Text = dt.Rows[i][1].ToString();
                    btn2.Font = new Font("AL-Mateen", 15f, FontStyle.Bold);













                    btn2.UseCompatibleTextRendering = true;

                    btn2.BackColor = Color.Yellow;
                    btn2.ForeColor = Color.Black;

                    btn2.Height = 150;
                    btn2.Width = 190;


                    btn2.Click += DataRow;
                    flowLayoutPanel2.Controls.Add(btn2);


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void Txt_discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_printInvo_Click(object sender, EventArgs e)
        {
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {





        }

        private void TexT_KeyUp(object sender, KeyEventArgs e)
        {
            totalInvoice();
            TOTALFINALYDELIVERY();
            TOTALFINALYDISCOUNT();
        }

        private void Cmb_customer_Validated(object sender, EventArgs e)
        {

        }

        private void Cmb_customer_KeyDown(object sender, KeyEventArgs e)
        {
            //InformationClient();
        }

        private void Txt_phone_TextChanged(object sender, EventArgs e)
        {
        }

        private void Txt_phone_Validated(object sender, EventArgs e)
        {

        }

        private void Txt_phone_KeyDown(object sender, KeyEventArgs e)
        {




        }

        private void Txt_phone_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Txt_phone_Enter(object sender, EventArgs e)
        {


        }

        private void Txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '.' && txt_phones.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Txt_delivery_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Txt_delivery_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_discount_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Txt_delivery_Click(object sender, EventArgs e)
        {
            txt_delivery.SelectAll();
        }

        private void Txt_discount_Click(object sender, EventArgs e)
        {
            txt_discount.SelectAll();
        }

        private void DataGridViewRow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void DataGridViewRow_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_MouseLeave(object sender, EventArgs e)
        {



        }

        private void Txt_quantity_TextChanged(object sender, EventArgs e)
        {


        }

        private void Txt_quantity_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void DataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Txtq_TextChanged(object sender, EventArgs e)
        {

        }

        private void TexT_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DataGridView1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void DataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FOrder_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Rdb_TotalDelivery_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void TexT_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void FOrder_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {




        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }





        private void DataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grb_customer_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_customer_EditValueChanged(object sender, EventArgs e)
        {
            //InformationClient();
        }

        private void cmb_customer_KeyDown_1(object sender, KeyEventArgs e)
        {
           // InformationClient();
        }

        private void cmb_customer_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           // InformationClient();
        }

        private void cmb_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //InformationClient();
        }

        private void cmb_customer_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmb_customer_Leave(object sender, EventArgs e)
        {
            //InformationClient();
        }

        private void rdb_clientsave_CheckedChanged(object sender, EventArgs e)
        { 
        }

        private void rdb_newclient_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }
        Frm_Hold fh = new Frm_Hold();
        private void button2_Click(object sender, EventArgs e)
        {





        }

        private void FOrder_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void rdb_sala_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdb_sala.Checked == true)
            {


               
         




                cmb_Table.DataSource = t.SelectTablesCompo();
                cmb_Table.DisplayMember = "Tables_Number";
                cmb_Table.ValueMember = "ID_Tables";
                cmb_stuff.DataSource = s.SelectStuuf();
                cmb_stuff.DisplayMember = "اسم الكابتن";
                cmb_stuff.ValueMember = "رقم الكابتن";

              





            }
        }

        private void rdb_delivery_CheckedChanged_1(object sender, EventArgs e)
        {

            //if (rdb_delivery.Checked == true)
            //{

            //    grb_customer.Show();
            //    grb_delivry.Show();
            //    //cmb_customer.Properties.DataSource = cu.SelectCompoCustomer();
            //    //cmb_customer.Properties.DisplayMember = "Client_Name";
            //    //cmb_customer.Properties.ValueMember = "Client_ID";
            //    //cmb_customer.Text = "";
            //    txt_discount.Text = "0";
            //    textEdit1.Text = "";
            //    txt_phones.Text = "";
            //    txt_delivery.Enabled = true;



            //    txt_address.Text = "";
            //    textEdit1.Hide();




            //    //InformationClient();




            //    grb_sala.Hide();











            totalInvoice();
            cmb_delivery.DataSource = d.SelectDeliverycomp();
            cmb_delivery.DisplayMember = "Name";
            cmb_delivery.ValueMember = "ID_Delivery";




            //}
        }

        private void rdb_takeaway_CheckedChanged_1(object sender, EventArgs e)
        {

            //if (rdb_takeaway.Checked == true)
            //{
            //    txt_address.Text = "";
            //    //cmb_customer.Text = "";

            //    textEdit1.Hide();

            //    textEdit1.Text = "";
            //    txt_phones.Text = "";

            //    totalInvoice();
            //    txt_discount.Text = "0";
            //    // textBox12.Show();






            //    grb_sala.Hide();

            //    grb_delivry.Hide();
            //    txt_delivery.Enabled = false;
            //    txt_delivery.Text = "0";
            //    grb_customer.Show();

            //}
        }

        private void textBox12_MouseHover(object sender, EventArgs e)
        {


            textEdit1.Select();
            if (textEdit1.Text == "اسم العميل")
            {
                textEdit1.Text = "";

            }





        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {
                textEdit1.Text = "اسم العميل";

            }

        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {




        }

        private void txt_phones_MouseHover(object sender, EventArgs e)
        {
            txt_phones.Select();
            if (txt_phones.Text == "موبايل")
            {
                txt_phones.Text = "";
            }


        }

        private void txt_phones_Leave(object sender, EventArgs e)
        {
            if (txt_phones.Text == "")
            {


                txt_phones.Text = "موبايل";
            }
        }

        private void txt_phones_KeyDown(object sender, KeyEventArgs e)
        {




        }

        private void txt_address_MouseHover(object sender, EventArgs e)
        {
            textEdit1.Select();
            if (textEdit1.Text == "العنوان")
            {

            }
            textEdit1.Text = "";

        }

        private void txt_address_Leave(object sender, EventArgs e)
        {

            if (textEdit1.Text == "")
            {


                textEdit1.Text = "العنوان";
            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {





        }

        private void txt_phones_MouseLeave(object sender, EventArgs e)
        {
            if (txt_phones.Text == "")
            {


                txt_phones.Text = "موبايل";
            }
        }

        private void txt_phones_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_phones.Select();
            if (txt_phones.Text == "موبايل")
            {
                txt_phones.Text = "";
            }

        }

        private void txt_phones_MouseDown(object sender, MouseEventArgs e)
        {


            textEdit1.Select();


            if (txt_phones.Text == "موبايل")
            {


                txt_phones.Text = "";
            }

        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {

            textEdit1.Select();


            if (textEdit1.Text == "العنوان")
            {


                textEdit1.Text = "";
            }

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            textEdit1.Select();
            if (textEdit1.Text == "اسم العميل")
            {
                textEdit1.Text = "";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            clear2();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            fh.ShowDialog();


            if (fh.gridView2.RowCount > 0)
            {


                btn_update.Show();
                gridControl2.Enabled = true;



                rdb_sala.Enabled = false;
                rdb_takeaway.Enabled = false;

                btn_update.Show();
               


                txt_delivery.Show();

                cmb_delivery.Enabled = false;
                btn_update.Enabled = true;

                flowLayoutPanel1.Enabled = true;
                flowLayoutPanel2.Enabled = true;
                txt_discount.Enabled = true;


                if (fh.gridView2.GetFocusedRowCellValue("نوع الطلب").ToString() == "Delivery")
                {

                    rdb_delivery.Checked = true;
                    //cmb_customer.Hide();
                    //textEdit1.Show();

                    //textEdit1.Enabled = false;
                    //rdb_clientsave.Enabled = false;
                    //rdb_newclient.Enabled = false;


                    //txt_phones.Enabled = false;
                    //txt_address.Enabled = false;
                    grb_customer.Show();
                    grb_delivry.Show();
                    grb_customer.Enabled = false;
                    dt2.Clear();
                    dt2 = o.SELECTOrderDetails(Convert.ToInt32(fh.gridView2.GetFocusedRowCellValue("رقم الفاتورة")));

                    gridControl2.DataSource = dt2;

                    ID_Dep.Visible = false;
                    Dep.Visible = false;
                    ID_Items.Visible = false;


                    dt5.Clear();
                    dt5 = o.SELECTOrder(Convert.ToInt32(fh.gridView2.GetFocusedRowCellValue("رقم الفاتورة")));

                    foreach (DataRow dr in dt5.Rows)
                    {




                        Lable_Num.Text = dr[0].ToString();
                        txt_cust.Text = dr[1].ToString();
                        textEdit1.Text = dr[2].ToString();
                        txt_phones.Text = dr[3].ToString();
                        txt_address.Text = dr[4].ToString();
                        lable_date.Text = dr[5].ToString();

                        texT.Text = dr[6].ToString();

                        cmb_delivery.Text = dr[9].ToString();
                        txt_delivery.Text = dr[10].ToString();
                        txt_discount.Text = dr[11].ToString();



                    }









                }
                else if (fh.gridView2.GetFocusedRowCellValue("نوع الطلب").ToString() == "Table")
                {
                    cmb_stuff.Enabled = true;

                    //  rdb_delivery.Enabled = false;
                    //    cmb_delivery.Enabled = false;
                    //   txt_delivery.Enabled = false;
                    //  txt_phones.Enabled = false;
                    //  textEdit1.Enabled = false;
                    rdb_sala.Enabled = true;
                    //textEdit1.Enabled = false;
                    rdb_sala.Checked = true;
                    //  cmb_Table.Enabled = false;
                    grb_sala.Show();
                    grb_sala.Enabled = false;

                    dt2.Clear();
                    dt2 = o.SELECTOrderDetails(Convert.ToInt32(fh.gridView2.GetFocusedRowCellValue("رقم الفاتورة")));

                    gridControl2.DataSource = dt2;
                    ID_Items.Visible = false;
                    Dep.Visible = false;
                    ID_Items.Visible = false;

                    dt5.Clear();
                    dt5 = o.SELECTOrderSala(Convert.ToInt32(fh.gridView2.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow dr in dt5.Rows)
                    {



                        Lable_Num.Text = dr[0].ToString();
                        txt_cust.Text = dr[1].ToString();
                        textEdit1.Text = dr[2].ToString();

                        lable_date.Text = dr[3].ToString();


                        texT.Text = dr[4].ToString();
                        //txt_pay.Text = dr[5].ToString();
                        //txt_mark.Text = dr[6].ToString();
                        // cmb_Table.Text = dr[7].ToString();
                        cmb_Table.Text = dr[7].ToString();
                        txt_discount.Text = dr[8].ToString();
                        cmb_stuff.Text = dr[9].ToString();
                    }






                }
                else if (fh.gridView2.GetFocusedRowCellValue("نوع الطلب").ToString() == "Take away")
                {
                    //   rdb_delivery.Enabled = false;
                    rdb_takeaway.Checked = true;
                    rdb_takeaway.Enabled = true;
                    // txt_phones.Enabled = false;
                    // textEdit1.Enabled = false;
                    //   cmb_customer.Hide();
                    //  textEdit1.Show();
                    //textEdit1.Enabled = false;
                    grb_customer.Show();
                    grb_delivry.Hide();
                    grb_customer.Enabled = false;

                    dt2.Clear();
                    dt2 = o.SELECTOrderDetails(Convert.ToInt32(fh.gridView2.GetFocusedRowCellValue("رقم الفاتورة")));
                    gridControl2.DataSource = dt2;
                    ID_Items.Visible = false;
                    Dep.Visible = false;
                    ID_Items.Visible = false;
                    dt5.Clear();
                    dt5 = o.SELECTOrderTakwAway(Convert.ToInt32(fh.gridView2.GetFocusedRowCellValue("رقم الفاتورة")));

                    foreach (DataRow dr in dt5.Rows)
                    {



                        Lable_Num.Text = dr[0].ToString();
                        txt_cust.Text = dr[1].ToString();
                        textEdit1.Text = dr[2].ToString();

                        lable_date.Text = dr[3].ToString();

                        texT.Text = dr[4].ToString();

                        txt_discount.Text = dr[7].ToString();


                    }

                }
                totalInvoice();
                TOTALFINALYDELIVERY();
                TOTALFINALYDISCOUNT();
            }


        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {


        }

        private void simpleButton3_Click_2(object sender, EventArgs e)
        {

            try
            {



                //  ------------------------------------------------------------//
                o.Delete_ProdFromOrderDetails(Convert.ToInt32(Lable_Num.Text));
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRow row = gridView2.GetDataRow(i);
                    o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                       Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                }
                dt10.Clear();
                dt10 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
            Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text),dt10.Rows[0][11],Convert.ToInt32(txt_cust.Text));
                //  t.UpdateSala(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_Table.SelectedValue));
                MessageBox.Show("تم التعديل بنجاح");

                Frm_UpdateOrrder fop = new Frm_UpdateOrrder();

                fop.gridControl2.DataSource = o.SELECtALLORDER(DateTime.Now.Date, DateTime.Now.Date);




                //  -----------------------------------------------------------------------------------------
            }

            catch (Exception ex)
            {

               
                MessageBox.Show(ex.Message);
            }

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "btn")
            {



                int quantity = 1;
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRow row = gridView2.GetDataRow(i);
                    if (gridView2.GetFocusedRowCellValue("رقم الصنف").ToString() == row[2].ToString())
                    {


                        row[5] = Convert.ToInt32(row[5]) + quantity;
                        totalProudect();
                        totalInvoice();
                        TOTALFINALYDISCOUNT();
                        TOTALFINALYDELIVERY();
                        Console.Beep();

                        return;

                    }

                }

            }
            if (e.Column.FieldName == "post")
            {

                int quantity = 1;
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    DataRow row = gridView2.GetDataRow(i);

                    if (gridView2.GetFocusedRowCellValue("رقم الصنف").ToString() == row[2].ToString())
                    {

                        if (Convert.ToInt32(row[5]) == 1)
                        {
                            return;
                        }
                        row[5] = Convert.ToInt32(row[5]) - quantity;
                        totalProudect();
                        totalInvoice();
                        TOTALFINALYDISCOUNT();
                        TOTALFINALYDELIVERY();
                        Console.Beep();
                        return;

                    }

                }

            }
            if (e.Column.FieldName == "Remove")
            {



                if (MessageBox.Show("هل تريد مسح الصنف من الفاتورة", "عمليه المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    gridView2.DeleteRow(gridView2.FocusedRowHandle);

                    totalInvoice();
                    TOTALFINALYDISCOUNT();
                    TOTALFINALYDELIVERY();

                }

            }
        }


        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_DoubleClick(object sender, EventArgs e)
        {



        }

        private void repositoryItemButtonEdit1_ButtonClick_1(object sender, ButtonPressedEventArgs e)
        {




        }

        private void gridView2_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {

        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Frm_Hold fh = new Frm_Hold();
            fh.ShowDialog();
        }

        private void Frm_AnotherForm_Click(object sender, EventArgs e)
        {


          

        



        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    





