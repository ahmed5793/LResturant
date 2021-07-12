using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Restuarnt.BL;
using Restuarnt.RPT.Exstra_Report;
using System;
using System.Data;
using System.Windows.Forms;
namespace Restuarnt.PL
{
    public partial class Sales_Management : Form
    {

        Order o = new Order();
        Delivery d = new Delivery();

        Stuff s = new Stuff();
        BL.Login l = new BL.Login();
        public Sales_Management()
        {
            InitializeComponent();
            selectUser();
            rdb_all.Checked = true;
            gridControl1.DataSource = o.SearchMangmentOrders(DateTime.Now, DateTime.Now);
            cmb_delivery.DataSource = d.SelectDeliverycomp();
            cmb_delivery.DisplayMember = "Name";
            cmb_delivery.ValueMember = "ID_Delivery";


            cmb_stuff.DataSource = s.SelectStuuf();
            cmb_stuff.DisplayMember = "اسم الكابتن";
            cmb_stuff.ValueMember = "رقم الكابتن";

        }
        void selectUser()
        {
            try
            {

                cmb_Users.DataSource = l.SelectComboUsers();
                cmb_Users.DisplayMember = "UserName";
                cmb_Users.ValueMember = "ID_User";

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
            Name_Cust.Caption = "اسم العميل";
            Name_Cust.FieldName = "اسم العميل";
            id_take.Caption = "رقم الطلب";
            id_take.FieldName = "رقم الطلب";
            id_take.Visible = false;

            FromDate.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            ToDate.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            dateEdit1.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            dateEdit2.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            dateEdit3.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            dateEdit4.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            dateEdit5.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            dateEdit6.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            dateEdit7.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
            dateEdit8.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm tt");
        }



        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void btn_save_Click(object sender, EventArgs e)
        {




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

        private void Rdb_orders_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_delivery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_sala_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_takeaway_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {

        }

        private void rdb_all_CheckedChanged(object sender, EventArgs e)
        {

            if (rdb_all.Checked == true)
            {
                gridControl1.DataSource = null;
                Name_Cust.Caption = "اسم العميل";
                Name_Cust.FieldName = "اسم العميل";
                id_take.Caption = "رقم الطلب";
                id_take.FieldName = "رقم الطلب";
                id_take.Visible = false;
                //gridControl1.DataSource = o.SearchMangmentOrders(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));

            }
        }

        private void rdb_sala_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_sala.Checked == true)
            {
                gridControl1.DataSource = null;
                id_take.Visible = true;
                Name_Cust.Caption = "رقم الطاوله";
                Name_Cust.FieldName = "رقم الطاوله";
                id_take.Caption = "الكابتن";
                id_take.FieldName = "الكابتن";
                //gridControl1.DataSource = o.SearchManagmentOrderSala(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));



            }
        }

