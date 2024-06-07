using System.Data;
using Npgsql;
using Project_PBO.App.Core;

namespace Project_PBO.App.Context
{
    public class datadiricontext : dataconn
    {
        // Mengambil nama user yang login
        public static DataTable getdatadirinama(string email)
        {
            string query = "SELECT nama FROM profil WHERE email = @Email";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@Email", email) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar }
            };
            return queryExecutor(query, parameters);
        }

        // Mengambil nomor telepon user yang login
        public static DataTable getdatadirinotelp(string email)
        {
            string query = "SELECT no_telfon FROM profil WHERE email = @Email";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@Email", email) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar }
            };
            return queryExecutor(query, parameters);
        }

        // Mengambil alamat user yang login
        public static DataTable getdatadirialamat(string email)
        {
            string query = "SELECT alamat From profil WHERE email = @Email";
            NpgsqlParameter[] parameters = {
                new NpgsqlParameter("@Email", email) { NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar }
            };
            return queryExecutor(query, parameters);
        }
    }
}
