namespace Siakada
{
    partial class AdminForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnRefreshUser = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.gbUserInput = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.chkUserActive = new System.Windows.Forms.CheckBox();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserClear = new System.Windows.Forms.Button();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.txtSearchClass = new System.Windows.Forms.TextBox();
            this.btnSearchClass = new System.Windows.Forms.Button();
            this.btnRefreshClass = new System.Windows.Forms.Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.gbClassInput = new System.Windows.Forms.GroupBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.btnClassAdd = new System.Windows.Forms.Button();
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.btnClassDelete = new System.Windows.Forms.Button();
            this.btnClassClear = new System.Windows.Forms.Button();
            this.tabSubjects = new System.Windows.Forms.TabPage();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.btnSearchSubject = new System.Windows.Forms.Button();
            this.btnRefreshSubject = new System.Windows.Forms.Button();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.gbSubjectInput = new System.Windows.Forms.GroupBox();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.lblSubjectDescription = new System.Windows.Forms.Label();
            this.txtSubjectDescription = new System.Windows.Forms.TextBox();
            this.btnSubjectAdd = new System.Windows.Forms.Button();
            this.btnSubjectUpdate = new System.Windows.Forms.Button();
            this.btnSubjectDelete = new System.Windows.Forms.Button();
            this.btnSubjectClear = new System.Windows.Forms.Button();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnRefreshStudent = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.gbStudentInput = new System.Windows.Forms.GroupBox();
            this.lblStudentUser = new System.Windows.Forms.Label();
            this.cmbStudentUser = new System.Windows.Forms.ComboBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentClass = new System.Windows.Forms.Label();
            this.cmbStudentClass = new System.Windows.Forms.ComboBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblParentName = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblParentPhone = new System.Windows.Forms.Label();
            this.txtParentPhone = new System.Windows.Forms.TextBox();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentClear = new System.Windows.Forms.Button();
            this.tabTeachers = new System.Windows.Forms.TabPage();
            this.txtSearchTeacher = new System.Windows.Forms.TextBox();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.btnRefreshTeacher = new System.Windows.Forms.Button();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.gbTeacherInput = new System.Windows.Forms.GroupBox();
            this.lblTeacherUser = new System.Windows.Forms.Label();
            this.cmbTeacherUser = new System.Windows.Forms.ComboBox();
            this.lblTeacherNumber = new System.Windows.Forms.Label();
            this.txtTeacherNumber = new System.Windows.Forms.TextBox();
            this.lblTeacherPhone = new System.Windows.Forms.Label();
            this.txtTeacherPhone = new System.Windows.Forms.TextBox();
            this.lblTeacherAddress = new System.Windows.Forms.Label();
            this.txtTeacherAddress = new System.Windows.Forms.TextBox();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.btnTeacherUpdate = new System.Windows.Forms.Button();
            this.btnTeacherDelete = new System.Windows.Forms.Button();
            this.btnTeacherClear = new System.Windows.Forms.Button();
            this.tabAcademic = new System.Windows.Forms.TabPage();
            this.lblAcademicYearTitle = new System.Windows.Forms.Label();
            this.dgvAcademicYear = new System.Windows.Forms.DataGridView();
            this.lblYearName = new System.Windows.Forms.Label();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.chkYearActive = new System.Windows.Forms.CheckBox();
            this.btnYearAdd = new System.Windows.Forms.Button();
            this.btnYearUpdate = new System.Windows.Forms.Button();
            this.btnYearDelete = new System.Windows.Forms.Button();
            this.btnYearSetActive = new System.Windows.Forms.Button();
            this.lblSemesterTitle = new System.Windows.Forms.Label();
            this.dgvSemester = new System.Windows.Forms.DataGridView();
            this.lblSemesterYear = new System.Windows.Forms.Label();
            this.cmbSemesterYear = new System.Windows.Forms.ComboBox();
            this.lblSemesterName = new System.Windows.Forms.Label();
            this.cmbSemesterName = new System.Windows.Forms.ComboBox();
            this.chkSemesterActive = new System.Windows.Forms.CheckBox();
            this.btnSemesterAdd = new System.Windows.Forms.Button();
            this.btnSemesterUpdate = new System.Windows.Forms.Button();
            this.btnSemesterDelete = new System.Windows.Forms.Button();
            this.btnSemesterSetActive = new System.Windows.Forms.Button();
            this.tabTeacherSubjects = new System.Windows.Forms.TabPage();
            this.txtSearchTeacherSubject = new System.Windows.Forms.TextBox();
            this.btnSearchTeacherSubject = new System.Windows.Forms.Button();
            this.btnRefreshTeacherSubject = new System.Windows.Forms.Button();
            this.dgvTeacherSubject = new System.Windows.Forms.DataGridView();
            this.gbTeacherSubjectInput = new System.Windows.Forms.GroupBox();
            this.lblTsTeacher = new System.Windows.Forms.Label();
            this.cmbTsTeacher = new System.Windows.Forms.ComboBox();
            this.lblTsSubject = new System.Windows.Forms.Label();
            this.cmbTsSubject = new System.Windows.Forms.ComboBox();
            this.lblTsClass = new System.Windows.Forms.Label();
            this.cmbTsClass = new System.Windows.Forms.ComboBox();
            this.lblTsSemester = new System.Windows.Forms.Label();
            this.cmbTsSemester = new System.Windows.Forms.ComboBox();
            this.btnTeacherSubjectAdd = new System.Windows.Forms.Button();
            this.btnTeacherSubjectUpdate = new System.Windows.Forms.Button();
            this.btnTeacherSubjectDelete = new System.Windows.Forms.Button();
            this.btnTeacherSubjectClear = new System.Windows.Forms.Button();
            this.tabAuditLogs = new System.Windows.Forms.TabPage();
            this.lblAuditFrom = new System.Windows.Forms.Label();
            this.dtpAuditFrom = new System.Windows.Forms.DateTimePicker();
            this.lblAuditTo = new System.Windows.Forms.Label();
            this.dtpAuditTo = new System.Windows.Forms.DateTimePicker();
            this.txtAuditSearch = new System.Windows.Forms.TextBox();
            this.btnAuditFilter = new System.Windows.Forms.Button();
            this.btnAuditRefresh = new System.Windows.Forms.Button();
            this.btnAuditExport = new System.Windows.Forms.Button();
            this.dgvAuditLog = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.gbUserInput.SuspendLayout();
            this.tabClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.gbClassInput.SuspendLayout();
            this.tabSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.gbSubjectInput.SuspendLayout();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.gbStudentInput.SuspendLayout();
            this.tabTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.gbTeacherInput.SuspendLayout();
            this.tabAcademic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemester)).BeginInit();
            this.tabTeacherSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSubject)).BeginInit();
            this.gbTeacherSubjectInput.SuspendLayout();
            this.tabAuditLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1150, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SIAKADA - Admin";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(560, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Selamat Datang";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(164)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(890, 14);
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
            this.btnLogout.Location = new System.Drawing.Point(1020, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabUsers);
            this.tabControlMain.Controls.Add(this.tabClasses);
            this.tabControlMain.Controls.Add(this.tabSubjects);
            this.tabControlMain.Controls.Add(this.tabStudents);
            this.tabControlMain.Controls.Add(this.tabTeachers);
            this.tabControlMain.Controls.Add(this.tabAcademic);
            this.tabControlMain.Controls.Add(this.tabTeacherSubjects);
            this.tabControlMain.Controls.Add(this.tabAuditLogs);
            this.tabControlMain.Location = new System.Drawing.Point(0, 60);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1150, 660);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.txtSearchUser);
            this.tabUsers.Controls.Add(this.btnSearchUser);
            this.tabUsers.Controls.Add(this.btnRefreshUser);
            this.tabUsers.Controls.Add(this.dgvUser);
            this.tabUsers.Controls.Add(this.gbUserInput);
            this.tabUsers.Location = new System.Drawing.Point(4, 29);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1142, 627);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(15, 15);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(300, 27);
            this.txtSearchUser.TabIndex = 0;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(325, 13);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(90, 27);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "Cari";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.Location = new System.Drawing.Point(425, 13);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(110, 27);
            this.btnRefreshUser.TabIndex = 2;
            this.btnRefreshUser.Text = "Muat Ulang";
            this.btnRefreshUser.UseVisualStyleBackColor = true;
            this.btnRefreshUser.Click += new System.EventHandler(this.btnRefreshUser_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersHeight = 29;
            this.dgvUser.Location = new System.Drawing.Point(15, 50);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(700, 560);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            // 
            // gbUserInput
            // 
            this.gbUserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUserInput.Controls.Add(this.lblUsername);
            this.gbUserInput.Controls.Add(this.txtUsername);
            this.gbUserInput.Controls.Add(this.lblEmail);
            this.gbUserInput.Controls.Add(this.txtEmail);
            this.gbUserInput.Controls.Add(this.lblUserPassword);
            this.gbUserInput.Controls.Add(this.txtUserPassword);
            this.gbUserInput.Controls.Add(this.lblFullName);
            this.gbUserInput.Controls.Add(this.txtFullName);
            this.gbUserInput.Controls.Add(this.lblRole);
            this.gbUserInput.Controls.Add(this.cmbRole);
            this.gbUserInput.Controls.Add(this.chkUserActive);
            this.gbUserInput.Controls.Add(this.btnUserAdd);
            this.gbUserInput.Controls.Add(this.btnUserUpdate);
            this.gbUserInput.Controls.Add(this.btnUserDelete);
            this.gbUserInput.Controls.Add(this.btnUserClear);
            this.gbUserInput.Location = new System.Drawing.Point(730, 15);
            this.gbUserInput.Name = "gbUserInput";
            this.gbUserInput.Size = new System.Drawing.Size(395, 382);
            this.gbUserInput.TabIndex = 4;
            this.gbUserInput.TabStop = false;
            this.gbUserInput.Text = "Form User";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(15, 48);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(360, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 100);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(15, 132);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(269, 20);
            this.lblUserPassword.TabIndex = 4;
            this.lblUserPassword.Text = "Password (kosongkan jika tidak diubah)";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(15, 152);
            this.txtUserPassword.MaxLength = 255;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(360, 27);
            this.txtUserPassword.TabIndex = 5;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(15, 184);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(109, 20);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Nama Lengkap";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(15, 204);
            this.txtFullName.MaxLength = 150;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(360, 27);
            this.txtFullName.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(15, 236);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 20);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Guru",
            "Siswa"});
            this.cmbRole.Location = new System.Drawing.Point(15, 256);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(360, 28);
            this.cmbRole.TabIndex = 9;
            // 
            // chkUserActive
            // 
            this.chkUserActive.AutoSize = true;
            this.chkUserActive.Checked = true;
            this.chkUserActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUserActive.Location = new System.Drawing.Point(15, 288);
            this.chkUserActive.Name = "chkUserActive";
            this.chkUserActive.Size = new System.Drawing.Size(97, 24);
            this.chkUserActive.TabIndex = 10;
            this.chkUserActive.Text = "Akun aktif";
            this.chkUserActive.CheckedChanged += new System.EventHandler(this.chkUserActive_CheckedChanged);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(15, 330);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(85, 32);
            this.btnUserAdd.TabIndex = 11;
            this.btnUserAdd.Text = "Tambah";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(107, 330);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnUserUpdate.TabIndex = 12;
            this.btnUserUpdate.Text = "Ubah";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(199, 330);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(85, 32);
            this.btnUserDelete.TabIndex = 13;
            this.btnUserDelete.Text = "Hapus";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserClear
            // 
            this.btnUserClear.Location = new System.Drawing.Point(291, 330);
            this.btnUserClear.Name = "btnUserClear";
            this.btnUserClear.Size = new System.Drawing.Size(85, 32);
            this.btnUserClear.TabIndex = 14;
            this.btnUserClear.Text = "Bersihkan";
            this.btnUserClear.UseVisualStyleBackColor = true;
            this.btnUserClear.Click += new System.EventHandler(this.btnUserClear_Click);
            // 
            // tabClasses
            // 
            this.tabClasses.Controls.Add(this.txtSearchClass);
            this.tabClasses.Controls.Add(this.btnSearchClass);
            this.tabClasses.Controls.Add(this.btnRefreshClass);
            this.tabClasses.Controls.Add(this.dgvClass);
            this.tabClasses.Controls.Add(this.gbClassInput);
            this.tabClasses.Location = new System.Drawing.Point(4, 29);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(1142, 627);
            this.tabClasses.TabIndex = 1;
            this.tabClasses.Text = "Kelas";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.Location = new System.Drawing.Point(15, 15);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(300, 27);
            this.txtSearchClass.TabIndex = 0;
            // 
            // btnSearchClass
            // 
            this.btnSearchClass.Location = new System.Drawing.Point(325, 13);
            this.btnSearchClass.Name = "btnSearchClass";
            this.btnSearchClass.Size = new System.Drawing.Size(90, 27);
            this.btnSearchClass.TabIndex = 1;
            this.btnSearchClass.Text = "Cari";
            this.btnSearchClass.UseVisualStyleBackColor = true;
            this.btnSearchClass.Click += new System.EventHandler(this.btnSearchClass_Click);
            // 
            // btnRefreshClass
            // 
            this.btnRefreshClass.Location = new System.Drawing.Point(425, 13);
            this.btnRefreshClass.Name = "btnRefreshClass";
            this.btnRefreshClass.Size = new System.Drawing.Size(110, 27);
            this.btnRefreshClass.TabIndex = 2;
            this.btnRefreshClass.Text = "Muat Ulang";
            this.btnRefreshClass.UseVisualStyleBackColor = true;
            this.btnRefreshClass.Click += new System.EventHandler(this.btnRefreshClass_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.BackgroundColor = System.Drawing.Color.White;
            this.dgvClass.ColumnHeadersHeight = 29;
            this.dgvClass.Location = new System.Drawing.Point(15, 50);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(700, 560);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.SelectionChanged += new System.EventHandler(this.dgvClass_SelectionChanged);
            // 
            // gbClassInput
            // 
            this.gbClassInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClassInput.Controls.Add(this.lblClassName);
            this.gbClassInput.Controls.Add(this.txtClassName);
            this.gbClassInput.Controls.Add(this.lblGradeLevel);
            this.gbClassInput.Controls.Add(this.cmbGradeLevel);
            this.gbClassInput.Controls.Add(this.btnClassAdd);
            this.gbClassInput.Controls.Add(this.btnClassUpdate);
            this.gbClassInput.Controls.Add(this.btnClassDelete);
            this.gbClassInput.Controls.Add(this.btnClassClear);
            this.gbClassInput.Location = new System.Drawing.Point(730, 15);
            this.gbClassInput.Name = "gbClassInput";
            this.gbClassInput.Size = new System.Drawing.Size(395, 192);
            this.gbClassInput.TabIndex = 4;
            this.gbClassInput.TabStop = false;
            this.gbClassInput.Text = "Form Kelas";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(15, 28);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(182, 20);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Nama Kelas (mis. X-IPA-1)";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(15, 48);
            this.txtClassName.MaxLength = 50;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(360, 27);
            this.txtClassName.TabIndex = 1;
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Location = new System.Drawing.Point(15, 80);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(58, 20);
            this.lblGradeLevel.TabIndex = 2;
            this.lblGradeLevel.Text = "Tingkat";
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.Items.AddRange(new object[] {
            "VII",
            "VIII",
            "IX",
            "X",
            "XI",
            "XII"});
            this.cmbGradeLevel.Location = new System.Drawing.Point(15, 100);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(360, 28);
            this.cmbGradeLevel.TabIndex = 3;
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.Location = new System.Drawing.Point(15, 140);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(85, 32);
            this.btnClassAdd.TabIndex = 4;
            this.btnClassAdd.Text = "Tambah";
            this.btnClassAdd.UseVisualStyleBackColor = true;
            this.btnClassAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.Location = new System.Drawing.Point(107, 140);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnClassUpdate.TabIndex = 5;
            this.btnClassUpdate.Text = "Ubah";
            this.btnClassUpdate.UseVisualStyleBackColor = true;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.Location = new System.Drawing.Point(199, 140);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(85, 32);
            this.btnClassDelete.TabIndex = 6;
            this.btnClassDelete.Text = "Hapus";
            this.btnClassDelete.UseVisualStyleBackColor = true;
            this.btnClassDelete.Click += new System.EventHandler(this.btnClassDelete_Click);
            // 
            // btnClassClear
            // 
            this.btnClassClear.Location = new System.Drawing.Point(291, 140);
            this.btnClassClear.Name = "btnClassClear";
            this.btnClassClear.Size = new System.Drawing.Size(85, 32);
            this.btnClassClear.TabIndex = 7;
            this.btnClassClear.Text = "Bersihkan";
            this.btnClassClear.UseVisualStyleBackColor = true;
            this.btnClassClear.Click += new System.EventHandler(this.btnClassClear_Click);
            // 
            // tabSubjects
            // 
            this.tabSubjects.Controls.Add(this.txtSearchSubject);
            this.tabSubjects.Controls.Add(this.btnSearchSubject);
            this.tabSubjects.Controls.Add(this.btnRefreshSubject);
            this.tabSubjects.Controls.Add(this.dgvSubject);
            this.tabSubjects.Controls.Add(this.gbSubjectInput);
            this.tabSubjects.Location = new System.Drawing.Point(4, 29);
            this.tabSubjects.Name = "tabSubjects";
            this.tabSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubjects.Size = new System.Drawing.Size(1142, 627);
            this.tabSubjects.TabIndex = 2;
            this.tabSubjects.Text = "Mata Pelajaran";
            this.tabSubjects.UseVisualStyleBackColor = true;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.Location = new System.Drawing.Point(15, 15);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(300, 27);
            this.txtSearchSubject.TabIndex = 0;
            // 
            // btnSearchSubject
            // 
            this.btnSearchSubject.Location = new System.Drawing.Point(325, 13);
            this.btnSearchSubject.Name = "btnSearchSubject";
            this.btnSearchSubject.Size = new System.Drawing.Size(90, 27);
            this.btnSearchSubject.TabIndex = 1;
            this.btnSearchSubject.Text = "Cari";
            this.btnSearchSubject.UseVisualStyleBackColor = true;
            this.btnSearchSubject.Click += new System.EventHandler(this.btnSearchSubject_Click);
            // 
            // btnRefreshSubject
            // 
            this.btnRefreshSubject.Location = new System.Drawing.Point(425, 13);
            this.btnRefreshSubject.Name = "btnRefreshSubject";
            this.btnRefreshSubject.Size = new System.Drawing.Size(110, 27);
            this.btnRefreshSubject.TabIndex = 2;
            this.btnRefreshSubject.Text = "Muat Ulang";
            this.btnRefreshSubject.UseVisualStyleBackColor = true;
            this.btnRefreshSubject.Click += new System.EventHandler(this.btnRefreshSubject_Click);
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AllowUserToDeleteRows = false;
            this.dgvSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubject.ColumnHeadersHeight = 29;
            this.dgvSubject.Location = new System.Drawing.Point(15, 50);
            this.dgvSubject.MultiSelect = false;
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.RowHeadersVisible = false;
            this.dgvSubject.RowHeadersWidth = 51;
            this.dgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubject.Size = new System.Drawing.Size(700, 560);
            this.dgvSubject.TabIndex = 3;
            this.dgvSubject.SelectionChanged += new System.EventHandler(this.dgvSubject_SelectionChanged);
            // 
            // gbSubjectInput
            // 
            this.gbSubjectInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSubjectInput.Controls.Add(this.lblSubjectCode);
            this.gbSubjectInput.Controls.Add(this.txtSubjectCode);
            this.gbSubjectInput.Controls.Add(this.lblSubjectName);
            this.gbSubjectInput.Controls.Add(this.txtSubjectName);
            this.gbSubjectInput.Controls.Add(this.lblSubjectDescription);
            this.gbSubjectInput.Controls.Add(this.txtSubjectDescription);
            this.gbSubjectInput.Controls.Add(this.btnSubjectAdd);
            this.gbSubjectInput.Controls.Add(this.btnSubjectUpdate);
            this.gbSubjectInput.Controls.Add(this.btnSubjectDelete);
            this.gbSubjectInput.Controls.Add(this.btnSubjectClear);
            this.gbSubjectInput.Location = new System.Drawing.Point(730, 15);
            this.gbSubjectInput.Name = "gbSubjectInput";
            this.gbSubjectInput.Size = new System.Drawing.Size(395, 301);
            this.gbSubjectInput.TabIndex = 4;
            this.gbSubjectInput.TabStop = false;
            this.gbSubjectInput.Text = "Form Mata Pelajaran";
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Location = new System.Drawing.Point(15, 28);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(90, 20);
            this.lblSubjectCode.TabIndex = 0;
            this.lblSubjectCode.Text = "Kode Mapel";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Location = new System.Drawing.Point(15, 48);
            this.txtSubjectCode.MaxLength = 20;
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(360, 27);
            this.txtSubjectCode.TabIndex = 1;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(15, 80);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(95, 20);
            this.lblSubjectName.TabIndex = 2;
            this.lblSubjectName.Text = "Nama Mapel";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(15, 100);
            this.txtSubjectName.MaxLength = 100;
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(360, 27);
            this.txtSubjectName.TabIndex = 3;
            // 
            // lblSubjectDescription
            // 
            this.lblSubjectDescription.AutoSize = true;
            this.lblSubjectDescription.Location = new System.Drawing.Point(15, 132);
            this.lblSubjectDescription.Name = "lblSubjectDescription";
            this.lblSubjectDescription.Size = new System.Drawing.Size(69, 20);
            this.lblSubjectDescription.TabIndex = 4;
            this.lblSubjectDescription.Text = "Deskripsi";
            // 
            // txtSubjectDescription
            // 
            this.txtSubjectDescription.Location = new System.Drawing.Point(15, 152);
            this.txtSubjectDescription.Multiline = true;
            this.txtSubjectDescription.Name = "txtSubjectDescription";
            this.txtSubjectDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubjectDescription.Size = new System.Drawing.Size(360, 80);
            this.txtSubjectDescription.TabIndex = 5;
            // 
            // btnSubjectAdd
            // 
            this.btnSubjectAdd.Location = new System.Drawing.Point(15, 249);
            this.btnSubjectAdd.Name = "btnSubjectAdd";
            this.btnSubjectAdd.Size = new System.Drawing.Size(85, 32);
            this.btnSubjectAdd.TabIndex = 6;
            this.btnSubjectAdd.Text = "Tambah";
            this.btnSubjectAdd.UseVisualStyleBackColor = true;
            this.btnSubjectAdd.Click += new System.EventHandler(this.btnSubjectAdd_Click);
            // 
            // btnSubjectUpdate
            // 
            this.btnSubjectUpdate.Location = new System.Drawing.Point(107, 249);
            this.btnSubjectUpdate.Name = "btnSubjectUpdate";
            this.btnSubjectUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnSubjectUpdate.TabIndex = 7;
            this.btnSubjectUpdate.Text = "Ubah";
            this.btnSubjectUpdate.UseVisualStyleBackColor = true;
            this.btnSubjectUpdate.Click += new System.EventHandler(this.btnSubjectUpdate_Click);
            // 
            // btnSubjectDelete
            // 
            this.btnSubjectDelete.Location = new System.Drawing.Point(199, 249);
            this.btnSubjectDelete.Name = "btnSubjectDelete";
            this.btnSubjectDelete.Size = new System.Drawing.Size(85, 32);
            this.btnSubjectDelete.TabIndex = 8;
            this.btnSubjectDelete.Text = "Hapus";
            this.btnSubjectDelete.UseVisualStyleBackColor = true;
            this.btnSubjectDelete.Click += new System.EventHandler(this.btnSubjectDelete_Click);
            // 
            // btnSubjectClear
            // 
            this.btnSubjectClear.Location = new System.Drawing.Point(291, 249);
            this.btnSubjectClear.Name = "btnSubjectClear";
            this.btnSubjectClear.Size = new System.Drawing.Size(85, 32);
            this.btnSubjectClear.TabIndex = 9;
            this.btnSubjectClear.Text = "Bersihkan";
            this.btnSubjectClear.UseVisualStyleBackColor = true;
            this.btnSubjectClear.Click += new System.EventHandler(this.btnSubjectClear_Click);
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.txtSearchStudent);
            this.tabStudents.Controls.Add(this.btnSearchStudent);
            this.tabStudents.Controls.Add(this.btnRefreshStudent);
            this.tabStudents.Controls.Add(this.dgvStudent);
            this.tabStudents.Controls.Add(this.gbStudentInput);
            this.tabStudents.Location = new System.Drawing.Point(4, 29);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(1142, 627);
            this.tabStudents.TabIndex = 3;
            this.tabStudents.Text = "Siswa";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(15, 15);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(300, 27);
            this.txtSearchStudent.TabIndex = 0;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(325, 13);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(90, 27);
            this.btnSearchStudent.TabIndex = 1;
            this.btnSearchStudent.Text = "Cari";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnRefreshStudent
            // 
            this.btnRefreshStudent.Location = new System.Drawing.Point(425, 13);
            this.btnRefreshStudent.Name = "btnRefreshStudent";
            this.btnRefreshStudent.Size = new System.Drawing.Size(110, 27);
            this.btnRefreshStudent.TabIndex = 2;
            this.btnRefreshStudent.Text = "Muat Ulang";
            this.btnRefreshStudent.UseVisualStyleBackColor = true;
            this.btnRefreshStudent.Click += new System.EventHandler(this.btnRefreshStudent_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.ColumnHeadersHeight = 29;
            this.dgvStudent.Location = new System.Drawing.Point(15, 50);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(700, 560);
            this.dgvStudent.TabIndex = 3;
            this.dgvStudent.SelectionChanged += new System.EventHandler(this.dgvStudent_SelectionChanged);
            // 
            // gbStudentInput
            // 
            this.gbStudentInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudentInput.Controls.Add(this.lblStudentUser);
            this.gbStudentInput.Controls.Add(this.cmbStudentUser);
            this.gbStudentInput.Controls.Add(this.lblStudentNumber);
            this.gbStudentInput.Controls.Add(this.txtStudentNumber);
            this.gbStudentInput.Controls.Add(this.lblStudentClass);
            this.gbStudentInput.Controls.Add(this.cmbStudentClass);
            this.gbStudentInput.Controls.Add(this.lblBirthDate);
            this.gbStudentInput.Controls.Add(this.dtpBirthDate);
            this.gbStudentInput.Controls.Add(this.lblGender);
            this.gbStudentInput.Controls.Add(this.cmbGender);
            this.gbStudentInput.Controls.Add(this.lblParentName);
            this.gbStudentInput.Controls.Add(this.txtParentName);
            this.gbStudentInput.Controls.Add(this.lblParentPhone);
            this.gbStudentInput.Controls.Add(this.txtParentPhone);
            this.gbStudentInput.Controls.Add(this.lblStudentAddress);
            this.gbStudentInput.Controls.Add(this.txtStudentAddress);
            this.gbStudentInput.Controls.Add(this.btnStudentAdd);
            this.gbStudentInput.Controls.Add(this.btnStudentUpdate);
            this.gbStudentInput.Controls.Add(this.btnStudentDelete);
            this.gbStudentInput.Controls.Add(this.btnStudentClear);
            this.gbStudentInput.Location = new System.Drawing.Point(730, 15);
            this.gbStudentInput.Name = "gbStudentInput";
            this.gbStudentInput.Size = new System.Drawing.Size(395, 541);
            this.gbStudentInput.TabIndex = 4;
            this.gbStudentInput.TabStop = false;
            this.gbStudentInput.Text = "Form Siswa";
            // 
            // lblStudentUser
            // 
            this.lblStudentUser.AutoSize = true;
            this.lblStudentUser.Location = new System.Drawing.Point(15, 28);
            this.lblStudentUser.Name = "lblStudentUser";
            this.lblStudentUser.Size = new System.Drawing.Size(156, 20);
            this.lblStudentUser.TabIndex = 0;
            this.lblStudentUser.Text = "Akun User (role Siswa)";
            // 
            // cmbStudentUser
            // 
            this.cmbStudentUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentUser.FormattingEnabled = true;
            this.cmbStudentUser.Location = new System.Drawing.Point(15, 48);
            this.cmbStudentUser.Name = "cmbStudentUser";
            this.cmbStudentUser.Size = new System.Drawing.Size(360, 28);
            this.cmbStudentUser.TabIndex = 1;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(15, 80);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(32, 20);
            this.lblStudentNumber.TabIndex = 2;
            this.lblStudentNumber.Text = "NIS";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(15, 100);
            this.txtStudentNumber.MaxLength = 30;
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(360, 27);
            this.txtStudentNumber.TabIndex = 3;
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.Location = new System.Drawing.Point(15, 132);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(44, 20);
            this.lblStudentClass.TabIndex = 4;
            this.lblStudentClass.Text = "Kelas";
            // 
            // cmbStudentClass
            // 
            this.cmbStudentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentClass.FormattingEnabled = true;
            this.cmbStudentClass.Location = new System.Drawing.Point(15, 152);
            this.cmbStudentClass.Name = "cmbStudentClass";
            this.cmbStudentClass.Size = new System.Drawing.Size(360, 28);
            this.cmbStudentClass.TabIndex = 5;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(15, 184);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(97, 20);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Tanggal Lahir";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(15, 204);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.ShowCheckBox = true;
            this.dtpBirthDate.Size = new System.Drawing.Size(360, 27);
            this.dtpBirthDate.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(15, 236);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(98, 20);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Jenis Kelamin";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cmbGender.Location = new System.Drawing.Point(15, 256);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(360, 28);
            this.cmbGender.TabIndex = 9;
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(15, 288);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(122, 20);
            this.lblParentName.TabIndex = 10;
            this.lblParentName.Text = "Nama Orang Tua";
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(15, 308);
            this.txtParentName.MaxLength = 150;
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(360, 27);
            this.txtParentName.TabIndex = 11;
            // 
            // lblParentPhone
            // 
            this.lblParentPhone.AutoSize = true;
            this.lblParentPhone.Location = new System.Drawing.Point(15, 340);
            this.lblParentPhone.Name = "lblParentPhone";
            this.lblParentPhone.Size = new System.Drawing.Size(135, 20);
            this.lblParentPhone.TabIndex = 12;
            this.lblParentPhone.Text = "Telepon Orang Tua";
            // 
            // txtParentPhone
            // 
            this.txtParentPhone.Location = new System.Drawing.Point(15, 360);
            this.txtParentPhone.MaxLength = 30;
            this.txtParentPhone.Name = "txtParentPhone";
            this.txtParentPhone.Size = new System.Drawing.Size(360, 27);
            this.txtParentPhone.TabIndex = 13;
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Location = new System.Drawing.Point(15, 392);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(57, 20);
            this.lblStudentAddress.TabIndex = 14;
            this.lblStudentAddress.Text = "Alamat";
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(15, 412);
            this.txtStudentAddress.Multiline = true;
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStudentAddress.Size = new System.Drawing.Size(360, 60);
            this.txtStudentAddress.TabIndex = 15;
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(15, 489);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(85, 32);
            this.btnStudentAdd.TabIndex = 16;
            this.btnStudentAdd.Text = "Tambah";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.Location = new System.Drawing.Point(107, 489);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnStudentUpdate.TabIndex = 17;
            this.btnStudentUpdate.Text = "Ubah";
            this.btnStudentUpdate.UseVisualStyleBackColor = true;
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(199, 489);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(85, 32);
            this.btnStudentDelete.TabIndex = 18;
            this.btnStudentDelete.Text = "Hapus";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentClear
            // 
            this.btnStudentClear.Location = new System.Drawing.Point(291, 489);
            this.btnStudentClear.Name = "btnStudentClear";
            this.btnStudentClear.Size = new System.Drawing.Size(85, 32);
            this.btnStudentClear.TabIndex = 19;
            this.btnStudentClear.Text = "Bersihkan";
            this.btnStudentClear.UseVisualStyleBackColor = true;
            this.btnStudentClear.Click += new System.EventHandler(this.btnStudentClear_Click);
            // 
            // tabTeachers
            // 
            this.tabTeachers.Controls.Add(this.txtSearchTeacher);
            this.tabTeachers.Controls.Add(this.btnSearchTeacher);
            this.tabTeachers.Controls.Add(this.btnRefreshTeacher);
            this.tabTeachers.Controls.Add(this.dgvTeacher);
            this.tabTeachers.Controls.Add(this.gbTeacherInput);
            this.tabTeachers.Location = new System.Drawing.Point(4, 29);
            this.tabTeachers.Name = "tabTeachers";
            this.tabTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeachers.Size = new System.Drawing.Size(1142, 627);
            this.tabTeachers.TabIndex = 4;
            this.tabTeachers.Text = "Guru";
            this.tabTeachers.UseVisualStyleBackColor = true;
            // 
            // txtSearchTeacher
            // 
            this.txtSearchTeacher.Location = new System.Drawing.Point(15, 15);
            this.txtSearchTeacher.Name = "txtSearchTeacher";
            this.txtSearchTeacher.Size = new System.Drawing.Size(300, 27);
            this.txtSearchTeacher.TabIndex = 0;
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.Location = new System.Drawing.Point(325, 13);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(90, 27);
            this.btnSearchTeacher.TabIndex = 1;
            this.btnSearchTeacher.Text = "Cari";
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // btnRefreshTeacher
            // 
            this.btnRefreshTeacher.Location = new System.Drawing.Point(425, 13);
            this.btnRefreshTeacher.Name = "btnRefreshTeacher";
            this.btnRefreshTeacher.Size = new System.Drawing.Size(110, 27);
            this.btnRefreshTeacher.TabIndex = 2;
            this.btnRefreshTeacher.Text = "Muat Ulang";
            this.btnRefreshTeacher.UseVisualStyleBackColor = true;
            this.btnRefreshTeacher.Click += new System.EventHandler(this.btnRefreshTeacher_Click);
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacher.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeacher.ColumnHeadersHeight = 29;
            this.dgvTeacher.Location = new System.Drawing.Point(15, 50);
            this.dgvTeacher.MultiSelect = false;
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.RowHeadersVisible = false;
            this.dgvTeacher.RowHeadersWidth = 51;
            this.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacher.Size = new System.Drawing.Size(700, 560);
            this.dgvTeacher.TabIndex = 3;
            this.dgvTeacher.SelectionChanged += new System.EventHandler(this.dgvTeacher_SelectionChanged);
            // 
            // gbTeacherInput
            // 
            this.gbTeacherInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTeacherInput.Controls.Add(this.lblTeacherUser);
            this.gbTeacherInput.Controls.Add(this.cmbTeacherUser);
            this.gbTeacherInput.Controls.Add(this.lblTeacherNumber);
            this.gbTeacherInput.Controls.Add(this.txtTeacherNumber);
            this.gbTeacherInput.Controls.Add(this.lblTeacherPhone);
            this.gbTeacherInput.Controls.Add(this.txtTeacherPhone);
            this.gbTeacherInput.Controls.Add(this.lblTeacherAddress);
            this.gbTeacherInput.Controls.Add(this.txtTeacherAddress);
            this.gbTeacherInput.Controls.Add(this.btnTeacherAdd);
            this.gbTeacherInput.Controls.Add(this.btnTeacherUpdate);
            this.gbTeacherInput.Controls.Add(this.btnTeacherDelete);
            this.gbTeacherInput.Controls.Add(this.btnTeacherClear);
            this.gbTeacherInput.Location = new System.Drawing.Point(730, 15);
            this.gbTeacherInput.Name = "gbTeacherInput";
            this.gbTeacherInput.Size = new System.Drawing.Size(395, 343);
            this.gbTeacherInput.TabIndex = 4;
            this.gbTeacherInput.TabStop = false;
            this.gbTeacherInput.Text = "Form Guru";
            // 
            // lblTeacherUser
            // 
            this.lblTeacherUser.AutoSize = true;
            this.lblTeacherUser.Location = new System.Drawing.Point(15, 28);
            this.lblTeacherUser.Name = "lblTeacherUser";
            this.lblTeacherUser.Size = new System.Drawing.Size(150, 20);
            this.lblTeacherUser.TabIndex = 0;
            this.lblTeacherUser.Text = "Akun User (role Guru)";
            // 
            // cmbTeacherUser
            // 
            this.cmbTeacherUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherUser.FormattingEnabled = true;
            this.cmbTeacherUser.Location = new System.Drawing.Point(15, 48);
            this.cmbTeacherUser.Name = "cmbTeacherUser";
            this.cmbTeacherUser.Size = new System.Drawing.Size(360, 28);
            this.cmbTeacherUser.TabIndex = 1;
            // 
            // lblTeacherNumber
            // 
            this.lblTeacherNumber.AutoSize = true;
            this.lblTeacherNumber.Location = new System.Drawing.Point(15, 80);
            this.lblTeacherNumber.Name = "lblTeacherNumber";
            this.lblTeacherNumber.Size = new System.Drawing.Size(32, 20);
            this.lblTeacherNumber.TabIndex = 2;
            this.lblTeacherNumber.Text = "NIP";
            // 
            // txtTeacherNumber
            // 
            this.txtTeacherNumber.Location = new System.Drawing.Point(15, 100);
            this.txtTeacherNumber.MaxLength = 30;
            this.txtTeacherNumber.Name = "txtTeacherNumber";
            this.txtTeacherNumber.Size = new System.Drawing.Size(360, 27);
            this.txtTeacherNumber.TabIndex = 3;
            // 
            // lblTeacherPhone
            // 
            this.lblTeacherPhone.AutoSize = true;
            this.lblTeacherPhone.Location = new System.Drawing.Point(15, 132);
            this.lblTeacherPhone.Name = "lblTeacherPhone";
            this.lblTeacherPhone.Size = new System.Drawing.Size(62, 20);
            this.lblTeacherPhone.TabIndex = 4;
            this.lblTeacherPhone.Text = "Telepon";
            // 
            // txtTeacherPhone
            // 
            this.txtTeacherPhone.Location = new System.Drawing.Point(15, 152);
            this.txtTeacherPhone.MaxLength = 30;
            this.txtTeacherPhone.Name = "txtTeacherPhone";
            this.txtTeacherPhone.Size = new System.Drawing.Size(360, 27);
            this.txtTeacherPhone.TabIndex = 5;
            // 
            // lblTeacherAddress
            // 
            this.lblTeacherAddress.AutoSize = true;
            this.lblTeacherAddress.Location = new System.Drawing.Point(15, 184);
            this.lblTeacherAddress.Name = "lblTeacherAddress";
            this.lblTeacherAddress.Size = new System.Drawing.Size(57, 20);
            this.lblTeacherAddress.TabIndex = 6;
            this.lblTeacherAddress.Text = "Alamat";
            // 
            // txtTeacherAddress
            // 
            this.txtTeacherAddress.Location = new System.Drawing.Point(15, 204);
            this.txtTeacherAddress.Multiline = true;
            this.txtTeacherAddress.Name = "txtTeacherAddress";
            this.txtTeacherAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTeacherAddress.Size = new System.Drawing.Size(360, 70);
            this.txtTeacherAddress.TabIndex = 7;
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.Location = new System.Drawing.Point(15, 291);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(85, 32);
            this.btnTeacherAdd.TabIndex = 8;
            this.btnTeacherAdd.Text = "Tambah";
            this.btnTeacherAdd.UseVisualStyleBackColor = true;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // btnTeacherUpdate
            // 
            this.btnTeacherUpdate.Location = new System.Drawing.Point(107, 291);
            this.btnTeacherUpdate.Name = "btnTeacherUpdate";
            this.btnTeacherUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnTeacherUpdate.TabIndex = 9;
            this.btnTeacherUpdate.Text = "Ubah";
            this.btnTeacherUpdate.UseVisualStyleBackColor = true;
            this.btnTeacherUpdate.Click += new System.EventHandler(this.btnTeacherUpdate_Click);
            // 
            // btnTeacherDelete
            // 
            this.btnTeacherDelete.Location = new System.Drawing.Point(199, 291);
            this.btnTeacherDelete.Name = "btnTeacherDelete";
            this.btnTeacherDelete.Size = new System.Drawing.Size(85, 32);
            this.btnTeacherDelete.TabIndex = 10;
            this.btnTeacherDelete.Text = "Hapus";
            this.btnTeacherDelete.UseVisualStyleBackColor = true;
            this.btnTeacherDelete.Click += new System.EventHandler(this.btnTeacherDelete_Click);
            // 
            // btnTeacherClear
            // 
            this.btnTeacherClear.Location = new System.Drawing.Point(291, 291);
            this.btnTeacherClear.Name = "btnTeacherClear";
            this.btnTeacherClear.Size = new System.Drawing.Size(85, 32);
            this.btnTeacherClear.TabIndex = 11;
            this.btnTeacherClear.Text = "Bersihkan";
            this.btnTeacherClear.UseVisualStyleBackColor = true;
            this.btnTeacherClear.Click += new System.EventHandler(this.btnTeacherClear_Click);
            // 
            // tabAcademic
            // 
            this.tabAcademic.Controls.Add(this.lblAcademicYearTitle);
            this.tabAcademic.Controls.Add(this.dgvAcademicYear);
            this.tabAcademic.Controls.Add(this.lblYearName);
            this.tabAcademic.Controls.Add(this.txtYearName);
            this.tabAcademic.Controls.Add(this.chkYearActive);
            this.tabAcademic.Controls.Add(this.btnYearAdd);
            this.tabAcademic.Controls.Add(this.btnYearUpdate);
            this.tabAcademic.Controls.Add(this.btnYearDelete);
            this.tabAcademic.Controls.Add(this.btnYearSetActive);
            this.tabAcademic.Controls.Add(this.lblSemesterTitle);
            this.tabAcademic.Controls.Add(this.dgvSemester);
            this.tabAcademic.Controls.Add(this.lblSemesterYear);
            this.tabAcademic.Controls.Add(this.cmbSemesterYear);
            this.tabAcademic.Controls.Add(this.lblSemesterName);
            this.tabAcademic.Controls.Add(this.cmbSemesterName);
            this.tabAcademic.Controls.Add(this.chkSemesterActive);
            this.tabAcademic.Controls.Add(this.btnSemesterAdd);
            this.tabAcademic.Controls.Add(this.btnSemesterUpdate);
            this.tabAcademic.Controls.Add(this.btnSemesterDelete);
            this.tabAcademic.Controls.Add(this.btnSemesterSetActive);
            this.tabAcademic.Location = new System.Drawing.Point(4, 29);
            this.tabAcademic.Name = "tabAcademic";
            this.tabAcademic.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcademic.Size = new System.Drawing.Size(1142, 627);
            this.tabAcademic.TabIndex = 5;
            this.tabAcademic.Text = "Tahun Ajaran & Semester";
            this.tabAcademic.UseVisualStyleBackColor = true;
            // 
            // lblAcademicYearTitle
            // 
            this.lblAcademicYearTitle.AutoSize = true;
            this.lblAcademicYearTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAcademicYearTitle.Location = new System.Drawing.Point(15, 15);
            this.lblAcademicYearTitle.Name = "lblAcademicYearTitle";
            this.lblAcademicYearTitle.Size = new System.Drawing.Size(129, 25);
            this.lblAcademicYearTitle.TabIndex = 0;
            this.lblAcademicYearTitle.Text = "Tahun Ajaran";
            // 
            // dgvAcademicYear
            // 
            this.dgvAcademicYear.AllowUserToAddRows = false;
            this.dgvAcademicYear.AllowUserToDeleteRows = false;
            this.dgvAcademicYear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcademicYear.BackgroundColor = System.Drawing.Color.White;
            this.dgvAcademicYear.ColumnHeadersHeight = 29;
            this.dgvAcademicYear.Location = new System.Drawing.Point(15, 40);
            this.dgvAcademicYear.MultiSelect = false;
            this.dgvAcademicYear.Name = "dgvAcademicYear";
            this.dgvAcademicYear.ReadOnly = true;
            this.dgvAcademicYear.RowHeadersVisible = false;
            this.dgvAcademicYear.RowHeadersWidth = 51;
            this.dgvAcademicYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcademicYear.Size = new System.Drawing.Size(540, 270);
            this.dgvAcademicYear.TabIndex = 1;
            this.dgvAcademicYear.SelectionChanged += new System.EventHandler(this.dgvAcademicYear_SelectionChanged);
            // 
            // lblYearName
            // 
            this.lblYearName.AutoSize = true;
            this.lblYearName.Location = new System.Drawing.Point(15, 325);
            this.lblYearName.Name = "lblYearName";
            this.lblYearName.Size = new System.Drawing.Size(252, 20);
            this.lblYearName.TabIndex = 2;
            this.lblYearName.Text = "Nama Tahun Ajaran (mis. 2025/2026)";
            // 
            // txtYearName
            // 
            this.txtYearName.Location = new System.Drawing.Point(15, 345);
            this.txtYearName.MaxLength = 20;
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.Size = new System.Drawing.Size(250, 27);
            this.txtYearName.TabIndex = 3;
            // 
            // chkYearActive
            // 
            this.chkYearActive.AutoSize = true;
            this.chkYearActive.Location = new System.Drawing.Point(280, 347);
            this.chkYearActive.Name = "chkYearActive";
            this.chkYearActive.Size = new System.Drawing.Size(62, 24);
            this.chkYearActive.TabIndex = 4;
            this.chkYearActive.Text = "Aktif";
            this.chkYearActive.CheckedChanged += new System.EventHandler(this.chkYearActive_CheckedChanged);
            // 
            // btnYearAdd
            // 
            this.btnYearAdd.Location = new System.Drawing.Point(15, 380);
            this.btnYearAdd.Name = "btnYearAdd";
            this.btnYearAdd.Size = new System.Drawing.Size(85, 32);
            this.btnYearAdd.TabIndex = 5;
            this.btnYearAdd.Text = "Tambah";
            this.btnYearAdd.UseVisualStyleBackColor = true;
            this.btnYearAdd.Click += new System.EventHandler(this.btnYearAdd_Click);
            // 
            // btnYearUpdate
            // 
            this.btnYearUpdate.Location = new System.Drawing.Point(107, 380);
            this.btnYearUpdate.Name = "btnYearUpdate";
            this.btnYearUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnYearUpdate.TabIndex = 6;
            this.btnYearUpdate.Text = "Ubah";
            this.btnYearUpdate.UseVisualStyleBackColor = true;
            this.btnYearUpdate.Click += new System.EventHandler(this.btnYearUpdate_Click);
            // 
            // btnYearDelete
            // 
            this.btnYearDelete.Location = new System.Drawing.Point(199, 380);
            this.btnYearDelete.Name = "btnYearDelete";
            this.btnYearDelete.Size = new System.Drawing.Size(85, 32);
            this.btnYearDelete.TabIndex = 7;
            this.btnYearDelete.Text = "Hapus";
            this.btnYearDelete.UseVisualStyleBackColor = true;
            this.btnYearDelete.Click += new System.EventHandler(this.btnYearDelete_Click);
            // 
            // btnYearSetActive
            // 
            this.btnYearSetActive.Location = new System.Drawing.Point(291, 380);
            this.btnYearSetActive.Name = "btnYearSetActive";
            this.btnYearSetActive.Size = new System.Drawing.Size(120, 32);
            this.btnYearSetActive.TabIndex = 8;
            this.btnYearSetActive.Text = "Jadikan Aktif";
            this.btnYearSetActive.UseVisualStyleBackColor = true;
            this.btnYearSetActive.Click += new System.EventHandler(this.btnYearSetActive_Click);
            // 
            // lblSemesterTitle
            // 
            this.lblSemesterTitle.AutoSize = true;
            this.lblSemesterTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSemesterTitle.Location = new System.Drawing.Point(585, 15);
            this.lblSemesterTitle.Name = "lblSemesterTitle";
            this.lblSemesterTitle.Size = new System.Drawing.Size(93, 25);
            this.lblSemesterTitle.TabIndex = 9;
            this.lblSemesterTitle.Text = "Semester";
            // 
            // dgvSemester
            // 
            this.dgvSemester.AllowUserToAddRows = false;
            this.dgvSemester.AllowUserToDeleteRows = false;
            this.dgvSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSemester.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSemester.BackgroundColor = System.Drawing.Color.White;
            this.dgvSemester.ColumnHeadersHeight = 29;
            this.dgvSemester.Location = new System.Drawing.Point(585, 40);
            this.dgvSemester.MultiSelect = false;
            this.dgvSemester.Name = "dgvSemester";
            this.dgvSemester.ReadOnly = true;
            this.dgvSemester.RowHeadersVisible = false;
            this.dgvSemester.RowHeadersWidth = 51;
            this.dgvSemester.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSemester.Size = new System.Drawing.Size(540, 270);
            this.dgvSemester.TabIndex = 10;
            this.dgvSemester.SelectionChanged += new System.EventHandler(this.dgvSemester_SelectionChanged);
            // 
            // lblSemesterYear
            // 
            this.lblSemesterYear.AutoSize = true;
            this.lblSemesterYear.Location = new System.Drawing.Point(585, 325);
            this.lblSemesterYear.Name = "lblSemesterYear";
            this.lblSemesterYear.Size = new System.Drawing.Size(94, 20);
            this.lblSemesterYear.TabIndex = 11;
            this.lblSemesterYear.Text = "Tahun Ajaran";
            // 
            // cmbSemesterYear
            // 
            this.cmbSemesterYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemesterYear.FormattingEnabled = true;
            this.cmbSemesterYear.Location = new System.Drawing.Point(585, 345);
            this.cmbSemesterYear.Name = "cmbSemesterYear";
            this.cmbSemesterYear.Size = new System.Drawing.Size(200, 28);
            this.cmbSemesterYear.TabIndex = 12;
            // 
            // lblSemesterName
            // 
            this.lblSemesterName.AutoSize = true;
            this.lblSemesterName.Location = new System.Drawing.Point(800, 325);
            this.lblSemesterName.Name = "lblSemesterName";
            this.lblSemesterName.Size = new System.Drawing.Size(70, 20);
            this.lblSemesterName.TabIndex = 13;
            this.lblSemesterName.Text = "Semester";
            // 
            // cmbSemesterName
            // 
            this.cmbSemesterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemesterName.FormattingEnabled = true;
            this.cmbSemesterName.Items.AddRange(new object[] {
            "Ganjil",
            "Genap"});
            this.cmbSemesterName.Location = new System.Drawing.Point(800, 345);
            this.cmbSemesterName.Name = "cmbSemesterName";
            this.cmbSemesterName.Size = new System.Drawing.Size(150, 28);
            this.cmbSemesterName.TabIndex = 14;
            // 
            // chkSemesterActive
            // 
            this.chkSemesterActive.AutoSize = true;
            this.chkSemesterActive.Location = new System.Drawing.Point(965, 347);
            this.chkSemesterActive.Name = "chkSemesterActive";
            this.chkSemesterActive.Size = new System.Drawing.Size(62, 24);
            this.chkSemesterActive.TabIndex = 15;
            this.chkSemesterActive.Text = "Aktif";
            this.chkSemesterActive.CheckedChanged += new System.EventHandler(this.chkSemesterActive_CheckedChanged);
            // 
            // btnSemesterAdd
            // 
            this.btnSemesterAdd.Location = new System.Drawing.Point(585, 380);
            this.btnSemesterAdd.Name = "btnSemesterAdd";
            this.btnSemesterAdd.Size = new System.Drawing.Size(85, 32);
            this.btnSemesterAdd.TabIndex = 16;
            this.btnSemesterAdd.Text = "Tambah";
            this.btnSemesterAdd.UseVisualStyleBackColor = true;
            this.btnSemesterAdd.Click += new System.EventHandler(this.btnSemesterAdd_Click);
            // 
            // btnSemesterUpdate
            // 
            this.btnSemesterUpdate.Location = new System.Drawing.Point(677, 380);
            this.btnSemesterUpdate.Name = "btnSemesterUpdate";
            this.btnSemesterUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnSemesterUpdate.TabIndex = 17;
            this.btnSemesterUpdate.Text = "Ubah";
            this.btnSemesterUpdate.UseVisualStyleBackColor = true;
            this.btnSemesterUpdate.Click += new System.EventHandler(this.btnSemesterUpdate_Click);
            // 
            // btnSemesterDelete
            // 
            this.btnSemesterDelete.Location = new System.Drawing.Point(769, 380);
            this.btnSemesterDelete.Name = "btnSemesterDelete";
            this.btnSemesterDelete.Size = new System.Drawing.Size(85, 32);
            this.btnSemesterDelete.TabIndex = 18;
            this.btnSemesterDelete.Text = "Hapus";
            this.btnSemesterDelete.UseVisualStyleBackColor = true;
            this.btnSemesterDelete.Click += new System.EventHandler(this.btnSemesterDelete_Click);
            // 
            // btnSemesterSetActive
            // 
            this.btnSemesterSetActive.Location = new System.Drawing.Point(861, 380);
            this.btnSemesterSetActive.Name = "btnSemesterSetActive";
            this.btnSemesterSetActive.Size = new System.Drawing.Size(120, 32);
            this.btnSemesterSetActive.TabIndex = 19;
            this.btnSemesterSetActive.Text = "Jadikan Aktif";
            this.btnSemesterSetActive.UseVisualStyleBackColor = true;
            this.btnSemesterSetActive.Click += new System.EventHandler(this.btnSemesterSetActive_Click);
            // 
            // tabTeacherSubjects
            // 
            this.tabTeacherSubjects.Controls.Add(this.txtSearchTeacherSubject);
            this.tabTeacherSubjects.Controls.Add(this.btnSearchTeacherSubject);
            this.tabTeacherSubjects.Controls.Add(this.btnRefreshTeacherSubject);
            this.tabTeacherSubjects.Controls.Add(this.dgvTeacherSubject);
            this.tabTeacherSubjects.Controls.Add(this.gbTeacherSubjectInput);
            this.tabTeacherSubjects.Location = new System.Drawing.Point(4, 29);
            this.tabTeacherSubjects.Name = "tabTeacherSubjects";
            this.tabTeacherSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeacherSubjects.Size = new System.Drawing.Size(1142, 627);
            this.tabTeacherSubjects.TabIndex = 6;
            this.tabTeacherSubjects.Text = "Guru Mengajar";
            this.tabTeacherSubjects.UseVisualStyleBackColor = true;
            // 
            // txtSearchTeacherSubject
            // 
            this.txtSearchTeacherSubject.Location = new System.Drawing.Point(15, 15);
            this.txtSearchTeacherSubject.Name = "txtSearchTeacherSubject";
            this.txtSearchTeacherSubject.Size = new System.Drawing.Size(300, 27);
            this.txtSearchTeacherSubject.TabIndex = 0;
            // 
            // btnSearchTeacherSubject
            // 
            this.btnSearchTeacherSubject.Location = new System.Drawing.Point(325, 13);
            this.btnSearchTeacherSubject.Name = "btnSearchTeacherSubject";
            this.btnSearchTeacherSubject.Size = new System.Drawing.Size(90, 27);
            this.btnSearchTeacherSubject.TabIndex = 1;
            this.btnSearchTeacherSubject.Text = "Cari";
            this.btnSearchTeacherSubject.UseVisualStyleBackColor = true;
            this.btnSearchTeacherSubject.Click += new System.EventHandler(this.btnSearchTeacherSubject_Click);
            // 
            // btnRefreshTeacherSubject
            // 
            this.btnRefreshTeacherSubject.Location = new System.Drawing.Point(425, 13);
            this.btnRefreshTeacherSubject.Name = "btnRefreshTeacherSubject";
            this.btnRefreshTeacherSubject.Size = new System.Drawing.Size(110, 27);
            this.btnRefreshTeacherSubject.TabIndex = 2;
            this.btnRefreshTeacherSubject.Text = "Muat Ulang";
            this.btnRefreshTeacherSubject.UseVisualStyleBackColor = true;
            this.btnRefreshTeacherSubject.Click += new System.EventHandler(this.btnRefreshTeacherSubject_Click);
            // 
            // dgvTeacherSubject
            // 
            this.dgvTeacherSubject.AllowUserToAddRows = false;
            this.dgvTeacherSubject.AllowUserToDeleteRows = false;
            this.dgvTeacherSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacherSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherSubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeacherSubject.ColumnHeadersHeight = 29;
            this.dgvTeacherSubject.Location = new System.Drawing.Point(15, 50);
            this.dgvTeacherSubject.MultiSelect = false;
            this.dgvTeacherSubject.Name = "dgvTeacherSubject";
            this.dgvTeacherSubject.ReadOnly = true;
            this.dgvTeacherSubject.RowHeadersVisible = false;
            this.dgvTeacherSubject.RowHeadersWidth = 51;
            this.dgvTeacherSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacherSubject.Size = new System.Drawing.Size(700, 560);
            this.dgvTeacherSubject.TabIndex = 3;
            this.dgvTeacherSubject.SelectionChanged += new System.EventHandler(this.dgvTeacherSubject_SelectionChanged);
            // 
            // gbTeacherSubjectInput
            // 
            this.gbTeacherSubjectInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTeacherSubjectInput.Controls.Add(this.lblTsTeacher);
            this.gbTeacherSubjectInput.Controls.Add(this.cmbTsTeacher);
            this.gbTeacherSubjectInput.Controls.Add(this.lblTsSubject);
            this.gbTeacherSubjectInput.Controls.Add(this.cmbTsSubject);
            this.gbTeacherSubjectInput.Controls.Add(this.lblTsClass);
            this.gbTeacherSubjectInput.Controls.Add(this.cmbTsClass);
            this.gbTeacherSubjectInput.Controls.Add(this.lblTsSemester);
            this.gbTeacherSubjectInput.Controls.Add(this.cmbTsSemester);
            this.gbTeacherSubjectInput.Controls.Add(this.btnTeacherSubjectAdd);
            this.gbTeacherSubjectInput.Controls.Add(this.btnTeacherSubjectUpdate);
            this.gbTeacherSubjectInput.Controls.Add(this.btnTeacherSubjectDelete);
            this.gbTeacherSubjectInput.Controls.Add(this.btnTeacherSubjectClear);
            this.gbTeacherSubjectInput.Location = new System.Drawing.Point(730, 15);
            this.gbTeacherSubjectInput.Name = "gbTeacherSubjectInput";
            this.gbTeacherSubjectInput.Size = new System.Drawing.Size(395, 296);
            this.gbTeacherSubjectInput.TabIndex = 4;
            this.gbTeacherSubjectInput.TabStop = false;
            this.gbTeacherSubjectInput.Text = "Form Guru Mengajar";
            // 
            // lblTsTeacher
            // 
            this.lblTsTeacher.AutoSize = true;
            this.lblTsTeacher.Location = new System.Drawing.Point(15, 28);
            this.lblTsTeacher.Name = "lblTsTeacher";
            this.lblTsTeacher.Size = new System.Drawing.Size(40, 20);
            this.lblTsTeacher.TabIndex = 0;
            this.lblTsTeacher.Text = "Guru";
            // 
            // cmbTsTeacher
            // 
            this.cmbTsTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTsTeacher.FormattingEnabled = true;
            this.cmbTsTeacher.Location = new System.Drawing.Point(15, 48);
            this.cmbTsTeacher.Name = "cmbTsTeacher";
            this.cmbTsTeacher.Size = new System.Drawing.Size(360, 28);
            this.cmbTsTeacher.TabIndex = 1;
            // 
            // lblTsSubject
            // 
            this.lblTsSubject.AutoSize = true;
            this.lblTsSubject.Location = new System.Drawing.Point(15, 80);
            this.lblTsSubject.Name = "lblTsSubject";
            this.lblTsSubject.Size = new System.Drawing.Size(107, 20);
            this.lblTsSubject.TabIndex = 2;
            this.lblTsSubject.Text = "Mata Pelajaran";
            // 
            // cmbTsSubject
            // 
            this.cmbTsSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTsSubject.FormattingEnabled = true;
            this.cmbTsSubject.Location = new System.Drawing.Point(15, 100);
            this.cmbTsSubject.Name = "cmbTsSubject";
            this.cmbTsSubject.Size = new System.Drawing.Size(360, 28);
            this.cmbTsSubject.TabIndex = 3;
            // 
            // lblTsClass
            // 
            this.lblTsClass.AutoSize = true;
            this.lblTsClass.Location = new System.Drawing.Point(15, 132);
            this.lblTsClass.Name = "lblTsClass";
            this.lblTsClass.Size = new System.Drawing.Size(44, 20);
            this.lblTsClass.TabIndex = 4;
            this.lblTsClass.Text = "Kelas";
            // 
            // cmbTsClass
            // 
            this.cmbTsClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTsClass.FormattingEnabled = true;
            this.cmbTsClass.Location = new System.Drawing.Point(15, 152);
            this.cmbTsClass.Name = "cmbTsClass";
            this.cmbTsClass.Size = new System.Drawing.Size(360, 28);
            this.cmbTsClass.TabIndex = 5;
            // 
            // lblTsSemester
            // 
            this.lblTsSemester.AutoSize = true;
            this.lblTsSemester.Location = new System.Drawing.Point(15, 184);
            this.lblTsSemester.Name = "lblTsSemester";
            this.lblTsSemester.Size = new System.Drawing.Size(70, 20);
            this.lblTsSemester.TabIndex = 6;
            this.lblTsSemester.Text = "Semester";
            // 
            // cmbTsSemester
            // 
            this.cmbTsSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTsSemester.FormattingEnabled = true;
            this.cmbTsSemester.Location = new System.Drawing.Point(15, 204);
            this.cmbTsSemester.Name = "cmbTsSemester";
            this.cmbTsSemester.Size = new System.Drawing.Size(360, 28);
            this.cmbTsSemester.TabIndex = 7;
            // 
            // btnTeacherSubjectAdd
            // 
            this.btnTeacherSubjectAdd.Location = new System.Drawing.Point(15, 244);
            this.btnTeacherSubjectAdd.Name = "btnTeacherSubjectAdd";
            this.btnTeacherSubjectAdd.Size = new System.Drawing.Size(85, 32);
            this.btnTeacherSubjectAdd.TabIndex = 8;
            this.btnTeacherSubjectAdd.Text = "Tambah";
            this.btnTeacherSubjectAdd.UseVisualStyleBackColor = true;
            this.btnTeacherSubjectAdd.Click += new System.EventHandler(this.btnTeacherSubjectAdd_Click);
            // 
            // btnTeacherSubjectUpdate
            // 
            this.btnTeacherSubjectUpdate.Location = new System.Drawing.Point(107, 244);
            this.btnTeacherSubjectUpdate.Name = "btnTeacherSubjectUpdate";
            this.btnTeacherSubjectUpdate.Size = new System.Drawing.Size(85, 32);
            this.btnTeacherSubjectUpdate.TabIndex = 9;
            this.btnTeacherSubjectUpdate.Text = "Ubah";
            this.btnTeacherSubjectUpdate.UseVisualStyleBackColor = true;
            this.btnTeacherSubjectUpdate.Click += new System.EventHandler(this.btnTeacherSubjectUpdate_Click);
            // 
            // btnTeacherSubjectDelete
            // 
            this.btnTeacherSubjectDelete.Location = new System.Drawing.Point(199, 244);
            this.btnTeacherSubjectDelete.Name = "btnTeacherSubjectDelete";
            this.btnTeacherSubjectDelete.Size = new System.Drawing.Size(85, 32);
            this.btnTeacherSubjectDelete.TabIndex = 10;
            this.btnTeacherSubjectDelete.Text = "Hapus";
            this.btnTeacherSubjectDelete.UseVisualStyleBackColor = true;
            this.btnTeacherSubjectDelete.Click += new System.EventHandler(this.btnTeacherSubjectDelete_Click);
            // 
            // btnTeacherSubjectClear
            // 
            this.btnTeacherSubjectClear.Location = new System.Drawing.Point(291, 244);
            this.btnTeacherSubjectClear.Name = "btnTeacherSubjectClear";
            this.btnTeacherSubjectClear.Size = new System.Drawing.Size(85, 32);
            this.btnTeacherSubjectClear.TabIndex = 11;
            this.btnTeacherSubjectClear.Text = "Bersihkan";
            this.btnTeacherSubjectClear.UseVisualStyleBackColor = true;
            this.btnTeacherSubjectClear.Click += new System.EventHandler(this.btnTeacherSubjectClear_Click);
            // 
            // tabAuditLogs
            // 
            this.tabAuditLogs.Controls.Add(this.lblAuditFrom);
            this.tabAuditLogs.Controls.Add(this.dtpAuditFrom);
            this.tabAuditLogs.Controls.Add(this.lblAuditTo);
            this.tabAuditLogs.Controls.Add(this.dtpAuditTo);
            this.tabAuditLogs.Controls.Add(this.txtAuditSearch);
            this.tabAuditLogs.Controls.Add(this.btnAuditFilter);
            this.tabAuditLogs.Controls.Add(this.btnAuditRefresh);
            this.tabAuditLogs.Controls.Add(this.btnAuditExport);
            this.tabAuditLogs.Controls.Add(this.dgvAuditLog);
            this.tabAuditLogs.Location = new System.Drawing.Point(4, 29);
            this.tabAuditLogs.Name = "tabAuditLogs";
            this.tabAuditLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuditLogs.Size = new System.Drawing.Size(1142, 627);
            this.tabAuditLogs.TabIndex = 7;
            this.tabAuditLogs.Text = "Audit Log";
            this.tabAuditLogs.UseVisualStyleBackColor = true;
            // 
            // lblAuditFrom
            // 
            this.lblAuditFrom.AutoSize = true;
            this.lblAuditFrom.Location = new System.Drawing.Point(15, 19);
            this.lblAuditFrom.Name = "lblAuditFrom";
            this.lblAuditFrom.Size = new System.Drawing.Size(37, 20);
            this.lblAuditFrom.TabIndex = 0;
            this.lblAuditFrom.Text = "Dari";
            // 
            // dtpAuditFrom
            // 
            this.dtpAuditFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAuditFrom.Location = new System.Drawing.Point(55, 15);
            this.dtpAuditFrom.Name = "dtpAuditFrom";
            this.dtpAuditFrom.Size = new System.Drawing.Size(120, 27);
            this.dtpAuditFrom.TabIndex = 1;
            // 
            // lblAuditTo
            // 
            this.lblAuditTo.AutoSize = true;
            this.lblAuditTo.Location = new System.Drawing.Point(190, 19);
            this.lblAuditTo.Name = "lblAuditTo";
            this.lblAuditTo.Size = new System.Drawing.Size(59, 20);
            this.lblAuditTo.TabIndex = 2;
            this.lblAuditTo.Text = "Sampai";
            // 
            // dtpAuditTo
            // 
            this.dtpAuditTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAuditTo.Location = new System.Drawing.Point(240, 15);
            this.dtpAuditTo.Name = "dtpAuditTo";
            this.dtpAuditTo.Size = new System.Drawing.Size(120, 27);
            this.dtpAuditTo.TabIndex = 3;
            // 
            // txtAuditSearch
            // 
            this.txtAuditSearch.Location = new System.Drawing.Point(375, 15);
            this.txtAuditSearch.Name = "txtAuditSearch";
            this.txtAuditSearch.Size = new System.Drawing.Size(220, 27);
            this.txtAuditSearch.TabIndex = 4;
            // 
            // btnAuditFilter
            // 
            this.btnAuditFilter.Location = new System.Drawing.Point(605, 13);
            this.btnAuditFilter.Name = "btnAuditFilter";
            this.btnAuditFilter.Size = new System.Drawing.Size(90, 27);
            this.btnAuditFilter.TabIndex = 5;
            this.btnAuditFilter.Text = "Filter";
            this.btnAuditFilter.UseVisualStyleBackColor = true;
            this.btnAuditFilter.Click += new System.EventHandler(this.btnAuditFilter_Click);
            // 
            // btnAuditRefresh
            // 
            this.btnAuditRefresh.Location = new System.Drawing.Point(700, 13);
            this.btnAuditRefresh.Name = "btnAuditRefresh";
            this.btnAuditRefresh.Size = new System.Drawing.Size(90, 27);
            this.btnAuditRefresh.TabIndex = 6;
            this.btnAuditRefresh.Text = "Muat Ulang";
            this.btnAuditRefresh.UseVisualStyleBackColor = true;
            this.btnAuditRefresh.Click += new System.EventHandler(this.btnAuditRefresh_Click);
            // 
            // btnAuditExport
            // 
            this.btnAuditExport.Location = new System.Drawing.Point(795, 13);
            this.btnAuditExport.Name = "btnAuditExport";
            this.btnAuditExport.Size = new System.Drawing.Size(110, 27);
            this.btnAuditExport.TabIndex = 7;
            this.btnAuditExport.Text = "Ekspor CSV";
            this.btnAuditExport.UseVisualStyleBackColor = true;
            this.btnAuditExport.Click += new System.EventHandler(this.btnAuditExport_Click);
            // 
            // dgvAuditLog
            // 
            this.dgvAuditLog.AllowUserToAddRows = false;
            this.dgvAuditLog.AllowUserToDeleteRows = false;
            this.dgvAuditLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAuditLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuditLog.ColumnHeadersHeight = 29;
            this.dgvAuditLog.Location = new System.Drawing.Point(15, 50);
            this.dgvAuditLog.MultiSelect = false;
            this.dgvAuditLog.Name = "dgvAuditLog";
            this.dgvAuditLog.ReadOnly = true;
            this.dgvAuditLog.RowHeadersVisible = false;
            this.dgvAuditLog.RowHeadersWidth = 51;
            this.dgvAuditLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditLog.Size = new System.Drawing.Size(1110, 560);
            this.dgvAuditLog.TabIndex = 8;
            this.dgvAuditLog.SelectionChanged += new System.EventHandler(this.dgvAuditLog_SelectionChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 720);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIAKADA - Panel Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.gbUserInput.ResumeLayout(false);
            this.gbUserInput.PerformLayout();
            this.tabClasses.ResumeLayout(false);
            this.tabClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.gbClassInput.ResumeLayout(false);
            this.gbClassInput.PerformLayout();
            this.tabSubjects.ResumeLayout(false);
            this.tabSubjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.gbSubjectInput.ResumeLayout(false);
            this.gbSubjectInput.PerformLayout();
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.gbStudentInput.ResumeLayout(false);
            this.gbStudentInput.PerformLayout();
            this.tabTeachers.ResumeLayout(false);
            this.tabTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.gbTeacherInput.ResumeLayout(false);
            this.gbTeacherInput.PerformLayout();
            this.tabAcademic.ResumeLayout(false);
            this.tabAcademic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemester)).EndInit();
            this.tabTeacherSubjects.ResumeLayout(false);
            this.tabTeacherSubjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSubject)).EndInit();
            this.gbTeacherSubjectInput.ResumeLayout(false);
            this.gbTeacherSubjectInput.PerformLayout();
            this.tabAuditLogs.ResumeLayout(false);
            this.tabAuditLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.TabPage tabSubjects;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabTeachers;
        private System.Windows.Forms.TabPage tabAcademic;
        private System.Windows.Forms.TabPage tabTeacherSubjects;
        private System.Windows.Forms.TabPage tabAuditLogs;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnRefreshUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.GroupBox gbUserInput;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.CheckBox chkUserActive;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserClear;
        private System.Windows.Forms.TextBox txtSearchClass;
        private System.Windows.Forms.Button btnSearchClass;
        private System.Windows.Forms.Button btnRefreshClass;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.GroupBox gbClassInput;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.ComboBox cmbGradeLevel;
        private System.Windows.Forms.Button btnClassAdd;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.Button btnClassDelete;
        private System.Windows.Forms.Button btnClassClear;
        private System.Windows.Forms.TextBox txtSearchSubject;
        private System.Windows.Forms.Button btnSearchSubject;
        private System.Windows.Forms.Button btnRefreshSubject;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.GroupBox gbSubjectInput;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblSubjectDescription;
        private System.Windows.Forms.TextBox txtSubjectDescription;
        private System.Windows.Forms.Button btnSubjectAdd;
        private System.Windows.Forms.Button btnSubjectUpdate;
        private System.Windows.Forms.Button btnSubjectDelete;
        private System.Windows.Forms.Button btnSubjectClear;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnRefreshStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.GroupBox gbStudentInput;
        private System.Windows.Forms.Label lblStudentUser;
        private System.Windows.Forms.ComboBox cmbStudentUser;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblStudentClass;
        private System.Windows.Forms.ComboBox cmbStudentClass;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblParentPhone;
        private System.Windows.Forms.TextBox txtParentPhone;
        private System.Windows.Forms.Label lblStudentAddress;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Button btnStudentUpdate;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentClear;
        private System.Windows.Forms.TextBox txtSearchTeacher;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.Button btnRefreshTeacher;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.GroupBox gbTeacherInput;
        private System.Windows.Forms.Label lblTeacherUser;
        private System.Windows.Forms.ComboBox cmbTeacherUser;
        private System.Windows.Forms.Label lblTeacherNumber;
        private System.Windows.Forms.TextBox txtTeacherNumber;
        private System.Windows.Forms.Label lblTeacherPhone;
        private System.Windows.Forms.TextBox txtTeacherPhone;
        private System.Windows.Forms.Label lblTeacherAddress;
        private System.Windows.Forms.TextBox txtTeacherAddress;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.Button btnTeacherUpdate;
        private System.Windows.Forms.Button btnTeacherDelete;
        private System.Windows.Forms.Button btnTeacherClear;
        private System.Windows.Forms.TextBox txtSearchTeacherSubject;
        private System.Windows.Forms.Button btnSearchTeacherSubject;
        private System.Windows.Forms.Button btnRefreshTeacherSubject;
        private System.Windows.Forms.DataGridView dgvTeacherSubject;
        private System.Windows.Forms.GroupBox gbTeacherSubjectInput;
        private System.Windows.Forms.Label lblTsTeacher;
        private System.Windows.Forms.ComboBox cmbTsTeacher;
        private System.Windows.Forms.Label lblTsSubject;
        private System.Windows.Forms.ComboBox cmbTsSubject;
        private System.Windows.Forms.Label lblTsClass;
        private System.Windows.Forms.ComboBox cmbTsClass;
        private System.Windows.Forms.Label lblTsSemester;
        private System.Windows.Forms.ComboBox cmbTsSemester;
        private System.Windows.Forms.Button btnTeacherSubjectAdd;
        private System.Windows.Forms.Button btnTeacherSubjectUpdate;
        private System.Windows.Forms.Button btnTeacherSubjectDelete;
        private System.Windows.Forms.Button btnTeacherSubjectClear;
        private System.Windows.Forms.Label lblAcademicYearTitle;
        private System.Windows.Forms.DataGridView dgvAcademicYear;
        private System.Windows.Forms.Label lblYearName;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.CheckBox chkYearActive;
        private System.Windows.Forms.Button btnYearAdd;
        private System.Windows.Forms.Button btnYearUpdate;
        private System.Windows.Forms.Button btnYearDelete;
        private System.Windows.Forms.Button btnYearSetActive;
        private System.Windows.Forms.Label lblSemesterTitle;
        private System.Windows.Forms.DataGridView dgvSemester;
        private System.Windows.Forms.Label lblSemesterYear;
        private System.Windows.Forms.ComboBox cmbSemesterYear;
        private System.Windows.Forms.Label lblSemesterName;
        private System.Windows.Forms.ComboBox cmbSemesterName;
        private System.Windows.Forms.CheckBox chkSemesterActive;
        private System.Windows.Forms.Button btnSemesterAdd;
        private System.Windows.Forms.Button btnSemesterUpdate;
        private System.Windows.Forms.Button btnSemesterDelete;
        private System.Windows.Forms.Button btnSemesterSetActive;
        private System.Windows.Forms.Label lblAuditFrom;
        private System.Windows.Forms.DateTimePicker dtpAuditFrom;
        private System.Windows.Forms.Label lblAuditTo;
        private System.Windows.Forms.DateTimePicker dtpAuditTo;
        private System.Windows.Forms.TextBox txtAuditSearch;
        private System.Windows.Forms.Button btnAuditFilter;
        private System.Windows.Forms.Button btnAuditRefresh;
        private System.Windows.Forms.Button btnAuditExport;
        private System.Windows.Forms.DataGridView dgvAuditLog;
    }
}