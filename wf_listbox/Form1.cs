using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string gun = txt_eklenen.Text;
            listBox1.Items.Add(gun);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string silinecekgun = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(silinecekgun);

            //yukardakiyle aynı işi yapıyo ama direkt index seçildiği için bu yorum satırındaki daha mantıklı
           // string silinecekgun2 = listBox1.Items[listBox1.SelectedIndex].ToString();
            //listBox1.Items.Remove(silinecekgun2);
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listenin count değeri : " + listBox1.Items.Count.ToString());
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("Liste Temizlendi");
        }
    }
}
