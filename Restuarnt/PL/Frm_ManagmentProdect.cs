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
    public partial class Frm_ManagmentProdect : Form
    {
        Product p = new Product();
        public Frm_ManagmentProdect()
        {
            InitializeComponent();
            dataGridViewList.DataSource = p.SelectProdec();
        }

        private void Frm_ManagmentProdect_Load(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            dt = p.SearchProduct(textBox1.Text);
            dataGridViewList.DataSource = dt;

        }
    }
}
