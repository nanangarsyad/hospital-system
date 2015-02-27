using HospitalSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Transaksi
{
     abstract class TransaksiBase
    {
        protected string rujukan;
        protected int idTransaksi;
        protected int idPasien;
        protected int idDokter;
        protected DateTime tanggalTransaksi;

         public TransaksiBase()
         {
             // init the constructor here
         }

         public abstract ETransaksi JenisTransaksi { get; }    

         public int IdTransaksi
         {
             get { return idTransaksi; }
             set { idTransaksi = value; }
         }

         public int IdPasien
         {
             get { return idTransaksi; }
             set { idTransaksi = value; }
         }      

         public DateTime TanggalTransaksi
         {
             get { return tanggalTransaksi; }
             set { tanggalTransaksi = value; }
         }

         public string Rujukan
         {
             get { return rujukan; }
             set { rujukan = value; }
         }
         
         

    }
}
