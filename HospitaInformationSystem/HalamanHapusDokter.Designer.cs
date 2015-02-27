namespace HospitaInformationSystem
{
    partial class HalamanHapusDokter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanHapusDokter));
            this.Batal = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.textBoxIdPoliklinik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNamaDokter = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdDokter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Batal
            // 
            this.Batal.Location = new System.Drawing.Point(249, 241);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(104, 34);
            this.Batal.TabIndex = 15;
            this.Batal.Text = "Batal";
            this.Batal.UseVisualStyleBackColor = true;
            this.Batal.Click += new System.EventHandler(this.Batal_Click);
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(106, 241);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(104, 34);
            this.Hapus.TabIndex = 16;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // textBoxIdPoliklinik
            // 
            this.textBoxIdPoliklinik.Location = new System.Drawing.Point(160, 181);
            this.textBoxIdPoliklinik.Name = "textBoxIdPoliklinik";
            this.textBoxIdPoliklinik.Size = new System.Drawing.Size(115, 20);
            this.textBoxIdPoliklinik.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(84, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Id Poliklinik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(84, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nama";
            // 
            // textBoxNamaDokter
            // 
            this.textBoxNamaDokter.Location = new System.Drawing.Point(160, 133);
            this.textBoxNamaDokter.Name = "textBoxNamaDokter";
            this.textBoxNamaDokter.Size = new System.Drawing.Size(229, 20);
            this.textBoxNamaDokter.TabIndex = 11;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(325, 85);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 10;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(84, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id Dokter";
            // 
            // textBoxIdDokter
            // 
            this.textBoxIdDokter.Location = new System.Drawing.Point(160, 87);
            this.textBoxIdDokter.Name = "textBoxIdDokter";
            this.textBoxIdDokter.Size = new System.Drawing.Size(132, 20);
            this.textBoxIdDokter.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitaInformationSystem.Properties.Resources.DOKTER_REMOVE;
            this.pictureBox1.Location = new System.Drawing.Point(117, -248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 847);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // HalamanHapusDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.textBoxIdPoliklinik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNamaDokter);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdDokter);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "HalamanHapusDokter";
            this.Text = "Hapus Data Dokter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Batal;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.TextBox textBoxIdPoliklinik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNamaDokter;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdDokter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}