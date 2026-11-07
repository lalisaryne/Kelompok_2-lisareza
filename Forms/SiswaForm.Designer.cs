namespace Siakada
{
    partial class SiswaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.lblNis = new System.Windows.Forms.Label();
            this.txtNis = new System.Windows.Forms.TextBox();
            this.lblNamaSiswa = new System.Windows.Forms.Label();
            this.txtNamaSiswa = new System.Windows.Forms.TextBox();
            this.lblKelas = new System.Windows.Forms.Label();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblParentName = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblParentPhone = new System.Windows.Forms.Label();
            this.txtParentPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblSemesterSiswa = new System.Windows.Forms.Label();
            this.cmbSemesterSiswa = new System.Windows.Forms.ComboBox();
            this.btnRefreshNilai = new System.Windows.Forms.Button();
            this.btnPrintNilai = new System.Windows.Forms.Button();
            this.dgvGradesSiswa = new System.Windows.Forms.DataGridView();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblTotalSubject = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.gbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradesSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnChangePassword);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SIAKADA - Panel Siswa";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(410, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Selamat datang, -";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(164)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(740, 14);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(120, 32);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Ganti Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(870, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // gbProfile
            // 
            this.gbProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProfile.Controls.Add(this.lblNis);
            this.gbProfile.Controls.Add(this.txtNis);
            this.gbProfile.Controls.Add(this.lblNamaSiswa);
            this.gbProfile.Controls.Add(this.txtNamaSiswa);
            this.gbProfile.Controls.Add(this.lblKelas);
            this.gbProfile.Controls.Add(this.txtKelas);
            this.gbProfile.Controls.Add(this.lblBirthDate);
            this.gbProfile.Controls.Add(this.txtBirthDate);
            this.gbProfile.Controls.Add(this.lblGender);
            this.gbProfile.Controls.Add(this.txtGender);
            this.gbProfile.Controls.Add(this.lblParentName);
            this.gbProfile.Controls.Add(this.txtParentName);
            this.gbProfile.Controls.Add(this.lblParentPhone);
            this.gbProfile.Controls.Add(this.txtParentPhone);
            this.gbProfile.Controls.Add(this.lblAddress);
            this.gbProfile.Controls.Add(this.txtAddress);
            this.gbProfile.Location = new System.Drawing.Point(15, 75);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(970, 175);
            this.gbProfile.TabIndex = 1;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Profil Siswa";
            // 
            // lblNis
            // 
            this.lblNis.AutoSize = true;
            this.lblNis.Location = new System.Drawing.Point(15, 22);
            this.lblNis.Name = "lblNis";
            this.lblNis.Size = new System.Drawing.Size(32, 20);
            this.lblNis.TabIndex = 0;
            this.lblNis.Text = "NIS";
            // 
            // txtNis
            // 
            this.txtNis.Location = new System.Drawing.Point(15, 42);
            this.txtNis.Name = "txtNis";
            this.txtNis.ReadOnly = true;
            this.txtNis.Size = new System.Drawing.Size(290, 27);
            this.txtNis.TabIndex = 1;
            // 
            // lblNamaSiswa
            // 
            this.lblNamaSiswa.AutoSize = true;
            this.lblNamaSiswa.Location = new System.Drawing.Point(15, 72);
            this.lblNamaSiswa.Name = "lblNamaSiswa";
            this.lblNamaSiswa.Size = new System.Drawing.Size(109, 20);
            this.lblNamaSiswa.TabIndex = 2;
            this.lblNamaSiswa.Text = "Nama Lengkap";
            // 
            // txtNamaSiswa
            // 
            this.txtNamaSiswa.Location = new System.Drawing.Point(15, 92);
            this.txtNamaSiswa.Name = "txtNamaSiswa";
            this.txtNamaSiswa.ReadOnly = true;
            this.txtNamaSiswa.Size = new System.Drawing.Size(290, 27);
            this.txtNamaSiswa.TabIndex = 3;
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(15, 122);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(44, 20);
            this.lblKelas.TabIndex = 4;
            this.lblKelas.Text = "Kelas";
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(15, 142);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.ReadOnly = true;
            this.txtKelas.Size = new System.Drawing.Size(290, 27);
            this.txtKelas.TabIndex = 5;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(325, 22);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(97, 20);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Tanggal Lahir";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(325, 42);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.ReadOnly = true;
            this.txtBirthDate.Size = new System.Drawing.Size(290, 27);
            this.txtBirthDate.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(325, 72);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(98, 20);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Jenis Kelamin";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(325, 92);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(290, 27);
            this.txtGender.TabIndex = 9;
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(325, 122);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(122, 20);
            this.lblParentName.TabIndex = 10;
            this.lblParentName.Text = "Nama Orang Tua";
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(325, 142);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.ReadOnly = true;
            this.txtParentName.Size = new System.Drawing.Size(290, 27);
            this.txtParentName.TabIndex = 11;
            // 
            // lblParentPhone
            // 
            this.lblParentPhone.AutoSize = true;
            this.lblParentPhone.Location = new System.Drawing.Point(635, 22);
            this.lblParentPhone.Name = "lblParentPhone";
            this.lblParentPhone.Size = new System.Drawing.Size(135, 20);
            this.lblParentPhone.TabIndex = 12;
            this.lblParentPhone.Text = "Telepon Orang Tua";
            // 
            // txtParentPhone
            // 
            this.txtParentPhone.Location = new System.Drawing.Point(635, 42);
            this.txtParentPhone.Name = "txtParentPhone";
            this.txtParentPhone.ReadOnly = true;
            this.txtParentPhone.Size = new System.Drawing.Size(315, 27);
            this.txtParentPhone.TabIndex = 13;
            this.txtParentPhone.TextChanged += new System.EventHandler(this.txtParentPhone_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(635, 72);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 20);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Alamat";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(635, 92);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(315, 70);
            this.txtAddress.TabIndex = 15;
            // 
            // lblSemesterSiswa
            // 
            this.lblSemesterSiswa.AutoSize = true;
            this.lblSemesterSiswa.Location = new System.Drawing.Point(15, 267);
            this.lblSemesterSiswa.Name = "lblSemesterSiswa";
            this.lblSemesterSiswa.Size = new System.Drawing.Size(70, 20);
            this.lblSemesterSiswa.TabIndex = 2;
            this.lblSemesterSiswa.Text = "Semester";
            // 
            // cmbSemesterSiswa
            // 
            this.cmbSemesterSiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemesterSiswa.FormattingEnabled = true;
            this.cmbSemesterSiswa.Location = new System.Drawing.Point(80, 263);
            this.cmbSemesterSiswa.Name = "cmbSemesterSiswa";
            this.cmbSemesterSiswa.Size = new System.Drawing.Size(200, 28);
            this.cmbSemesterSiswa.TabIndex = 3;
            this.cmbSemesterSiswa.SelectedIndexChanged += new System.EventHandler(this.cmbSemesterSiswa_SelectedIndexChanged);
            // 
            // btnRefreshNilai
            // 
            this.btnRefreshNilai.Location = new System.Drawing.Point(300, 260);
            this.btnRefreshNilai.Name = "btnRefreshNilai";
            this.btnRefreshNilai.Size = new System.Drawing.Size(110, 30);
            this.btnRefreshNilai.TabIndex = 4;
            this.btnRefreshNilai.Text = "Muat Nilai";
            this.btnRefreshNilai.UseVisualStyleBackColor = true;
            this.btnRefreshNilai.Click += new System.EventHandler(this.btnRefreshNilai_Click);
            // 
            // btnPrintNilai
            // 
            this.btnPrintNilai.Location = new System.Drawing.Point(420, 260);
            this.btnPrintNilai.Name = "btnPrintNilai";
            this.btnPrintNilai.Size = new System.Drawing.Size(140, 30);
            this.btnPrintNilai.TabIndex = 5;
            this.btnPrintNilai.Text = "Cetak / Ekspor";
            this.btnPrintNilai.UseVisualStyleBackColor = true;
            this.btnPrintNilai.Click += new System.EventHandler(this.btnPrintNilai_Click);
            // 
            // dgvGradesSiswa
            // 
            this.dgvGradesSiswa.AllowUserToAddRows = false;
            this.dgvGradesSiswa.AllowUserToDeleteRows = false;
            this.dgvGradesSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGradesSiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGradesSiswa.BackgroundColor = System.Drawing.Color.White;
            this.dgvGradesSiswa.ColumnHeadersHeight = 29;
            this.dgvGradesSiswa.Location = new System.Drawing.Point(15, 300);
            this.dgvGradesSiswa.MultiSelect = false;
            this.dgvGradesSiswa.Name = "dgvGradesSiswa";
            this.dgvGradesSiswa.ReadOnly = true;
            this.dgvGradesSiswa.RowHeadersVisible = false;
            this.dgvGradesSiswa.RowHeadersWidth = 51;
            this.dgvGradesSiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradesSiswa.Size = new System.Drawing.Size(970, 290);
            this.dgvGradesSiswa.TabIndex = 6;
            this.dgvGradesSiswa.SelectionChanged += new System.EventHandler(this.dgvGradesSiswa_SelectionChanged);
            // 
            // lblAverage
            // 
            this.lblAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAverage.Location = new System.Drawing.Point(15, 605);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(102, 23);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Rata-rata: -";
            // 
            // lblTotalSubject
            // 
            this.lblTotalSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalSubject.AutoSize = true;
            this.lblTotalSubject.Location = new System.Drawing.Point(300, 607);
            this.lblTotalSubject.Name = "lblTotalSubject";
            this.lblTotalSubject.Size = new System.Drawing.Size(114, 20);
            this.lblTotalSubject.TabIndex = 8;
            this.lblTotalSubject.Text = "Jumlah mapel: -";
            // 
            // SiswaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.gbProfile);
            this.Controls.Add(this.lblSemesterSiswa);
            this.Controls.Add(this.cmbSemesterSiswa);
            this.Controls.Add(this.btnRefreshNilai);
            this.Controls.Add(this.btnPrintNilai);
            this.Controls.Add(this.dgvGradesSiswa);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotalSubject);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "SiswaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIAKADA - Panel Siswa";
            this.Load += new System.EventHandler(this.SiswaForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradesSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.Label lblNis;
        private System.Windows.Forms.TextBox txtNis;
        private System.Windows.Forms.Label lblNamaSiswa;
        private System.Windows.Forms.TextBox txtNamaSiswa;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblParentPhone;
        private System.Windows.Forms.TextBox txtParentPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblSemesterSiswa;
        private System.Windows.Forms.ComboBox cmbSemesterSiswa;
        private System.Windows.Forms.Button btnRefreshNilai;
        private System.Windows.Forms.Button btnPrintNilai;
        private System.Windows.Forms.DataGridView dgvGradesSiswa;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblTotalSubject;
    }
}