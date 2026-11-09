using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthenticationAuthorization.Services;
using MySql.Data.MySqlClient;



namespace Siakada
{
    public partial class AdminForm : Form
    {
		private long selectedUserId = 0;
		private int selectedClassId = 0;
		private int selectedSubjectId = 0;
		private int selectedStudentId = 0;
		private int selectedTeacherId = 0;
		private long selectedTeacherSubjectId = 0;
		private int selectedAcademicYearId = 0;
		private int selectedSemesterId = 0;
		private long loggedInUserId;


		public AdminForm(long userId)
		{
			InitializeComponent();
			loggedInUserId = userId;

			SaveAuditLog(loggedInUserId, "Login", "Admin berhasil masuk ke sistem");
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			cmbRole.Items.Clear();
			cmbRole.Items.AddRange(new string[] { "Admin", "Guru", "Siswa" });

			LoadUsers();
			LoadClasses();
			LoadSubjects();
			LoadStudentCombo();
			LoadStudents();
			LoadTeacherCombo();
			LoadTeachers();
			LoadTeacherSubjectCombo();
			LoadTeacherSubjects();
			LoadAcademicYears();
			LoadSemesterCombo();
			LoadSemesters();
			dtpAuditFrom.Value = DateTime.Today.AddMonths(-1);
			dtpAuditTo.Value = DateTime.Today;
			LoadAuditLogs();
		}

		private void LoadUsers(string keyword = "")
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                SELECT id, username, email, full_name, role, is_active
                FROM users
                WHERE username LIKE @keyword
                   OR email LIKE @keyword
                   OR full_name LIKE @keyword
                ORDER BY id DESC";

					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

						DataTable dt = new DataTable();

						using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
						{
							adapter.Fill(dt);
						}

