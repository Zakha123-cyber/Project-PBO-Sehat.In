using Project_PBO.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Context
{
    public class Artikelcontext : dataconn
    {
        private static string artikelTable = "artikel";
        private static string penyakitTable = "penyakit";

        public static DataTable all()
        {
            string query = $@"
        SELECT 
            a.id_artikel, 
            a.judul AS Nama, 
            a.sumber AS Sumber, 
            p.nama_penyakit AS Penyakit 
        FROM {artikelTable} a
        JOIN {penyakitTable} p ON a.penyakit_id = p.id_penyakit";

            return queryExecutor(query);
        }


        //insert sumber
        public static void insert(string judul, string sumber)
        {
            string query = $"INSERT INTO {artikelTable} (judul, sumber) VALUES ('{judul}', '{sumber}')";
            queryExecutor(query);
        }


        //update judul





        //delete artikel

        public static bool delete(int idArtikel)
        {
            try
            {
                string query = $"DELETE FROM {artikelTable} WHERE id_artikel = {idArtikel}";
                // Execute the delete query here
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting artikel: {ex.Message}");
                return false;
            }
        }

    }






}



