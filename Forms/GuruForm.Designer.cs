namespace Siakada
{
    partial class GuruForm
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.lblTeaching = new System.Windows.Forms.Label();
            this.cmbTeaching = new System.Windows.Forms.ComboBox();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.gbInputGrade = new System.Windows.Forms.GroupBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.lblGradeDescription = new System.Windows.Forms.Label();
            this.txtGradeDescription = new System.Windows.Forms.TextBox();
            this.btnSaveGrade = new System.Windows.Forms.Button();
            this.btnDeleteGrade = new System.Windows.Forms.Button();
            this.btnClearGrade = new System.Windows.Forms.Button();
            this.btnExportGrade = new System.Windows.Forms.Button();
            this.lblStatusGuru = new System.Windows.Forms.Label();
            this.lblClassAverage = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.gbInputGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(270, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SIAKADA - Panel Guru";
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
            // gbFilter
            // 
            this.gbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilter.Controls.Add(this.lblSemester);
            this.gbFilter.Controls.Add(this.cmbSemester);
            this.gbFilter.Controls.Add(this.lblTeaching);
            this.gbFilter.Controls.Add(this.cmbTeaching);
            this.gbFilter.Controls.Add(this.btnLoadStudents);
            this.gbFilter.Location = new System.Drawing.Point(15, 75);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(970, 75);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Pilih Semester & Kelas Mengajar";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(15, 33);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(70, 20);
            this.lblSemester.TabIndex = 0;
            this.lblSemester.Text = "Semester";
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(80, 30);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(180, 28);
            this.cmbSemester.TabIndex = 1;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // lblTeaching
            // 
            this.lblTeaching.AutoSize = true;
            this.lblTeaching.Location = new System.Drawing.Point(280, 33);
            this.lblTeaching.Name = "lblTeaching";
            this.lblTeaching.Size = new System.Drawing.Size(72, 20);
            this.lblTeaching.TabIndex = 2;
            this.lblTeaching.Text = "Mengajar";
            // 
            // cmbTeaching
            // 
            this.cmbTeaching.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeaching.FormattingEnabled = true;
            this.cmbTeaching.Location = new System.Drawing.Point(345, 30);
            this.cmbTeaching.Name = "cmbTeaching";
            this.cmbTeaching.Size = new System.Drawing.Size(300, 28);
            this.cmbTeaching.TabIndex = 3;
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(665, 27);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(140, 30);
            this.btnLoadStudents.TabIndex = 4;
            this.btnLoadStudents.Text = "Tampilkan Siswa";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrades.ColumnHeadersHeight = 29;
            this.dgvGrades.Location = new System.Drawing.Point(15, 165);
            this.dgvGrades.MultiSelect = false;
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.RowHeadersVisible = false;
            this.dgvGrades.RowHeadersWidth = 51;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.Size = new System.Drawing.Size(630, 430);
            this.dgvGrades.TabIndex = 2;
            this.dgvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellContentClick);
            this.dgvGrades.SelectionChanged += new System.EventHandler(this.dgvGrades_SelectionChanged);
            // 
            // gbInputGrade
            // 
            this.gbInputGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInputGrade.Controls.Add(this.lblStudentNumber);
            this.gbInputGrade.Controls.Add(this.txtStudentNumber);
            this.gbInputGrade.Controls.Add(this.lblStudentName);
            this.gbInputGrade.Controls.Add(this.txtStudentName);
            this.gbInputGrade.Controls.Add(this.lblScore);
            this.gbInputGrade.Controls.Add(this.nudScore);
            this.gbInputGrade.Controls.Add(this.lblGradeDescription);
            this.gbInputGrade.Controls.Add(this.txtGradeDescription);
            this.gbInputGrade.Controls.Add(this.btnSaveGrade);
            this.gbInputGrade.Controls.Add(this.btnDeleteGrade);
            this.gbInputGrade.Controls.Add(this.btnClearGrade);
            this.gbInputGrade.Controls.Add(this.btnExportGrade);
            this.gbInputGrade.Location = new System.Drawing.Point(660, 165);
            this.gbInputGrade.Name = "gbInputGrade";
            this.gbInputGrade.Size = new System.Drawing.Size(325, 430);
            this.gbInputGrade.TabIndex = 3;
            this.gbInputGrade.TabStop = false;
            this.gbInputGrade.Text = "Input Nilai";
            this.gbInputGrade.Enter += new System.EventHandler(this.gbInputGrade_Enter);
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(15, 28);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(32, 20);
            this.lblStudentNumber.TabIndex = 0;
            this.lblStudentNumber.Text = "NIS";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(15, 48);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.ReadOnly = true;
            this.txtStudentNumber.Size = new System.Drawing.Size(295, 27);
            this.txtStudentNumber.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(15, 82);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(90, 20);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Nama Siswa";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(15, 102);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(295, 27);
            this.txtStudentName.TabIndex = 3;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(15, 136);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Nilai (0 - 100)";
            // 
            // nudScore
            // 
            this.nudScore.DecimalPlaces = 2;
            this.nudScore.Location = new System.Drawing.Point(15, 156);
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(120, 27);
            this.nudScore.TabIndex = 5;
            this.nudScore.ValueChanged += new System.EventHandler(this.nudScore_ValueChanged);
            // 
            // lblGradeDescription
            // 
            this.lblGradeDescription.AutoSize = true;
            this.lblGradeDescription.Location = new System.Drawing.Point(15, 190);
            this.lblGradeDescription.Name = "lblGradeDescription";
            this.lblGradeDescription.Size = new System.Drawing.Size(85, 20);
            this.lblGradeDescription.TabIndex = 6;
            this.lblGradeDescription.Text = "Keterangan";
            // 
            // txtGradeDescription
            // 
            this.txtGradeDescription.Location = new System.Drawing.Point(15, 210);
            this.txtGradeDescription.MaxLength = 255;
            this.txtGradeDescription.Multiline = true;
            this.txtGradeDescription.Name = "txtGradeDescription";
            this.txtGradeDescription.Size = new System.Drawing.Size(295, 70);
            this.txtGradeDescription.TabIndex = 7;
            // 
            // btnSaveGrade
            // 
            this.btnSaveGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSaveGrade.FlatAppearance.BorderSize = 0;
            this.btnSaveGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGrade.ForeColor = System.Drawing.Color.White;
            this.btnSaveGrade.Location = new System.Drawing.Point(15, 300);
            this.btnSaveGrade.Name = "btnSaveGrade";
            this.btnSaveGrade.Size = new System.Drawing.Size(140, 34);
            this.btnSaveGrade.TabIndex = 8;
            this.btnSaveGrade.Text = "Simpan Nilai";
            this.btnSaveGrade.UseVisualStyleBackColor = false;
            this.btnSaveGrade.Click += new System.EventHandler(this.btnSaveGrade_Click);
            // 
            // btnDeleteGrade
            // 
            this.btnDeleteGrade.Location = new System.Drawing.Point(170, 300);
            this.btnDeleteGrade.Name = "btnDeleteGrade";
            this.btnDeleteGrade.Size = new System.Drawing.Size(140, 34);
            this.btnDeleteGrade.TabIndex = 9;
            this.btnDeleteGrade.Text = "Hapus Nilai";
            this.btnDeleteGrade.UseVisualStyleBackColor = true;
            this.btnDeleteGrade.Click += new System.EventHandler(this.btnDeleteGrade_Click);
            // 
            // btnClearGrade
            // 
            this.btnClearGrade.Location = new System.Drawing.Point(15, 344);
            this.btnClearGrade.Name = "btnClearGrade";
            this.btnClearGrade.Size = new System.Drawing.Size(140, 32);
            this.btnClearGrade.TabIndex = 10;
            this.btnClearGrade.Text = "Bersihkan";
            this.btnClearGrade.UseVisualStyleBackColor = true;
            this.btnClearGrade.Click += new System.EventHandler(this.btnClearGrade_Click);
            // 
            // btnExportGrade
            // 
            this.btnExportGrade.Location = new System.Drawing.Point(170, 344);
            this.btnExportGrade.Name = "btnExportGrade";
            this.btnExportGrade.Size = new System.Drawing.Size(140, 32);
            this.btnExportGrade.TabIndex = 11;
            this.btnExportGrade.Text = "Ekspor CSV";
            this.btnExportGrade.UseVisualStyleBackColor = true;
            this.btnExportGrade.Click += new System.EventHandler(this.btnExportGrade_Click);
            // 
            // lblStatusGuru
            // 
            this.lblStatusGuru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusGuru.AutoSize = true;
            this.lblStatusGuru.Location = new System.Drawing.Point(15, 607);
            this.lblStatusGuru.Name = "lblStatusGuru";
            this.lblStatusGuru.Size = new System.Drawing.Size(41, 20);
            this.lblStatusGuru.TabIndex = 4;
            this.lblStatusGuru.Text = "Siap.";
            // 
            // lblClassAverage
            // 
            this.lblClassAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClassAverage.AutoSize = true;
            this.lblClassAverage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClassAverage.Location = new System.Drawing.Point(660, 607);
            this.lblClassAverage.Name = "lblClassAverage";
            this.lblClassAverage.Size = new System.Drawing.Size(128, 20);
            this.lblClassAverage.TabIndex = 5;
            this.lblClassAverage.Text = "Rata-rata kelas: -";
            // 
            // GuruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.gbInputGrade);
            this.Controls.Add(this.lblStatusGuru);
            this.Controls.Add(this.lblClassAverage);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "GuruForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIAKADA - Panel Guru";
            this.Load += new System.EventHandler(this.GuruForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.gbInputGrade.ResumeLayout(false);
            this.gbInputGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label lblTeaching;
        private System.Windows.Forms.ComboBox cmbTeaching;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.GroupBox gbInputGrade;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.Label lblGradeDescription;
        private System.Windows.Forms.TextBox txtGradeDescription;
        private System.Windows.Forms.Button btnSaveGrade;
        private System.Windows.Forms.Button btnDeleteGrade;
        private System.Windows.Forms.Button btnClearGrade;
        private System.Windows.Forms.Button btnExportGrade;
        private System.Windows.Forms.Label lblStatusGuru;
        private System.Windows.Forms.Label lblClassAverage;
    }
}