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
    public class RegistrasiContext : dataconn
    {
        private readonly NpgsqlConnection _connection;

        public RegistrasiContext(string connectionString)
        {
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }

        public void InsertProfil(string nama, string email, string password, string alamat, string kota, string negara, long noTelfon, int idJenisProfil)
        {
            string sql = @"
            INSERT INTO profil (nama, email, password, alamat, kota, negara, no_telfon, id_jenis_profil)
            VALUES (@nama, @email, @password, @alamat, @kota, @negara, @no_telfon, @id_jenis_profil)
            ";

            using (var cmd = new NpgsqlCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("alamat", alamat);
                cmd.Parameters.AddWithValue("kota", kota);
                cmd.Parameters.AddWithValue("negara", negara);
                cmd.Parameters.AddWithValue("no_telfon", noTelfon);
                cmd.Parameters.AddWithValue("id_jenis_profil", idJenisProfil = 2);

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data berhasil dimasukkan ke dalam tabel profil.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
                }
            }
        }

        public void Dispose()
        {
            _connection.Close();
        }
    }
}









