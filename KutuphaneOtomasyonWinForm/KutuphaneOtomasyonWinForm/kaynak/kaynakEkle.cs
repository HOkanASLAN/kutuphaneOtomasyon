using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.kaynak
{
    public partial class kaynakEkle : Form
    {
        public kaynakEkle()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void kaynakEklebtn_Click(object sender, EventArgs e)
        {
            Kaynaklar kaynaklar =new Kaynaklar();
            kaynaklar.kaynak_ad = adKaynaktxt.Text;
            kaynaklar.kaynak_yazar = yazarKaynaktxt.Text;
            kaynaklar.kaynak_yayinci = yayinciKaynaktxt.Text;
            kaynaklar.kaynak_sayfasayisi = Convert.ToInt16(sSayisi.Value);
            kaynaklar.kaynak_basimtarihi = tarih.Value;
            db.Kaynaklar.Add(kaynaklar);
            db.SaveChanges();

            var Listele = db.Kaynaklar.ToList();
            dataGridView1.DataSource = Listele.ToList();

        }

    }
}
