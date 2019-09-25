namespace CNLGELİRGİDERTAKİP
{
    partial class NotIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotIslemleri));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NotListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NotTarihi = new System.Windows.Forms.DateTimePicker();
            this.NotTarih = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NotAciklama = new System.Windows.Forms.RichTextBox();
            this.NotId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NotGuncelle = new System.Windows.Forms.Button();
            this.NotSil = new System.Windows.Forms.Button();
            this.NotEkle = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.NotListesi);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox3.Location = new System.Drawing.Point(393, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 376);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panel3.Location = new System.Drawing.Point(0, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 30);
            this.panel3.TabIndex = 53;
            // 
            // NotListesi
            // 
            this.NotListesi.AllowUserToAddRows = false;
            this.NotListesi.AllowUserToDeleteRows = false;
            this.NotListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotListesi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.NotListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotListesi.Location = new System.Drawing.Point(6, 47);
            this.NotListesi.Name = "NotListesi";
            this.NotListesi.ReadOnly = true;
            this.NotListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NotListesi.Size = new System.Drawing.Size(362, 323);
            this.NotListesi.TabIndex = 21;
            this.NotListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotListesi_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NotTarihi);
            this.groupBox1.Controls.Add(this.NotTarih);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.NotAciklama);
            this.groupBox1.Controls.Add(this.NotId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NotGuncelle);
            this.groupBox1.Controls.Add(this.NotSil);
            this.groupBox1.Controls.Add(this.NotEkle);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 376);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Tarih :";
            // 
            // NotTarihi
            // 
            this.NotTarihi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NotTarihi.Location = new System.Drawing.Point(65, 56);
            this.NotTarihi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.NotTarihi.Name = "NotTarihi";
            this.NotTarihi.Size = new System.Drawing.Size(106, 26);
            this.NotTarihi.TabIndex = 55;
            this.NotTarihi.Value = new System.DateTime(2019, 7, 1, 0, 0, 0, 0);
            // 
            // NotTarih
            // 
            this.NotTarih.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotTarih.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NotTarih.Location = new System.Drawing.Point(65, 59);
            this.NotTarih.Name = "NotTarih";
            this.NotTarih.Size = new System.Drawing.Size(81, 20);
            this.NotTarih.TabIndex = 54;
            this.NotTarih.Text = "28.09.1987";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 30);
            this.panel1.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOTLAR";
            // 
            // NotAciklama
            // 
            this.NotAciklama.BackColor = System.Drawing.SystemColors.Window;
            this.NotAciklama.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotAciklama.Location = new System.Drawing.Point(8, 84);
            this.NotAciklama.Name = "NotAciklama";
            this.NotAciklama.Size = new System.Drawing.Size(358, 231);
            this.NotAciklama.TabIndex = 16;
            this.NotAciklama.Text = " ";
            // 
            // NotId
            // 
            this.NotId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotId.AutoSize = true;
            this.NotId.BackColor = System.Drawing.SystemColors.Window;
            this.NotId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NotId.Location = new System.Drawing.Point(323, 61);
            this.NotId.Name = "NotId";
            this.NotId.Size = new System.Drawing.Size(41, 20);
            this.NotId.TabIndex = 51;
            this.NotId.Text = "1234";
            this.NotId.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(284, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "ID :";
            this.label6.Visible = false;
            // 
            // NotGuncelle
            // 
            this.NotGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.NotGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.NotGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotGuncelle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotGuncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.NotGuncelle.Location = new System.Drawing.Point(137, 321);
            this.NotGuncelle.Name = "NotGuncelle";
            this.NotGuncelle.Size = new System.Drawing.Size(111, 32);
            this.NotGuncelle.TabIndex = 18;
            this.NotGuncelle.Text = "Güncelle";
            this.NotGuncelle.UseVisualStyleBackColor = false;
            this.NotGuncelle.Click += new System.EventHandler(this.NotGuncelle_Click);
            // 
            // NotSil
            // 
            this.NotSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.NotSil.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.NotSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotSil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotSil.ForeColor = System.Drawing.SystemColors.Window;
            this.NotSil.Location = new System.Drawing.Point(269, 321);
            this.NotSil.Name = "NotSil";
            this.NotSil.Size = new System.Drawing.Size(95, 32);
            this.NotSil.TabIndex = 19;
            this.NotSil.Text = "Notu Sil";
            this.NotSil.UseVisualStyleBackColor = false;
            this.NotSil.Click += new System.EventHandler(this.NotSil_Click);
            // 
            // NotEkle
            // 
            this.NotEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.NotEkle.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.NotEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotEkle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotEkle.ForeColor = System.Drawing.SystemColors.Window;
            this.NotEkle.Location = new System.Drawing.Point(6, 321);
            this.NotEkle.Name = "NotEkle";
            this.NotEkle.Size = new System.Drawing.Size(111, 32);
            this.NotEkle.TabIndex = 17;
            this.NotEkle.Text = "Not Ekle";
            this.NotEkle.UseVisualStyleBackColor = false;
            this.NotEkle.Click += new System.EventHandler(this.NotEkle_Click);
            // 
            // NotIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 403);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotIslemleri";
            this.Text = "NotIslemleri";
            this.Load += new System.EventHandler(this.NotIslemleri_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NotListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label NotTarih;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button NotGuncelle;
        public System.Windows.Forms.Button NotSil;
        public System.Windows.Forms.Button NotEkle;
        private System.Windows.Forms.DataGridView NotListesi;
        private System.Windows.Forms.DateTimePicker NotTarihi;
        private System.Windows.Forms.RichTextBox NotAciklama;
        private System.Windows.Forms.Label NotId;

    }
}