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
    public partial class HalamanLogin : Form
    {
        Database db = new Database();
        public HalamanLogin()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtusername.Text=="")
            {
                MessageBox.Show("Username tidak boleh kosong");
            }
            else if(txtpassword.Text=="")
            {
                MessageBox.Show("Password tidak bolek kosong");
            }
            else
            {
                db.openConnection();
                string sql = "select * from pengguna where username ='" + txtusername.Text + "' and password ='" + txtpassword.Text + "'";
                Console.WriteLine(sql);
                string[] result = db.queryNoReturn(sql);
                db.closeConnection();
                if(result.Length > 0)
                {
                    HalamanDepan form = new HalamanDepan();
                    form.Show();
                    Hide();
                }
            }


        }
    }
}
