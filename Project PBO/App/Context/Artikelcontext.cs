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
        private static string table = "artikel";
         public static DataTable all()
        {
            string query = $"SELECT id_artikel, judul AS Nama, sumber AS Sumber FROM {table}";
            return queryExecutor(query);
        }

 

        //insert sumber
       public static void insert(string judul, string sumber)
        {
            string query = $"INSERT INTO {table} (judul, sumber) VALUES ('{judul}', '{sumber}')";
            queryExecutor(query);
        }

        //update judul
        public static void update(int id, string judul)
        {
            string query = $"UPDATE {table} SET judul = '{judul}' WHERE artikel_id = {id}";
            queryExecutor(query);
        }

        //update sumber
        public static void update(int id, string judul, string sumber)
        {
            string query = $"UPDATE {table} SET judul = '{judul}', sumber = '{sumber}' WHERE artikel_id = {id}";
            queryExecutor(query);
        }

        //delete
        public static void delete(int id)
        {
            string query = $"DELETE FROM {table} WHERE artikel_id = {id}";
            queryExecutor(query);
        }   




    }
}


