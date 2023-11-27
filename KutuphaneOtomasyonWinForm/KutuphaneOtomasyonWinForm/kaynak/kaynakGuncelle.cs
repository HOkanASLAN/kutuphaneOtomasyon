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
    public partial class kaynakGuncelle : Form
    {
        public kaynakGuncelle()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();   
        private void kaynakGuncelle_Load(object sender, EventArgs e)
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adKaynaktxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazarKaynaktxt.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yayinciKaynaktxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sSayisi.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            tarih.Value =Convert.ToDateTime( dataGridView1.CurrentRow.Cells[5].Value);
         }

        private void kaynakEklebtn_Click(object sender, EventArgs e)
        {
            int secilenKaynak =Convert.ToInt16( dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenecekKaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenKaynak).FirstOrDefault();
            guncellenecekKaynak.kaynak_ad = adKaynaktxt.Text;
            guncellenecekKaynak.kaynak_yazar = yazarKaynaktxt.Text;
            guncellenecekKaynak.kaynak_yayinci = yayinciKaynaktxt.Text;
            guncellenecekKaynak.kaynak_sayfasayisi =Convert.ToInt16( sSayisi.Value);
            guncellenecekKaynak.kaynak_basimtarihi = tarih.Value;
            db.SaveChanges();

            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

        }
    }
}
