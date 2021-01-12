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
    public partial class Frm_Quantity : Form
    {
       
        public Frm_Quantity()
        {
            InitializeComponent();
           

        }

        private void Frm_Quantity_Load(object sender, EventArgs e)
        {
          
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Quantity.Clear();
            this.Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
           

            



                this.Close();
          
        }

      

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Quantity_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void Txt_Prise_KeyDown(object sender, KeyEventArgs e)
        {
         

            if (e.KeyCode == Keys.Enter )
            {
            
                  


             
                    this.Close();




                 




                }
              
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void Txt_Quantity_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
