using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            //burda System.Windows.Forms. ekledik başına çünkü namespace ile ismi aynı yani yapma aynı isim bi daha
            System.Windows.Forms.MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?","Bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
    }
}
