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
    public partial class HalamanTambahDokter : Form
    {
        public HalamanTambahDokter()
        {
            InitializeComponent();
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            this.Dispose();
            using (HalamanDepan halamanDepan = new HalamanDepan())
            {
                halamanDepan.ShowDialog();
            }
        }

        private void Tambah_Click(object sender, EventArgs e)
        {

        }
    }
}
