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
using DevExpress.Charts.Native;
using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
using Restuarnt.BL;
using Restuarnt.RPT.Exstra_Report;

namespace Restuarnt.PL
{
    public partial class FOrder : Form
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

        void RdbTackAway()
        {
            if (rdb_takeaway.Checked == true)
            {
                grb_customer.Show();

                cmb_customer.Properties.DataSource = cu.SelectCompoCustomer();
                cmb_customer.Properties.DisplayMember = "Client_Name";
                cmb_customer.Properties.ValueMember = "Client_ID";
                InformationClient();

                txt_address.Text = "";
                cmb_customer.Text = "";

                rdb_clientsave.Checked = true;
                textEdit1.Hide();
                cmb_customer.Show();
                textEdit1.Text = "";
                txt_phones.Text = "";

                totalInvoice();
                txt_discount.Text = "0";
                // textBox12.Show();

                grb_sala.Hide();

                grb_delivry.Hide();
                txt_delivery.Enabled = false;
                txt_delivery.Text = "0";
                textEdit1.Text = "";

            }
        }

        void RdbDelivery()
        {
            if (rdb_delivery.Checked == true)
            {

                grb_customer.Show();
                grb_delivry.Show();

                rdb_clientsave.Checked = true;
                cmb_customer.Properties.DataSource = cu.SelectCompoCustomer();
                cmb_customer.Properties.DisplayMember = "Client_Name";
                cmb_customer.Properties.ValueMember = "Client_ID";
                 
                cmb_customer.Text = "";
                txt_discount.Text = "0";
                textEdit1.Text = "";
                txt_phones.Text = "";
                txt_delivery.Enabled = true;
                txt_address.Text = "";
                textEdit1.Hide();
                cmb_customer.Show();
                txt_delivery.Text = Properties.Settings.Default.DeliveryService.ToString();

                InformationClient();

                grb_sala.Hide();
                totalInvoice();
                cmb_delivery.DataSource = d.SelectDeliverycomp();
                cmb_delivery.DisplayMember = "Name";
                cmb_delivery.ValueMember = "ID_Delivery";
                cmb_delivery.SelectedIndex = -1;

            }
        }

