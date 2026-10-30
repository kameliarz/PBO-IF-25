using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace pertemuan_9.Helpers {
    public class DatabaseHelper {

        private string connectionString;
        public DatabaseHelper() {
            string host = "localhost";
            string port = "5432";
            string db = "test_db";
            string username = "postgres";
            string password = "lia241105";

            connectionString = $"Host={host};Port={port};Database={db};Username={username};Password={password}";
        }

        public NpgsqlConnection getConnection() {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            return conn;
        }

    }
}
