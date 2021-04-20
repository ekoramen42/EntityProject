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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities db = new DbEntityUrunEntities();
            var sorgu = from x in db.TBLADMIN where x.KULLANICI == textBox1.Text && x.SIFRE == textBox2.Text select x;
            if (sorgu.Any())
            {
                FrmMainForm fr = new FrmMainForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!!!");
            }
        }
    }
}