        void RdbSala()
        {
            if (rdb_sala.Checked == true)
            {


                txt_discount.Text = "0";

                cmb_customer.Text = "";
                txt_delivery.Text = "0";
                totalInvoice();

                grb_customer.Hide();

                grb_sala.Show();

                grb_delivry.Hide();

                txt_address.Text = "";

                textEdit1.Text = "";
                txt_phones.Text = "";

                txt_delivery.Text = "0";

                txt_delivery.Enabled = false;


                cmb_Table.DataSource = t.SelectTablesCompo();
                cmb_Table.DisplayMember = "Tables_Number";
                cmb_Table.ValueMember = "ID_Tables";

                cmb_stuff.DataSource = s.SelectStuuf();
                cmb_stuff.DisplayMember = "اسم الكابتن";
                cmb_stuff.ValueMember = "رقم الكابتن";
            }

        }
        private static FOrder farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static FOrder getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new FOrder();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }

        public FOrder()
        {
            InitializeComponent();

            if (farm == null)
            {
                farm = this;
            }

            texT.Hide();
            SelectdataTable();
            if (Properties.Settings.Default.OrderType=="صالة")
            {
                rdb_sala.Checked = true;
                RdbSala();
            }
            if (Properties.Settings.Default.OrderType == "دليفرى")
            {
                rdb_delivery.Checked = true;
                RdbDelivery();
            }
            if (Properties.Settings.Default.OrderType== "تيك اواى")
            {
                rdb_takeaway.Checked = true;
                RdbTackAway();
            }

            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;

            ID_Dep.Visible = false;
            Dep.Visible = false;
            ID_Items.Visible = false;

          //  txt_delivery.Enabled = false;

        }



        //public void rezizse()
        //{

        //    dataGridView1.RowHeadersWidth = 20;


        //    dataGridView1.Columns[3].Width = 180;
        //    dataGridView1.Columns[4].Width = 90;
        //    dataGridView1.Columns[5].Width = 90;

        //    dataGridView1.Columns[6].Width = 100;
        //}

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

        internal void InformationClient()
        {
            if (cmb_customer.Text != "")
            {
                dt = cu.SelectPhoneAdress(Convert.ToInt32(cmb_customer.EditValue));
                if (dt.Rows.Count > 0)
                {
                    txt_phones.Text = dt.Rows[0][0].ToString();
                    txt_address.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    txt_phones.Text = "";
                    txt_address.Text = "";
                }
            }
        }

        private void FOrder_Load(object sender, EventArgs e)
        {
           

            dt.Clear();
            dt = o.SELECTOrderRentALLORDER();
          
            simpleButton4.Text = $"({dt.Rows.Count}) الفواتير المتعلقة";
            ButtonSelectCategory();
            txt_cust.Hide();
            txt_num.Hide();
        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //lable_Timer.Text = DateTime.Now.ToLongTimeString();
            lable_date.Text = DateTime.Now.ToShortDateString() + "     " + DateTime.Now.ToLongTimeString();
        }
        private void Rdb_takeaway_CheckedChanged(object sender, EventArgs e)
        {        
        }
        private void Rdb_delivery_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void Rdb_sala_CheckedChanged(object sender, EventArgs e)
        {
        }
     

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totalInvoice();
            TOTALFINALYDISCOUNT();
            TOTALFINALYDELIVERY();

        }
        private void Cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            InformationClient();
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


        private void Txt_delivery_Leave(object sender, EventArgs e)
        {
            if (txt_delivery.Text == "")
            {
                txt_delivery.Text = "0";
            }
        }

        public void clear()
        {
            txt_delivery.Text = "0";
            timer1.Enabled = true;
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
            dt.Clear();
            dt = o.SELECTOrderRentALLORDER();
            simpleButton4.Text = $"({dt.Rows.Count}) الفواتير المتعلقة";
            if (Properties.Settings.Default.OrderType == "صالة")
            {
                rdb_sala.Checked = true;
                RdbSala();
            }
            if (Properties.Settings.Default.OrderType == "دليفرى")
            {
                rdb_delivery.Checked = true;
                RdbDelivery();
            }
            if (Properties.Settings.Default.OrderType == "تيك اواى")
            {
                rdb_takeaway.Checked = true;
                RdbTackAway();
            }
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
      
        DataTable dt10 = new DataTable();

        void Enable()
        {


            flowLayoutPanel1.Enabled = false;
            flowLayoutPanel2.Controls.Clear();
            btn_hold.Enabled = false;
            gridControl2.Enabled = false;

            cmb_customer.Enabled = false;
            txt_delivery.Enabled = false;
            textEdit1.Enabled = false;
            txt_phones.Enabled = false;
            cmb_delivery.Enabled = false;
            cmb_Table.Enabled = false;
            rdb_delivery.Enabled = false;
            rdb_sala.Enabled = false;
            rdb_takeaway.Enabled = false;
            timer1.Enabled = false;
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
        private void TexT_KeyUp(object sender, KeyEventArgs e)
        {
            totalInvoice();
            TOTALFINALYDELIVERY();
            TOTALFINALYDISCOUNT();
        }
        private void Cmb_customer_KeyDown(object sender, KeyEventArgs e)
        {
            InformationClient();
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

        private void Txt_delivery_Click(object sender, EventArgs e)
        {
            txt_delivery.SelectAll();
        }

        private void Txt_discount_Click(object sender, EventArgs e)
        {
            txt_discount.SelectAll();
        }


        private void cmb_customer_EditValueChanged(object sender, EventArgs e)
        {
            InformationClient();
        }

        private void cmb_customer_KeyDown_1(object sender, KeyEventArgs e)
        {
           // InformationClient();
        }

        private void cmb_customer_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //InformationClient();
        }

        private void cmb_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            InformationClient();
        }

        private void cmb_customer_Leave(object sender, EventArgs e)
        {
            if (rdb_clientsave.Checked == true)
            {


            
                dt.Clear();
                dt = cu.VildateCustomer(Convert.ToInt32(cmb_customer.EditValue), cmb_customer.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("هذا العميل لم يسجل من قبل من فضلك قم باضافة العميل اولا ");

                    cmb_customer.Focus();
                    cmb_customer.Text = "";
                    return;
                }
                InformationClient();
            }
           
        }

        private void rdb_clientsave_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_clientsave.Checked == true)
            {
                cmb_customer.Show();
                textEdit1.Hide();
                txt_address.Text = "";
                textEdit1.Text = "";
                txt_phones.Text = "";
            }
        }

        private void rdb_newclient_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_newclient.Checked == true)
            {
                cmb_customer.Hide();
                textEdit1.Show();
                txt_address.Text = "";
                textEdit1.Text = "";
                txt_phones.Text = "";
            }
        }

        Frm_Hold fh = new Frm_Hold();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (Lable_Num.Text == "")
                {
                      if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الحفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                      {

                        if (gridView2.RowCount > 0)
                        {
                            if (rdb_takeaway.Checked == true)
                            {

                                if (rdb_clientsave.Checked == true)
                                {
                                    if (cmb_customer.Text == "")
                                    {
                                        MessageBox.Show("من فضلك قم بالتاكد من بيانات العميل ");
                                        return;
                                    }



                                        cu.UpdateCustomer(Convert.ToInt32(cmb_customer.EditValue), txt_address.Text, txt_phones.Text);
                                        dt.Clear();
                                        dt = o.AddOrder(Convert.ToInt32(cmb_customer.EditValue), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text), "Take away", Program.Id_USer, "true");
                                        Lable_Num.Text = dt.Rows[0][0].ToString();

                                        for (int i = 0; i < gridView2.RowCount; i++)
                                        {
                                            DataRow row = gridView2.GetDataRow(i);
                                            o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                               Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                                        }
                                }
                                else if (rdb_newclient.Checked == true)
                                {


                                    //else if (dt.Rows.Count == 0)
                                    //{
                                    if (textEdit1.Text == "")
                                    {
                                        MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                        return;
                                    }

                                    //else if (dt.Rows.Count == 0)
                                    //{

                                    cu.AddCustomer(textEdit1.Text, txt_address.Text, txt_phones.Text);
                                    txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();
                                    dt.Clear();
                                    dt = o.AddOrder(Convert.ToInt32(txt_cust.Text), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                     Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text), "Take away", Program.Id_USer, "true");
                                    Lable_Num.Text = dt.Rows[0][0].ToString();

                                    for (int i = 0; i < gridView2.RowCount; i++)
                                    {
                                        DataRow row = gridView2.GetDataRow(i);
                                        o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                           Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                                    }

                                }
                                o.AddTakeAway(Convert.ToInt32(Lable_Num.Text));

                            }
                            else if (rdb_delivery.Checked == true)
                            {


                                if (cmb_delivery.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بتسجيل اسم الطيار ");
                                    return;
                                }

                                if (rdb_clientsave.Checked == true)
                                {
                                    if (cmb_customer.Text == "" || txt_address.Text == "" || txt_phones.Text == "")
                                    {
                                        MessageBox.Show("من فضلك قم باادخال بيانات العميل كامله");
                                        return;
                                    }
                                   
                                        cu.UpdateCustomer(Convert.ToInt32(cmb_customer.EditValue), txt_address.Text, txt_phones.Text);
                                        dt.Clear();
                                        dt = o.AddOrder(Convert.ToInt32(cmb_customer.EditValue), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                 Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text), "Delivery", Program.Id_USer, "true");
                                        Lable_Num.Text = dt.Rows[0][0].ToString();

                                        for (int i = 0; i < gridView2.RowCount; i++)
                                        {
                                            DataRow row = gridView2.GetDataRow(i);
                                            o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                               Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                                        }
                          
                                }
                                 if (rdb_newclient.Checked == true)
                                {

                                    if (textEdit1.Text == "" || txt_phones.Text == "" || txt_address.Text == "")
                                    {
                                        MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                        return;
                                    }
                                    cu.AddCustomer(textEdit1.Text, txt_address.Text, txt_phones.Text);
                                    txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();
                                    dt.Clear();
                                    dt = o.AddOrder(Convert.ToInt32(txt_cust.Text), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                     Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text), "Delivery", Program.Id_USer, "true");
                                    Lable_Num.Text = dt.Rows[0][0].ToString();

                                    for (int i = 0; i < gridView2.RowCount; i++)
                                    {
                                        DataRow row = gridView2.GetDataRow(i);
                                        o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                           Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                                    }



                                }
                                o.AddDelivery(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_delivery.SelectedValue));


                            }
                            else if (rdb_sala.Checked == true)
                            {
                                textEdit1.Text = "عميل نقدى";


                                if (cmb_Table.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بتسجيل رقم الطاولة ");
                                    return;
                                }
                                t.UpdateTablesInOrder(Convert.ToInt32(cmb_Table.SelectedValue), 0);
                                cu.AddCustomerTakeAway(textEdit1.Text);
                                txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();
                                dt.Clear();
                                dt = o.AddOrder(Convert.ToInt32(txt_cust.Text), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text), "Table", Program.Id_USer, "true");
                                Lable_Num.Text = dt.Rows[0][0].ToString();
                                for (int i = 0; i < gridView2.RowCount; i++)
                                {
                                    DataRow row = gridView2.GetDataRow(i);
                                    o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                       Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                                }
                                o.AddSala(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_Table.SelectedValue),
                                     Convert.ToInt32(cmb_stuff.SelectedValue));

                            }
                        }
                        else
                        {
                            MessageBox.Show("من فضلك فم بااختيار اصناف الفاتورة اولا");
                            return;
                        }

                        MessageBox.Show("تم حفظ وسداد الفاتوره بنجاح", "عمليه الحفظ والسداد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                       
                        ///////////////// code of print   /////////////////////////////
                        if (Lable_Num.Text != "")
                        {
                            DataTable dt6 = new DataTable();
                            DataSet1 ds = new DataSet1();
                            ////////////////   كود طباعة امر تشغيل   ///////////
                            if (Properties.Settings.Default.PrintCheckenInSave == "true")
                            {


                                if (Properties.Settings.Default.CheckenType == "collect")
                                {
                                    XtraReportCheck rc = new XtraReportCheck();
                                    dt6.Clear();
                                    dt6 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                                    if (dt6.Rows[0][11].ToString() == "Table")
                                    {
                                        dt5.Clear();

                                        dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                        rc.Label_TableNum.Visible = true;
                                        rc.Txt_TableNum.Visible = true;
                                        rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                    }


                                    ds.Tables["Order"].Clear();
                                    for (int i = 0; i < dt6.Rows.Count; i++)
                                    {
                                        ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                        dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                        dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                    }
                                    rc.DataSource = ds;
                                    rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                    rc.Parameters["Id"].Visible = false;
                                    //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                    // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                    rc.PrinterName = Properties.Settings.Default.PrinterChecken;
                                    rc.Print();
                                    rc.Dispose();
                                }
                                if (Properties.Settings.Default.CheckenType == "seperator")
                                {
                                    //كود طباعة المشروبات فقط
                                    #region
                                    XtraReportCheck rc = new XtraReportCheck();
                                    dt6.Clear();
                                    dt6 = o.PrintOrderDeliveryDrinks(Convert.ToInt32(Lable_Num.Text));
                                    if (dt6.Rows.Count > 0)
                                    {


                                        if (dt6.Rows[0][11].ToString() == "Table")
                                        {
                                            dt5.Clear();

                                            dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                            rc.Label_TableNum.Visible = true;
                                            rc.Txt_TableNum.Visible = true;
                                            rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                        }



                                        ds.Tables["Order"].Clear();
                                        for (int i = 0; i < dt6.Rows.Count; i++)
                                        {
                                            ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                            dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                            dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                        }
                                        rc.DataSource = ds;
                                        rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                        rc.Parameters["Id"].Visible = false;
                                        //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                        // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                        rc.PrinterName = Properties.Settings.Default.PrinterDrinks;
                                        rc.Print();
                                        rc.Dispose();

                                    }
                                    #endregion

                                    //كود طباعة الماكولات فقط
                                    #region
                                    XtraReportCheck rcmakolat = new XtraReportCheck();
                                    dt6.Clear();
                                    dt6 = o.PrintOrderDeliveryMakolat(Convert.ToInt32(Lable_Num.Text));
                                    if (dt6.Rows.Count > 0)
                                    {

                                        if (dt6.Rows[0][11].ToString() == "Table")
                                        {
                                            dt5.Clear();

                                            dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                            rcmakolat.Label_TableNum.Visible = true;
                                            rcmakolat.Txt_TableNum.Visible = true;
                                            rcmakolat.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                        }



                                        ds.Tables["Order"].Clear();
                                        for (int i = 0; i < dt6.Rows.Count; i++)
                                        {
                                            ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                            dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                            dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                        }
                                        rcmakolat.DataSource = ds;
                                        rcmakolat.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                        rcmakolat.Parameters["Id"].Visible = false;
                                        //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                        // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                        rcmakolat.PrinterName = Properties.Settings.Default.PrinterChecken;
                                        rcmakolat.Print();
                                        rcmakolat.Dispose();
                                    }
                                    #endregion
                                }
                            }
                            /////كود طباعة فاتورة للعميل ///////
                            if (Properties.Settings.Default.PrintOrderInSave == "true")
                            {
                                XtraReport1Order ro = new XtraReport1Order();

                                dt5.Clear();
                                dt5 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                                if (dt5.Rows[0][11].ToString() == "Delivery")
                                {
                                    dt6.Clear();
                                    dt6 = o.Select_DeliveyMan(Convert.ToInt32(Lable_Num.Text));
                                    ro.Txt_DeliveryService.Visible = true;
                                    ro.Lable_DeliveryService.Visible = true;
                                    ro.Lable_DeliveryName.Visible = true;
                                    ro.Txt_DeliveryName.Visible = true;
                                    ro.Txt_DeliveryName.Text = dt6.Rows[0][1].ToString();
                                }

                                if (dt5.Rows[0][11].ToString() == "Table")
                                {
                                    dt6.Clear();
                                    dt6 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));

                                    ro.Lable_TableNum.Visible = true;
                                    ro.Txt_TableNum.Visible = true;
                                    ro.Txt_TableNum.Text = dt6.Rows[0][1].ToString();
                                }
                                ds.Tables["Order"].Clear();
                                for (int i = 0; i < dt5.Rows.Count; i++)
                                {
                                    ds.Tables["Order"].Rows.Add(dt5.Rows[i][0], dt5.Rows[i][1], dt5.Rows[i][4],
                                    dt5.Rows[i][5], dt5.Rows[i][7], dt5.Rows[i][6], dt5.Rows[i][9], dt5.Rows[i][8],
                                    dt5.Rows[i][2], (dt5.Rows[i][3]), dt5.Rows[i][11], dt5.Rows[i][10], dt5.Rows[i][12]);
                                }
                                ro.Txt_Delivery.Visible = true;
                                ro.DataSource = ds;
                                ro.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                ro.Parameters["Id"].Visible = false;
                                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                                //ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                ro.PrinterName = Properties.Settings.Default.PrinterOrderClient;
                                ro.Print();
                                ro.Dispose();
                            }

                        }

                        clear2();
                      }
                      else
                      {
                        MessageBox.Show("تم الغاء عمليه الحفظ والسداد");
                        return;
                      }

                }


                 if (Lable_Num.Text != "")
                 {
                    if (MessageBox.Show("هل تريد حفظ وسداد الفاتورة", "عمليه الحفظ والسداد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {


                        o.DeleteOrderNewRow();

                        int x;
                        for (int y = 0; y < gridView2.RowCount; y++)
                        {
                            DataRow row = gridView2.GetDataRow(y);
                            dt5.Clear();
                            dt5 = o.VildateQuantity(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(row[2]), Convert.ToInt32(row[5]));
                            foreach (DataRow dr in dt5.Rows)
                            {
                                x = Convert.ToInt32(row[5]) - Convert.ToInt32(dr[2]);



                                if (dt5.Rows.Count > 0)
                                {
                                    o.AddOrderNewRow(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                  x, Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));

                                }
                            }
                            dt10.Clear();
                            dt10 = o.VildateOrderDetails(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(row[2]));
                            if (dt10.Rows.Count == 0)
                            {
                                o.AddOrderNewRow(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                           Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                            }
                        }

                        //  ------------------------------------------------------------//
                        o.Delete_ProdFromOrderDetails(Convert.ToInt32(Lable_Num.Text));
                        for (int i = 0; i < gridView2.RowCount; i++)
                        {
                            DataRow row = gridView2.GetDataRow(i);
                            o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                               Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                        }


                        #region delete order from sala or delevery or tackaway
                        dt10.Clear();
                        dt10 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                        dt5.Clear();
                        dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text)) ;
                        if (dt10.Rows[0][11].ToString() == "Table")
                        {
                            o.Delete_OrderFromSala(Convert.ToInt32(Lable_Num.Text));
                            t.UpdateTablesInOrder(Convert.ToInt32(dt5.Rows[0][2]), 0);

                        }
                        if (dt10.Rows[0][11].ToString() == "Delivery")
                        {
                            o.Delete_OrderFromDelivery(Convert.ToInt32(Lable_Num.Text));
                        }
                        if (dt10.Rows[0][11].ToString() == "Take away")
                        {
                            o.Delete_OrderFromTakeAway(Convert.ToInt32(Lable_Num.Text));
                        }
                        #endregion


                        if (rdb_takeaway.Checked == true)
                        {
                            if (rdb_clientsave.Checked == true)
                            {

                                if (cmb_customer.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بالتاكد من بيانات العميل ");
                                    return;
                                }
                              
                                cu.UpdateCustomer(Convert.ToInt32(cmb_customer.EditValue), txt_address.Text, txt_phones.Text);

                                o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                 Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text),
                                "Take away", Convert.ToInt32(cmb_customer.EditValue));
                            }
                            else if (rdb_newclient.Checked == true)
                            {

                                if (textEdit1.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }

                                cu.AddCustomer(textEdit1.Text, txt_address.Text, txt_phones.Text);
                                txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                                o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                   Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text),
                                  "Take away", Convert.ToInt32(txt_cust.Text));

                            }
                            o.AddTakeAway(Convert.ToInt32(Lable_Num.Text));

                        }

                        else if (rdb_delivery.Checked == true)
                        {


                            if (cmb_delivery.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتسجيل اسم الطيار ");
                                return;
                            }

                            if (rdb_clientsave.Checked == true)
                            {
                                if (cmb_customer.Text == "" || txt_address.Text == "" || txt_phones.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم باادخال بيانات العميل كامله");
                                    return;
                                }
                                cu.UpdateCustomer(Convert.ToInt32(cmb_customer.EditValue), txt_address.Text, txt_phones.Text);

                                o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                 Convert.ToDecimal(txt_invo.Text),0, Convert.ToDecimal(txt_discount.Text),
                                "Delivery", Convert.ToInt32(cmb_customer.EditValue));
                            }
                            else if (rdb_newclient.Checked == true)
                            {

                                if (textEdit1.Text == "" || txt_phones.Text == "" || txt_address.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }


                                cu.AddCustomer(textEdit1.Text, txt_address.Text, txt_phones.Text);
                                txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                                o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                   Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text),
                                  "Delivery", Convert.ToInt32(txt_cust.Text));

                            }
                            o.AddDelivery(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_delivery.SelectedValue));


                        }

                        else if (rdb_sala.Checked == true)
                        {
                            textEdit1.Text = "عميل نقدى";

                            if (cmb_Table.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتسجيل رقم الطاولة ");
                                return;
                            }
                            if (cmb_stuff.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتسجيل الكابتن  ");
                                return;
                            }
                            t.UpdateTablesInOrder(Convert.ToInt32(cmb_Table.SelectedValue), 0);
                            cu.AddCustomerTakeAway(textEdit1.Text);
                            txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                            o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                               Convert.ToDecimal(txt_invo.Text), 0, Convert.ToDecimal(txt_discount.Text),
                                 "Table", Convert.ToInt32(txt_cust.Text));

                            o.AddSala(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_Table.SelectedValue),
                                 Convert.ToInt32(cmb_stuff.SelectedValue));

                        }
                    }

                    else
                    {
                        MessageBox.Show("تم الغاء عمليه الحفظ والسداد");
                        return;
                    }

                    //////كود الطباعة فى الحفظ والسداد بعد التعديل //////
                    if (Lable_Num.Text != "")
                        {
                            DataTable dt6 = new DataTable();
                            DataSet1 ds = new DataSet1();
                            ////////////////   كود طباعة امر تشغيل مجمع بعد التعديل ///////////
                            if (Properties.Settings.Default.PrintCheckenInSave == "true")
                            {

                                if (Properties.Settings.Default.CheckenType == "collect")
                                {
                                    XtraReportCheck rc = new XtraReportCheck();
                                    dt6.Clear();
                                    dt6 = o.PritOrderNewRow(Convert.ToInt32(Lable_Num.Text));
                                    if (dt6.Rows.Count > 0)
                                    {


                                        if (dt6.Rows[0][11].ToString() == "Table")
                                        {
                                            dt5.Clear();

                                            dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                            rc.Label_TableNum.Visible = true;
                                            rc.Txt_TableNum.Visible = true;
                                            rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                        }



                                            ds.Tables["Order"].Clear();
                                            for (int i = 0; i < dt6.Rows.Count; i++)
                                            {
                                                ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                                dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                                dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                            }
                                            rc.DataSource = ds;
                                            rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                            rc.Parameters["Id"].Visible = false;
                                            //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                            // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                            rc.PrinterName = Properties.Settings.Default.PrinterChecken;
                                            rc.Print();
                                            rc.Dispose();

                                        
                                    }
                                }
                                if (Properties.Settings.Default.CheckenType == "seperator")
                                {
                                    //كود طباعة المشروبات فقط
                                    #region
                                    XtraReportCheck rc = new XtraReportCheck();
                                    dt6.Clear();
                                    dt6 = o.PritOrderNewRowDrinks(Convert.ToInt32(Lable_Num.Text));
                                    if (dt6.Rows.Count > 0)
                                    {


                                        if (dt6.Rows[0][11].ToString() == "Table")
                                        {
                                            dt5.Clear();

                                            dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                            rc.Label_TableNum.Visible = true;
                                            rc.Txt_TableNum.Visible = true;
                                            rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                        }

                                      

                                            ds.Tables["Order"].Clear();
                                            for (int i = 0; i < dt6.Rows.Count; i++)
                                            {
                                                ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                                dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                                dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                            }
                                            rc.DataSource = ds;
                                            rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                            rc.Parameters["Id"].Visible = false;
                                            //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                            // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                            rc.PrinterName = Properties.Settings.Default.PrinterDrinks;
                                            rc.Print();
                                            rc.Dispose();

                                        
                                    }
                                    #endregion

                                    //كود طباعة الماكولات فقط
                                    #region
                                    XtraReportCheck rcmakolat = new XtraReportCheck();
                                    dt6.Clear();
                                    dt6 = o.PritOrderNewRowMakolat(Convert.ToInt32(Lable_Num.Text));
                                    if (dt6.Rows.Count > 0)
                                    {


                                        if (dt6.Rows[0][11].ToString() == "Table")
                                        {
                                            dt5.Clear();
                                            dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                            rcmakolat.Label_TableNum.Visible = true;
                                            rcmakolat.Txt_TableNum.Visible = true;
                                            rcmakolat.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                        }

                                       


                                            ds.Tables["Order"].Clear();
                                            for (int i = 0; i < dt6.Rows.Count; i++)
                                            {
                                                ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                                dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                                dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                            }
                                            rcmakolat.DataSource = ds;
                                            rcmakolat.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                            rcmakolat.Parameters["Id"].Visible = false;
                                            //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                            // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                            rcmakolat.PrinterName = Properties.Settings.Default.PrinterChecken;
                                            rcmakolat.Print();
                                            rcmakolat.Dispose();
                                        
                                    }
                                    #endregion
                                }
                            }
                            /////كود طباعة فاتورة للعميل ///////
                            if (Properties.Settings.Default.PrintOrderInSave == "true")
                            {
                                XtraReport1Order ro = new XtraReport1Order();

                                dt5.Clear();
                                dt5 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                                if (dt5.Rows[0][11].ToString() == "Delivery")
                                {
                                    dt6.Clear();
                                    dt6 = o.Select_DeliveyMan(Convert.ToInt32(Lable_Num.Text));
                                    ro.Txt_DeliveryService.Visible = true;
                                    ro.Lable_DeliveryService.Visible = true;
                                    ro.Lable_DeliveryName.Visible = true;
                                    ro.Txt_DeliveryName.Visible = true;
                                    ro.Txt_DeliveryName.Text = dt6.Rows[0][1].ToString();
                                }

                                if (dt5.Rows[0][11].ToString() == "Table")
                                {
                                    dt6.Clear();
                                   dt6 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));

                                    ro.Lable_TableNum.Visible = true;
                                    ro.Txt_TableNum.Visible = true;
                                    ro.Txt_TableNum.Text = dt6.Rows[0][1].ToString();
                                }
                                dt5.Clear();
                                dt5 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                                ds.Tables["Order"].Clear();
                                for (int i = 0; i < dt5.Rows.Count; i++)
                                {
                                    ds.Tables["Order"].Rows.Add(dt5.Rows[i][0], dt5.Rows[i][1], dt5.Rows[i][4],
                                    dt5.Rows[i][5], dt5.Rows[i][7], dt5.Rows[i][6], dt5.Rows[i][9], dt5.Rows[i][8],
                                    dt5.Rows[i][2], (dt5.Rows[i][3]), dt5.Rows[i][11], dt5.Rows[i][10], dt5.Rows[i][12]);
                                }
                                ro.DataSource = ds;
                                ro.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                ro.Parameters["Id"].Visible = false;
                                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                                //ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                ro.PrinterName = Properties.Settings.Default.PrinterOrderClient;
                                ro.Print();
                                ro.Dispose();
                            }

                        }
                        o.DeleteOrderNewRow();

                        clear2();
                 }



                dt.Clear();
                dt = o.SELECTOrderRentALLORDER();
                simpleButton4.Text = $"({dt.Rows.Count}) الفواتير المتعلقة";

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void rdb_sala_CheckedChanged_1(object sender, EventArgs e)
        {
            RdbSala();
        }

        private void rdb_delivery_CheckedChanged_1(object sender, EventArgs e)
        {
            RdbDelivery();
        }

        private void rdb_takeaway_CheckedChanged_1(object sender, EventArgs e)
        {
            RdbTackAway();
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
        private void txt_address_MouseHover(object sender, EventArgs e)
        {
            textEdit1.Select();
            if (textEdit1.Text == "العنوان")
            {
                textEdit1.Text = "";
            }
        }
        private void txt_address_Leave(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {
                textEdit1.Text = "العنوان";
            }
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

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            clear2();
            if (Properties.Settings.Default.OrderType == "صالة")
            {
                rdb_sala.Checked = true;
                RdbSala();
            }

            if (Properties.Settings.Default.OrderType == "دليفرى")
            {
                rdb_delivery.Checked = true;
                RdbDelivery();
            }
            if (Properties.Settings.Default.OrderType == "تيك اواى")
            {
                rdb_takeaway.Checked = true;
                RdbTackAway();
            }            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            try
            {
                if (Lable_Num.Text!="")
                {
                    DataTable dt5 = new DataTable();
                    DataTable dt6 = new DataTable();
                    DataSet1 ds = new DataSet1();
                    XtraReport1Order ro = new XtraReport1Order();

                    dt5.Clear();
                    dt5 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                    if (dt5.Rows[0][11].ToString() == "Delivery")
                    {
                        dt6.Clear();
                        dt6 = o.Select_DeliveyMan(Convert.ToInt32(Lable_Num.Text));
                        ro.Txt_DeliveryService.Visible = true;
                        ro.Lable_DeliveryService.Visible = true;
                        ro.Lable_DeliveryName.Visible = true;
                        ro.Txt_DeliveryName.Visible = true;
                        ro.Txt_DeliveryName.Text = dt6.Rows[0][1].ToString();
                    }

                    if (dt5.Rows[0][11].ToString() == "Table")
                    {
                        dt6.Clear();
                        dt6 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));

                        ro.Lable_TableNum.Visible = true;
                        ro.Txt_TableNum.Visible = true;
                        ro.Txt_TableNum.Text = dt6.Rows[0][1].ToString();
                    }
                    dt5.Clear();
                    dt5 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));

                    ds.Tables["Order"].Clear();
                    for (int i = 0; i < dt5.Rows.Count; i++)
                    {
                        ds.Tables["Order"].Rows.Add(Convert.ToInt32(dt5.Rows[i][0]),
                            dt5.Rows[i][1].ToString(), Convert.ToDateTime(dt5.Rows[i][4]),
                        dt5.Rows[i][5].ToString(), Convert.ToInt32(dt5.Rows[i][7]), Convert.ToDecimal(dt5.Rows[i][6])
                        , dt5.Rows[i][9].ToString(), Convert.ToDecimal(dt5.Rows[i][8]),
                        dt5.Rows[i][2].ToString(), (dt5.Rows[i][3].ToString()), dt5.Rows[i][11].ToString()
                        , Convert.ToDecimal(dt5.Rows[i][10]), Convert.ToDecimal(dt5.Rows[i][12]));
       
                    }
                    ro.DataSource = ds;
                    ro.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                    ro.Parameters["Id"].Visible = false;
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                    ro.PrinterName = Properties.Settings.Default.PrinterOrderClient;
                    ro.Print();
                    
                }
                else
                {
                    MessageBox.Show("لا بد من وجود فاتورة مسبقة للطباعة");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
            fh.ShowDialog();


            if (fh.gridView2.RowCount > 0  )
            {
                gridControl2.Enabled = true;
                //rdb_sala.Enabled = false;
                //rdb_takeaway.Enabled = false;

                //txt_delivery.Show();

               // cmb_delivery.Enabled = false;
              //  btn_update.Enabled = true;

                flowLayoutPanel1.Enabled = true;
                flowLayoutPanel2.Enabled = true;
                txt_discount.Enabled = true;
                if (fh.gridView2.GetFocusedRowCellValue("نوع الطلب").ToString() == "Delivery")
                {

                    rdb_delivery.Checked = true;
                    cmb_customer.Show();
                    textEdit1.Hide();

                    //textEdit1.Enabled = false;
                  //  rdb_clientsave.Enabled = false;
                    //rdb_newclient.Enabled = false;


                    //txt_phones.Enabled = false;
                    //txt_address.Enabled = false;
                  //  grb_customer.Show();
                  //  grb_delivry.Show();
                  //  grb_customer.Enabled = false;
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
                        cmb_customer.Text = dr[2].ToString();
                        cmb_customer.EditValue = dr[1].ToString();
                        txt_phones.Text = dr[3].ToString();
                        txt_address.Text = dr[4].ToString();
                        timer1.Enabled = false;
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

                    rdb_sala.Checked = true;

                    grb_sala.Show();

                 
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

                        t.UpdateTablesInOrder(Convert.ToInt32(dr[10]), 0);

                        cmb_Table.DataSource = t.SelectTablesCompo();
                        cmb_Table.DisplayMember = "Tables_Number";
                        cmb_Table.ValueMember = "ID_Tables";
                        cmb_Table.Text = dr[7].ToString();

                        Lable_Num.Text = dr[0].ToString();
                        txt_cust.Text = dr[1].ToString();
                        textEdit1.Text = dr[2].ToString();

                        timer1.Enabled = false;
                        lable_date.Text = dr[3].ToString();


                        texT.Text = dr[4].ToString();
                

                        txt_discount.Text = dr[8].ToString();
                        cmb_stuff.Text = dr[9].ToString();
                    }
                }
                else if (fh.gridView2.GetFocusedRowCellValue("نوع الطلب").ToString() == "Take away")
                {

                    rdb_takeaway.Checked = true;
                    cmb_customer.Show();
                    textEdit1.Hide();
                    rdb_clientsave.Checked = true;
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
                        cmb_customer.Text = dr[2].ToString();
                        cmb_customer.EditValue = dr[1].ToString();

                        timer1.Enabled = false;
                        lable_date.Text = dr[3].ToString();

                        texT.Text = dr[4].ToString();

                        txt_discount.Text = dr[7].ToString();
                        txt_phones.Text = dr[8].ToString();
                        txt_address.Text = dr[9].ToString();

                    }

                }
                totalInvoice();
                TOTALFINALYDELIVERY();
                TOTALFINALYDISCOUNT();
            }


        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (Lable_Num.Text == "")
                {
                    if (gridView2.RowCount > 0)
                    {
                        if (rdb_takeaway.Checked == true)
                        {

                            if (rdb_clientsave.Checked == true)
                            {
                                if (cmb_customer.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بالتاكد من بيانات العميل ");
                                    return;
                                }

                                    cu.UpdateCustomer(Convert.ToInt32(cmb_customer.EditValue), txt_address.Text, txt_phones.Text);
                                    dt.Clear();
                                    dt = o.AddOrder(Convert.ToInt32(cmb_customer.EditValue), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                            0, Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text), "Take away", Program.Id_USer, "true");
                                    Lable_Num.Text = dt.Rows[0][0].ToString();

                                    for (int i = 0; i < gridView2.RowCount; i++)
                                    {
                                        DataRow row = gridView2.GetDataRow(i);
                                        o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                           Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                                    }
                              



                            }
                            else if (rdb_newclient.Checked == true)
                            {


                                //else if (dt.Rows.Count == 0)
                                //{
                                if (textEdit1.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }

                                //else if (dt.Rows.Count == 0)
                                //{

                                cu.AddCustomer(textEdit1.Text, txt_address.Text, txt_phones.Text);
                                txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();
                                dt.Clear();
                                dt = o.AddOrder(Convert.ToInt32(txt_cust.Text), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                0, Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text), "Take away", Program.Id_USer, "true");
                                Lable_Num.Text = o.LasIdOrder().Rows[0][0].ToString();

                                for (int i = 0; i < gridView2.RowCount; i++)
                                {
                                    DataRow row = gridView2.GetDataRow(i);
                                    o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                       Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                                }

                            }
                            o.AddTakeAway(Convert.ToInt32(Lable_Num.Text));

                            MessageBox.Show("تم تعليق الفاتوره بنجاح", "عمليه التعليق", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                        else if (rdb_delivery.Checked == true)
                        {


                            if (cmb_delivery.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتسجيل اسم الطيار ");
                                return;
                            }

                            if (rdb_clientsave.Checked == true)
                            {
                                if (cmb_customer.Text == "" || txt_address.Text == "" || txt_phones.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم باادخال بيانات العميل كامله");
                                    return;
                                }
                               
                                    cu.UpdateCustomer(Convert.ToInt32(cmb_customer.EditValue), txt_address.Text, txt_phones.Text);
                                    dt.Clear();
                                    dt = o.AddOrder(Convert.ToInt32(cmb_customer.EditValue), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                              0, Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text), "Delivery", Program.Id_USer, "true");
                                    Lable_Num.Text = dt.Rows[0][0].ToString();

                                    for (int i = 0; i < gridView2.RowCount; i++)
                                    {
                                        DataRow row = gridView2.GetDataRow(i);
                                        o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                           Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                                    }
                               
                            }
                            else if (rdb_newclient.Checked == true)
                            {


                                //else if (dt.Rows.Count == 0)
                                //{
                                if (textEdit1.Text == "" || txt_phones.Text == "" || txt_address.Text == "")
                                {
                                    MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                    return;
                                }

                                //else if (dt.Rows.Count == 0)
                                //{

                                cu.AddCustomer(textEdit1.Text, txt_address.Text, txt_phones.Text);
                                txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();
                                dt.Clear();
                                dt = o.AddOrder(Convert.ToInt32(txt_cust.Text), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                0, Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text), "Delivery", Program.Id_USer, "true");
                                Lable_Num.Text = o.LasIdOrder().Rows[0][0].ToString();

                                for (int i = 0; i < gridView2.RowCount; i++)
                                {
                                    DataRow row = gridView2.GetDataRow(i);
                                    o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                       Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                                }
                                //MessageBox.Show("تم تعليق الفاتوره بنجاح", "عمليه التعليق", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                                //o.AddDelivery(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_delivery.SelectedValue));



                                //}


                            }
                            o.AddDelivery(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_delivery.SelectedValue));

                            MessageBox.Show("تم تعليق الفاتوره بنجاح", "عمليه التعليق", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);



                        }

                        else if (rdb_sala.Checked == true)
                        {
                            textEdit1.Text = "عميل نقدى";


                            if (cmb_Table.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بتسجيل رقم الطاولة ");
                                return;
                            }
                            t.UpdateTablesInOrder(Convert.ToInt32(cmb_Table.SelectedValue), 1);
                            cu.AddCustomerTakeAway(textEdit1.Text);
                            txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();
                            dt.Clear();
                            dt = o.AddOrder(Convert.ToInt32(txt_cust.Text), Convert.ToDateTime(lable_date.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                            0, Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text), "Table", Program.Id_USer, "true");
                            Lable_Num.Text = dt.Rows[0][0].ToString();
                            for (int i = 0; i < gridView2.RowCount; i++)
                            {
                                DataRow row = gridView2.GetDataRow(i);
                                o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                                   Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                            }
                            o.AddSala(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_Table.SelectedValue),
                                 Convert.ToInt32(cmb_stuff.SelectedValue));
                            MessageBox.Show("تم تعليق الفاتوره بنجاح", "عمليه التعليق", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                        }


                        //////كود الطباعة فى التعلليق //////
                        if (Lable_Num.Text != "")
                        {
                            DataTable dt6 = new DataTable();
                            DataSet1 ds = new DataSet1();
                            ////////////////   كود طباعة امر تشغيل   ///////////
                            if (Properties.Settings.Default.PrintCheckenInHold == "true")
                            {


                                if (Properties.Settings.Default.CheckenType == "collect")
                                {
                                    XtraReportCheck rc = new XtraReportCheck();
                                    dt6.Clear();
                                    dt6 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                                    if (dt6.Rows[0][11].ToString() == "Table")
                                    {
                                        dt5.Clear();

                                        dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                        rc.Label_TableNum.Visible = true;
                                        rc.Txt_TableNum.Visible = true;
                                        rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                    }

                                    ds.Tables["Order"].Clear();
                                    for (int i = 0; i < dt6.Rows.Count; i++)
                                    {
                                        ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                        dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                        dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                    }
                                    rc.DataSource = ds;
                                    rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                    rc.Parameters["Id"].Visible = false;
                                    //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                    // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                    rc.PrinterName = Properties.Settings.Default.PrinterChecken;
                                    rc.Print();
                                    rc.Dispose();
                                }
                                if (Properties.Settings.Default.CheckenType == "seperator")
                                {
                                    //كود طباعة المشروبات فقط
                                    #region
                                    XtraReportCheck rc = new XtraReportCheck();
                                    dt6.Clear();
                                    dt6 = o.PrintOrderDeliveryDrinks(Convert.ToInt32(Lable_Num.Text));
                                    if (dt6.Rows.Count > 0)
                                    {


                                        if (dt6.Rows[0][11].ToString() == "Table")
                                        {
                                            dt5.Clear();

                                            dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                            rc.Label_TableNum.Visible = true;
                                            rc.Txt_TableNum.Visible = true;
                                            rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                        }


                                        ds.Tables["Order"].Clear();
                                        for (int i = 0; i < dt6.Rows.Count; i++)
                                        {
                                            ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                            dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                            dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                        }
                                        rc.DataSource = ds;
                                        rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                        rc.Parameters["Id"].Visible = false;
                                        //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                        // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                        rc.PrinterName = Properties.Settings.Default.PrinterDrinks;
                                        rc.Print();
                                        rc.Dispose();
                                    }
                                    
                                    #endregion

                                    //كود طباعة الماكولات فقط
                                    #region
                                    XtraReportCheck rcmakolat = new XtraReportCheck();
                                    dt6.Clear();
                                    dt6 = o.PrintOrderDeliveryMakolat(Convert.ToInt32(Lable_Num.Text));
                                  if (dt6.Rows.Count>0)
                                  {

                                    
                                    if (dt6.Rows[0][11].ToString() == "Table")
                                    {
                                        dt5.Clear();

                                        dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                        rcmakolat.Label_TableNum.Visible = true;
                                        rcmakolat.Txt_TableNum.Visible = true;
                                        rcmakolat.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                    }

                                   


                                        ds.Tables["Order"].Clear();
                                        for (int i = 0; i < dt6.Rows.Count; i++)
                                        {
                                            ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                            dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                            dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                        }
                                        rcmakolat.DataSource = ds;
                                        rcmakolat.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                        rcmakolat.Parameters["Id"].Visible = false;
                                        //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                        // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                        rcmakolat.PrinterName = Properties.Settings.Default.PrinterChecken;
                                        rcmakolat.Print();
                                        rcmakolat.Dispose();
                                    }
                                    #endregion
                                }
                            }
                            /////كود طباعة فاتورة للعميل ///////
                            if (Properties.Settings.Default.PrintOrderInHold == "true")
                            {
                                XtraReport1Order ro = new XtraReport1Order();

                                dt5.Clear();
                                dt5 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                                if (dt5.Rows[0][11].ToString() == "Delivery")
                                {
                                    dt6.Clear();
                                    dt6 = o.Select_DeliveyMan(Convert.ToInt32(Lable_Num.Text));
                                    ro.Txt_DeliveryService.Visible = true;
                                    ro.Lable_DeliveryService.Visible = true;
                                    ro.Lable_DeliveryName.Visible = true;
                                    ro.Txt_DeliveryName.Visible = true;
                                    ro.Txt_DeliveryName.Text = dt6.Rows[0][1].ToString();
                                }

                                if (dt5.Rows[0][11].ToString() == "Table")
                                {
                                    dt6.Clear();
                                    dt6 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));

                                    ro.Lable_TableNum.Visible = true;
                                    ro.Txt_TableNum.Visible = true;
                                    ro.Txt_TableNum.Text = dt6.Rows[0][1].ToString();
                                }
                                ds.Tables["Order"].Clear();
                                for (int i = 0; i < dt5.Rows.Count; i++)
                                {
                                    ds.Tables["Order"].Rows.Add(dt5.Rows[i][0], dt5.Rows[i][1], dt5.Rows[i][4],
                                    dt5.Rows[i][5], dt5.Rows[i][7], dt5.Rows[i][6], dt5.Rows[i][9], dt5.Rows[i][8],
                                    dt5.Rows[i][2], (dt5.Rows[i][3]), dt5.Rows[i][11], dt5.Rows[i][10], dt5.Rows[i][12]);
                                }
                                ro.Txt_Delivery.Visible = true;
                                ro.DataSource = ds;
                                ro.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                ro.Parameters["Id"].Visible = false;
                                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                                //ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                ro.PrinterName = Properties.Settings.Default.PrinterOrderClient;
                                ro.Print();
                                ro.Dispose();
                            }
                           
                        }
                        clear2();
                    }
                    else
                    {
                        MessageBox.Show("من فضلك فم بااختيار اصناف الفاتورة اولا");
                        return;
                    }
                }


                if (Lable_Num.Text != "")
                {


                    o.DeleteOrderNewRow();
                    /////////// code of add in order new row  /////////////////////
                    int x;
                    for (int y = 0; y < gridView2.RowCount; y++)
                    {
                        DataRow row = gridView2.GetDataRow(y);
                        dt5.Clear();
                        dt5 = o.VildateQuantity(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(row[2]), Convert.ToInt32(row[5]));
                        foreach (DataRow dr in dt5.Rows)
                        {
                            x = Convert.ToInt32(row[5]) - Convert.ToInt32(dr[2]);



                            if (dt5.Rows.Count > 0)
                            {
                                o.AddOrderNewRow(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                              x, Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));

                            }
                        }
                        dt10.Clear();
                        dt10 = o.VildateOrderDetails(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(row[2]));
                        if (dt10.Rows.Count == 0)
                        {
                            o.AddOrderNewRow(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                       Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                        }
                    }

                    //--  code of delete item from order details and add all item in order details   ----//
                    o.Delete_ProdFromOrderDetails(Convert.ToInt32(Lable_Num.Text));
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        DataRow row = gridView2.GetDataRow(i);
                        o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
                           Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
                    }


                    #region delete order from sala or delevery or tackaway
                    dt10.Clear();
                    dt10 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                    dt5.Clear();
                    dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                    if (dt10.Rows[0][11].ToString() == "Table")
                    {
                        o.Delete_OrderFromSala(Convert.ToInt32(Lable_Num.Text));
                        t.UpdateTablesInOrder(Convert.ToInt32(dt5.Rows[0][2]), 0);
                    }
                    if (dt10.Rows[0][11].ToString() == "Delivery")
                    {
                        o.Delete_OrderFromDelivery(Convert.ToInt32(Lable_Num.Text));
                    }
                    if (dt10.Rows[0][11].ToString() == "Take away")
                    {
                        o.Delete_OrderFromTakeAway(Convert.ToInt32(Lable_Num.Text));
                    }
                    #endregion


                    if (rdb_takeaway.Checked == true)
                    {
                        if (rdb_clientsave.Checked == true)
                        {

                            if (cmb_customer.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بالتاكد من بيانات العميل ");
                                return;
                            }
                            
                                cu.UpdateCustomer(Convert.ToInt32(cmb_customer.EditValue), txt_address.Text, txt_phones.Text);

                                o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                 0,Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text),
                                "Take away", Convert.ToInt32(cmb_customer.EditValue));
                          
                        }
                        else if (rdb_newclient.Checked == true)
                        {

                            if (textEdit1.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                return;
                            }

                            cu.AddCustomer(textEdit1.Text, txt_address.Text, txt_phones.Text);
                            txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                            o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                               0,Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text),
                              "Take away", Convert.ToInt32(txt_cust.Text));

                        }
                        o.AddTakeAway(Convert.ToInt32(Lable_Num.Text));

                        MessageBox.Show("تم تعليق الفاتوره بعد التعديل بنجاح", "عمليه التعليق", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }

                    else if (rdb_delivery.Checked == true)
                    {


                        if (cmb_delivery.Text == "")
                        {
                            MessageBox.Show("من فضلك قم بتسجيل اسم الطيار ");
                            return;
                        }

                        if (rdb_clientsave.Checked == true)
                        {
                            if (cmb_customer.Text == "" && txt_address.Text == "" && txt_phones.Text == "")
                            {
                                MessageBox.Show("من فضلك قم باادخال بيانات العميل كامله");
                                return;
                            }
                            
                                cu.UpdateCustomer(Convert.ToInt32(cmb_customer.EditValue), txt_address.Text, txt_phones.Text);

                                o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                                0, Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text),
                                "Delivery", Convert.ToInt32(cmb_customer.EditValue));
                           
                        }
                        else if (rdb_newclient.Checked == true)
                        {

                            if (textEdit1.Text == "" || txt_phones.Text == "" || txt_address.Text == "")
                            {
                                MessageBox.Show("من فضلك قم بكتابه بيانات العميل");
                                return;
                            }


                            cu.AddCustomer(textEdit1.Text, txt_address.Text, txt_phones.Text);
                            txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                            o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                              0, Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text),
                              "Delivery", Convert.ToInt32(txt_cust.Text));

                        }
                        MessageBox.Show("تم تعليق الفاتوره بعد التعديل بنجاح", "عمليه التعليق", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        o.AddDelivery(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_delivery.SelectedValue));


                    }

                    else if (rdb_sala.Checked == true)
                    {
                        textEdit1.Text = "عميل نقدى";

                        if (cmb_Table.Text == "")
                        {
                            MessageBox.Show("من فضلك قم بتسجيل رقم الطاولة ");
                            return;
                        }
                        cu.AddCustomerTakeAway(textEdit1.Text);
                        txt_cust.Text = cu.LastIdCustomer().Rows[0][0].ToString();

                        o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
                             0, Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text),
                             "Table", Convert.ToInt32(txt_cust.Text));

                        o.AddSala(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_Table.SelectedValue),
                             Convert.ToInt32(cmb_stuff.SelectedValue));
                        t.UpdateTablesInOrder(Convert.ToInt32(cmb_Table.SelectedValue), 1);

                        MessageBox.Show("تم تعليق الفاتوره بعد التعديل بنجاح", "عمليه التعليق", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }


                    //////كود الطباعة فى التعديل //////
                    if (Lable_Num.Text != "")
                    {
                        DataTable dt6 = new DataTable();
                        DataSet1 ds = new DataSet1();
                        ////////////////   كود طباعة امر تشغيل مجمع بعد التعديل ///////////
                        if (Properties.Settings.Default.PrintCheckenInHold == "true")
                        {

                            if (Properties.Settings.Default.CheckenType == "collect")
                            {
                                XtraReportCheck rc = new XtraReportCheck();
                                dt6.Clear();
                                dt6 = o.PritOrderNewRow(Convert.ToInt32(Lable_Num.Text));
                                if (dt6.Rows.Count > 0)
                                {


                                    if (dt6.Rows[0][11].ToString() == "Table")
                                    {
                                        dt5.Clear();

                                        dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                        rc.Label_TableNum.Visible = true;
                                        rc.Txt_TableNum.Visible = true;
                                        rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                    }

                                    


                                        ds.Tables["Order"].Clear();
                                        for (int i = 0; i < dt6.Rows.Count; i++)
                                        {
                                            ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                            dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                            dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                        }
                                        rc.DataSource = ds;
                                        rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                        rc.Parameters["Id"].Visible = false;
                                        //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                        // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                        rc.PrinterName = Properties.Settings.Default.PrinterChecken;
                                        rc.Print();
                                        rc.Dispose();
                                    
                                }
                            }

                            if (Properties.Settings.Default.CheckenType == "seperator")
                            {
                                //كود طباعة المشروبات فقط
                                #region
                                XtraReportCheck rc = new XtraReportCheck();
                                dt6.Clear();
                                dt6 = o.PritOrderNewRowDrinks(Convert.ToInt32(Lable_Num.Text));
                                if (dt6.Rows.Count > 0)
                                {


                                    if (dt6.Rows[0][11].ToString() == "Table")
                                    {
                                        dt5.Clear();

                                        dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                        rc.Label_TableNum.Visible = true;
                                        rc.Txt_TableNum.Visible = true;
                                        rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                    }

                                  

                                        ds.Tables["Order"].Clear();
                                        for (int i = 0; i < dt6.Rows.Count; i++)
                                        {
                                            ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                            dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                            dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                        }
                                        rc.DataSource = ds;
                                        rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                        rc.Parameters["Id"].Visible = false;
                                        //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                        // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                        rc.PrinterName = Properties.Settings.Default.PrinterDrinks;
                                        rc.Print();
                                        rc.Dispose();

                                    
                                }
                                #endregion


                                //كود طباعة الماكولات فقط
                                #region
                                XtraReportCheck rcmakolat = new XtraReportCheck();
                                dt6.Clear();
                                dt6 = o.PritOrderNewRowMakolat(Convert.ToInt32(Lable_Num.Text));
                                if (dt6.Rows.Count > 0)
                                {


                                    if (dt6.Rows[0][11].ToString() == "Table")
                                    {
                                        dt5.Clear();

                                        dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                        rcmakolat.Label_TableNum.Visible = true;
                                        rcmakolat.Txt_TableNum.Visible = true;
                                        rcmakolat.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                    }


                                        ds.Tables["Order"].Clear();
                                        for (int i = 0; i < dt6.Rows.Count; i++)
                                        {
                                            ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                            dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                            dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                        }
                                        rcmakolat.DataSource = ds;
                                        rcmakolat.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                        rcmakolat.Parameters["Id"].Visible = false;
                                        //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                        // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                        rcmakolat.PrinterName = Properties.Settings.Default.PrinterChecken;
                                        rcmakolat.Print();
                                        rcmakolat.Dispose();
                                    
                                }
                                #endregion

                            }
                        }
                        /////كود طباعة فاتورة للعميل ///////
                        if (Properties.Settings.Default.PrintOrderInHold == "true")
                        {
                            XtraReport1Order ro = new XtraReport1Order();

                            dt5.Clear();
                            dt5 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                            if (dt5.Rows[0][11].ToString() == "Delivery")
                            {
                                dt6.Clear();
                                dt6 = o.Select_DeliveyMan(Convert.ToInt32(Lable_Num.Text));
                                ro.Txt_DeliveryService.Visible = true;
                                ro.Lable_DeliveryService.Visible = true;
                                ro.Lable_DeliveryName.Visible = true;
                                ro.Txt_DeliveryName.Visible = true;
                                ro.Txt_DeliveryName.Text = dt6.Rows[0][1].ToString();
                            }

                            if (dt5.Rows[0][11].ToString() == "Table")
                            {
                                dt6.Clear();
                                dt6 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));

                                ro.Lable_TableNum.Visible = true;
                                ro.Txt_TableNum.Visible = true;
                                ro.Txt_TableNum.Text = dt6.Rows[0][1].ToString();
                            }
                            ds.Tables["Order"].Clear();
                            for (int i = 0; i < dt5.Rows.Count; i++)
                            {
                                ds.Tables["Order"].Rows.Add(dt5.Rows[i][0], dt5.Rows[i][1], dt5.Rows[i][4],
                                dt5.Rows[i][5], dt5.Rows[i][7], dt5.Rows[i][6], dt5.Rows[i][9], dt5.Rows[i][8],
                                dt5.Rows[i][2], (dt5.Rows[i][3]), dt5.Rows[i][11], dt5.Rows[i][10], dt5.Rows[i][12]);
                            }
                            ro.Txt_Delivery.Visible = true;
                            ro.DataSource = ds;
                            ro.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                            ro.Parameters["Id"].Visible = false;
                            //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                            //ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                            ro.PrinterName = Properties.Settings.Default.PrinterOrderClient;
                            ro.Print();
                            ro.Dispose();
                        }

                    }

                    o.DeleteOrderNewRow();

                    clear2();


                }

                dt.Clear();
                dt = o.SELECTOrderRentALLORDER();
                simpleButton4.Text = $"({dt.Rows.Count}) الفواتير المتعلقة";

                ////////////      كود التحكم فى فورمة اخرى     /////////////
                //Frm_Hold master = (Frm_Hold)Application.OpenForms["Frm_Hold"];
                //master.simpleButton3.PerformClick();




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);



            }

        }

        private void simpleButton3_Click_2(object sender, EventArgs e)
        {
            #region كود التعديل القديم
            //try
            //{
            //    if (Lable_Num.Text != "")
            //    {


            //        o.DeleteOrderNewRow();

            //        int x;
            //        for (int y = 0; y < gridView2.RowCount; y++)
            //        {
            //            DataRow row = gridView2.GetDataRow(y);
            //            dt5.Clear();
            //            dt5 = o.VildateQuantity(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(row[2]), Convert.ToInt32(row[5]));
            //            foreach (DataRow dr in dt5.Rows)
            //            {
            //                x = Convert.ToInt32(row[5]) - Convert.ToInt32(dr[2]);



            //                if (dt5.Rows.Count > 0)
            //                {
            //                    o.AddOrderNewRow(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
            //                  x, Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));

            //                }
            //            }
            //            dt10 = o.VildateOrderDetails(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(row[2]));
            //            if (dt10.Rows.Count == 0)
            //            {


            //                o.AddOrderNewRow(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
            //           Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
            //            }





            //        }


            //        //  ------------------------------------------------------------//
            //        o.Delete_ProdFromOrderDetails(Convert.ToInt32(Lable_Num.Text));
            //        for (int i = 0; i < gridView2.RowCount; i++)
            //        {
            //            DataRow row = gridView2.GetDataRow(i);
            //            o.AddOrderDetails(Convert.ToInt32(row[2]), Convert.ToDecimal(row[4]),
            //               Convert.ToInt32(row[5]), Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(row[6]));
            //        }
            //        o.UpdateOrder(Convert.ToInt32(Lable_Num.Text), Convert.ToDecimal(txt_delivery.Text), Convert.ToDecimal(txt_invo.Text),
            //    0, Convert.ToDecimal(txt_invo.Text), Convert.ToDecimal(txt_discount.Text));
            //        t.UpdateSala(Convert.ToInt32(Lable_Num.Text), Convert.ToInt32(cmb_Table.SelectedValue));
            //        MessageBox.Show("تم التعديل بنجاح");





            //        //  -----------------------------------------------------------------------------------------

            //        if (Lable_Num.Text != string.Empty)
            //        {


            //            dt.Clear();
            //            dt = o.validatePritOrderNewRow(Convert.ToInt32(Lable_Num.Text));
            //            if (dt.Rows.Count > 0)
            //            {




            //                if (rdb_delivery.Checked == true)
            //                {
            //                    RPT.rptNewRowDAELIVERYMakolat ro = new RPT.rptNewRowDAELIVERYMakolat();
            //                    RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

            //                    // s.crystalReportViewer1.RefreshReport();
            //                    ro.SetDatabaseLogon("", "", ".", "Restuarnt");
            //                    ro.SetParameterValue("@id", (Convert.ToInt32(Lable_Num.Text)));
            //                    if (ro.Rows.Count > 0)
            //                    {
            //                        //  s.crystalReportViewer1.ReportSource = ro;
            //                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
            //                        ro.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
            //                        ro.PrintToPrinter(1, true, 0, 0);
            //                        ro.Close();
            //                        s.Dispose();


            //                    }
            //                    //////////////////////////////////////////////
            //                    ///


            //                    RPT.rptNewRowDAELIVERY newrowdel = new RPT.rptNewRowDAELIVERY();
            //                    RPT.Frm_ReportOrder snewrowdel = new RPT.Frm_ReportOrder();

            //                    // snewrowdel.crystalReportViewer1.RefreshReport();
            //                    newrowdel.SetDatabaseLogon("", "", ".", "Restuarnt");
            //                    newrowdel.SetParameterValue("@id", (Convert.ToInt32(Lable_Num.Text)));
            //                    if (newrowdel.Rows.Count > 0)
            //                    {


            //                        //  snewrowdel.crystalReportViewer1.ReportSource = newrowdel;
            //                        System.Drawing.Printing.PrintDocument printDocumentnewdel = new System.Drawing.Printing.PrintDocument();
            //                        newrowdel.PrintOptions.PrinterName = printDocumentnewdel.PrinterSettings.PrinterName;
            //                        newrowdel.PrintToPrinter(1, true, 0, 0);
            //                        newrowdel.Close();
            //                        snewrowdel.Dispose();



            //                        //GC.Collect();
            //                        //GC.WaitForPendingFinalizers();
            //                    }


            //                }
            //                o.DeleteOrderNewRow();
            //                // clear2();
            //            }

            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("لا بد من وجود فاتورة مسبقة للتعديل");
            //    }


            //}

            //catch (Exception ex)
            //{

            //    MessageBox.Show("لايوجد طابعه متصله");
            //    MessageBox.Show(ex.Message);
            //}
            #endregion   

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
                    Console.Beep();
                }

            }
        }



        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Frm_Hold fh = new Frm_Hold();
            fh.ShowDialog();
        }

        private void Frm_AnotherForm_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Lable_Num.Text != "")
                {
                    DataTable dt6 = new DataTable();
                    DataSet1 ds = new DataSet1();
                    ////////////////   كود طباعة امر تشغيل   ///////////
                    if (Properties.Settings.Default.PrintCheckenInHold == "true")
                    {


                        if (Properties.Settings.Default.CheckenType == "collect")
                        {
                            XtraReportCheck rc = new XtraReportCheck();
                            dt6.Clear();
                            dt6 = o.PrintOrder(Convert.ToInt32(Lable_Num.Text));
                            if (dt6.Rows[0][11].ToString() == "Table")
                            {
                                dt5.Clear();

                                dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                rc.Label_TableNum.Visible = true;
                                rc.Txt_TableNum.Visible = true;
                                rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                            }

                            ds.Tables["Order"].Clear();
                            for (int i = 0; i < dt6.Rows.Count; i++)
                            {
                                ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                            }
                            rc.DataSource = ds;
                            rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                            rc.Parameters["Id"].Visible = false;
                            //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                            // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                            rc.PrinterName = Properties.Settings.Default.PrinterChecken;
                            rc.Print();
                            rc.Dispose();
                        }
                        if (Properties.Settings.Default.CheckenType == "seperator")
                        {
                            //كود طباعة المشروبات فقط
                            #region
                            XtraReportCheck rc = new XtraReportCheck();
                            dt6.Clear();
                            dt6 = o.PrintOrderDeliveryDrinks(Convert.ToInt32(Lable_Num.Text));
                            if (dt6.Rows.Count > 0)
                            {


                                if (dt6.Rows[0][11].ToString() == "Table")
                                {
                                    dt5.Clear();

                                    dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                    rc.Label_TableNum.Visible = true;
                                    rc.Txt_TableNum.Visible = true;
                                    rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                }


                                ds.Tables["Order"].Clear();
                                for (int i = 0; i < dt6.Rows.Count; i++)
                                {
                                    ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                    dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                    dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                }
                                rc.DataSource = ds;
                                rc.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                rc.Parameters["Id"].Visible = false;
                                //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                rc.PrinterName = Properties.Settings.Default.PrinterDrinks;
                                rc.Print();
                                rc.Dispose();
                            }

                            #endregion

                            //كود طباعة الماكولات فقط
                            #region
                            XtraReportCheck rcmakolat = new XtraReportCheck();
                            dt6.Clear();
                            dt6 = o.PrintOrderDeliveryMakolat(Convert.ToInt32(Lable_Num.Text));
                            if (dt6.Rows.Count > 0)
                            {
                                if (dt6.Rows[0][11].ToString() == "Table")
                                {
                                    dt5.Clear();

                                    dt5 = o.PrintOrderSala(Convert.ToInt32(Lable_Num.Text));
                                    rcmakolat.Label_TableNum.Visible = true;
                                    rcmakolat.Txt_TableNum.Visible = true;
                                    rcmakolat.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                                }
                                ds.Tables["Order"].Clear();
                                for (int i = 0; i < dt6.Rows.Count; i++)
                                {
                                    ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                                    dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                                    dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                                }
                                rcmakolat.DataSource = ds;
                                rcmakolat.Parameters["Id"].Value = Convert.ToInt32(Lable_Num.Text);
                                rcmakolat.Parameters["Id"].Visible = false;
                                //System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                                // ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                                rcmakolat.PrinterName = Properties.Settings.Default.PrinterChecken;
                                rcmakolat.Print();
                                rcmakolat.Dispose();
                            }
                            #endregion
                        }
                    }
                }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmb_customer_MouseClick(object sender, MouseEventArgs e)
        {
            InformationClient();
        }

        private void cmb_customer_MouseDown(object sender, MouseEventArgs e)
        {
            InformationClient();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    





