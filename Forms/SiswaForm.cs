using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AuthenticationAuthorization.Services;

namespace Siakada
{
	public partial class SiswaForm : Form
	{
		private long loggedInUserId;
		private long loggedInStudentId;
		private long loggedInClassId;

		private readonly Color NavNormalBg = Color.FromArgb(240, 244, 251);
		private readonly Color NavNormalFg = Color.FromArgb(30, 41, 59);
		private readonly Color NavActiveBg = Color.FromArgb(219, 232, 250);
		private readonly Color NavActiveFg = Color.FromArgb(11, 92, 191);

		public SiswaForm(long userId)
		{
			InitializeComponent();
			loggedInUserId = userId;
		}

		private void SiswaForm_Load(object sender, EventArgs e)
		{
			try
			{
				LoadStudentId();
				LoadProfile();
				LoadSemester();

				ShowPage(pnlPageDashboard, btnNavDashboard);

				LoadDashboard();
				LoadClass();
				LoadMapel();
				LoadGrades();
				LoadRekap();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Gagal memuat data siswa: " + ex.Message);
			}
		}

		private MySqlConnection GetConnection()
		{
			return DatabaseService.GetConnection();
		}

		private void LoadStudentId()
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT id, class_id
                               FROM students
                               WHERE user_id=@userId
                               LIMIT 1";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@userId", loggedInUserId);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (!reader.Read())
							throw new Exception("Data siswa belum terdaftar.");

						loggedInStudentId = Convert.ToInt64(reader["id"]);

