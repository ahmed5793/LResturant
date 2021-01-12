using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Restuarnt.PL
{
    public partial class BackUp : Form
    {
        SqlConnection con = new SqlConnection(@" server =. ; database=Restuarnt;integrated security=true");
        SqlCommand cmd;
        public BackUp()
        {
            InitializeComponent();
        }

        private void Btn_file_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Btn_backUp_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text != "")
                {

                    string fileName = textBox1.Text + "\\Restuarnt " + DateTime.Now.ToShortDateString().Replace('/', '-') + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
                    string sqlQuary = "BackUp Database Restuarnt to Disk= '" + fileName + ".bak '";
                    cmd = new SqlCommand(sqlQuary, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم إنشاء نسخة إحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("من فضلك قم بتحديد المسار ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ممنوع حفظ نسخه علي سطح المكتب");
                MessageBox.Show(ex.Message);

            }

        }
    }
}
