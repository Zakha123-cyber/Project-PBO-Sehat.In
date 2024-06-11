using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Npgsql;
using NpgsqlTypes;
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
            a.judul AS Judul, 
            a.sumber AS Sumber, 
            p.nama_penyakit AS Penyakit 
        FROM {artikelTable} a
        JOIN {penyakitTable} p ON a.id_penyakit = p.id_penyakit";

            return queryExecutor(query);
        }


        //insert sumber
        public static void insert(string judul, string sumber, string penyakit)
        {
            //insert artikel dan penyakitnya
            string query = $"INSERT INTO {artikelTable} (judul, sumber) VALUES (@judul, @sumber, @penyakit)";
            queryExecutor(query);
        }


        //update judul





        //delete artikel

        public static void delete(string id)
        {
            string query = $"DELETE FROM {artikelTable} WHERE id_artikel = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Varchar){Value = id},
            };
            commandExecutor(query, parameters);
        }

    }






}



