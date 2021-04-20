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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORİ.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORİ t = new TBLKATEGORİ();
            t.AD = textBox2.Text;
            db.TBLKATEGORİ.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi!!!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATEGORİ.Find(x);
            db.TBLKATEGORİ.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi!!!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATEGORİ.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi!!!");
        }
    }
}
