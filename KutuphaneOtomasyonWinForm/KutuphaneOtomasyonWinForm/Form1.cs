using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm
{
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;


            var pesonel =db.Personeller.Where(x =>x.personel_ad.Equals(gelenAd) && x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if(pesonel == null)
            {
                MessageBox.Show(text: "ad veya şifre yanlış");
            }
            else
            {
                MessageBox.Show(text: "Başarılı");
                islemPaneli panel = new islemPaneli();
                panel.Show();
                this.Hide();
            }
        }
    }
    }
