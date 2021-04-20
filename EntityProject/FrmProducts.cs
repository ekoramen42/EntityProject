using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORİ.AD,
                                            x.DURUMU
                                        }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txtUrunAd.Text;
            t.MARKA = txtMarka.Text;
            t.STOK = short.Parse(textBox3.Text);
            t.KATEGORİ = int.Parse(cmbKategori.SelectedValue.ToString());
            t.FIYAT = int.Parse(textBox4.Text);
            t.DURUMU = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün siteme Kaydedildi!!!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Listeden Kaldırılıdı!!!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = txtUrunAd.Text;
            urun.STOK = short.Parse(textBox3.Text);
            urun.MARKA = txtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi!!!");
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORİ
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            cmbKategori.ValueMember = "ID";
            cmbKategori.DisplayMember = "AD";
            cmbKategori.DataSource = kategoriler;
        }
    }
}
