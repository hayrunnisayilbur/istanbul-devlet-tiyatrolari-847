namespace istanbul_devlet_tiyatrosu_847
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.numSure = new System.Windows.Forms.NumericUpDown();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbSahne = new System.Windows.Forms.ComboBox();
            this.cmbOyun = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbMuzikal = new System.Windows.Forms.CheckBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSahne = new System.Windows.Forms.Label();
            this.lblOyun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(491, 153);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnSil.Size = new System.Drawing.Size(180, 39);
            this.btnSil.TabIndex = 49;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.Location = new System.Drawing.Point(491, 101);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnGuncelle.Size = new System.Drawing.Size(180, 46);
            this.btnGuncelle.TabIndex = 48;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.Location = new System.Drawing.Point(491, 53);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnEkle.Size = new System.Drawing.Size(180, 42);
            this.btnEkle.TabIndex = 47;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 171);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(201, 20);
            this.txtId.TabIndex = 46;
            // 
            // numSure
            // 
            this.numSure.Location = new System.Drawing.Point(125, 138);
            this.numSure.Name = "numSure";
            this.numSure.Size = new System.Drawing.Size(201, 20);
            this.numSure.TabIndex = 45;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(125, 105);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 44;
            // 
            // cmbSahne
            // 
            this.cmbSahne.FormattingEnabled = true;
            this.cmbSahne.Location = new System.Drawing.Point(125, 74);
            this.cmbSahne.Name = "cmbSahne";
            this.cmbSahne.Size = new System.Drawing.Size(201, 21);
            this.cmbSahne.TabIndex = 43;
            // 
            // cmbOyun
            // 
            this.cmbOyun.FormattingEnabled = true;
            this.cmbOyun.Items.AddRange(new object[] {
            "Babamın Kelimeleriyle",
            "Çarpışma",
            "Yanlızlık İntiharı",
            "Bir Ruhun Hikayesi",
            "Yedi Kadın",
            "Masanın Altında ",
            "Limon"});
            this.cmbOyun.Location = new System.Drawing.Point(125, 41);
            this.cmbOyun.Name = "cmbOyun";
            this.cmbOyun.Size = new System.Drawing.Size(201, 21);
            this.cmbOyun.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(776, 128);
            this.dataGridView1.TabIndex = 41;
            // 
            // cbMuzikal
            // 
            this.cbMuzikal.AutoSize = true;
            this.cbMuzikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMuzikal.Location = new System.Drawing.Point(32, 208);
            this.cbMuzikal.Name = "cbMuzikal";
            this.cbMuzikal.Size = new System.Drawing.Size(78, 20);
            this.cbMuzikal.TabIndex = 40;
            this.cbMuzikal.Text = "Müzikal";
            this.cbMuzikal.UseVisualStyleBackColor = true;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(30, 172);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(48, 20);
            this.lblFiyat.TabIndex = 39;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(28, 139);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(47, 20);
            this.lblSure.TabIndex = 38;
            this.lblSure.Text = "Süre";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(28, 106);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(49, 20);
            this.lblTarih.TabIndex = 37;
            this.lblTarih.Text = "Tarih";
            // 
            // lblSahne
            // 
            this.lblSahne.AutoSize = true;
            this.lblSahne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSahne.Location = new System.Drawing.Point(28, 72);
            this.lblSahne.Name = "lblSahne";
            this.lblSahne.Size = new System.Drawing.Size(61, 20);
            this.lblSahne.TabIndex = 36;
            this.lblSahne.Text = "Sahne";
            // 
            // lblOyun
            // 
            this.lblOyun.AutoSize = true;
            this.lblOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyun.Location = new System.Drawing.Point(28, 43);
            this.lblOyun.Name = "lblOyun";
            this.lblOyun.Size = new System.Drawing.Size(50, 20);
            this.lblOyun.TabIndex = 35;
            this.lblOyun.Text = "Oyun";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.numSure);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbSahne);
            this.Controls.Add(this.cmbOyun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbMuzikal);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSahne);
            this.Controls.Add(this.lblOyun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.NumericUpDown numSure;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbSahne;
        private System.Windows.Forms.ComboBox cmbOyun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbMuzikal;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSahne;
        private System.Windows.Forms.Label lblOyun;
    }
}

