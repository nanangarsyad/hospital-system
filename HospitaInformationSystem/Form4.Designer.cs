namespace HospitaInformationSystem
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NamaObat = new System.Windows.Forms.TextBox();
            this.HargaObat = new System.Windows.Forms.TextBox();
            this.BanyakObat = new System.Windows.Forms.TextBox();
            this.TambahOke = new System.Windows.Forms.Button();
            this.TambahCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(110, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(110, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(110, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Banyak Obat";
            // 
            // NamaObat
            // 
            this.NamaObat.Location = new System.Drawing.Point(222, 89);
            this.NamaObat.Name = "NamaObat";
            this.NamaObat.Size = new System.Drawing.Size(181, 20);
            this.NamaObat.TabIndex = 3;
            // 
            // HargaObat
            // 
            this.HargaObat.Location = new System.Drawing.Point(222, 126);
            this.HargaObat.Name = "HargaObat";
            this.HargaObat.Size = new System.Drawing.Size(181, 20);
            this.HargaObat.TabIndex = 4;
            // 
            // BanyakObat
            // 
            this.BanyakObat.Location = new System.Drawing.Point(222, 163);
            this.BanyakObat.Name = "BanyakObat";
            this.BanyakObat.Size = new System.Drawing.Size(181, 20);
            this.BanyakObat.TabIndex = 5;
            // 
            // TambahOke
            // 
            this.TambahOke.Location = new System.Drawing.Point(117, 212);
            this.TambahOke.Name = "TambahOke";
            this.TambahOke.Size = new System.Drawing.Size(101, 33);
            this.TambahOke.TabIndex = 6;
            this.TambahOke.Text = "button1";
            this.TambahOke.UseVisualStyleBackColor = true;
            // 
            // TambahCancel
            // 
            this.TambahCancel.Location = new System.Drawing.Point(232, 212);
            this.TambahCancel.Name = "TambahCancel";
            this.TambahCancel.Size = new System.Drawing.Size(101, 33);
            this.TambahCancel.TabIndex = 7;
            this.TambahCancel.Text = "button2";
            this.TambahCancel.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(450, 257);
            this.Controls.Add(this.TambahCancel);
            this.Controls.Add(this.TambahOke);
            this.Controls.Add(this.BanyakObat);
            this.Controls.Add(this.HargaObat);
            this.Controls.Add(this.NamaObat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Tambah Data Obat";
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


    }
}