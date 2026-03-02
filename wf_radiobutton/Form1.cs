using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            string ad, soyad, cinsiyet = " ";//null verdim atamada
            ad=txt_ad.Text;
            soyad=txt_soyad.Text;

            if (radio_kız.Checked)
            {
                cinsiyet = "Kız";

            }
            else
            {
                cinsiyet= "Erkek";
            }

            MessageBox.Show("Adınız : " + ad + "\n" + "Soyadınız : " + soyad + "\n" + "Cinsiyetiniz : " + cinsiyet);




        }
    }
}
