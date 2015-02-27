using HospitalSystem.Transaksi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Entity
{
    class TransaksiDetail : TransaksiBase
    {
        private string jenis;
        private int tarif;
        private int idTransaksiDetail;          
        
        public TransaksiDetail()
            : base()
        {
            
        }

        public override ETransaksi JenisTransaksi
        {
            get { return ETransaksi.TRANSAKSI_DETAIL; }
        }

        public string JenisJasa
        {
            get { return jenis; }
            set { jenis = value; }
        }          


        public int IdTransaksiDetail
        {
            get { return idTransaksiDetail; }
            set { idTransaksiDetail = value; }
        }
        
    }
}
