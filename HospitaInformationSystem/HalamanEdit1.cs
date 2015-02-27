using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitaInformationSystem
{
    public partial class HalamanEdit : Form
    {
        public HalamanEdit()
        {
            InitializeComponent();
            
        }

        private void OnClosed(object p)
        {
            throw new NotImplementedException();
        }

        private bool FormClosingEventArgs()
        {
            throw new NotImplementedException();
        }

        private void CM_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBatal_Click(object sender, EventArgs e)
        {
            this.Dispose();
            using (HalamanDepan halamanDepan = new HalamanDepan())
            {
                halamanDepan.ShowDialog();
            }
        }

        Database db = new Database();
        private string nama;
        private string alamat;
        private string tanggal_registrasi;
        private string no_hp;
        private string tempat_lahir;
        private string tanggal_lahir;

        private string id;
        

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
             tanggal_registrasi = System.DateTime.Now.ToLongDateString();
             no_hp = txtHp.Text ;
             tempat_lahir = txtTTL.Text;
             tanggal_lahir = dtpTTL.Text;
        }

        public void ResetForm()
        {
            
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtHp.Text = "";
            txtTTL.Text = System.DateTime.Now.ToLongDateString();
            // txtTTL.Text = "2015-02-15";
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
                ResetForm();
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
                ResetForm();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            btnSearch_Click(sender,e);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }
    }
}
