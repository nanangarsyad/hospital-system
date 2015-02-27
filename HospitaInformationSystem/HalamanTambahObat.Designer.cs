namespace HospitaInformationSystem
{
    partial class HalamanTambahObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanTambahObat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NamaObat = new System.Windows.Forms.TextBox();
            this.HargaObat = new System.Windows.Forms.TextBox();
            this.BanyakObat = new System.Windows.Forms.TextBox();
            this.TambahOke = new System.Windows.Forms.Button();
            this.TambahCancel = new System.Windows.Forms.Button();
            this.IdObat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(103, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(103, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Banyak Obat";
            // 
            // NamaObat
            // 
            this.NamaObat.Location = new System.Drawing.Point(215, 68);
            this.NamaObat.Name = "NamaObat";
            this.NamaObat.Size = new System.Drawing.Size(181, 20);
            this.NamaObat.TabIndex = 3;
            // 
            // HargaObat
            // 
            this.HargaObat.Location = new System.Drawing.Point(215, 102);
            this.HargaObat.Name = "HargaObat";
            this.HargaObat.Size = new System.Drawing.Size(181, 20);
            this.HargaObat.TabIndex = 4;
            // 
            // BanyakObat
            // 
            this.BanyakObat.Location = new System.Drawing.Point(215, 136);
            this.BanyakObat.Name = "BanyakObat";
            this.BanyakObat.Size = new System.Drawing.Size(181, 20);
            this.BanyakObat.TabIndex = 5;
            // 
            // TambahOke
            // 
            this.TambahOke.Location = new System.Drawing.Point(134, 204);
            this.TambahOke.Name = "TambahOke";
            this.TambahOke.Size = new System.Drawing.Size(101, 33);
            this.TambahOke.TabIndex = 6;
            this.TambahOke.Text = "Tambah";
            this.TambahOke.UseVisualStyleBackColor = true;
            // 
            // TambahCancel
            // 
            this.TambahCancel.Location = new System.Drawing.Point(249, 204);
            this.TambahCancel.Name = "TambahCancel";
            this.TambahCancel.Size = new System.Drawing.Size(101, 33);
            this.TambahCancel.TabIndex = 7;
            this.TambahCancel.Text = "Batal";
            this.TambahCancel.UseVisualStyleBackColor = true;
            this.TambahCancel.Click += new System.EventHandler(this.TambahCancel_Click);
            // 
            // IdObat
            // 
            this.IdObat.Location = new System.Drawing.Point(215, 34);
            this.IdObat.Name = "IdObat";
            this.IdObat.Size = new System.Drawing.Size(181, 20);
            this.IdObat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(103, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Obat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitaInformationSystem.Properties.Resources.OBAT_OBAT_TAMBAH;
            this.pictureBox1.Location = new System.Drawing.Point(95, -247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 847);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // HalamanTambahObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.IdObat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TambahCancel);
            this.Controls.Add(this.TambahOke);
            this.Controls.Add(this.BanyakObat);
            this.Controls.Add(this.HargaObat);
            this.Controls.Add(this.NamaObat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "HalamanTambahObat";
            this.Text = "Tambah Data Obat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NamaObat;
        private System.Windows.Forms.TextBox HargaObat;
        private System.Windows.Forms.TextBox BanyakObat;
        private System.Windows.Forms.Button TambahOke;
        private System.Windows.Forms.Button TambahCancel;
        private System.Windows.Forms.TextBox IdObat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}