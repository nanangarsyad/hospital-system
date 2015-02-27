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
    public partial class HalamanTambah : Form
    {
         private string nama;
        private string alamat;
        private string tanggal_registrasi;
        private string no_hp;
        private string tempat_lahir;
        private string tanggal_lahir;
        Database db = new Database();

        public HalamanTambah()
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
             tanggal_registrasi = System.DateTime.Now.ToShortDateString();
             no_hp = txtHp.Text ;
             tempat_lahir = txtTTL.Text;
             tanggal_lahir = dtpTTL.Text;
        }

        public void ResetForm()
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtHp.Text = "";
            txtTTL.Text = System.DateTime.Now.ToShortDateString();
            dtpTTL.Text = "";
            txtNama.Focus();
        }

        private void SavePasien()
        {
            this.SetData();
            string sql = "insert into pasien (nama,alamat,tanggal_registrasi,no_hp,tempat_lahir,tanggal_lahir)"
                    + "values('" + nama + "','" + alamat + "','" + tanggal_registrasi + "','" + no_hp + "','" + tempat_lahir + "','" + tanggal_lahir + "') ";
            Console.WriteLine(sql);
            this.QueryData(sql);
        }

        private void QueryData(string query)
        {

            db.openConnection();
            db.query(query);
            db.closeConnection();
        }


        
        private void TambahCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            using (HalamanDepan halamanDepan = new HalamanDepan())
            {
                halamanDepan.ShowDialog();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            this.SavePasien();
            ResetForm();
            MessageBox.Show("Penambahan Data Pasien Sukses");
        }
    }
}
