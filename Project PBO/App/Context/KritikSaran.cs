using Project_PBO.App.Core;
using System;
using System.Data;

namespace Project_PBO.App.Context
{
    public class kritikSaranContext : dataconn
    {
        private static string keluhantable = "keluhan";
        private static string profiltable = "profil";

        public static DataTable all()
        {
            // Menambahkan nomor urut menggunakan ROW_NUMBER()
            string query = $@"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY nama) AS No,
                    a.id_keluhan,
                    a.detail_kritik AS kritik, 
                    a.detail_saran AS saran, 
                    p.nama AS nama
                FROM {keluhantable} a
                JOIN {profiltable} p ON a.id_pelanggan = p.id_profil";
            return queryExecutor(query);
        }

        //insert kritik dan sarannya
        public static void insert(string kritik, string saran, int id)
        {
            //insert kritik dan sarannya
            string query = $"INSERT INTO {keluhantable} (detail_kritik, detail_saran, id_pelanggan) VALUES ({kritik}, {saran}, {id})";
            queryExecutor(query);
        }
    }

}