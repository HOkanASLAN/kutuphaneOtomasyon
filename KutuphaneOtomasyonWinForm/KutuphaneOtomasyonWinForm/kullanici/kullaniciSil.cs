using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.kullanici
{
    public partial class kullaniciSil : Form
    {
        public kullaniciSil()
        {
            InitializeComponent();
        }
        
        KutuphaneOtomasyonEntities db=new KutuphaneOtomasyonEntities();
        public void Listele()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void kullaniciSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenID =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenID).FirstOrDefault();
            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            Listele();
        }
    }
}
