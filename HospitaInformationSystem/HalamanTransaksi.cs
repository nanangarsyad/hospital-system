using HospitaInformationSystem;
using HospitaInformationSystem.Modal;
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
    public partial class HalamanTransaksi : Form
    {
        private string idKuitansi;
        DatabaseQuery db = new DatabaseQuery();
        Database dbs = new Database();
        public HalamanTransaksi()
        {
            InitializeComponent();
            txtIdPasien.TextChanged += new EventHandler(handlerPasienChanged);
            txtIdDokter.TextChanged += new EventHandler(handlerDokterChanged);
        }
        
        private void handler(object o,EventArgs e)
        {
            
        }
        private void handlerPasienChanged(object o,EventArgs e)
        {
            lblNamaPasien.Text = searchPasien(txtIdPasien.Text)[1];
            lblAlamat.Text = searchPasien(txtIdPasien.Text)[2];
        }

        private void handlerDokterChanged(object o, EventArgs e)
        {
            lblDokter.Text = db.searchDokterJoinPoli(txtIdDokter.Text)[0];
            lblPoli.Text = db.searchDokterJoinPoli(txtIdDokter.Text)[1];
        }
        public string[] searchPasien(string id)
        {

            return db.searchPasien(id);
        }

        public string[] searchDokter(string id_dokter)
        {
            return db.searchDokter(id_dokter);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            lblNoKuitansi.Text = db.getIdTrans()[0];
            txtJumlah.Hide();
            lblJumlah.Hide();
            lblTgl.Text = System.DateTime.Now.ToShortDateString();
            idKuitansi = db.getIdTrans()[0];
            
        }

        private void BtnAddTindakan_Click(object sender, EventArgs e)
        {

            string tarif = "0";
            string query = "";
            Console.WriteLine("kategori = "  + cboKategori.Text);
            if(cboKategori.Text=="Jasa")
            {
                query = "insert into temp_transaksi_detail (jasa,tarif,id_transaksi) values ('" + txtItem.Text + "','" + txtJumlah.Text + "','" + idKuitansi + "') ";
                 
            }
            else if(cboKategori.Text =="Obat")
            {
                tarif = db.getObat(txtItem.Text)[2];
                query = "insert into temp_transaksi_obat (id_obat,tarif,jumlah,id_transaksi) values ('"+txtItem.Text+"','"+tarif+"','"+txtJumlah.Text+"','"+idKuitansi+"') ";
            }
            Console.WriteLine(query);
            db.query(query);

            dbs.openConnection();
            // Console.WriteLine("SELECT jasa as tindakan,'1' jumlah ,tarif,tarif as total from temp_transaksi_detail where id_transaksi=id_transaksi='" + idKuitansi + "' union SELECT nama_obat,temp_transaksi_obat.jumlah,temp_transaksi_obat.tarif,temp_transaksi_obat.jumlah*temp_transaksi_obat.tarif as total from temp_transaksi_obat LEFT JOIN obat on temp_transaksi_obat.id_obat=obat.id_obat WHERE id_transaksi='" + idKuitansi + "'");
            dbs.select("SELECT jasa as tindakan,'1' jumlah ,tarif,tarif as total from temp_transaksi_detail where id_transaksi='" + idKuitansi + "' union SELECT nama_obat,temp_transaksi_obat.jumlah,temp_transaksi_obat.tarif,temp_transaksi_obat.jumlah*temp_transaksi_obat.tarif as total from temp_transaksi_obat LEFT JOIN obat on temp_transaksi_obat.id_obat=obat.id_obat WHERE id_transaksi='" + idKuitansi + "'");
            
            DataSet ds = dbs.resultSelect();
            gridTrans.DataSource = ds.Tables[0];
            dbs.closeConnection();    
        }

        private void cboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblJumlah.Show();
            txtJumlah.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.query("insert into transaksi (id_pasien,id_dokter,tanggal,rujukan) values ('" + txtIdPasien.Text + "','" + txtIdDokter.Text + "','" + lblTgl.Text + "','"+txtRujukan.Text+"')");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            using (HalamanDepan halamanDepan = new HalamanDepan())
            {
                halamanDepan.ShowDialog();
            }
        }

         
    }
}
