using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarnt.PL
{
    public partial class Frm_Prise : Form
    {
        public Frm_Prise()
        {
            InitializeComponent();
          
        }

        private void Txt_Quantity_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {



            this.Close();


        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Prise.Clear();
            this.Close();
        }

        private void Frm_Prise_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Prise_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txt_Prise.Text != string.Empty)
            {

                this.Close();
               
            }
        }

        private void Txt_Prise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!=Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
            else if(e.KeyChar=='.'&& txt_Prise.Text.ToString().IndexOf('.')>-1)
            {
                e.Handled = true;
            }
        }

        private void Txt_Prise_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
