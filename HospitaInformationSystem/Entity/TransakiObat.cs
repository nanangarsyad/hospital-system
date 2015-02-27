using HospitalSystem.Transaksi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Entity
{

    class TransakiObat : TransaksiBase
    {
        private Obat obat;        

        public TransakiObat() :
            base()
        {

        }

        public override ETransaksi JenisTransaksi
        {
            get { return ETransaksi.TRANSAKSI_OBAT; }
        }

        public Obat Obat
        {
            get { return obat; }
            set { obat = value;  }
        }
       
    }
}   
