namespace pertemuan_9 {
    partial class FormDashboard {
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
            LabelSelamat = new Label();
            DgUser = new DataGridView();
            TbTambahData = new Button();
            TbEditData = new Button();
            TbHapusData = new Button();
            ((System.ComponentModel.ISupportInitialize)DgUser).BeginInit();
            SuspendLayout();
            // 
            // LabelSelamat
            // 
            LabelSelamat.AutoSize = true;
            LabelSelamat.BackColor = Color.Transparent;
            LabelSelamat.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelSelamat.ForeColor = Color.WhiteSmoke;
            LabelSelamat.Location = new Point(37, 25);
            LabelSelamat.Name = "LabelSelamat";
            LabelSelamat.Size = new Size(298, 50);
            LabelSelamat.TabIndex = 0;
            LabelSelamat.Text = "Selamat Datang";
            // 
            // DgUser
            // 
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgUser.Location = new Point(50, 120);
            DgUser.Name = "DgUser";
            DgUser.Size = new Size(694, 275);
            DgUser.TabIndex = 1;
            // 
            // TbTambahData
            // 
            TbTambahData.BackColor = Color.Lime;
            TbTambahData.Location = new Point(445, 39);
            TbTambahData.Name = "TbTambahData";
            TbTambahData.Size = new Size(93, 42);
            TbTambahData.TabIndex = 2;
            TbTambahData.Text = "Tambah";
            TbTambahData.UseVisualStyleBackColor = false;
            TbTambahData.Click += TbTambahData_Click;
            // 
            // TbEditData
            // 
            TbEditData.BackColor = Color.Yellow;
            TbEditData.Location = new Point(544, 39);
            TbEditData.Name = "TbEditData";
            TbEditData.Size = new Size(89, 42);
            TbEditData.TabIndex = 3;
            TbEditData.Text = "Edit";
            TbEditData.UseVisualStyleBackColor = false;
            TbEditData.Click += TbEditData_Click;
            // 
            // TbHapusData
            // 
            TbHapusData.BackColor = Color.Red;
            TbHapusData.ForeColor = SystemColors.ButtonFace;
            TbHapusData.Location = new Point(639, 39);
            TbHapusData.Name = "TbHapusData";
            TbHapusData.Size = new Size(91, 42);
            TbHapusData.TabIndex = 4;
            TbHapusData.Text = "Hapus";
            TbHapusData.UseVisualStyleBackColor = false;
            TbHapusData.Click += TbHapusData_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgwinforms__dark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(TbHapusData);
            Controls.Add(TbEditData);
            Controls.Add(TbTambahData);
            Controls.Add(DgUser);
            Controls.Add(LabelSelamat);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelSelamat;
        private DataGridView DgUser;
        private Button TbTambahData;
        private Button TbEditData;
        private Button TbHapusData;
    }
}
