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
            DgUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgUser.Location = new Point(58, 137);
            DgUser.Name = "DgUser";
            DgUser.Size = new Size(682, 267);
            DgUser.TabIndex = 1;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgwinforms__dark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(DgUser);
            Controls.Add(LabelSelamat);
            Name = "FormDashboard";
            Text = "FormDashboard";
            ((System.ComponentModel.ISupportInitialize)DgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelSelamat;
        private DataGridView DgUser;
    }
}