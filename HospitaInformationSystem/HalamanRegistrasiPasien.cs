using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace HospitalSystem
{
    public partial class HalamanRegistrasiPasien : Form
    {
        private string nama;
        private string alamat;
        private string tanggal_registrasi;
        private string no_hp;
        private string tempat_lahir;
        private string tanggal_lahir;
        Database db = new Database();

        public HalamanRegistrasiPasien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void SetData()
        {
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

        private void SavePasien()
        {
            this.SetData();
            string sql = "insert into pasien (nama,alamat,tanggal_registrasi,no_hp,tempat_lahir,tanggal_lahir)"
                    + "values('" + nama + "','" + alamat + "','" + tanggal_registrasi + "','" + no_hp + "','" + tempat_lahir + "','" + tanggal_lahir + "') ";
            this.QueryData(sql);

        }

        private void QueryData(string query)
        {

            db.openConnection();
            db.query(query);
            db.closeConnection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SavePasien();
            ResetForm();
            MessageBox.Show("Update Data Sukses");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HalamanUpdate form = new HalamanUpdate();
            form.Show();
            this.Hide();
        }
    }
}
