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
    public partial class HalamanEditDokter : Form
    {
        public HalamanEditDokter()
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

        private void Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
