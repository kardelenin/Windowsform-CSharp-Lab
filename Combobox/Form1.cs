using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cuma");
            comboBox1.Items.Add("Cumartesi");
            comboBox1.Items.Add("Pazar");
        }

        private void btn_gunsec_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sectiginiz Gün : " + comboBox1.SelectedItem);
        }
    }
}