						dgvUser.DataSource = dt;
						dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
						dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
						dgvUser.MultiSelect = false;
						dgvUser.ReadOnly = true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat data pengguna: " + ex.Message);
			}
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControlMain.SelectedTab == tabTeachers)
			{
				LoadTeacherCombo();
				LoadTeachers();
			}
			else if (tabControlMain.SelectedTab == tabTeacherSubjects)
			{
				LoadTeacherSubjectCombo();
				LoadTeacherSubjects();
			}
			else if (tabControlMain.SelectedTab == tabAcademic)
			{
				LoadAcademicYears();
				LoadSemesterCombo();
				LoadSemesters();
			}
			else if (tabControlMain.SelectedTab == tabAuditLogs)
			{
				LoadAuditLogs();
			}
		}

		private void btnSearchUser_Click(object sender, EventArgs e)
		{
			LoadUsers(txtSearchUser.Text.Trim());
		}

		private void btnRefreshUser_Click(object sender, EventArgs e)
		{
			txtSearchUser.Clear();
			LoadUsers();
		}

		private void dgvUser_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvUser.CurrentRow == null ||
				dgvUser.CurrentRow.Cells["id"].Value == null)
				return;

			selectedUserId = Convert.ToInt64(
				dgvUser.CurrentRow.Cells["id"].Value);

			txtUsername.Text = dgvUser.CurrentRow.Cells["username"].Value.ToString();
			txtEmail.Text = dgvUser.CurrentRow.Cells["email"].Value.ToString();
			txtFullName.Text = dgvUser.CurrentRow.Cells["full_name"].Value.ToString();
			cmbRole.Text = dgvUser.CurrentRow.Cells["role"].Value.ToString();

			chkUserActive.Checked = Convert.ToBoolean(
				dgvUser.CurrentRow.Cells["is_active"].Value);

			txtUserPassword.Clear();
		}

		private string HashPassword(string password)
		{
			using (SHA256 sha = SHA256.Create())
			{
				byte[] bytes = sha.ComputeHash(
					System.Text.Encoding.UTF8.GetBytes(password));

				return BitConverter.ToString(bytes).Replace("-", "").ToLower();
			}
		}

		private void chkUserActive_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

		private void btnUserAdd_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text.Trim() == "" ||
				txtFullName.Text.Trim() == "" ||
				txtUserPassword.Text == "" ||
				cmbRole.SelectedIndex == -1)
			{
				MessageBox.Show("Lengkapi username, nama, password, dan role.");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                INSERT INTO users
                (username, email, password_hash, full_name, role, is_active)
                VALUES
                (@username, @email, @password, @fullname, @role, @active)";

					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
						cmd.Parameters.AddWithValue("@email",
							string.IsNullOrWhiteSpace(txtEmail.Text)
							? (object)DBNull.Value : txtEmail.Text.Trim());
						cmd.Parameters.AddWithValue("@password",
							HashPassword(txtUserPassword.Text));
						cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
						cmd.Parameters.AddWithValue("@role", cmbRole.Text);
						cmd.Parameters.AddWithValue("@active", chkUserActive.Checked);

						cmd.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Pengguna berhasil ditambahkan.");
				LoadUsers();
				ClearUserForm();
				SaveAuditLog(loggedInUserId, "Tambah User", "Menambahkan pengguna: " + txtUsername.Text.Trim());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menambahkan pengguna: " + ex.Message);
			}
		}

		private void btnUserUpdate_Click(object sender, EventArgs e)
		{
			if (selectedUserId == 0)
			{
				MessageBox.Show("Pilih pengguna yang ingin diubah.");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query;

					if (txtUserPassword.Text.Trim() != "")
					{
						query = @"
                    UPDATE users SET
                    username=@username,
                    email=@email,
                    password_hash=@password,
                    full_name=@fullname,
                    role=@role,
                    is_active=@active
                    WHERE id=@id";
					}
					else
					{
						query = @"
                    UPDATE users SET
                    username=@username,
                    email=@email,
                    full_name=@fullname,
                    role=@role,
                    is_active=@active
                    WHERE id=@id";
					}

					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
						cmd.Parameters.AddWithValue("@email",
							string.IsNullOrWhiteSpace(txtEmail.Text)
							? (object)DBNull.Value : txtEmail.Text.Trim());
						cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
						cmd.Parameters.AddWithValue("@role", cmbRole.Text);
						cmd.Parameters.AddWithValue("@active", chkUserActive.Checked);
						cmd.Parameters.AddWithValue("@id", selectedUserId);

						if (txtUserPassword.Text.Trim() != "")
						{
							cmd.Parameters.AddWithValue("@password",
								HashPassword(txtUserPassword.Text));
						}

						cmd.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Data pengguna berhasil diperbarui.");
				LoadUsers();
				ClearUserForm();
				SaveAuditLog(loggedInUserId, "Ubah User", "Memperbarui pengguna ID: " + selectedUserId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memperbarui pengguna: " + ex.Message);
			}
		}

		private void btnUserDelete_Click(object sender, EventArgs e)
		{
			if (selectedUserId == 0)
			{
				MessageBox.Show("Pilih pengguna yang ingin dihapus.");
				return;
			}

			DialogResult result = MessageBox.Show(
				"Apakah Anda yakin ingin menghapus pengguna ini?",
				"Konfirmasi Hapus",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (result != DialogResult.Yes)
				return;

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = "DELETE FROM users WHERE id=@id";

					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@id", selectedUserId);
						cmd.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Pengguna berhasil dihapus.");
				LoadUsers();
				ClearUserForm();
				SaveAuditLog(loggedInUserId, "Hapus User", "Menghapus pengguna ID: " + selectedUserId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menghapus pengguna: " + ex.Message);
			}
		}

		private void btnUserClear_Click(object sender, EventArgs e)
		{
			ClearUserForm();
		}

		private void LoadClasses(string keyword = "")
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                SELECT id, class_name, grade_level
                FROM classes
                WHERE class_name LIKE @keyword
                   OR grade_level LIKE @keyword
                ORDER BY id DESC";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

					DataTable dt = new DataTable();
					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
					adapter.Fill(dt);

					dgvClass.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat data kelas: " + ex.Message);
			}
		}

		private void ClearUserForm()
		{
			selectedUserId = 0;

			txtUsername.Clear();
			txtEmail.Clear();
			txtUserPassword.Clear();
			txtFullName.Clear();

			cmbRole.SelectedIndex = -1;
			chkUserActive.Checked = true;

			dgvUser.ClearSelection();
		}

		private void btnSearchClass_Click(object sender, EventArgs e)
		{
			LoadClasses(txtSearchClass.Text.Trim());
		}

		private void btnRefreshClass_Click(object sender, EventArgs e)
		{
			txtSearchClass.Clear();
			LoadClasses();
		}

		private void dgvClass_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvClass.CurrentRow == null ||
				dgvClass.CurrentRow.Cells["id"].Value == null)
				return;

			selectedClassId = Convert.ToInt32(
				dgvClass.CurrentRow.Cells["id"].Value);

			txtClassName.Text =
				dgvClass.CurrentRow.Cells["class_name"].Value.ToString();

			cmbGradeLevel.Text =
				dgvClass.CurrentRow.Cells["grade_level"].Value.ToString();
		}

		private void btnClassAdd_Click(object sender, EventArgs e)
		{
			if (txtClassName.Text.Trim() == "" ||
				cmbGradeLevel.Text == "")
			{
				MessageBox.Show("Nama kelas dan tingkat harus diisi!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                INSERT INTO classes (class_name, grade_level)
                VALUES (@name, @level)";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@name", txtClassName.Text.Trim());
					cmd.Parameters.AddWithValue("@level", cmbGradeLevel.Text);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data kelas berhasil ditambahkan!");
				LoadClasses();
				ClearClassForm();
				SaveAuditLog(loggedInUserId, "Tambah Kelas", "Menambahkan kelas: " + txtClassName.Text.Trim());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menambahkan kelas: " + ex.Message);
			}
		}

		private void btnClassUpdate_Click(object sender, EventArgs e)
		{
			if (selectedClassId == 0)
			{
				MessageBox.Show("Pilih kelas yang ingin diubah!");
				return;
			}

			if (txtClassName.Text.Trim() == "" ||
				cmbGradeLevel.Text == "")
			{
				MessageBox.Show("Lengkapi data kelas!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                UPDATE classes
                SET class_name = @name,
                    grade_level = @level
                WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@name", txtClassName.Text.Trim());
					cmd.Parameters.AddWithValue("@level", cmbGradeLevel.Text);
					cmd.Parameters.AddWithValue("@id", selectedClassId);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data kelas berhasil diubah!");
				LoadClasses();
				ClearClassForm();
				SaveAuditLog(loggedInUserId, "Ubah Kelas", "Memperbarui kelas ID: " + selectedClassId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal mengubah data kelas: " + ex.Message);
			}
		}

		private void btnClassDelete_Click(object sender, EventArgs e)
		{
			if (selectedClassId == 0)
			{
				MessageBox.Show("Pilih kelas yang ingin dihapus!");
				return;
			}

			DialogResult hasil = MessageBox.Show(
				"Yakin ingin menghapus kelas ini?",
				"Konfirmasi",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (hasil == DialogResult.No)
				return;

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = "DELETE FROM classes WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", selectedClassId);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data kelas berhasil dihapus!");
				LoadClasses();
				ClearClassForm();
				SaveAuditLog(loggedInUserId, "Hapus Kelas", "Menghapus kelas ID: " + selectedClassId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menghapus kelas: " + ex.Message);
			}
		}

		private void btnClassClear_Click(object sender, EventArgs e)
		{
			ClearClassForm();
		}

		private void ClearClassForm()
		{
			selectedClassId = 0;
			txtClassName.Clear();
			cmbGradeLevel.SelectedIndex = -1;
			dgvClass.ClearSelection();
		}

		private void LoadSubjects(string keyword = "")
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                SELECT id, subject_code, subject_name, description
                FROM subjects
                WHERE subject_code LIKE @keyword
                   OR subject_name LIKE @keyword
                ORDER BY id DESC";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

					DataTable dt = new DataTable();
					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
					adapter.Fill(dt);

					dgvSubject.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat mata pelajaran: " + ex.Message);
			}
		}

		private void btnSearchSubject_Click(object sender, EventArgs e)
		{
			LoadSubjects(txtSearchSubject.Text.Trim());
		}

		private void btnRefreshSubject_Click(object sender, EventArgs e)
		{
			txtSearchSubject.Clear();
			LoadSubjects();
		}

		private void dgvSubject_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvSubject.CurrentRow == null ||
				dgvSubject.CurrentRow.Cells["id"].Value == null)
				return;

			selectedSubjectId = Convert.ToInt32(
				dgvSubject.CurrentRow.Cells["id"].Value);

			txtSubjectCode.Text =
				dgvSubject.CurrentRow.Cells["subject_code"].Value.ToString();

			txtSubjectName.Text =
				dgvSubject.CurrentRow.Cells["subject_name"].Value.ToString();

			txtSubjectDescription.Text =
				dgvSubject.CurrentRow.Cells["description"].Value == DBNull.Value
				? ""
				: dgvSubject.CurrentRow.Cells["description"].Value.ToString();
		}

		private void btnSubjectAdd_Click(object sender, EventArgs e)
		{
			if (txtSubjectCode.Text.Trim() == "" ||
				txtSubjectName.Text.Trim() == "")
			{
				MessageBox.Show("Kode dan nama mata pelajaran harus diisi!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                INSERT INTO subjects
                (subject_code, subject_name, description)
                VALUES (@code, @name, @description)";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@code", txtSubjectCode.Text.Trim());
					cmd.Parameters.AddWithValue("@name", txtSubjectName.Text.Trim());
					cmd.Parameters.AddWithValue("@description",
						string.IsNullOrWhiteSpace(txtSubjectDescription.Text)
						? (object)DBNull.Value : txtSubjectDescription.Text.Trim());

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Mata pelajaran berhasil ditambahkan!");
				LoadSubjects();
				ClearSubjectForm();
				SaveAuditLog(loggedInUserId, "Tambah Mapel", "Menambahkan mata pelajaran: " + txtSubjectCode.Text.Trim() + " - " + txtSubjectName.Text.Trim());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menambahkan data: " + ex.Message);
			}
		}

		private void btnSubjectUpdate_Click(object sender, EventArgs e)
		{
			if (selectedSubjectId == 0)
			{
				MessageBox.Show("Pilih mata pelajaran terlebih dahulu!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                UPDATE subjects SET
                subject_code = @code,
                subject_name = @name,
                description = @description
                WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@code", txtSubjectCode.Text.Trim());
					cmd.Parameters.AddWithValue("@name", txtSubjectName.Text.Trim());
					cmd.Parameters.AddWithValue("@description",
						string.IsNullOrWhiteSpace(txtSubjectDescription.Text)
						? (object)DBNull.Value : txtSubjectDescription.Text.Trim());
					cmd.Parameters.AddWithValue("@id", selectedSubjectId);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data berhasil diubah!");
				LoadSubjects();
				ClearSubjectForm();
				SaveAuditLog(loggedInUserId, "Ubah Mapel", "Memperbarui mata pelajaran ID: " + selectedSubjectId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal mengubah data: " + ex.Message);
			}
		}

		private void btnSubjectDelete_Click(object sender, EventArgs e)
		{
			if (selectedSubjectId == 0)
			{
				MessageBox.Show("Pilih mata pelajaran yang ingin dihapus!");
				return;
			}

			DialogResult hasil = MessageBox.Show(
				"Yakin ingin menghapus mata pelajaran ini?",
				"Konfirmasi",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (hasil == DialogResult.No)
				return;

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = "DELETE FROM subjects WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", selectedSubjectId);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Mata pelajaran berhasil dihapus!");
				LoadSubjects();
				ClearSubjectForm();
				SaveAuditLog(loggedInUserId, "Hapus Mapel", "Menghapus mata pelajaran ID: " + selectedSubjectId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menghapus data: " + ex.Message);
			}
		}

		private void btnSubjectClear_Click(object sender, EventArgs e)
		{
			ClearSubjectForm();
		}

		private void ClearSubjectForm()
		{
			selectedSubjectId = 0;

			txtSubjectCode.Clear();
			txtSubjectName.Clear();
			txtSubjectDescription.Clear();

			dgvSubject.ClearSelection();
		}

		private void LoadStudentCombo()
		{
			using (MySqlConnection conn = DatabaseService.GetConnection())
			{
				conn.Open();

				string queryUser = @"
            SELECT id, full_name
            FROM users
            WHERE role = 'Siswa'
            ORDER BY full_name";

				DataTable dtUser = new DataTable();
				MySqlDataAdapter adUser = new MySqlDataAdapter(queryUser, conn);
				adUser.Fill(dtUser);

				cmbStudentUser.DataSource = dtUser;
				cmbStudentUser.DisplayMember = "full_name";
				cmbStudentUser.ValueMember = "id";
				cmbStudentUser.SelectedIndex = -1;

				string queryClass = "SELECT id, class_name FROM classes ORDER BY class_name";

				DataTable dtClass = new DataTable();
				MySqlDataAdapter adClass = new MySqlDataAdapter(queryClass, conn);
				adClass.Fill(dtClass);

				cmbStudentClass.DataSource = dtClass;
				cmbStudentClass.DisplayMember = "class_name";
				cmbStudentClass.ValueMember = "id";
				cmbStudentClass.SelectedIndex = -1;
			}
		}

		private void LoadStudents(string keyword = "")
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                SELECT s.id, u.full_name, s.student_number,
                       c.class_name, s.birth_date, s.gender,
                       s.parent_name, s.parent_phone, s.address
                FROM students s
                JOIN users u ON s.user_id = u.id
                JOIN classes c ON s.class_id = c.id
                WHERE u.full_name LIKE @keyword
                   OR s.student_number LIKE @keyword
                   OR c.class_name LIKE @keyword
                ORDER BY s.id DESC";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

					DataTable dt = new DataTable();
					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
					adapter.Fill(dt);

					dgvStudent.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat data siswa: " + ex.Message);
			}
		}

		private void btnSearchStudent_Click(object sender, EventArgs e)
		{
			LoadStudents(txtSearchStudent.Text.Trim());
		}

		private void btnRefreshStudent_Click(object sender, EventArgs e)
		{
			txtSearchStudent.Clear();
			LoadStudents();
		}

		private void dgvStudent_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvStudent.CurrentRow == null ||
				dgvStudent.CurrentRow.Cells["id"].Value == null)
				return;

			selectedStudentId = Convert.ToInt32(
				dgvStudent.CurrentRow.Cells["id"].Value);

			txtStudentNumber.Text =
				dgvStudent.CurrentRow.Cells["student_number"].Value.ToString();

			cmbStudentUser.Text =
				dgvStudent.CurrentRow.Cells["full_name"].Value.ToString();

			cmbStudentClass.Text =
				dgvStudent.CurrentRow.Cells["class_name"].Value.ToString();

			dtpBirthDate.Value = Convert.ToDateTime(
				dgvStudent.CurrentRow.Cells["birth_date"].Value);

			cmbGender.Text =
				dgvStudent.CurrentRow.Cells["gender"].Value.ToString();

			txtParentName.Text =
				dgvStudent.CurrentRow.Cells["parent_name"].Value.ToString();

			txtParentPhone.Text =
				dgvStudent.CurrentRow.Cells["parent_phone"].Value.ToString();

			txtStudentAddress.Text =
				dgvStudent.CurrentRow.Cells["address"].Value.ToString();
		}

		private void btnStudentAdd_Click(object sender, EventArgs e)
		{
			if (txtStudentNumber.Text.Trim() == "" ||
				cmbStudentUser.SelectedIndex == -1 ||
				cmbStudentClass.SelectedIndex == -1)
			{
				MessageBox.Show("Lengkapi data siswa terlebih dahulu!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                INSERT INTO students
                (user_id, student_number, class_id, birth_date,
                 gender, parent_name, parent_phone, address)
                VALUES
                (@user, @number, @class, @birth, @gender,
                 @parent, @phone, @address)";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@user", cmbStudentUser.SelectedValue);
					cmd.Parameters.AddWithValue("@number", txtStudentNumber.Text.Trim());
					cmd.Parameters.AddWithValue("@class", cmbStudentClass.SelectedValue);
					cmd.Parameters.AddWithValue("@birth", dtpBirthDate.Value.Date);
					cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
					cmd.Parameters.AddWithValue("@parent", txtParentName.Text.Trim());
					cmd.Parameters.AddWithValue("@phone", txtParentPhone.Text.Trim());
					cmd.Parameters.AddWithValue("@address", txtStudentAddress.Text.Trim());

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data siswa berhasil ditambahkan!");
				LoadStudents();
				ClearStudentForm();
				SaveAuditLog(loggedInUserId, "Tambah Siswa", "Menambahkan siswa: " + txtStudentNumber.Text.Trim());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menambahkan siswa: " + ex.Message);
			}
		}

		private void btnStudentUpdate_Click(object sender, EventArgs e)
		{
			if (selectedStudentId == 0)
			{
				MessageBox.Show("Pilih siswa yang ingin diubah!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                UPDATE students SET
                user_id=@user,
                student_number=@number,
                class_id=@class,
                birth_date=@birth,
                gender=@gender,
                parent_name=@parent,
                parent_phone=@phone,
                address=@address
                WHERE id=@id";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@user", cmbStudentUser.SelectedValue);
					cmd.Parameters.AddWithValue("@number", txtStudentNumber.Text.Trim());
					cmd.Parameters.AddWithValue("@class", cmbStudentClass.SelectedValue);
					cmd.Parameters.AddWithValue("@birth", dtpBirthDate.Value.Date);
					cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
					cmd.Parameters.AddWithValue("@parent", txtParentName.Text.Trim());
					cmd.Parameters.AddWithValue("@phone", txtParentPhone.Text.Trim());
					cmd.Parameters.AddWithValue("@address", txtStudentAddress.Text.Trim());
					cmd.Parameters.AddWithValue("@id", selectedStudentId);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data siswa berhasil diubah!");
				LoadStudents();
				ClearStudentForm();
				SaveAuditLog(loggedInUserId, "Ubah Siswa", "Memperbarui siswa ID: " + selectedStudentId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal mengubah data: " + ex.Message);
			}
		}

		private void btnStudentDelete_Click(object sender, EventArgs e)
		{
			if (selectedStudentId == 0)
			{
				MessageBox.Show("Pilih siswa yang ingin dihapus!");
				return;
			}

			DialogResult hasil = MessageBox.Show(
				"Yakin ingin menghapus data siswa ini?",
				"Konfirmasi",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (hasil == DialogResult.No)
				return;

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = "DELETE FROM students WHERE id=@id";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", selectedStudentId);
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data siswa berhasil dihapus!");
				LoadStudents();
				ClearStudentForm();
				SaveAuditLog(loggedInUserId, "Hapus Siswa", "Menghapus siswa ID: " + selectedStudentId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menghapus siswa: " + ex.Message);
			}
		}

		private void btnStudentClear_Click(object sender, EventArgs e)
		{
			ClearStudentForm();
		}

		private void ClearStudentForm()
		{
			selectedStudentId = 0;

			txtStudentNumber.Clear();
			cmbStudentUser.SelectedIndex = -1;
			cmbStudentClass.SelectedIndex = -1;
			dtpBirthDate.Value = DateTime.Today;
			cmbGender.SelectedIndex = -1;
			txtParentName.Clear();
			txtParentPhone.Clear();
			txtStudentAddress.Clear();

			dgvStudent.ClearSelection();
		}

		private void LoadTeacherCombo()
		{
			using (MySqlConnection conn = DatabaseService.GetConnection())
			{
				conn.Open();

				string query = "SELECT id, full_name FROM users " +
							   "WHERE TRIM(role) = 'Guru' " +
							   "ORDER BY full_name";

				MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);

				cmbTeacherUser.DataSource = null;
				cmbTeacherUser.Items.Clear();

				cmbTeacherUser.DataSource = dt;
				cmbTeacherUser.DisplayMember = "full_name";
				cmbTeacherUser.ValueMember = "id";
				cmbTeacherUser.SelectedIndex = -1;

			}
		}

		private void LoadTeachers(string keyword = "")
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                SELECT t.id, t.user_id, u.full_name,
                       t.teacher_number, t.phone, t.address
                FROM teachers t
                JOIN users u ON t.user_id = u.id
                WHERE u.full_name LIKE @keyword
                   OR t.teacher_number LIKE @keyword
                ORDER BY t.id DESC";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

					DataTable dt = new DataTable();

					MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
					adapter.Fill(dt);

					dgvTeacher.DataSource = dt;

					dgvTeacher.Columns["id"].Visible = false;
					dgvTeacher.Columns["user_id"].Visible = false;

					dgvTeacher.Columns["full_name"].HeaderText = "Nama Guru";
					dgvTeacher.Columns["teacher_number"].HeaderText = "Nomor Guru";
					dgvTeacher.Columns["phone"].HeaderText = "Telepon";
					dgvTeacher.Columns["address"].HeaderText = "Alamat";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat data guru: " + ex.Message);
			}
		}

		// Membersihkan form guru
		private void ClearTeacherForm()
		{
			selectedTeacherId = 0;

			cmbTeacherUser.SelectedIndex = -1;
			txtTeacherNumber.Clear();
			txtTeacherPhone.Clear();
			txtTeacherAddress.Clear();

			dgvTeacher.ClearSelection();
		}

		private void btnSearchTeacher_Click(object sender, EventArgs e)
		{
			LoadTeachers(txtSearchTeacher.Text.Trim());
		}

		private void btnRefreshTeacher_Click(object sender, EventArgs e)
		{
			LoadTeacherCombo();
			LoadTeachers();
			ClearTeacherForm();
		}

		private void dgvTeacher_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvTeacher.CurrentRow == null ||
				dgvTeacher.CurrentRow.Cells["id"].Value == null)
				return;

			selectedTeacherId = Convert.ToInt32(
				dgvTeacher.CurrentRow.Cells["id"].Value);

			cmbTeacherUser.SelectedValue =
				dgvTeacher.CurrentRow.Cells["user_id"].Value;

			txtTeacherNumber.Text =
				Convert.ToString(dgvTeacher.CurrentRow.Cells["teacher_number"].Value);

			txtTeacherPhone.Text =
				Convert.ToString(dgvTeacher.CurrentRow.Cells["phone"].Value);

			txtTeacherAddress.Text =
				Convert.ToString(dgvTeacher.CurrentRow.Cells["address"].Value);
		}

		private void btnTeacherAdd_Click(object sender, EventArgs e)
		{
			if (cmbTeacherUser.SelectedIndex == -1 ||
				txtTeacherNumber.Text.Trim() == "")
			{
				MessageBox.Show("Pilih akun guru dan isi nomor guru!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                INSERT INTO teachers
                (user_id, teacher_number, phone, address)
                VALUES
                (@user, @number, @phone, @address)";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@user", cmbTeacherUser.SelectedValue);
					cmd.Parameters.AddWithValue("@number", txtTeacherNumber.Text.Trim());
					cmd.Parameters.AddWithValue("@phone",
						string.IsNullOrWhiteSpace(txtTeacherPhone.Text)
						? (object)DBNull.Value : txtTeacherPhone.Text.Trim());
					cmd.Parameters.AddWithValue("@address",
						string.IsNullOrWhiteSpace(txtTeacherAddress.Text)
						? (object)DBNull.Value : txtTeacherAddress.Text.Trim());

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data guru berhasil ditambahkan!");

				LoadTeachers();
				ClearTeacherForm();
				SaveAuditLog(loggedInUserId, "Hapus User", "Menghapus pengguna ID: " + selectedUserId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menambahkan data guru: " + ex.Message);
			}
		}

		private void btnTeacherUpdate_Click(object sender, EventArgs e)
		{
			if (selectedTeacherId == 0)
			{
				MessageBox.Show("Pilih data guru yang ingin diubah!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                UPDATE teachers SET
                    user_id = @user,
                    teacher_number = @number,
                    phone = @phone,
                    address = @address
                WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@user", cmbTeacherUser.SelectedValue);
					cmd.Parameters.AddWithValue("@number", txtTeacherNumber.Text.Trim());
					cmd.Parameters.AddWithValue("@phone",
						string.IsNullOrWhiteSpace(txtTeacherPhone.Text)
						? (object)DBNull.Value : txtTeacherPhone.Text.Trim());
					cmd.Parameters.AddWithValue("@address",
						string.IsNullOrWhiteSpace(txtTeacherAddress.Text)
						? (object)DBNull.Value : txtTeacherAddress.Text.Trim());
					cmd.Parameters.AddWithValue("@id", selectedTeacherId);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data guru berhasil diperbarui!");

				LoadTeachers();
				ClearTeacherForm();
				SaveAuditLog(loggedInUserId, "Ubah Guru", "Memperbarui guru ID: " + selectedTeacherId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal mengubah data guru: " + ex.Message);
			}
		}

		private void btnTeacherDelete_Click(object sender, EventArgs e)
		{
			if (selectedTeacherId == 0)
			{
				MessageBox.Show("Pilih data guru yang ingin dihapus!");
				return;
			}

			DialogResult hasil = MessageBox.Show(
				"Yakin ingin menghapus data guru ini?",
				"Konfirmasi Hapus",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (hasil != DialogResult.Yes)
				return;

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = "DELETE FROM teachers WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", selectedTeacherId);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data guru berhasil dihapus!");

				LoadTeachers();
				ClearTeacherForm();
				SaveAuditLog(loggedInUserId, "Hapus Guru", "Menghapus guru ID: " + selectedTeacherId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menghapus data guru: " + ex.Message);
			}
		}

		private void btnTeacherClear_Click(object sender, EventArgs e)
		{
			ClearTeacherForm();
		}

		private void LoadTeacherSubjectCombo()
		{
			using (MySqlConnection conn = DatabaseService.GetConnection())
			{
				conn.Open();

				// Combo Guru
				string queryGuru = @"
            SELECT t.id, u.full_name
            FROM teachers t
            JOIN users u ON t.user_id = u.id
            ORDER BY u.full_name";

				DataTable dtGuru = new DataTable();
				new MySqlDataAdapter(queryGuru, conn).Fill(dtGuru);

				cmbTsTeacher.DataSource = dtGuru;
				cmbTsTeacher.DisplayMember = "full_name";
				cmbTsTeacher.ValueMember = "id";
				cmbTsTeacher.SelectedIndex = -1;

				// Combo Mata Pelajaran
				string queryMapel = "SELECT id, subject_name FROM subjects ORDER BY subject_name";

				DataTable dtMapel = new DataTable();
				new MySqlDataAdapter(queryMapel, conn).Fill(dtMapel);

				cmbTsSubject.DataSource = dtMapel;
				cmbTsSubject.DisplayMember = "subject_name";
				cmbTsSubject.ValueMember = "id";
				cmbTsSubject.SelectedIndex = -1;

				// Combo Kelas
				string queryKelas = "SELECT id, class_name FROM classes ORDER BY class_name";

				DataTable dtKelas = new DataTable();
				new MySqlDataAdapter(queryKelas, conn).Fill(dtKelas);

				cmbTsClass.DataSource = dtKelas;
				cmbTsClass.DisplayMember = "class_name";
				cmbTsClass.ValueMember = "id";
				cmbTsClass.SelectedIndex = -1;

				// Combo Semester
				string querySemester = @"
            SELECT s.id,
                   CONCAT(s.semester_name, ' - ', a.year_name) AS semester
            FROM semesters s
            JOIN academic_years a ON s.academic_year_id = a.id
            ORDER BY a.year_name DESC, s.semester_name";

				DataTable dtSemester = new DataTable();
				new MySqlDataAdapter(querySemester, conn).Fill(dtSemester);

				cmbTsSemester.DataSource = dtSemester;
				cmbTsSemester.DisplayMember = "semester";
				cmbTsSemester.ValueMember = "id";
				cmbTsSemester.SelectedIndex = -1;
			}
		}

		private void LoadTeacherSubjects(string keyword = "")
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                SELECT 
                    ts.id,
                    ts.teacher_id,
                    ts.subject_id,
                    ts.class_id,
                    ts.semester_id,
                    u.full_name AS nama_guru,
                    s.subject_name AS mata_pelajaran,
                    c.class_name AS kelas,
                    CONCAT(sm.semester_name, ' - ', ay.year_name) AS semester
                FROM teacher_subjects ts
                JOIN teachers t ON ts.teacher_id = t.id
                JOIN users u ON t.user_id = u.id
                JOIN subjects s ON ts.subject_id = s.id
                JOIN classes c ON ts.class_id = c.id
                JOIN semesters sm ON ts.semester_id = sm.id
                JOIN academic_years ay ON sm.academic_year_id = ay.id
                WHERE u.full_name LIKE @keyword
                   OR s.subject_name LIKE @keyword
                   OR c.class_name LIKE @keyword
                ORDER BY ts.id DESC";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

					DataTable dt = new DataTable();
					new MySqlDataAdapter(cmd).Fill(dt);

					dgvTeacherSubject.DataSource = dt;

					dgvTeacherSubject.Columns["id"].Visible = false;
					dgvTeacherSubject.Columns["teacher_id"].Visible = false;
					dgvTeacherSubject.Columns["subject_id"].Visible = false;
					dgvTeacherSubject.Columns["class_id"].Visible = false;
					dgvTeacherSubject.Columns["semester_id"].Visible = false;

					dgvTeacherSubject.Columns["nama_guru"].HeaderText = "Nama Guru";
					dgvTeacherSubject.Columns["mata_pelajaran"].HeaderText = "Mata Pelajaran";
					dgvTeacherSubject.Columns["kelas"].HeaderText = "Kelas";
					dgvTeacherSubject.Columns["semester"].HeaderText = "Semester";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat data Guru Mengajar: " + ex.Message);
			}
		}

		private void ClearTeacherSubjectForm()
		{
			selectedTeacherSubjectId = 0;

			cmbTsTeacher.SelectedIndex = -1;
			cmbTsSubject.SelectedIndex = -1;
			cmbTsClass.SelectedIndex = -1;
			cmbTsSemester.SelectedIndex = -1;

			dgvTeacherSubject.ClearSelection();
		}

		private void btnSearchTeacherSubject_Click(object sender, EventArgs e)
		{
			LoadTeacherSubjects(txtSearchTeacherSubject.Text.Trim());
		}

		private void btnRefreshTeacherSubject_Click(object sender, EventArgs e)
		{
			txtSearchTeacherSubject.Clear();
			LoadTeacherSubjectCombo();
			LoadTeacherSubjects();
			ClearTeacherSubjectForm();
		}

		private void dgvTeacherSubject_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvTeacherSubject.CurrentRow == null ||
				dgvTeacherSubject.CurrentRow.Cells["id"].Value == null)
				return;

			selectedTeacherSubjectId = Convert.ToInt64(
				dgvTeacherSubject.CurrentRow.Cells["id"].Value);

			cmbTsTeacher.SelectedValue =
				dgvTeacherSubject.CurrentRow.Cells["teacher_id"].Value;

			cmbTsSubject.SelectedValue =
				dgvTeacherSubject.CurrentRow.Cells["subject_id"].Value;

			cmbTsClass.SelectedValue =
				dgvTeacherSubject.CurrentRow.Cells["class_id"].Value;

			cmbTsSemester.SelectedValue =
				dgvTeacherSubject.CurrentRow.Cells["semester_id"].Value;
		}

		private void btnTeacherSubjectAdd_Click(object sender, EventArgs e)
		{
			if (cmbTsTeacher.SelectedIndex == -1 ||
				cmbTsSubject.SelectedIndex == -1 ||
				cmbTsClass.SelectedIndex == -1 ||
				cmbTsSemester.SelectedIndex == -1)
			{
				MessageBox.Show("Lengkapi semua data terlebih dahulu!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                INSERT INTO teacher_subjects
                (teacher_id, subject_id, class_id, semester_id)
                VALUES
                (@teacher, @subject, @class, @semester)";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@teacher", cmbTsTeacher.SelectedValue);
					cmd.Parameters.AddWithValue("@subject", cmbTsSubject.SelectedValue);
					cmd.Parameters.AddWithValue("@class", cmbTsClass.SelectedValue);
					cmd.Parameters.AddWithValue("@semester", cmbTsSemester.SelectedValue);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data Guru Mengajar berhasil ditambahkan!");

				LoadTeacherSubjects();
				ClearTeacherSubjectForm();
				SaveAuditLog(loggedInUserId, "Tambah Guru Mengajar", "Menambahkan penugasan guru mengajar.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menambahkan data: " + ex.Message);
			}
		}

		private void btnTeacherSubjectUpdate_Click(object sender, EventArgs e)
		{
			if (selectedTeacherSubjectId == 0)
			{
				MessageBox.Show("Pilih data yang ingin diubah!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                UPDATE teacher_subjects SET
                teacher_id = @teacher,
                subject_id = @subject,
                class_id = @class,
                semester_id = @semester
                WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@teacher", cmbTsTeacher.SelectedValue);
					cmd.Parameters.AddWithValue("@subject", cmbTsSubject.SelectedValue);
					cmd.Parameters.AddWithValue("@class", cmbTsClass.SelectedValue);
					cmd.Parameters.AddWithValue("@semester", cmbTsSemester.SelectedValue);
					cmd.Parameters.AddWithValue("@id", selectedTeacherSubjectId);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data Guru Mengajar berhasil diubah!");

				LoadTeacherSubjects();
				ClearTeacherSubjectForm();
				SaveAuditLog(loggedInUserId, "Ubah Guru Mengajar", "Memperbarui penugasan ID: " + selectedTeacherSubjectId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal mengubah data: " + ex.Message);
			}
		}

		private void btnTeacherSubjectDelete_Click(object sender, EventArgs e)
		{
			if (selectedTeacherSubjectId == 0)
			{
				MessageBox.Show("Pilih data yang ingin dihapus!");
				return;
			}

			DialogResult hasil = MessageBox.Show(
				"Yakin ingin menghapus data ini?",
				"Konfirmasi",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (hasil == DialogResult.No)
				return;

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = "DELETE FROM teacher_subjects WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", selectedTeacherSubjectId);

					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Data Guru Mengajar berhasil dihapus!");

				LoadTeacherSubjects();
				ClearTeacherSubjectForm();
				SaveAuditLog(loggedInUserId, "Hapus Guru Mengajar", "Menghapus penugasan ID: " + selectedTeacherSubjectId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menghapus data: " + ex.Message);
			}
		}

		private void btnTeacherSubjectClear_Click(object sender, EventArgs e)
		{
			ClearTeacherSubjectForm();
		}

		private void LoadAcademicYears()
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                SELECT id, year_name, is_active
                FROM academic_years
                ORDER BY id DESC";

					DataTable dt = new DataTable();
					new MySqlDataAdapter(query, conn).Fill(dt);

					dgvAcademicYear.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat tahun ajaran: " + ex.Message);
			}
		}

		private void LoadSemesterCombo()
		{
			using (MySqlConnection conn = DatabaseService.GetConnection())
			{
				conn.Open();

				string query = @"
            SELECT id, year_name
            FROM academic_years
            ORDER BY year_name DESC";

				DataTable dt = new DataTable();
				new MySqlDataAdapter(query, conn).Fill(dt);

				cmbSemesterYear.DataSource = dt;
				cmbSemesterYear.DisplayMember = "year_name";
				cmbSemesterYear.ValueMember = "id";
				cmbSemesterYear.SelectedIndex = -1;
			}
		}

		private void LoadSemesters()
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                SELECT s.id, s.academic_year_id,
                       a.year_name, s.semester_name, s.is_active
                FROM semesters s
                JOIN academic_years a ON s.academic_year_id = a.id
                ORDER BY a.year_name DESC, s.id DESC";

					DataTable dt = new DataTable();
					new MySqlDataAdapter(query, conn).Fill(dt);

					dgvSemester.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat semester: " + ex.Message);
			}
		}

		private void chkYearActive_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void dgvAcademicYear_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvAcademicYear.CurrentRow == null ||
				dgvAcademicYear.CurrentRow.Cells["id"].Value == null)
				return;

			selectedAcademicYearId = Convert.ToInt32(
				dgvAcademicYear.CurrentRow.Cells["id"].Value);

			txtYearName.Text =
				dgvAcademicYear.CurrentRow.Cells["year_name"].Value.ToString();

			chkYearActive.Checked = Convert.ToBoolean(
				dgvAcademicYear.CurrentRow.Cells["is_active"].Value);
		}

		private void btnYearAdd_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(txtYearName.Text))
			{
				MessageBox.Show("Nama tahun ajaran harus diisi!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                INSERT INTO academic_years
                (year_name, is_active)
                VALUES (@name, @active)";

					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@name", txtYearName.Text.Trim());
						cmd.Parameters.AddWithValue("@active", chkYearActive.Checked);

						cmd.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Tahun ajaran berhasil ditambahkan!");

				LoadAcademicYears();
				LoadSemesterCombo();
				ClearYearForm();
				SaveAuditLog(loggedInUserId, "Tambah Tahun Ajaran", "Menambahkan tahun ajaran: " + txtYearName.Text.Trim());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menambahkan tahun ajaran: " + ex.Message);
			}
		}

		private void btnYearUpdate_Click(object sender, EventArgs e)
		{
			if (selectedAcademicYearId == 0)
			{
				MessageBox.Show("Pilih tahun ajaran yang ingin diubah!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					if (chkYearActive.Checked)
					{
						MySqlCommand reset = new MySqlCommand(
							"UPDATE academic_years SET is_active = 0", conn);
						reset.ExecuteNonQuery();
					}

					string query = @"
                UPDATE academic_years
                SET year_name = @name, is_active = @active
                WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@name", txtYearName.Text.Trim());
					cmd.Parameters.AddWithValue("@active", chkYearActive.Checked);
					cmd.Parameters.AddWithValue("@id", selectedAcademicYearId);
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Tahun ajaran berhasil diubah!");
				LoadAcademicYears();
				LoadSemesterCombo();
				ClearYearForm();
				SaveAuditLog(loggedInUserId, "Ubah Tahun Ajaran", "Memperbarui tahun ajaran ID: " + selectedAcademicYearId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal mengubah tahun ajaran: " + ex.Message);
			}
		}

		private void btnYearDelete_Click(object sender, EventArgs e)
		{
			if (selectedAcademicYearId == 0)
			{
				MessageBox.Show("Pilih tahun ajaran yang ingin dihapus!");
				return;
			}

			DialogResult hasil = MessageBox.Show(
				"Yakin ingin menghapus tahun ajaran ini?",
				"Konfirmasi",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (hasil != DialogResult.Yes)
				return;

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = "DELETE FROM academic_years WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", selectedAcademicYearId);
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Tahun ajaran berhasil dihapus!");
				LoadAcademicYears();
				LoadSemesterCombo();
				LoadSemesters();
				ClearYearForm();
				SaveAuditLog(loggedInUserId, "Hapus Tahun Ajaran", "Menghapus tahun ajaran ID: " + selectedAcademicYearId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menghapus tahun ajaran: " + ex.Message);
			}
		}

		private void btnYearSetActive_Click(object sender, EventArgs e)
		{
			if (selectedAcademicYearId == 0)
			{
				MessageBox.Show("Pilih tahun ajaran terlebih dahulu!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					MySqlCommand reset = new MySqlCommand(
						"UPDATE academic_years SET is_active = 0", conn);
					reset.ExecuteNonQuery();

					MySqlCommand cmd = new MySqlCommand(
						"UPDATE academic_years SET is_active = 1 WHERE id = @id", conn);
					cmd.Parameters.AddWithValue("@id", selectedAcademicYearId);
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Tahun ajaran berhasil dijadikan aktif!");
				LoadAcademicYears();
				ClearYearForm();
				SaveAuditLog(loggedInUserId, "Aktifkan Tahun Ajaran", "Mengaktifkan tahun ajaran ID: " + selectedAcademicYearId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal mengaktifkan tahun ajaran: " + ex.Message);
			}
		}

		private void ClearYearForm()
		{
			selectedAcademicYearId = 0;
			txtYearName.Clear();
			chkYearActive.Checked = false;
			dgvAcademicYear.ClearSelection();
		}

		private void dgvSemester_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvSemester.CurrentRow == null ||
				dgvSemester.CurrentRow.Cells["id"].Value == null)
				return;

			selectedSemesterId = Convert.ToInt32(
				dgvSemester.CurrentRow.Cells["id"].Value);

			cmbSemesterYear.SelectedValue =
				dgvSemester.CurrentRow.Cells["academic_year_id"].Value;

			cmbSemesterName.Text =
				dgvSemester.CurrentRow.Cells["semester_name"].Value.ToString();

			chkSemesterActive.Checked = Convert.ToBoolean(
				dgvSemester.CurrentRow.Cells["is_active"].Value);
		}

		private void btnSemesterAdd_Click(object sender, EventArgs e)
		{
			if (cmbSemesterYear.SelectedIndex == -1 ||
				cmbSemesterName.SelectedIndex == -1)
			{
				MessageBox.Show("Pilih tahun ajaran dan semester!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                INSERT INTO semesters
                (academic_year_id, semester_name, is_active)
                VALUES (@year, @name, @active)";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@year", cmbSemesterYear.SelectedValue);
					cmd.Parameters.AddWithValue("@name", cmbSemesterName.Text);
					cmd.Parameters.AddWithValue("@active", chkSemesterActive.Checked);
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Semester berhasil ditambahkan!");
				LoadSemesters();
				ClearSemesterForm();
				SaveAuditLog(loggedInUserId, "Tambah Semester", "Menambahkan semester: " + cmbSemesterName.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menambahkan semester: " + ex.Message);
			}
		}

		private void btnSemesterUpdate_Click(object sender, EventArgs e)
		{
			if (selectedSemesterId == 0)
			{
				MessageBox.Show("Pilih semester yang ingin diubah!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                UPDATE semesters SET
                academic_year_id = @year,
                semester_name = @name,
                is_active = @active
                WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@year", cmbSemesterYear.SelectedValue);
					cmd.Parameters.AddWithValue("@name", cmbSemesterName.Text);
					cmd.Parameters.AddWithValue("@active", chkSemesterActive.Checked);
					cmd.Parameters.AddWithValue("@id", selectedSemesterId);
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Semester berhasil diubah!");
				LoadSemesters();
				ClearSemesterForm();
				SaveAuditLog(loggedInUserId, "Ubah Semester", "Memperbarui semester ID: " + selectedSemesterId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal mengubah semester: " + ex.Message);
			}
		}

		private void btnSemesterDelete_Click(object sender, EventArgs e)
		{
			if (selectedSemesterId == 0)
			{
				MessageBox.Show("Pilih semester yang ingin dihapus!");
				return;
			}

			DialogResult hasil = MessageBox.Show(
				"Yakin ingin menghapus semester ini?",
				"Konfirmasi",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (hasil != DialogResult.Yes)
				return;

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = "DELETE FROM semesters WHERE id = @id";

					MySqlCommand cmd = new MySqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", selectedSemesterId);
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Semester berhasil dihapus!");
				LoadSemesters();
				ClearSemesterForm();
				SaveAuditLog(loggedInUserId, "Hapus Semester", "Menghapus semester ID: " + selectedSemesterId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menghapus semester: " + ex.Message);
			}
		}

		private void btnSemesterSetActive_Click(object sender, EventArgs e)
		{
			if (selectedSemesterId == 0)
			{
				MessageBox.Show("Pilih semester terlebih dahulu!");
				return;
			}

			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					MySqlCommand reset = new MySqlCommand(
						"UPDATE semesters SET is_active = 0", conn);
					reset.ExecuteNonQuery();

					MySqlCommand cmd = new MySqlCommand(
						"UPDATE semesters SET is_active = 1 WHERE id = @id", conn);
					cmd.Parameters.AddWithValue("@id", selectedSemesterId);
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Semester berhasil dijadikan aktif!");
				LoadSemesters();
				ClearSemesterForm();
				SaveAuditLog(loggedInUserId, "Aktifkan Semester", "Mengaktifkan semester ID: " + selectedSemesterId);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal mengaktifkan semester: " + ex.Message);
			}
		}

		private void ClearSemesterForm()
		{
			selectedSemesterId = 0;
			cmbSemesterYear.SelectedIndex = -1;
			cmbSemesterName.SelectedIndex = -1;
			chkSemesterActive.Checked = false;
			dgvSemester.ClearSelection();
		}

		private void SaveAuditLog(long? userId, string activity, string detail)
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                INSERT INTO audit_logs
                (user_id, activity, detail, ip_address)
                VALUES
                (@user_id, @activity, @detail, @ip)";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue(
						"@user_id", userId.HasValue ? (object)userId.Value : DBNull.Value);

					cmd.Parameters.AddWithValue("@activity", activity);
					cmd.Parameters.AddWithValue("@detail", detail);
					cmd.Parameters.AddWithValue("@ip", "127.0.0.1");

					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal menyimpan audit log: " + ex.Message);
			}
		}

		private void LoadAuditLogs()
		{
			try
			{
				using (MySqlConnection conn = DatabaseService.GetConnection())
				{
					conn.Open();

					string query = @"
                SELECT
                    id,
                    user_id,
                    activity,
                    detail,
                    ip_address,
                    created_at
                FROM audit_logs
                WHERE created_at >= @from
                  AND created_at < @to
                ORDER BY created_at DESC";

					MySqlCommand cmd = new MySqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@from", dtpAuditFrom.Value.Date);
					cmd.Parameters.AddWithValue("@to", dtpAuditTo.Value.Date.AddDays(1));

					DataTable dt = new DataTable();
					new MySqlDataAdapter(cmd).Fill(dt);

					dgvAuditLog.DataSource = dt;

					dgvAuditLog.Columns["id"].HeaderText = "ID";
					dgvAuditLog.Columns["user_id"].HeaderText = "ID Pengguna";
					dgvAuditLog.Columns["activity"].HeaderText = "Aktivitas";
					dgvAuditLog.Columns["detail"].HeaderText = "Detail";
					dgvAuditLog.Columns["ip_address"].HeaderText = "Alamat IP";
					dgvAuditLog.Columns["created_at"].HeaderText = "Waktu";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat audit log: " + ex.Message);
			}
		}

		private void btnAuditFilter_Click(object sender, EventArgs e)
		{
			LoadAuditLogs();

			string keyword = txtAuditSearch.Text.Trim();

			if (keyword != "")
			{
				DataTable dt = dgvAuditLog.DataSource as DataTable;

				if (dt != null)
				{
					string filter = "";

					foreach (DataColumn col in dt.Columns)
					{
						if (col.DataType == typeof(string))
						{
							if (filter != "")
								filter += " OR ";

							filter += "[" + col.ColumnName + "] LIKE '%" +
									  keyword.Replace("'", "''") + "%'";
						}
					}

					if (filter != "")
						dt.DefaultView.RowFilter = filter;
				}
			}
		}

		private void btnAuditRefresh_Click(object sender, EventArgs e)
		{
			txtAuditSearch.Clear();
			dtpAuditFrom.Value = DateTime.Today.AddMonths(-1);
			dtpAuditTo.Value = DateTime.Today;

			LoadAuditLogs();
		}

		private void btnAuditExport_Click(object sender, EventArgs e)
		{
			DataTable dt = dgvAuditLog.DataSource as DataTable;

			if (dt == null || dt.Rows.Count == 0)
			{
				MessageBox.Show("Tidak ada data audit log untuk diekspor!");
				return;
			}

			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "CSV File (*.csv)|*.csv";
			save.FileName = "AuditLog.csv";

			if (save.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (System.IO.StreamWriter sw =
						   new System.IO.StreamWriter(save.FileName, false,
						   System.Text.Encoding.UTF8))
					{
						for (int i = 0; i < dt.Columns.Count; i++)
						{
							sw.Write("\"" + dt.Columns[i].ColumnName + "\"");

							if (i < dt.Columns.Count - 1)
								sw.Write(",");
						}

						sw.WriteLine();

						foreach (DataRow row in dt.Rows)
						{
							for (int i = 0; i < dt.Columns.Count; i++)
							{
								string value = row[i].ToString().Replace("\"", "\"\"");
								sw.Write("\"" + value + "\"");

								if (i < dt.Columns.Count - 1)
									sw.Write(",");
							}

							sw.WriteLine();
						}
					}

					MessageBox.Show("Audit log berhasil diekspor!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Gagal mengekspor data: " + ex.Message);
				}
			}
		}

		private void dgvAuditLog_SelectionChanged(object sender, EventArgs e)
		{
			// Data audit log hanya untuk ditampilkan.
		}

		private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

		private void chkSemesterActive_CheckedChanged(object sender, EventArgs e)
		{
			// Status aktif disimpan melalui tombol Tambah,
			// Ubah, dan Jadikan Aktif.
		}

	}
}