using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Entity
{
    class Obat
    {
        public int idObat;
        public string namaObat;
        private int tarif;
        private int stok;

        /**
         * Encapusulate Obat entity
         */
        public Obat()
        {
           
        }

        #region Setter and Getter
        public int IdObat
        {
            get { return idObat; }
            set { idObat = value; }
        }

        public int TarifObat
        {
            get { return tarif; }
            set { tarif = value; }
        }

        public int StokObat
        {
            get { return stok; }
            set { stok = value; }
        }

        public string Namaobat
        {
            get { return namaObat; }
            set { namaObat = value; }
        }

        #endregion
       
    }
}
