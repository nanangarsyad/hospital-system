namespace HospitaInformationSystem
{
    partial class HalamanTambah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanTambah));
            this.TambahBatal = new System.Windows.Forms.Button();
            this.dtpTTL = new System.Windows.Forms.DateTimePicker();
            this.txtTTL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TambahBatal
            // 
            this.TambahBatal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TambahBatal.Location = new System.Drawing.Point(257, 290);
            this.TambahBatal.Name = "TambahBatal";
            this.TambahBatal.Size = new System.Drawing.Size(104, 34);
            this.TambahBatal.TabIndex = 21;
            this.TambahBatal.Text = "Batal";
            this.TambahBatal.UseVisualStyleBackColor = true;
            this.TambahBatal.Click += new System.EventHandler(this.TambahCancel_Click);
            // 
            // dtpTTL
            // 
            this.dtpTTL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTTL.Location = new System.Drawing.Point(270, 175);
            this.dtpTTL.Name = "dtpTTL";
            this.dtpTTL.Size = new System.Drawing.Size(99, 20);
            this.dtpTTL.TabIndex = 39;
            // 
            // txtTTL
            // 
            this.txtTTL.Location = new System.Drawing.Point(163, 175);
            this.txtTTL.Name = "txtTTL";
            this.txtTTL.Size = new System.Drawing.Size(100, 20);
            this.txtTTL.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "TTL";
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(163, 149);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(100, 20);
            this.txtHp.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "No Hp";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(163, 97);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(169, 45);
            this.txtAlamat.TabIndex = 34;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(163, 69);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 20);
            this.txtNama.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nama";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 34);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitaInformationSystem.Properties.Resources.PASIEN_TAMBAH;
            this.pictureBox1.Location = new System.Drawing.Point(75, -177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 847);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // HalamanTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.TambahBatal;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.dtpTTL);
            this.Controls.Add(this.txtTTL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TambahBatal);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "HalamanTambah";
            this.Text = "Tambah Data Pasien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TambahBatal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpTTL;
        private System.Windows.Forms.TextBox txtTTL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}