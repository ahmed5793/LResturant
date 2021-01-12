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
    public partial class Restore : Form
    {
        SqlConnection con = new SqlConnection(@"server =.; database=master;integrated security = true");
        SqlCommand cmd;
        public Restore()
        {
            InitializeComponent();
        }

        private void Restore_Load(object sender, EventArgs e)
        {

        }

        private void Btn_file_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Btn_Restore_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string query = "ALTER Database Restuarnt SET OFFLINE WITH ROLLBACK IMMEDIATE;Restore Database Restuarnt from Disk='" + textBox1.Text + "' WITH REPLACE";

                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استرجاع النسخه الاحتياطيه بنجاح", "استرجاع نسخه احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("من فضلك قم بتحديد المسار ");
            }
        }
    }
}
