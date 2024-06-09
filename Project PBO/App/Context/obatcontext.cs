using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using Project_PBO.App.Core;

namespace Project_PBO.App.Context
{
    public class obatcontext : dataconn
    {


        private static string obatTable = "obat";
        private static string penyakitTable = "penyakit";
        private static string jenisTable = "jenis_obat";

        //menampilkan data
        public DataTable getAll()
        {
            string query = $@"
            SELECT 
                a.nama_obat, 
                a.fungsi, 
                a.dosis, 
                p.nama_penyakit AS Penyakit, 
                j.jenis AS Jenis
            FROM {obatTable} a
            JOIN {penyakitTable} p ON a.penyakit_id = p.id_penyakit
            JOIN {jenisTable} j ON a.jenis_id = j.id_jenis";
            return queryExecutor(query);
        }
        

        }

  }

