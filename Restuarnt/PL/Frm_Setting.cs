using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.IO;
using Restuarnt.Bl;
using System.Windows.Input;

namespace Restuarnt.PL
{
    public partial class Frm_Setting : DevExpress.XtraEditors.XtraForm
    {
        SettingPrint st = new SettingPrint();

        public Frm_Setting()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        //call to show orderdata in DB
        private void showOrderData()
        {
            try
            {

          
            tbl.Clear();
            tbl = st.SelectSettingPrintOrder();

            if (tbl.Rows.Count >0)
            {
                txtName.Text = tbl.Rows[0][0].ToString();
                txtAddress.Text = tbl.Rows[0][1].ToString();
                txtDescription.Text = tbl.Rows[0][2].ToString();
                txtPhone1.Text = tbl.Rows[0][3].ToString();
                txtPhone2.Text = tbl.Rows[0][4].ToString();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        string printerName = "";
        //call to show printers name in combo
        private void showPrinters()
        {
            try { 
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                printerName = PrinterSettings.InstalledPrinters[i];
                cbxPrinter.Items.Add(printerName);
            }

            if (Properties.Settings.Default.PrinterName == "")
            {
                cbxPrinter.SelectedIndex = 0;
            }
            else
            {
                    cbxPrinter.Text = Properties.Settings.Default.PrinterName;
                   
            }
            //if (Properties.Settings.Default.PrintBarcode == "")
            //{
            //    cbx_printBarcode.SelectedIndex = 0;
            //}
            //else
            //{
                
            //    cbx_printBarcode.Text = Properties.Settings.Default.PrintBarcode;
            //}
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}
        private void Frm_Setting_Load(object sender, EventArgs e)
        {
            try
            {
                showPrinters();
            }
            catch (Exception) { }
            try
            {
                showOrderData();
            }
            catch (Exception) { }

           
           
        }

        private void btnSavePrinter_Click(object sender, EventArgs e)
        {
            //try
            //{

            
            //if (cbxPrinter.Text == "")
            //{
            //    MessageBox.Show("من فضلك تاكد من بيانات طابعة الفواتير", "تاكيد");
            //    return;
            //}
            
            //Properties.Settings.Default.PrinterName = cbxPrinter.Text;
            //Properties.Settings.Default.Save();
            ////Properties.Settings.Default.PrintBarcode = cbx_printBarcode.Text;
            ////Properties.Settings.Default.Save();

            //MessageBox.Show("تم الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }
      //  string imagePath = "";
        private void btnChoose_Click(object sender, EventArgs e)
        {
          
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
        //function to convert image to byte and save it in DB
        private void saveImage(string stmt, string paramaterName, string message)
        {

        }
        DataTable tbl = new DataTable();
       
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {

            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك اكتب اسم الشركة", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

                if (cbxPrinter.Text == "")
                {
                    MessageBox.Show("من فضلك تاكد من بيانات طابعة الفواتير", "تاكيد");
                    return;
                }

                Properties.Settings.Default.PrinterName = cbxPrinter.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.DeliveryService = Convert.ToDecimal(Txt_DeliveryService.Text);
                Properties.Settings.Default.Save();
                if (Rdb_Deleviry.Checked==true)
                {
                    Properties.Settings.Default.OrderType = Rdb_Deleviry.Text;
                    Properties.Settings.Default.Save();
                }
                else if (Rdb_Sala.Checked==true)
                {
                    Properties.Settings.Default.OrderType = Rdb_Sala.Text;
                    Properties.Settings.Default.Save();
                }
                else if (Rdb_TakeAway.Checked == true)
                {
                    Properties.Settings.Default.OrderType = Rdb_TakeAway.Text;
                    Properties.Settings.Default.Save();
                }

             tbl.Clear();
             tbl = st.SelectSettingPrintOrder();
            if (tbl.Rows.Count > 0)
            {
                st.UpdateSettingPrint(txtName.Text, txtAddress.Text, txtDescription.Text, txtPhone1.Text, txtPhone2.Text);
            }
            else
            {
                st.AddSettingPrint(txtName.Text, txtAddress.Text, txtDescription.Text, txtPhone1.Text, txtPhone2.Text);
            }
                MessageBox.Show("تم الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void btnSaveGenralSetting_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_DeliveryService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_DeliveryService.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txtPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}