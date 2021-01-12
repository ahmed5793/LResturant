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
    public partial class Frm_Phrchise : Form
    {
        Unit u = new Unit();
        Suppliers s = new Suppliers();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        Product p = new Product();
        private static Frm_Phrchise farm;


        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Phrchise getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Phrchise();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }
        public Frm_Phrchise()
        {
            
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }

            SelectdataTable();

            cmb_supplier.DataSource = s.SelectCompoSupplier();
            cmb_supplier.DisplayMember = "Name";
            cmb_supplier.ValueMember = "Sup_id";

            cmb_Proudect.DataSource = p.SelectProdec();
            cmb_Proudect.DisplayMember = "اسم الصنف";
            cmb_Proudect.ValueMember = "رقم الصنف";
        }
      

        public void SelectdataTable()
        {
            dt2.Columns.Add("رقم الصنف");
            dt2.Columns.Add("اسم الصنف");
          
            dt2.Columns.Add("الكميه");
          






            dataGridView1.DataSource = dt2;








        }

        private void Btn_pay_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_printCheken_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.Rows.Count > 0)
                {
                    if (cmb_supplier.Text=="")
                    {
                        MessageBox.Show("من فضلك قم باادخال اسم المورد");
                        return;
                    }
                    

                    dt = s.VildateSUppliers(Convert.ToInt32(cmb_supplier.SelectedValue), cmb_supplier.Text);
                    if (dt.Rows.Count > 0)
                    {


                        s.AddPhrichise(Convert.ToInt32(cmb_supplier.SelectedValue), dateTimePicker1.Value);
                            txt_num.Text = s.LastsuppliersID().Rows[0][0].ToString();
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                s.AddPhrichiseDetails(Convert.ToInt32(txt_num.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value));

                            }
                             MessageBox.Show("تم حفظ", "عمليه الحفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                             clear();

                }

                else if (dt.Rows.Count == 0)
                {
                    s.addSuppliers(cmb_supplier.Text);
                    txt_cust.Text = s.LastsuppliersNameID().Rows[0][0].ToString();
                    s.AddPhrichise(Convert.ToInt32(txt_cust.Text), dateTimePicker1.Value);
                    txt_num.Text = s.LastsuppliersID().Rows[0][0].ToString();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        s.AddPhrichiseDetails(Convert.ToInt32(txt_num.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value));

                    }

                        MessageBox.Show("تم حفظ", "عمليه الحفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        cmb_supplier.DataSource = s.SelectCompoSupplier();
                        cmb_supplier.DisplayMember = "Name";
                        cmb_supplier.ValueMember = "Sup_id";
                        clear();
                    }
            }
                
                
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void clear()
        {
            txt_num.Clear();
            txt_quantity.Text = "0";
            txt_cust.Clear();
            dt2.Clear();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == cmb_Proudect.SelectedValue.ToString())
                {
                    Console.Beep();
                    MessageBox.Show("هذا الصنف مسجل من قبل ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                  
                    return;

                }

            }
            if (cmb_Proudect.Text == "")
            {
                MessageBox.Show("من فضلك قم بتسجيل الصنف ");
                return;
            }


            if (txt_quantity.Text == "")
            {
                MessageBox.Show("من فضلك قم بكتابه الكمية");
                return;
            }

          
        

                DataRow r = dt2.NewRow();
                r[0] = cmb_Proudect.SelectedValue;
                r[1] = cmb_Proudect.Text;

                r[2] = txt_quantity.Text;


                dt2.Rows.Add(r);

                dataGridView1.DataSource = dt2;
                Console.Beep();

                txt_quantity.Text = "0";
                 

            
           


               
               
           
            
        }
        //internal void totalInvoice()
        //{
        //    decimal x = 0;

        //    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
        //    {
        //        x += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

        //    }
        //    label7.Text = Math.Round(x, 2).ToString();


        //}
        //internal void totalProudect()
        //{
        //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //    {


        //        decimal x = Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value) * (Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value));
        //        dataGridView1.Rows[i].Cells[3].Value = x.ToString();
        //    }
        //}

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Btn_addItem_Click(object sender, EventArgs e)
        {
            Frm_Prodects p= new Frm_Prodects();
            p.ShowDialog();

        }

        private void Txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_quantity.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Frm_Phrchise_Load(object sender, EventArgs e)
        {
            txt_cust.Hide();
            txt_num.Hide();
            cmb_supplier.DataSource = s.SelectCompoSupplier();
            cmb_supplier.DisplayMember = "Name";
            cmb_supplier.ValueMember = "Sup_id";


        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
