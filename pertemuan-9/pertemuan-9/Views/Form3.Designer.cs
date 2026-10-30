namespace pertemuan_9 {
    partial class Form3 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblNama = new Label();
            lblUmur = new Label();
            lblAsal = new Label();
            txtNama = new TextBox();
            txtUmur = new TextBox();
            txtAsal = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.Location = new Point(21, 18);
            lblNama.Margin = new Padding(2, 0, 2, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(56, 15);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama :";
            // 
            // lblUmur
            // 
            lblUmur.Location = new Point(21, 45);
            lblUmur.Margin = new Padding(2, 0, 2, 0);
            lblUmur.Name = "lblUmur";
            lblUmur.Size = new Size(56, 15);
            lblUmur.TabIndex = 2;
            lblUmur.Text = "Umur :";
            // 
            // lblAsal
            // 
            lblAsal.Location = new Point(21, 72);
            lblAsal.Margin = new Padding(2, 0, 2, 0);
            lblAsal.Name = "lblAsal";
            lblAsal.Size = new Size(56, 15);
            lblAsal.TabIndex = 4;
            lblAsal.Text = "Asal :";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(91, 16);
            txtNama.Margin = new Padding(2, 2, 2, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(155, 23);
            txtNama.TabIndex = 1;
            // 
            // txtUmur
            // 
            txtUmur.Location = new Point(91, 43);
            txtUmur.Margin = new Padding(2, 2, 2, 2);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(155, 23);
            txtUmur.TabIndex = 3;
            // 
            // txtAsal
            // 
            txtAsal.Location = new Point(91, 70);
            txtAsal.Margin = new Padding(2, 2, 2, 2);
            txtAsal.Name = "txtAsal";
            txtAsal.Size = new Size(155, 23);
            txtAsal.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.SeaGreen;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(91, 102);
            btnSimpan.Margin = new Padding(2, 2, 2, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(70, 21);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Gray;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(172, 102);
            btnBatal.Margin = new Padding(2, 2, 2, 2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(70, 21);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 144);
            Controls.Add(lblNama);
            Controls.Add(txtNama);
            Controls.Add(lblUmur);
            Controls.Add(txtUmur);
            Controls.Add(lblAsal);
            Controls.Add(txtAsal);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form Tambah / Edit User";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label lblNama, lblUmur, lblAsal;
        private TextBox txtNama, txtUmur, txtAsal;
        private Button btnSimpan, btnBatal;
    }
}
