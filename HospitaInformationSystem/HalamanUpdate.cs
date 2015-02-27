using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystem
{
    public partial class HalamanUpdate : Form
    {
        Database db = new Database();
        private string nama;
        private string alamat;
        private string tanggal_registrasi;
        private string no_hp;
        private string tempat_lahir;
        private string tanggal_lahir;

        private string id;
        
        public HalamanUpdate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] datapasien = searchPasien(txtId.Text);
            txtNama.Text = datapasien[1];
            txtAlamat.Text = datapasien[2];
            txtHp.Text = datapasien[4];
            txtTTL.Text = datapasien[5];
            dtpTTL.Text = datapasien[6];
            
        }
        public string[] searchPasien(string id)
        {
            db.openConnection();
            string sql = "select * from pasien where id_pasien ='"+id+"'";
            string[] data = db.queryNoReturn(sql);
            db.closeConnection();
            return data;
        }

        private void SetData()
        {
             id = txtId.Text;
             nama = txtNama.Text;
             alamat = txtAlamat.Text;
             tanggal_registrasi = "2015-02-15";// System.DateTime.Now.ToShortDateString;
             no_hp = txtHp.Text ;
             tempat_lahir = txtTTL.Text;
             tanggal_lahir = dtpTTL.Text;
        }

        public void ResetForm()
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtHp.Text = "";
            txtTTL.Text = "2015-02-15";
            dtpTTL.Text = "";
            txtNama.Focus();
        }


        public void updatePasien()
        {
            this.SetData();
            db.openConnection();
            db.query("update pasien set nama = '"+nama+"',alamat = '"+alamat+"', no_hp ='"+no_hp+"',tempat_lahir ='"+tempat_lahir+"',tanggal_lahir = '"+tanggal_lahir+"' where  id_pasien ='"+id+"'");
            db.closeConnection();

        }
        public void detelePasien()
        {
            this.SetData();
            db.openConnection();
            db.query("delete from pasien where id_pasien = '"+id+"'");
            db.closeConnection();
        }

   
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Id Pasien tidak Boleh Kosong");
            }
            else
            {
                this.detelePasien();
                MessageBox.Show("Delete Sukses");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Id Pasien tidak Boleh Kosong");
            }
            else
            {
                this.updatePasien();
                MessageBox.Show("Update Sukses");
            }
        }

        
    }



}
