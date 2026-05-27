using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanatusuTasks
{
    public static class Database
    {
        private static string connectionString =
            "server=localhost;database=NanatsuTasks;uid=root;pwd=rootroot;";

        public static MySqlConnection GetConnection()
        {
            // cria objeto de conexão com o MySQL
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                // abre a conexão com o banco
                conn.Open();

                // retorna conexão aberta para uso
                return conn;
            }
            catch (Exception ex)
            {
                // mostra erro caso conexão falhe
                throw new Exception("Error in Connection: " + ex.Message);
            }
        }
    }
}
