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
    public partial class HalamanHapusDokter : Form
    {
        public HalamanHapusDokter()
        {
            InitializeComponent();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {

        }

        private void Batal_Click(object sender, EventArgs e)
        {
            this.Dispose();
            using (HalamanDepan halamanDepan = new HalamanDepan())
            {
                halamanDepan.ShowDialog();
            }
        }
    }
}
