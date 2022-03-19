using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_Yigin_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public class Dugum
        {
            public int sayi;
            public Dugum baglanti;
        }
        Dugum ilk;

        private void ekleButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                Dugum yeni = new Dugum();
                yeni.sayi = Convert.ToInt32(textBox1.Text);
                yeni.baglanti = ilk;
                ilk = yeni;
                yiginGoster();
            }
            
        }

        private void yiginGoster()
        {
            int yiginBoyut = 0;
            listBox1.Items.Clear();
            if (ilk==null)
            {
                MessageBox.Show("Yığın Boşaltıldı.");
                return;
            }
            else
            {
                Dugum isaretci = ilk;
                while (isaretci != null)
                {
                    yiginBoyut++;
                    listBox1.Items.Add(isaretci.sayi);
                    isaretci = isaretci.baglanti;
                }
            }
            label1.Text = "Yığının Boyutu: " + yiginBoyut.ToString();
        }

        private void cıkarButon_Click(object sender, EventArgs e)
        {
            if (ilk==null)
            {
                MessageBox.Show("Yığın Boş");
                return;
            }
            ilk = ilk.baglanti;
            yiginGoster();
        }
    }
}
