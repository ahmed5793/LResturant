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
                    Txt_DeliveryService.Text = Properties.Settings.Default.DeliveryService.ToString();
                    if (Properties.Settings.Default.OrderType=="صالة")
                    {
                        Rdb_Sala.Checked = true;
                    }
                    if (Properties.Settings.Default.OrderType == "دليفرى")
                    {
                        Rdb_Deleviry.Checked = true;
                    }
                    if (Properties.Settings.Default.OrderType == "تيك اواى")
                    {
                        Rdb_TakeAway.Checked = true;
                    }
                    /////////////////
                    if (Properties.Settings.Default.PrintCheckenInHold == "true")
                    {
                        check_checkenInHold.Checked = true;
                    }
                    if (Properties.Settings.Default.PrintCheckenInHold == "false")
                    {
                        
                        check_checkenInHold.Checked = false;
                    }

                    ////////////////////////
                    if (Properties.Settings.Default.PrintOrderInHold == "true")
                    {
                        
                        check_OrderInhold.Checked = true;
                    }
                    if (Properties.Settings.Default.PrintOrderInHold == "false")
                    {
                        
                        check_OrderInhold.Checked = false;
                    }

                    ////////////////////////////
                    if (Properties.Settings.Default.PrintCheckenInSave == "true")
                    {
                        
                        check_CheckenInSave.Checked = true;
                    }
                    if (Properties.Settings.Default.PrintCheckenInSave == "false")
                    {
                        
                        check_CheckenInSave.Checked = false;
                    }
                    /////////////////////////////
                    ///
                    if (Properties.Settings.Default.PrintOrderInSave == "true")
                    {
                        
                        check_OrderInSave.Checked = true;
                    }
                    if (Properties.Settings.Default.PrintOrderInSave == "false")
                    {
                        
                        check_OrderInSave.Checked = false;
                    }
                    ///////////////////////


                    /////////////////////////
                    if (Properties.Settings.Default.CheckenType == "collect")
                    {
                        
                        Rdb_Collect.Checked = true;
                    }
                    if (Rdb_Seperator.Checked == true)
                    {
                        Properties.Settings.Default.CheckenType = "seperator";
                        Properties.Settings.Default.Save();
                    }

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
            try
            { 
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                printerName = PrinterSettings.InstalledPrinters[i];
                cbxPrinterClient.Items.Add(printerName);
                Cmb_PrintChecken.Items.Add(printerName);
                Cmb_PrintDrinks.Items.Add(printerName);
            }

            if (Properties.Settings.Default.PrinterOrderClient == "")
            {
                cbxPrinterClient.SelectedIndex = 0;
            }
            else
            {
                    cbxPrinterClient.Text = Properties.Settings.Default.PrinterOrderClient;
                   
            }
            if (Properties.Settings.Default.PrinterChecken == "")
            {
                    Cmb_PrintChecken.SelectedIndex = 0;
            }
            else
            {
                    Cmb_PrintChecken.Text = Properties.Settings.Default.PrinterChecken;
            }

            if (Properties.Settings.Default.PrinterDrinks == "")
            {
                    Cmb_PrintDrinks.SelectedIndex = 0;
            }
            else
            {
                    Cmb_PrintDrinks.Text = Properties.Settings.Default.PrinterDrinks;
            }
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

                if (cbxPrinterClient.Text == "")
                {
                    MessageBox.Show("من فضلك تاكد من اختيار طابعة فاتورة العميل", "تاكيد");
                    return;
                }
                if (Cmb_PrintChecken.Text == "")
                {
                    MessageBox.Show("من فضلك تاكد من اختيار طابعة للمطبخ   ", "تاكيد");
                    return;
                }
                if (Cmb_PrintDrinks.Text == "")
                {
                    MessageBox.Show("من فضلك تاكد من اختيار طابعة للمشروبات   ", "تاكيد");
                    return;
                }

                Properties.Settings.Default.PrinterOrderClient = cbxPrinterClient.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.PrinterChecken = (Cmb_PrintChecken.Text);
                Properties.Settings.Default.Save();
                Properties.Settings.Default.PrinterDrinks = (Cmb_PrintDrinks.Text);
                Properties.Settings.Default.Save();
                Properties.Settings.Default.DeliveryService = Convert.ToDecimal(Txt_DeliveryService.Text);
                Properties.Settings.Default.Save();
                //////////////////////////
                if (check_checkenInHold.Checked == true)
                {
                    Properties.Settings.Default.PrintCheckenInHold = "true";
                    Properties.Settings.Default.Save();
                }
                if (check_checkenInHold.Checked == false)
                {
                    Properties.Settings.Default.PrintCheckenInHold = "false";
                    Properties.Settings.Default.Save();
                }

                ////////////////////////
                if (check_OrderInhold.Checked == true)
                {
                    Properties.Settings.Default.PrintOrderInHold = "true";
                    Properties.Settings.Default.Save();
                }
                if (check_OrderInhold.Checked == false)
                {
                    Properties.Settings.Default.PrintOrderInHold = "false";
                    Properties.Settings.Default.Save();
                }

                ////////////////////////////
                if (check_CheckenInSave.Checked == true)
                {
                    Properties.Settings.Default.PrintCheckenInSave = "true";
                    Properties.Settings.Default.Save();
                }
                if (check_CheckenInSave.Checked == false)
                {
                    Properties.Settings.Default.PrintCheckenInSave = "false";
                    Properties.Settings.Default.Save();
                }
                /////////////////////////////
                ///
                if (check_OrderInSave.Checked == true)
                {
                    Properties.Settings.Default.PrintOrderInSave = "true";
                    Properties.Settings.Default.Save();
                }
                if (check_OrderInSave.Checked == false)
                {
                    Properties.Settings.Default.PrintOrderInSave = "false";
                    Properties.Settings.Default.Save();
                }
                ///////////////////////
             

                /////////////////////////
                if (Rdb_Collect.Checked == true)
                {
                    Properties.Settings.Default.CheckenType ="collect";
                    Properties.Settings.Default.Save();
                }
                if (Rdb_Seperator.Checked == true)
                {
                    Properties.Settings.Default.CheckenType = "seperator";
                    Properties.Settings.Default.Save();
                }

                ////////////////////////////////////////
                if (Rdb_Deleviry.Checked==true)
                {
                    Properties.Settings.Default.OrderType ="دليفرى";
                    Properties.Settings.Default.Save();
                }
                if (Rdb_Sala.Checked==true)
                {
                    Properties.Settings.Default.OrderType ="صالة";
                    Properties.Settings.Default.Save();
                }
                if (Rdb_TakeAway.Checked == true)
                {
                    Properties.Settings.Default.OrderType ="تيك اواى";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}