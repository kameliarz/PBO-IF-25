
namespace pertemuan_9 {
    public partial class FormLogin : Form {
        public string username;
        public string password;
        FormUtama _FormUtama;

        public FormLogin(FormUtama formUtama) {
            InitializeComponent();
            username = "A";
            password = "A";
            this._FormUtama = formUtama;
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            string usernameInput = TbUsername.Text;
            string passwordInput = TbPassword.Text;

            if (usernameInput == username && passwordInput == password) {
                MessageBox.Show("Login Berhasil", "Succees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _FormUtama.BukaFormDiPanel(new FormDashboard(usernameInput, _FormUtama));
                //FormDashboard HalamanSetelahLogin = new FormDashboard(usernameInput, _FormUtama);
                //HalamanSetelahLogin.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Password atau Username salah", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
