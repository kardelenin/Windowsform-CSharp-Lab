using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using islemler;

namespace DDL
{
   

    
    
    public partial class Form1 : Form
    {
        dortislem islemyap = new dortislem();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_topla_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = islemyap.topla(Convert.ToInt32(txt_birincisayi.Text), Convert.ToInt32(txt_ikincisayi.Text)).ToString() ;
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = islemyap.cikarma(Convert.ToInt32(txt_birincisayi.Text), Convert.ToInt32(txt_ikincisayi.Text)).ToString(); 
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = islemyap.carpma(Convert.ToInt32(txt_birincisayi.Text), Convert.ToInt32(txt_ikincisayi.Text)).ToString(); 
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = islemyap.bolme(Convert.ToDouble(txt_birincisayi.Text), Convert.ToDouble(txt_ikincisayi.Text)).ToString();
        }
    }
}
