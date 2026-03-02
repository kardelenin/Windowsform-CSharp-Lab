using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_tutarhesapla_Click(object sender, EventArgs e)
        {
            int tutar =0;
            if(checkbox_cay.Checked)
            {
                tutar += 50;
            }

            if(checkbox_kahve.Checked)
            {
                tutar += 200;
            }

            if(checkbox_hamburger.Checked)
            {
                tutar += 300;
            }
            if (checkbox_pizza.Checked)
            {
                tutar += 350;
            }

            lbl_tutar.Text=tutar.ToString();


        }
    }
}
