namespace HospitaInformationSystem
{
    partial class HalamanTambahDokter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanTambahDokter));
            this.Batal = new System.Windows.Forms.Button();
            this.Tambah = new System.Windows.Forms.Button();
            this.textBoxIdPoliklinik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNamaDokter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdDokter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Batal
            // 
            this.Batal.Location = new System.Drawing.Point(254, 228);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(104, 34);
            this.Batal.TabIndex = 24;
            this.Batal.Text = "Batal";
            this.Batal.UseVisualStyleBackColor = true;
            this.Batal.Click += new System.EventHandler(this.Batal_Click);
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(111, 228);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(104, 34);
            this.Tambah.TabIndex = 25;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // textBoxIdPoliklinik
            // 
            this.textBoxIdPoliklinik.Location = new System.Drawing.Point(165, 168);
            this.textBoxIdPoliklinik.Name = "textBoxIdPoliklinik";
            this.textBoxIdPoliklinik.Size = new System.Drawing.Size(115, 20);
            this.textBoxIdPoliklinik.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(89, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Id Poliklinik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(89, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama";
            // 
            // textBoxNamaDokter
            // 
            this.textBoxNamaDokter.Location = new System.Drawing.Point(165, 120);
            this.textBoxNamaDokter.Name = "textBoxNamaDokter";
            this.textBoxNamaDokter.Size = new System.Drawing.Size(229, 20);
            this.textBoxNamaDokter.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(89, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id Dokter";
            // 
            // textBoxIdDokter
            // 
            this.textBoxIdDokter.Location = new System.Drawing.Point(165, 74);
            this.textBoxIdDokter.Name = "textBoxIdDokter";
            this.textBoxIdDokter.Size = new System.Drawing.Size(132, 20);
            this.textBoxIdDokter.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitaInformationSystem.Properties.Resources.DOKTER1;
            this.pictureBox1.Location = new System.Drawing.Point(92, -251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 847);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // HalamanTambahDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.textBoxIdPoliklinik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNamaDokter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdDokter);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "HalamanTambahDokter";
            this.Text = "Tambah Data Dokter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Batal;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.TextBox textBoxIdPoliklinik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNamaDokter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdDokter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}