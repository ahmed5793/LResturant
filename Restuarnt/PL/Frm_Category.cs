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
using Restuarnt.BL;

namespace Restuarnt.PL
{
    public partial class Frm_Category : Form
    {
        Category c = new Category();
       
        public Frm_Category()
        {
            InitializeComponent();
            gridControl1.DataSource = c.SelectCategory();
            layoutView1.Columns[0].Visible = false;
            layoutView1.Columns[2].Visible = false;
            btn_update.Enabled = false;
           
            
        }

    



        private void Btn_add_Click(object sender, EventArgs e)
        {

           

            if (txt_name.Text=="")
            {
                MessageBox.Show("من فضلك يرجي ادخال الفئة");
                return;

            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال القسم");
                return;

            }
            if (imagePath == "")
            {
                imagePath = Application.StartupPath + @"\Resources" + @"\image-not-found-scaled-1150x6471.png";

            }
            //convert from image to byte
            FileStream filestream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            Byte[] bytestream = new Byte[filestream.Length];
            filestream.Read(bytestream, 0, bytestream.Length);
            filestream.Close();

            c.AddCategory(txt_name.Text,comboBox1.Text, bytestream);
            MessageBox.Show("تم الاضافه  بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            gridControl1.DataSource = c.SelectCategory();
            clear();
           



        }
        void clear()
        {
            txt_name.Clear();
            btn_update.Enabled = false;
            btn_add.Enabled = true;
            pictureLogo.BackgroundImage = Properties.Resources.image_not_found_scaled_1150x647;
            pictureLogo.Image = Properties.Resources.image_not_found_scaled_1150x647;
            imagePath = "";
            lable_num.Text = "";
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
         try
         {

            


            if (txt_name.Text == "")
            {
                MessageBox.Show("من فضلك يرجي ادخال الفئة");
                return;

            }

            if (imagePath == "")
            {
                c.UpdateCtegory(Convert.ToInt32(lable_num.Text), txt_name.Text, comboBox1.Text,
                    (byte[])layoutView1.GetFocusedRowCellValue("Images"));

            }
            else
            {

                FileStream filestream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                Byte[] bytestream = new Byte[filestream.Length];
                filestream.Read(bytestream, 0, bytestream.Length);
                filestream.Close();
                c.UpdateCtegory(Convert.ToInt32(lable_num.Text), txt_name.Text, comboBox1.Text, bytestream);
            }
            MessageBox.Show("تم التعديل  بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            gridControl1.DataSource = c.SelectCategory();
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

        private void Frm_Category_Load(object sender, EventArgs e)
        {

          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
         
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           
        }
        string imagePath = "";
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
        imagePath = Application.StartupPath+ @"\Resources" + @"\image-not-found-scaled-1150x6471.png";
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (layoutView1.RowCount > 0)
            {
                //convert from byte to image
                byte[] image = (byte[])layoutView1.GetFocusedRowCellValue("Images");
                MemoryStream f = new MemoryStream(image);
                pictureLogo.Image = Image.FromStream(f);
                lable_num.Text = layoutView1.GetFocusedRowCellValue(ID_Category).ToString();
                txt_name.Text = layoutView1.GetFocusedRowCellValue("الفئات").ToString();
                comboBox1.Text = layoutView1.GetFocusedRowCellValue("القسم").ToString();


                btn_add.Enabled = false;

                btn_update.Enabled = true;
            }
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل تريد المسح", "يرجي العلم في حالة مسح فئة يقوم البرنامج بمسح الاصناف المرتبطه بالفئة ديه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

            {
                c.deleteCategory(Convert.ToInt32(layoutView1.GetFocusedRowCellValue("ID_Category")));

                MessageBox.Show("تم المسح  بنجاح", "عمليه المسح", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                gridControl1.DataSource = c.SelectCategory();
            }
           

            clear();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

