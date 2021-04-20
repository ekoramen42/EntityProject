
namespace EntityProject
{
    partial class FrmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(176, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(146, 31);
            this.txtId.TabIndex = 1;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(176, 70);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(146, 31);
            this.txtUrunAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÜRÜN ADI:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(176, 107);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(146, 31);
            this.txtMarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "MARKA:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 31);
            this.textBox3.TabIndex = 7;
            // 
            // txtStok
            // 
            this.txtStok.AutoSize = true;
            this.txtStok.Location = new System.Drawing.Point(111, 152);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(62, 23);
            this.txtStok.TabIndex = 6;
            this.txtStok.Text = "STOK:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 31);
            this.textBox4.TabIndex = 9;
            // 
            // txtFiyat
            // 
            this.txtFiyat.AutoSize = true;
            this.txtFiyat.Location = new System.Drawing.Point(106, 189);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(67, 23);
            this.txtFiyat.TabIndex = 8;
            this.txtFiyat.Text = "FİYATI:";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(176, 218);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(146, 31);
            this.txtDurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "DURUM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "KATEGORİ:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(405, 45);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(194, 56);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(405, 106);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(194, 63);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(405, 175);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(194, 51);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(405, 232);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(194, 48);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 220);
            this.dataGridView1.TabIndex = 19;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(176, 255);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(146, 31);
            this.cmbKategori.TabIndex = 20;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 531);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtStok;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtFiyat;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbKategori;
    }
}