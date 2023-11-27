using KutuphaneOtomasyonWinForm.kaynak;
using KutuphaneOtomasyonWinForm.kullanici;
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
    public partial class islemPaneli : Form
    {
        public islemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void islemPaneli_Load(object sender, EventArgs e)
        {
            // kullanıcı butonları girişte kapalıdır.
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible= false;
            silKullanicibtn.Visible = false;

            // kaynak butonaları girişte kapalıdır.
            ekleKaynakBtn.Visible = false;
            guncelleKaynakbtn.Visible = false;
            silKaynakbtn.Visible = false;
        }

        private void Kullanicibtn_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
            }

            kullaniciListeForm klisteForm = new kullaniciListeForm();
            klisteForm.MdiParent = this;
            klisteForm.Show();
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciEkle ekleForm = new kullaniciEkle();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciSil silForm = new kullaniciSil();
            silForm.MdiParent = this;
            silForm.Show();
        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciGuncelle Guncelle = new kullaniciGuncelle();
            Guncelle.MdiParent = this;
            Guncelle.Show();
        }

        private void kaynakbtn_Click(object sender, EventArgs e)
        {
            if (ekleKaynakBtn.Visible == false)
            {
                ekleKaynakBtn.Visible = true;
                guncelleKaynakbtn.Visible = true;
                silKaynakbtn.Visible = true;
            }
            else
            {
                ekleKaynakBtn.Visible = false;
                guncelleKaynakbtn.Visible = false;
                silKaynakbtn.Visible = false;
            }

            kaynakListe kliste = new kaynakListe();
            kliste.MdiParent = this;
            kliste.Show();

        }

        private void ekleKaynakBtn_Click(object sender, EventArgs e)
        {
            kaynakEkle kEkle=new kaynakEkle();
            kEkle.MdiParent = this;
            kEkle.Show();
        }

        private void silKaynakbtn_Click(object sender, EventArgs e)
        {
            kaynakSil kSil=new kaynakSil();
            kSil.MdiParent = this;
            kSil.Show();
        }

        private void guncelleKaynakbtn_Click(object sender, EventArgs e)
        {
            kaynakGuncelle kGuncelle = new kaynakGuncelle();
            kGuncelle.MdiParent = this;
            kGuncelle.Show();
        }
    }
}