						loggedInClassId = reader["class_id"] == DBNull.Value
							? 0 : Convert.ToInt64(reader["class_id"]);
					}
				}
			}
		}

		private void LoadProfile()
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT u.username, u.full_name, u.email,
                                      st.student_number, st.class_id,
                                      c.class_name, st.*
                               FROM students st
                               JOIN users u ON u.id=st.user_id
                               LEFT JOIN classes c ON c.id=st.class_id
                               WHERE st.id=@id
                               LIMIT 1";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", loggedInStudentId);

					using (MySqlDataReader r = cmd.ExecuteReader())
					{
						if (r.Read())
						{
							string nama = ReadValue(r, "full_name");
							string kelas = ReadValue(r, "class_name");

							lblTopUser.Text = nama;
							lblWelcomeTitle.Text = "Selamat datang, " + nama + "!";

							txtNis.Text = ReadValue(r, "student_number");
							txtNamaSiswa.Text = nama;
							txtKelas.Text = kelas;

							lblClassName.Text = "Kelas: " +
								(kelas == "" ? "-" : kelas);

							txtBirthDate.Text = ReadValue(r, "birth_date");
							txtGender.Text = ReadValue(r, "gender");
							txtParentName.Text = ReadValue(r, "parent_name");
							txtParentPhone.Text = ReadValue(r, "parent_phone");
							txtAddress.Text = ReadValue(r, "address");
						}
					}
				}
			}
		}

		private string ReadValue(IDataRecord reader, string column)
		{
			try
			{
				int index = reader.GetOrdinal(column);

				return reader.IsDBNull(index)
					? "" : Convert.ToString(reader.GetValue(index));
			}
			catch
			{
				return "";
			}
		}

		private void LoadSemester()
		{
			DataTable dt = new DataTable();

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT DISTINCT s.id,
                                      CONCAT(s.semester_name, ' - ', a.year_name)
                                      AS semester_label
                               FROM semesters s
                               JOIN academic_years a ON a.id=s.academic_year_id
                               JOIN teacher_subjects ts ON ts.semester_id=s.id
                               WHERE ts.class_id=@classId
                               ORDER BY s.id DESC";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@classId", loggedInClassId);

					using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
					{
						da.Fill(dt);
					}
				}
			}

			cmbMapelSemester.SelectedIndexChanged -= cmbMapelSemester_SelectedIndexChanged;
			cmbSemesterSiswa.SelectedIndexChanged -= cmbSemesterSiswa_SelectedIndexChanged;

			cmbMapelSemester.DataSource = dt.Copy();
			cmbMapelSemester.DisplayMember = "semester_label";
			cmbMapelSemester.ValueMember = "id";

			cmbSemesterSiswa.DataSource = dt;
			cmbSemesterSiswa.DisplayMember = "semester_label";
			cmbSemesterSiswa.ValueMember = "id";

			cmbMapelSemester.SelectedIndexChanged += cmbMapelSemester_SelectedIndexChanged;
			cmbSemesterSiswa.SelectedIndexChanged += cmbSemesterSiswa_SelectedIndexChanged;
		}

		private void LoadDashboard()
		{
			lblStatKelasValue.Text = loggedInClassId == 0 ? "-" : "1";

			lblStatMapelValue.Text = CountValue(
				"SELECT COUNT(DISTINCT subject_id) FROM teacher_subjects WHERE class_id=@classId",
				"@classId", loggedInClassId).ToString();

			object avg = Scalar(
				"SELECT AVG(score) FROM grades WHERE student_id=@studentId",
				"@studentId", loggedInStudentId);

			lblStatRataValue.Text = avg == null || avg == DBNull.Value
				? "-" : Convert.ToDecimal(avg).ToString("0.00");

			lblStatNilaiValue.Text = CountValue(
				"SELECT COUNT(*) FROM grades WHERE student_id=@studentId",
				"@studentId", loggedInStudentId).ToString();

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT a.year_name, s.semester_name
                               FROM semesters s
                               JOIN academic_years a ON a.id=s.academic_year_id
                               WHERE s.is_active=1 OR a.is_active=1
                               ORDER BY s.id DESC
                               LIMIT 1";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				using (MySqlDataReader r = cmd.ExecuteReader())
				{
					if (r.Read())
					{
						lblYearValue.Text = Convert.ToString(r["year_name"]);
						lblYearSemester.Text = "Semester " +
							Convert.ToString(r["semester_name"]);
					}
					else
					{
						lblYearValue.Text = "-";
						lblYearSemester.Text = "Semester -";
					}
				}
			}
		}

		private object Scalar(string sql, string parameter, long value)
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue(parameter, value);
					return cmd.ExecuteScalar();
				}
			}
		}

		private int CountValue(string sql, string parameter, long value)
		{
			object result = Scalar(sql, parameter, value);

			return result == null || result == DBNull.Value
				? 0 : Convert.ToInt32(result);
		}

		private void LoadClass()
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT st.student_number AS NIS,
                                      u.full_name AS Nama
                               FROM students st
                               JOIN users u ON u.id=st.user_id
                               WHERE st.class_id=@classId
                               ORDER BY u.full_name";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@classId", loggedInClassId);

					DataTable dt = new DataTable();

					using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
					{
						da.Fill(dt);
					}

					dgvClassmates.DataSource = dt;
				}

				string levelSql = "SELECT class_name FROM classes WHERE id=@id";

				using (MySqlCommand cmd = new MySqlCommand(levelSql, conn))
				{
					cmd.Parameters.AddWithValue("@id", loggedInClassId);

					object name = cmd.ExecuteScalar();

					lblGradeLevel.Text = "Tingkat: " +
						(name == null ? "-" : Convert.ToString(name));
				}
			}
		}

		private void LoadMapel()
		{
			if (cmbMapelSemester.SelectedValue == null)
				return;

			long semesterId;

			if (!long.TryParse(Convert.ToString(cmbMapelSemester.SelectedValue),
				out semesterId))
				return;

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT DISTINCT
                                      sub.subject_name AS `Mata Pelajaran`,
                                      u.full_name AS `Guru`,
                                      c.class_name AS `Kelas`
                               FROM teacher_subjects ts
                               JOIN subjects sub ON sub.id=ts.subject_id
                               JOIN teachers t ON t.id=ts.teacher_id
                               JOIN users u ON u.id=t.user_id
                               JOIN classes c ON c.id=ts.class_id
                               WHERE ts.class_id=@classId
                               AND ts.semester_id=@semesterId
                               ORDER BY sub.subject_name";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@classId", loggedInClassId);
					cmd.Parameters.AddWithValue("@semesterId", semesterId);

					DataTable dt = new DataTable();

					using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
					{
						da.Fill(dt);
					}

					dgvMapelSiswa.DataSource = dt;
				}
			}
		}

		private void LoadGrades()
		{
			if (cmbSemesterSiswa.SelectedValue == null)
				return;

			long semesterId;

			if (!long.TryParse(Convert.ToString(cmbSemesterSiswa.SelectedValue),
				out semesterId))
				return;

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT sub.subject_name AS `Mata Pelajaran`,
                                      u.full_name AS `Guru`,
                                      g.score AS `Nilai`,
                                      g.description AS `Keterangan`
                               FROM grades g
                               JOIN teacher_subjects ts ON ts.id=g.teacher_subject_id
                               JOIN subjects sub ON sub.id=ts.subject_id
                               JOIN teachers t ON t.id=ts.teacher_id
                               JOIN users u ON u.id=t.user_id
                               WHERE g.student_id=@studentId
                               AND ts.semester_id=@semesterId
                               ORDER BY sub.subject_name";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@studentId", loggedInStudentId);
					cmd.Parameters.AddWithValue("@semesterId", semesterId);

					DataTable dt = new DataTable();

					using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
					{
						da.Fill(dt);
					}

					dgvGradesSiswa.DataSource = dt;

					decimal total = 0;
					int count = 0;

					foreach (DataRow row in dt.Rows)
					{
						if (row["Nilai"] != DBNull.Value)
						{
							total += Convert.ToDecimal(row["Nilai"]);
							count++;
						}
					}

					lblAverage.Text = "Rata-rata: " +
						(count == 0 ? "-" : (total / count).ToString("0.00"));

					lblTotalSubject.Text = "Jumlah mapel: " + count;
				}
			}
		}

		private void LoadRekap()
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT a.year_name AS `Tahun Ajaran`,
                                      s.semester_name AS `Semester`,
                                      COUNT(g.id) AS `Jumlah Nilai`,
                                      ROUND(AVG(g.score),2) AS `Rata-rata`
                               FROM grades g
                               JOIN teacher_subjects ts ON ts.id=g.teacher_subject_id
                               JOIN semesters s ON s.id=ts.semester_id
                               JOIN academic_years a ON a.id=s.academic_year_id
                               WHERE g.student_id=@studentId
                               GROUP BY s.id, a.year_name, s.semester_name
                               ORDER BY s.id DESC";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@studentId", loggedInStudentId);

					DataTable dt = new DataTable();

					using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
					{
						da.Fill(dt);
					}

					dgvRekapSiswa.DataSource = dt;

					object avg;

					using (MySqlCommand avgCmd = new MySqlCommand(
						"SELECT AVG(score) FROM grades WHERE student_id=@studentId",
						conn))
					{
						avgCmd.Parameters.AddWithValue("@studentId", loggedInStudentId);
						avg = avgCmd.ExecuteScalar();
					}

					lblRekapAvgAll.Text = "Rata-rata keseluruhan: " +
						(avg == null || avg == DBNull.Value
						? "-" : Convert.ToDecimal(avg).ToString("0.00"));
				}
			}
		}

		private void ExportGrid(DataGridView grid, string title)
		{
			if (grid.Rows.Count == 0)
			{
				MessageBox.Show("Belum ada data untuk diekspor.");
				return;
			}

			using (SaveFileDialog save = new SaveFileDialog())
			{
				save.Filter = "CSV File (*.csv)|*.csv";
				save.FileName = title + ".csv";

				if (save.ShowDialog() != DialogResult.OK)
					return;

				using (StreamWriter writer = new StreamWriter(
					save.FileName, false, Encoding.UTF8))
				{
					for (int c = 0; c < grid.Columns.Count; c++)
					{
						if (c > 0)
							writer.Write(";");

						writer.Write(grid.Columns[c].HeaderText);
					}

					writer.WriteLine();

					foreach (DataGridViewRow row in grid.Rows)
					{
						if (row.IsNewRow)
							continue;

						for (int c = 0; c < grid.Columns.Count; c++)
						{
							if (c > 0)
								writer.Write(";");

							string value = Convert.ToString(row.Cells[c].Value)
								.Replace(";", ",");

							writer.Write(value);
						}

						writer.WriteLine();
					}
				}

				MessageBox.Show("Data berhasil diekspor.");
			}
		}

		private void ChangePassword()
		{
			string oldPassword = Microsoft.VisualBasic.Interaction.InputBox(
				"Masukkan password lama:", "Ganti Password");

			if (oldPassword == "")
				return;

			string newPassword = Microsoft.VisualBasic.Interaction.InputBox(
				"Masukkan password baru:", "Ganti Password");

			if (newPassword.Length < 6)
			{
				MessageBox.Show("Password baru minimal 6 karakter.");
				return;
			}

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string checkSql =
					"SELECT password_hash FROM users WHERE id=@id";

				string oldHash = "";

				using (MySqlCommand cmd = new MySqlCommand(checkSql, conn))
				{
					cmd.Parameters.AddWithValue("@id", loggedInUserId);
					oldHash = Convert.ToString(cmd.ExecuteScalar());
				}

				if (oldHash != HashPassword(oldPassword))
				{
					MessageBox.Show("Password lama tidak sesuai.");
					return;
				}

				using (MySqlCommand cmd = new MySqlCommand(
					"UPDATE users SET password_hash=@hash WHERE id=@id", conn))
				{
					cmd.Parameters.AddWithValue("@hash", HashPassword(newPassword));
					cmd.Parameters.AddWithValue("@id", loggedInUserId);
					cmd.ExecuteNonQuery();
				}
			}

			MessageBox.Show("Password berhasil diubah.");
		}

		private string HashPassword(string password)
		{
			using (SHA256 sha = SHA256.Create())
			{
				byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

				StringBuilder result = new StringBuilder();

				foreach (byte b in bytes)
					result.Append(b.ToString("x2"));

				return result.ToString();
			}
		}

		private void ShowPage(Panel page, Button activeButton)
		{
			page.BringToFront();

			foreach (Control control in pnlSidebar.Controls)
			{
				if (control is Button button &&
					button.Name.StartsWith("btnNav"))
				{
					SetNavStyle(button, false);
				}
			}

			if (activeButton != null)
				SetNavStyle(activeButton, true);
		}

		private void SetNavStyle(Button button, bool active)
		{
			button.BackColor = active ? NavActiveBg : NavNormalBg;
			button.ForeColor = active ? NavActiveFg : NavNormalFg;

			foreach (Control control in button.Controls)
				control.ForeColor = button.ForeColor;
		}

		private void lblProfile_Click(object sender, EventArgs e)
		{
			btnNavProfil.PerformClick();
		}

		private void btnNavDashboard_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageDashboard, btnNavDashboard);
			LoadDashboard();
		}

		private void lblIconDashboard_Click(object sender, EventArgs e)
		{
			btnNavDashboard.PerformClick();
		}

		private void btnNavProfil_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageProfil, btnNavProfil);
			LoadProfile();
		}

		private void lblIconProfil_Click(object sender, EventArgs e)
		{
			btnNavProfil.PerformClick();
		}

		private void btnNavKelas_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageKelas, btnNavKelas);
			LoadClass();
		}

		private void lblIconKelas_Click(object sender, EventArgs e)
		{
			btnNavKelas.PerformClick();
		}

		private void btnNavMapel_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageMapel, btnNavMapel);
			LoadMapel();
		}

		private void lblIconMapel_Click(object sender, EventArgs e)
		{
			btnNavMapel.PerformClick();
		}

		private void btnNavRekap_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageRekap, btnNavRekap);
			LoadRekap();
		}

		private void lblIconRekap_Click(object sender, EventArgs e)
		{
			btnNavRekap.PerformClick();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(
				"Yakin ingin logout?",
				"Konfirmasi",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Close();
			}
		}

		private void lblIconLogout_Click(object sender, EventArgs e)
		{
			btnLogout.PerformClick();
		}

		private void btnOpenGrade_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageNilaiSaya, btnNavDashboard);
			LoadGrades();
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			ChangePassword();
		}

		private void btnMapelRefresh_Click(object sender, EventArgs e)
		{
			LoadMapel();
		}

		private void cmbMapelSemester_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadMapel();
		}

		private void cmbSemesterSiswa_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadGrades();
		}

		private void btnRefreshNilai_Click(object sender, EventArgs e)
		{
			LoadGrades();
		}

		private void btnPrintNilai_Click(object sender, EventArgs e)
		{
			ExportGrid(dgvGradesSiswa, "Nilai_Saya");
		}

		private void dgvGradesSiswa_SelectionChanged(object sender, EventArgs e)
		{
		}

		private void btnRekapPrint_Click(object sender, EventArgs e)
		{
			ExportGrid(dgvRekapSiswa, "Rekap_Nilai");
		}
	}
}