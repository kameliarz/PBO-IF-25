using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pertemuan_9 {
    public partial class FormUtama : Form {
        public FormUtama() {
            InitializeComponent();

            BukaFormDiPanel(new FormLogin(this));

        }

        public void BukaFormDiPanel(Form formAnak) {
            if (this.PanelUtama.Controls.Count > 0) {
                this.PanelUtama.Controls[0].Dispose(); // Bersihkan form sebelumnya
                this.PanelUtama.Controls.Clear();
            }


            formAnak.TopLevel = false;
            formAnak.FormBorderStyle = FormBorderStyle.None;
            formAnak.Dock = DockStyle.Fill;

            this.PanelUtama.Controls.Add(formAnak);
            this.PanelUtama.Tag = formAnak;
            formAnak.Show();
        }
    }
}
