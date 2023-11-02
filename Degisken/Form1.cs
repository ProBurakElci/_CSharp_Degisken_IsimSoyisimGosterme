using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degisken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            // DEĞİŞKEN KULLANMADAN

           // MessageBox.Show(txtAdi.Text + " "+ txtSoyadi.Text);


            // DEĞİŞKEN KULLANARAK

            string isim = txtAdi.Text;
            string soyad = txtSoyadi.Text;

            MessageBox.Show(isim + " " + soyad);
             //int i = txtAdi.Text;
   // NOT : Değişkene değer aktyarırken = in sağındaki ve solundaki veri tipleri UYUMLU olmalıdır.
       // int i = txtAdi.TextLength;
            string soyisim = txtSoyadi.Text;
            // NOT : mbox yazıp 2 kere tab tuşuna basılırsa MessageBox.Show otomatik yazılır.
     

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
