using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Modal
{
    

    public class DatabaseQuery
    {
        Database db = new Database();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Pasient</returns>
        public string[] searchPasien(string id)
        {
            db.openConnection();
            string sql = "select * from pasien where id_pasien ='" + id + "'";
            string[] data = db.queryNoReturn(sql);
            db.closeConnection();
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>list Dokter </returns>
        public string[] searchDokter(string id)
        {
            db.openConnection();
            string sql = "select * from dokter where id_dokter ='" + id + "'";
            string[] data = db.queryNoReturn(sql);
            db.closeConnection();
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param> The doctor ID
        /// <returns>The Docotr and his poliklinik</returns>
        public string[] searchDokterJoinPoli(string id)
        {
            db.openConnection();
            string sql = "SELECT dokter.nama_dokter,poliklinik.nama_poli from dokter LEFT JOIN poliklinik on dokter.id_poli=poliklinik.id_poli  where id_dokter = '"+id+"'";
            string[] result = db.queryNoReturn(sql);
            db.closeConnection();
            return result;
        }

        /// <summary>
        /// Generate new Id kwitansi
        /// </summary>
        /// <returns>New id kwitansi</returns>
        public string[] generateIdKwitansi()
        {
            db.openConnection();
            string sql = "SELECT max(id_transaksi)+1 as id_kuitansi from transaksi";
            string[] result = db.queryNoReturn(sql);
            db.closeConnection();
            return result;
        }

        
        public string[] getObat(string id)
        {
            db.openConnection();
            string sql = "select * from obat where id_obat = '"+id+"'";
            string[] result = db.queryNoReturn(sql);
            db.closeConnection();
            return result;
        }

        /// <summary>
        /// Execute sql query
        /// </summary>
        /// <param name="sql"></param>
        public void query(string sql)
        {            
            db.openConnection();
            db.query(sql);
            db.closeConnection();
        }
    }

}
