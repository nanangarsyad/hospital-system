using HospitalSystem;
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
    public partial class HalamanDepan : Form
    {
        private HalamanTambah halamanTambah = new HalamanTambah();
        private HalamanEdit halamanEdit = new HalamanEdit();
        private HalamanHapus halamanHapus = new HalamanHapus();
        private HalamanTambahObat halamanTambahObat = new HalamanTambahObat();
        private HalamanEditObat halamanEditObat = new HalamanEditObat();
        private HalamanHapusObat halamanHapusObat = new HalamanHapusObat();
        private HalamanTambahDokter halamanTambahDokter = new HalamanTambahDokter();
        private HalamanEditDokter halamanEditDokter = new HalamanEditDokter();
        private HalamanHapusDokter halamanHapusDokter = new HalamanHapusDokter();
        private HalamanTransaksi halamanTransaksi = new HalamanTransaksi();
        public HalamanDepan()
        {
            InitializeComponent();
            TambahDokter.Hide();
            EditDokter.Hide();
            HapusDokter.Hide();
            TambahObat.Hide();
            EditObat.Hide();
            HapusObat.Hide();
            TambahPasien.Hide();
            EditPasien.Hide();
            HapusPasien.Hide();
         
        }

        private void ManPasien_Click(object sender, EventArgs e)
        {
            TambahDokter.Hide();
            EditDokter.Hide();
            HapusDokter.Hide();
            TambahObat.Hide();
            EditObat.Hide();
            HapusObat.Hide();
            TambahPasien.Show();
            EditPasien.Show();
            HapusPasien.Show();
        }

        private void ManDokter_Click(object sender, EventArgs e)
        {
            TambahObat.Hide();
            EditObat.Hide();
            HapusObat.Hide();
            TambahPasien.Hide();
            EditPasien.Hide();
            HapusPasien.Hide();
            TambahDokter.Show();
            EditDokter.Show();
            HapusDokter.Show();

        }

        private void ManObat_Click(object sender, EventArgs e)
        {
            TambahDokter.Hide();
            EditDokter.Hide();
            HapusDokter.Hide();
            TambahPasien.Hide();
            EditPasien.Hide();
            HapusPasien.Hide();
            TambahObat.Show();
            EditObat.Show();
            HapusObat.Show();
        }

        private void TambahPasien_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanTambah.Show();
        }

        private void EditPasien_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanEdit.Show();
        }

        private void HapusPasien_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanHapus.Show();
        }

        private void TambahObat_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanTambahObat.Show();
        }

        private void EditObat_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanEditObat.Show();
        }

        private void HapusObat_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanHapusObat.Show();
        }

        private void TambahDokter_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanTambahDokter.Show();
        }

        private void EditDokter_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanEditDokter.Show();
        }

        private void HapusDokter_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanHapusDokter.Show();
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            halamanTransaksi.Show();
        }

    }
}
