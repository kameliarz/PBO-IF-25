using pertemuan_9.Repositories;
using pertemuan_9.Models;
using System;
using System.Collections.Generic;
using System.Text;
using pertemuan_9.Helpers;

namespace pertemuan_9.Controllers {
    public class UserController {
        private readonly UserRepository _repository;

        public UserController() {
            _repository = new UserRepository();
        }

        public List<User> GetUsers() {
            return _repository.GetAllUsers();
        }

        public bool TambahUser(string nama, string umurText, string asal) {
            if (!int.TryParse(umurText, out int umur)) {
                throw new Exception("Umur harus berupa angka.");
            }

            if (string.IsNullOrWhiteSpace(nama)) {
                throw new Exception("Nama tidak boleh kosong.");
            }

            if (umur <= 0) {
                throw new Exception("Umur harus lebih dari 0.");
            }

            User user = new User {
                nama = nama,
                umur = umur,
                asal = asal
            };

            return _repository.AddUser(user);
        }

        public bool UpdateUser(
            int id,
            string nama,
            string umurText,
            string asal) {
            if (id <= 0) {
                throw new Exception("Pilih data yang ingin diubah.");
            }

            if (!int.TryParse(umurText, out int umur)) {
                throw new Exception("Umur harus berupa angka.");
            }

            if (string.IsNullOrWhiteSpace(nama)) {
                throw new Exception("Nama tidak boleh kosong.");
            }

            if (umur <= 0) {
                throw new Exception("Umur harus lebih dari 0.");
            }

            User user = new User {
                id = id,
                nama = nama,
                umur = umur,
                asal = asal
            };

            return _repository.UpdateUser(user);
        }

        public bool DeleteUser(int id) {
            if (id <= 0) {
                throw new Exception("Pilih data yang ingin dihapus.");
            }

            return _repository.DeleteUser(id);
        }
    }
}