        private void rdb_delivery_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_delivery.Checked == true)
            {
                gridControl1.DataSource = null;
                id_take.Visible = true;
                Name_Cust.Caption = "اسم العميل";
                Name_Cust.FieldName = "اسم العميل";
                id_take.Caption = "اسم الطيار";
                id_take.FieldName = "اسم الطيار";
                //gridControl1.DataSource = o.SearchManamentTOrderDelivery(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));

            }
        }

        private void rdb_takeaway_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_takeaway.Checked == true)
            {
                gridControl1.DataSource = null;
                Name_Cust.Caption = "اسم العميل";
                Name_Cust.FieldName = "اسم العميل";
                id_take.Caption = "رقم الطلب";
                id_take.FieldName = "رقم الطلب";
                id_take.Visible = false;
                //gridControl1.DataSource = o.SearchManagmentOrderTakwAway(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));



            }
        }

        private void simpleButton5_Click_2(object sender, EventArgs e)
        {
            if (rdb_all.Checked == true)
            {
                gridControl1.DataSource = o.SearchMangmentOrders(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));

            }
            else if (rdb_takeaway.Checked == true)
            {

                gridControl1.DataSource = o.SearchManagmentOrderTakwAway(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));



            }
            else if (rdb_delivery.Checked == true)
            {

                gridControl1.DataSource = o.SearchManamentTOrderDelivery(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));

            }
            else if (rdb_sala.Checked == true)
            {

                gridControl1.DataSource = o.SearchManagmentOrderSala(Convert.ToDateTime(FromDate.EditValue), Convert.ToDateTime(ToDate.EditValue));



            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }


        DataTable dt5 = new DataTable();
        DataTable dt6 = new DataTable();
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "show_print")
            {

                try
                {
                    if (gridView1.RowCount > 0)
                    {
                        XtraReport1Order ro = new XtraReport1Order();
                        DataSet1 ds = new DataSet1();
                        RPT.Frm_ReportOrder fr = new RPT.Frm_ReportOrder();
                        fr.documentViewer1.Refresh();
                        dt5.Clear();
                        dt5 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        if (gridView1.GetFocusedRowCellValue(Statues).ToString() == "Delivery")
                        {
                            dt6.Clear();
                            dt6 = o.Select_DeliveyMan(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                            ro.Txt_DeliveryService.Visible = true;
                            ro.Lable_DeliveryService.Visible = true;
                            ro.Lable_DeliveryName.Visible = true;
                            ro.Txt_DeliveryName.Visible = true;
                            ro.Txt_DeliveryName.Text = dt6.Rows[0][1].ToString();

                        }

                        if (gridView1.GetFocusedRowCellValue(Statues).ToString() == "Table")
                        {


                            dt6.Clear();
                            dt6 = o.PrintOrderSala(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
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
                        ro.Parameters["Id"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة"));
                        ro.Parameters["Id"].Visible = false;
                        fr.documentViewer1.DocumentSource = ro;
                        fr.Show();
                        // ro.Dispose();

                        //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        //ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                        // ro.PrinterName = Properties.Settings.Default.PrinterName;
                        // ro.Print();

                        ////كود طباعة امر التشغيل للمطبخ//////////////

                        //DataTable dt6 = new DataTable();
                        //XtraReportCheck rc = new XtraReportCheck();
                        //DataSet1 ds1 = new DataSet1();
                        //dt6.Clear();
                        //dt6 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        //if (dt5.Rows[0][11].ToString() == "Table")
                        //{
                        //    dt6.Clear();

                        //    dt6 = o.PrintOrderSala(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        //    rc.Label_TableNum.Visible = true;
                        //    rc.Txt_TableNum.Visible = true;
                        //    rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                        //}

                        //dt6.Clear();
                        //dt6 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        //ds.Tables["Order"].Clear();
                        //for (int i = 0; i < dt6.Rows.Count; i++)
                        //{
                        //    ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                        //    dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                        //    dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                        //}
                        //rc.DataSource = ds;
                        //rc.Parameters["Id"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة"));
                        //rc.Parameters["Id"].Visible = false;
                        ////System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                        //// ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                        //rc.PrinterName = Properties.Settings.Default.PrinterName;
                        //rc.Print();
                    }
                    else
                    {
                        MessageBox.Show("لايوجد بيانات للطباعه");
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (e.Column.Name == "print")
            {
                try
                {
                    if (gridView1.RowCount > 0)
                    {

                        XtraReport1Order ro = new XtraReport1Order();
                        DataSet1 ds = new DataSet1();
                        RPT.Frm_ReportOrder fr = new RPT.Frm_ReportOrder();
                        dt5.Clear();
                        dt5 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        if (gridView1.GetFocusedRowCellValue(Statues).ToString() == "Delivery")
                        {
                            dt6.Clear();
                            dt6 = o.Select_DeliveyMan(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                            ro.Txt_DeliveryService.Visible = true;
                            ro.Lable_DeliveryService.Visible = true;
                            ro.Lable_DeliveryName.Visible = true;
                            ro.Txt_DeliveryName.Visible = true;
                            ro.Txt_DeliveryName.Text = dt6.Rows[0][1].ToString();

                        }

                        if (gridView1.GetFocusedRowCellValue(Statues).ToString() == "Table")
                        {


                            dt6.Clear();
                            dt6 = o.PrintOrderSala(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                            ro.Lable_TableNum.Visible = true;
                            ro.Txt_TableNum.Visible = true;
                            ro.xrLabel11.Visible = true;
                            ro.txtcaptin.Visible = true;
                            ro.Txt_TableNum.Text = dt6.Rows[0][1].ToString();
                            ro.txtcaptin.Text = dt6.Rows[0][3].ToString();
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
                        ro.Parameters["Id"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة"));
                        ro.Parameters["Id"].Visible = false;

                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                        ro.PrinterName = Properties.Settings.Default.PrinterOrderClient;
                        ro.Print();

                        ro.Dispose();
                        ////كود طباعة امر التشغيل للمطبخ//////////////

                        //DataTable dt6 = new DataTable();
                        //XtraReportCheck rc = new XtraReportCheck();
                        //DataSet1 ds1 = new DataSet1();
                        //dt6.Clear();
                        //dt6 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        //if (dt5.Rows[0][11].ToString() == "Table")
                        //{
                        //    dt6.Clear();

                        //    dt6 = o.PrintOrderSala(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        //    rc.Label_TableNum.Visible = true;
                        //    rc.Txt_TableNum.Visible = true;
                        //    rc.Txt_TableNum.Text = dt5.Rows[0][1].ToString();
                        //}

                        //dt6.Clear();
                        //dt6 = o.PrintOrder(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        //ds.Tables["Order"].Clear();
                        //for (int i = 0; i < dt6.Rows.Count; i++)
                        //{
                        //    ds.Tables["Order"].Rows.Add(dt6.Rows[i][0], dt6.Rows[i][1], dt6.Rows[i][4],
                        //    dt6.Rows[i][5], dt6.Rows[i][7], dt6.Rows[i][6], dt6.Rows[i][9], dt6.Rows[i][8],
                        //    dt6.Rows[i][2], (dt6.Rows[i][3]), dt6.Rows[i][11], dt6.Rows[i][10], dt6.Rows[i][12]);
                        //}
                        //rc.DataSource = ds;
                        //rc.Parameters["Id"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة"));
                        //rc.Parameters["Id"].Visible = false;
                        ////System.Drawing.Printing.PrintDocument printDocumentch = new System.Drawing.Printing.PrintDocument();
                        //// ro.PrinterName = printDocument.PrinterSettings.PrinterName;
                        //rc.PrinterName = Properties.Settings.Default.PrinterName;
                        //rc.Print();
                    }
                    else
                    {
                        MessageBox.Show("لايوجد بيانات للطباعه");
                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (cmb_delivery.Text == "")
                {
                    XtraMessageBox.Show("من فضلك قم بااختيار اسم الطيار", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    return;
                }

                gridControl2.DataSource = o.SELECtAllOrderOneDelivery(Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue), Convert.ToInt32(cmb_delivery.SelectedValue));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {

            if (cmb_stuff.Text == "")
            {
                MessageBox.Show("من فضلك قم بااختيار اسم الكابتن");
                return;
            }
            gridControl3.DataSource = s.REPORTStuff(Convert.ToInt32(cmb_stuff.SelectedValue), Convert.ToDateTime(dateEdit3.EditValue),
                Convert.ToDateTime(dateEdit4.EditValue));



        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {


            try
            {
                if (rdb_drink.Checked == true)
                {
                    gridControl4.DataSource = o.ReportOrderDepartment(rdb_drink.Text, Convert.ToDateTime(dateEdit5.EditValue), Convert.ToDateTime(dateEdit6.EditValue));

                }
                else if (rdb_eat.Checked == true)
                {
                    gridControl4.DataSource = o.ReportOrderDepartment(rdb_eat.Text, Convert.ToDateTime(dateEdit5.EditValue), Convert.ToDateTime(dateEdit6.EditValue));

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rdb_eat_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rdb_drink_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            gridControl5.DataSource = l.SelectUserAllOrddr(Convert.ToDateTime(dateEdit7.EditValue), Convert.ToDateTime(dateEdit8.EditValue), Convert.ToInt32(cmb_Users.SelectedValue));

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            try
            {

                if (gridView1.RowCount > 0)
                {
                    if (rdb_all.Checked == true)
                    {
                        decimal total = 0;
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            DataRow r = gridView1.GetDataRow(i);
                            total += Convert.ToDecimal(r[4]);
                        }
                        RPT.rptTotalDay ro = new RPT.rptTotalDay();
                        RPT.Frm_ReportOrder s = new RPT.Frm_ReportOrder();

                        //s.crystalReportViewer1.RefreshReport();
                        ro.SetDatabaseLogon("", "", ".", "DB_A54A03_Resturant");
                        ro.SetParameterValue("@FromDate", FromDate.EditValue);
                        ro.SetParameterValue("@ToDate", ToDate.EditValue);
                        ro.SetParameterValue("@total", total);
                        //s.crystalReportViewer1.ReportSource = ro;

                        System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        ro.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName;
                        ro.PrintToPrinter(1, true, 0, 0);
                        ro.Close();
                        s.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("لا بد من اختيار كل المبيعات لطباعة تقرير المبيعات");
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("لايوجد بيانات للطباعه ");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
