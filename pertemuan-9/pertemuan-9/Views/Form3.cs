using pertemuan_9.Helpers;
using pertemuan_9.Models;
using pertemuan_9.Controllers;
using pertemuan_9.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pertemuan_9 {
    public partial class Form3 : Form {
        private DatabaseHelper db;
        private readonly UserController _controller;
        private User _user;
        public Form3(User user) {
            InitializeComponent();
            string connectionString = "Host=localhost;Port=5432;Database=test_db;Username=postgres;Password=lia241105";
            _user = user;
            var db = new UserRepository();
            _controller = new UserController();

            if (_user != null) // mode EDIT, isi field dengan data lama
            {
                txtNama.Text = _user.nama;
                txtUmur.Text = _user.umur.ToString();
                txtAsal.Text = _user.asal;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNama.Text)) {
                MessageBox.Show("Nama tidak boleh kosong!");
                return;
            }

            if (_user == null) // TAMBAH
            {
                //User baru = new User(0, txtNama.Text, int.Parse(txtUmur.Text), txtAsal.Text);
                _controller.TambahUser(txtNama.Text, txtUmur.Text, txtAsal.Text);
                MessageBox.Show("User berhasil ditambahkan!");
            }
            else // EDIT
            {
                _user.id = _user.id;
                _user.nama = txtNama.Text;
                _user.asal = txtAsal.Text;
                _controller.UpdateUser(_user.id, _user.nama, txtUmur.Text, _user.asal);
                MessageBox.Show("User berhasil diupdate!");
            }


            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
