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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORİ.Count().ToString();
            label3.Text = db.TBLURUN.Count().ToString();
            label23.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            label17.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            label13.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            label9.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString()+" TL";
            label5.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label7.Text = (from X in db.TBLURUN orderby X.FIYAT ascending select X.URUNAD).FirstOrDefault();
            label15.Text = db.TBLURUN.Count(x => x.KATEGORİ == 1).ToString();
            label21.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label11.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            label19.Text = db.MARKAGETIR().FirstOrDefault();

        }
    }
}
