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
        private List<User> listUser;
        public FormDashboard(string usernameInput) {
            InitializeComponent();
            username = usernameInput;

            LabelSelamat.Text = $"Selamat Datang Bang {usernameInput}";
            this.listUser = generateData();
            DgUser.DataSource = listUser;
        }

        public List<User> generateData() {
            List<User> listUser = new List<User>();
            for (int i = 0; i < 5; i++) {
                User user = new User($"Ahmad {i}", 20, "Bwi");
                listUser.Add(user);
            }
            return listUser;
        }
    }
}
