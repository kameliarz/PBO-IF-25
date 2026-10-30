using pertemuan_9.Controllers;
using pertemuan_9.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pertemuan_9 {
    public partial class FormDashboard : Form {
        public string username;
        FormUtama _FormUtama;
        private readonly UserController _UserController = new UserController();
        //private List<User> listUser;

        public FormDashboard(string usernameInput, FormUtama formUtama) {
            InitializeComponent();
            this._FormUtama = formUtama;
            username = usernameInput;
            LabelSelamat.Text = $"Selamat Datang Bang {usernameInput}";
            TampilkanData();
            //this.listUser = generateData();
            //DgUser.DataSource = listUser;
        }

        public void TampilkanData() {
            DgUser.DataSource = _UserController.GetUsers();
        }

        //public List<User> generateData() {
        //    List<User> listUser = new List<User>();
        //    for (int i = 0; i < 5; i++) {
        //        User user = new User(20, $"Ahmad {i}", 20, "Bwi");
        //        listUser.Add(user);
        //    }
        //    return listUser;
        //}

        private void FormDashboard_Load(object sender, EventArgs e) {

        }

        private void TbTambahData_Click(object sender, EventArgs e) {
            Form3 formTambah = new Form3(null); // null = mode tambah
            formTambah.ShowDialog();
            this.TampilkanData();
        }

        private void TbEditData_Click(object sender, EventArgs e) {
            if (DgUser.CurrentRow == null) return;
            User Selected = (User)DgUser.CurrentRow.DataBoundItem;
            Form3 Edit = new Form3(Selected);
            Edit.ShowDialog();
            TampilkanData();
        }

        private void TbHapusData_Click(object sender, EventArgs e) {
            if (DgUser.CurrentRow == null) return;
            User Selected = (User)DgUser.CurrentRow.DataBoundItem;
            var Konfirmasi = MessageBox.Show($"Apakah Anda Yakin Hapus Data '{Selected.nama}'", "Konfirmasi", MessageBoxButtons.YesNo);
            if (Konfirmasi == DialogResult.Yes) {
                _UserController.DeleteUser(Selected.id);
                TampilkanData();
            }
        }
    }
}
