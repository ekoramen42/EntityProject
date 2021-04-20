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
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void btnKtgrIslem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProducts fr = new FrmProducts();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStatistics fr = new FrmStatistics();
            fr.Show();
        }
    }
}
