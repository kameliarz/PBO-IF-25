using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using pertemuan_9.Models;
using pertemuan_9.Helpers;

namespace pertemuan_9.Repositories {
    public class UserRepository {
        private readonly DatabaseHelper dbHelper;

        public UserRepository() {
            dbHelper = new DatabaseHelper();
        }

        public List<User> GetAllUsers() {
            List<User> list = new List<User>();

            using var conn = dbHelper.getConnection();

            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT id, nama, umur, asal FROM users", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                list.Add(new User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetString(3)
                ));
            }
            return list;
        }


        // CREATE
        public bool AddUser(User user) {
            try {
                using var conn = dbHelper.getConnection();

                conn.Open();
                using var cmd = new NpgsqlCommand(
                    "INSERT INTO users (nama, umur, asal) VALUES (@nama, @umur, @asal)", conn);
                cmd.Parameters.AddWithValue("nama", user.nama);
                cmd.Parameters.AddWithValue("umur", user.umur);
                cmd.Parameters.AddWithValue("asal", user.asal);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message);
                return false;
            }

        }


        // UPDATE
        public bool UpdateUser(User user) {
            using var conn = dbHelper.getConnection();

            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE users SET nama=@nama, umur=@umur, asal=@asal WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("id", user.id);
            cmd.Parameters.AddWithValue("nama", user.nama);
            cmd.Parameters.AddWithValue("umur", user.umur);
            cmd.Parameters.AddWithValue("asal", user.asal);
            cmd.ExecuteNonQuery();

            return true;

        }


        // DELETE
        public bool DeleteUser(int id) {
            using var conn = dbHelper.getConnection();

            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM users WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();

            return true;
        }
    }
}
