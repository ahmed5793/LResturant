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
using DevExpress.XtraGrid.Views.Layout;
using Restuarnt.BL;


namespace Restuarnt.PL
{
    public partial class Frm_Menu : Form
    {
        Category c = new Category();
        BL.Menu m = new BL.Menu();
      
        public Frm_Menu()
        {
            InitializeComponent();
            comboBox1.DataSource = c.SelectCategoryCompo();
            comboBox1.DisplayMember = "Ctegory_Name";
            comboBox1.ValueMember = "ID_Category";
       
            btn_update.Enabled = false;

            gridControl1.DataSource = m.SelectMenu();

            layoutView1.Columns[0].Visible = false;
            //   cardView1.Columns[4].Visible = false;
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
               


                if (txt_name.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال اسم الصنف");
                return;

            }

             if(comboBox1.Text=="")
            {

                MessageBox.Show("من فضلك يرجي ادخال الفئه");
                comboBox1.Focus();
                return;
            }
            if (txt_seeling.Text == "")
            {

                MessageBox.Show("من فضلك يرجي ادخال سعر البيع");
                txt_seeling.Focus();
                return;
            }
                if (imagePath=="")
                {
                    imagePath = Application.StartupPath + @"\Resources" + @"\image-not-found-scaled-1150x6471.png";

                }

                //convert image to byte save in db
                FileStream filestream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                Byte[] bytestream = new Byte[filestream.Length];
                filestream.Read(bytestream, 0, bytestream.Length);
                filestream.Close();

                m.AddMenu(txt_name.Text, Convert.ToDecimal(txt_seeling.Text), Convert.ToInt32(comboBox1.SelectedValue),bytestream);
            MessageBox.Show("تم الاضافه  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
           
            gridControl1.DataSource = m.SelectMenu();
            clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);


            }
        }

        private void DataGridViewPR_DoubleClick(object sender, EventArgs e)
        {
           


        }
       
    private void Btn_update_Click(object sender, EventArgs e)
        {
          
        }

        private void Txt_seeling_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_seeling.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        string imagePath= "";
         
        private void btnChoose_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                imagePath = openFileDialog.FileName.ToString();
                pictureLogo.Image = null;
                pictureLogo.ImageLocation = imagePath;
            }
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            pictureLogo.BackgroundImage = Properties.Resources.image_not_found_scaled_1150x647;
            pictureLogo.Image = Properties.Resources.image_not_found_scaled_1150x647;
            imagePath = Application.StartupPath + @"\Resources" + @"\image-not-found-scaled-1150x6471.png";
        }

        void clear()
        {
            btn_update.Enabled = false;
            btn_add.Enabled = true;
            comboBox1.Enabled = true;
            pictureLogo.BackgroundImage = Properties.Resources.image_not_found_scaled_1150x647; 
            pictureLogo.Image = Properties.Resources.image_not_found_scaled_1150x647;
            imagePath = "";
            txt_name.Clear();
            txt_seeling.Clear();
            lable_num.Text = "";
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
           
          
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال اسم الصنف");
                return;

            }
           

            if (imagePath == "")
            {
                m.UpdateMenu(txt_name.Text, Convert.ToDecimal(txt_seeling.Text), Convert.ToInt32(lable_num.Text), Convert.ToInt32(comboBox1.SelectedValue), (byte[])layoutView1.GetFocusedRowCellValue("Images"));
            }
            else
            {

                FileStream filestream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                Byte[] bytestream = new Byte[filestream.Length];
                filestream.Read(bytestream, 0, bytestream.Length);
                filestream.Close();
                m.UpdateMenu(txt_name.Text, Convert.ToDecimal(txt_seeling.Text), Convert.ToInt32(lable_num.Text), Convert.ToInt32(comboBox1.SelectedValue), bytestream);
            }

            MessageBox.Show("تم التعديل  بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
           
            gridControl1.DataSource = m.SelectMenu();
            clear();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //m.deleteMenu(Convert.ToInt32(layoutView1.GetFocusedRowCellValue("Item_ID")));


            //MessageBox.Show("تم المسح  بنجاح", "عمليه المسح", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            //gridControl1.DataSource = m.SelectMenu();
            //clear();
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل تريد المسح", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

            {

                m.deleteMenu(Convert.ToInt32(layoutView1.GetFocusedRowCellValue("Item_ID")));


                MessageBox.Show("تم المسح  بنجاح", "عمليه المسح", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                gridControl1.DataSource = m.SelectMenu();
                clear();
            }
            
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (layoutView1.RowCount > 0)
            {
                //convert from byte to image 

                byte[] image = (byte[])layoutView1.GetFocusedRowCellValue("Images");
                MemoryStream f = new MemoryStream(image);
                pictureLogo.Image = Image.FromStream(f);

                btn_add.Enabled = false;
                btn_update.Enabled = true;
                lable_num.Text= layoutView1.GetFocusedRowCellValue(Item_ID).ToString();
                comboBox1.Text = layoutView1.GetFocusedRowCellValue("الفئه").ToString();
                txt_name.Text = layoutView1.GetFocusedRowCellValue("اسم الصنف").ToString();
                txt_seeling.Text = layoutView1.GetFocusedRowCellValue("السعر").ToString();
                

            }

        }

        private void txt_seeling_Click(object sender, EventArgs e)
        {
            txt_seeling.SelectAll();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
