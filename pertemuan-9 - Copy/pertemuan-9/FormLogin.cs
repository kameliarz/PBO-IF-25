namespace pertemuan_9 {
    public partial class FormLogin : Form {
        public string username;
        public string password;

        public FormLogin() {
            InitializeComponent();
            username = "BudiSiregar";
            password = "KapalLawd";
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            string usernameInput = TbUsername.Text;
            string passwordInput = TbPassword.Text;

            if (usernameInput == username && passwordInput == password) {
                MessageBox.Show("Login Berhasil", "Succees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDashboard HalamanSetelahLogin = new FormDashboard(usernameInput);
                HalamanSetelahLogin.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Password atau Username salah", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
