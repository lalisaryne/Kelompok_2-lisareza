using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using AuthenticationAuthorization.Services;
using MySql.Data.MySqlClient;

namespace Siakada
{
	public partial class GuruForm : Form
	{

		private long loggedInUserId;
		private long loggedInTeacherId;
		private long selectedGradeId = 0;

		public GuruForm(long userId)
		{
			InitializeComponent();
			loggedInUserId = userId;
		}

		private void GuruForm_Load(object sender, EventArgs e)
		{
			LoadTeacherId();
			LoadProfile();
			LoadSemester();
			LoadTeachingCombo();
			LoadRekapCombo();
			ShowPage(pnlPageDashboard, btnNavDashboard);
			LoadDashboard();
		}

		private MySqlConnection GetConnection()
		{
			return DatabaseService.GetConnection();
		}

		private void LoadTeacherId()
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();
				string sql = "SELECT id FROM teachers WHERE user_id=@userId LIMIT 1";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@userId", loggedInUserId);
					object result = cmd.ExecuteScalar();

					if (result != null)
						loggedInTeacherId = Convert.ToInt64(result);
				}
			}
		}

		private void ShowPage(Panel page, Button activeButton)
		{
			pnlPageDashboard.Visible = false;
			pnlPageProfil.Visible = false;
			pnlPageKelas.Visible = false;
			pnlPageMapel.Visible = false;
			pnlPageRekap.Visible = false;
			pnlPageInputNilai.Visible = false;

			page.Visible = true;

			btnNavDashboard.BackColor = System.Drawing.Color.White;
			btnNavProfil.BackColor = System.Drawing.Color.White;
			btnNavKelas.BackColor = System.Drawing.Color.White;
			btnNavMapel.BackColor = System.Drawing.Color.White;
			btnNavRekap.BackColor = System.Drawing.Color.White;

			if (activeButton != null)
			{
				activeButton.BackColor = System.Drawing.Color.LightBlue;
			}
		}

		private void LoadProfile()
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT u.username, u.full_name, u.email,
                                      t.teacher_number, t.phone, t.address
                               FROM users u
                               LEFT JOIN teachers t ON t.user_id=u.id
                               WHERE u.id=@id";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", loggedInUserId);

					using (MySqlDataReader r = cmd.ExecuteReader())
					{
						if (r.Read())
						{
							txtUsername.Text = r["username"].ToString();
							txtFullName.Text = r["full_name"].ToString();
							txtEmail.Text = r["email"].ToString();
							txtTeacherNumber.Text = r["teacher_number"].ToString();
							txtPhone.Text = r["phone"].ToString();
							txtAddress.Text = r["address"].ToString();

							lblTopUser.Text = r["full_name"].ToString();
							lblWelcomeTitle.Text = "Selamat datang, " + r["full_name"].ToString();
						}
					}
				}
			}
		}

		private void LoadSemester()
		{
			cmbSemester.Items.Clear();
			cmbKelasSemester.Items.Clear();
			cmbRekapSemester.Items.Clear();

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT DISTINCT s.id,
                                      CONCAT(s.semester_name, ' - ', a.year_name) AS semester
                               FROM semesters s
                               JOIN academic_years a ON a.id=s.academic_year_id
                               JOIN teacher_subjects ts ON ts.semester_id=s.id
                               WHERE ts.teacher_id=@teacherId
                               ORDER BY s.id DESC";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@teacherId", loggedInTeacherId);

					using (MySqlDataReader r = cmd.ExecuteReader())
					{
						while (r.Read())
						{
							ComboItem item1 = new ComboItem(
								Convert.ToInt64(r["id"]), r["semester"].ToString());

							ComboItem item2 = new ComboItem(
								Convert.ToInt64(r["id"]), r["semester"].ToString());

							ComboItem item3 = new ComboItem(
								Convert.ToInt64(r["id"]), r["semester"].ToString());

							cmbSemester.Items.Add(item1);
							cmbKelasSemester.Items.Add(item2);
							cmbRekapSemester.Items.Add(item3);
						}
					}
				}
			}

			if (cmbSemester.Items.Count > 0)
				cmbSemester.SelectedIndex = 0;

			if (cmbKelasSemester.Items.Count > 0)
				cmbKelasSemester.SelectedIndex = 0;

			if (cmbRekapSemester.Items.Count > 0)
				cmbRekapSemester.SelectedIndex = 0;
		}

		private void LoadTeachingCombo()
		{
			cmbTeaching.Items.Clear();

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT ts.id,
                                      CONCAT(c.class_name, ' - ', sub.subject_name) AS teaching
                               FROM teacher_subjects ts
                               JOIN classes c ON c.id=ts.class_id
                               JOIN subjects sub ON sub.id=ts.subject_id
                               WHERE ts.teacher_id=@teacherId
                               ORDER BY c.class_name, sub.subject_name";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@teacherId", loggedInTeacherId);

					using (MySqlDataReader r = cmd.ExecuteReader())
					{
						while (r.Read())
						{
							cmbTeaching.Items.Add(
								new ComboItem(
									Convert.ToInt64(r["id"]),
									r["teaching"].ToString()));
						}
					}
				}
			}

			if (cmbTeaching.Items.Count > 0)
				cmbTeaching.SelectedIndex = 0;
		}

		private void LoadRekapCombo()
		{
			cmbRekapTeaching.Items.Clear();

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT ts.id,
                                      CONCAT(c.class_name, ' - ', sub.subject_name) AS teaching
                               FROM teacher_subjects ts
                               JOIN classes c ON c.id=ts.class_id
                               JOIN subjects sub ON sub.id=ts.subject_id
                               WHERE ts.teacher_id=@teacherId
                               ORDER BY c.class_name, sub.subject_name";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@teacherId", loggedInTeacherId);

					using (MySqlDataReader r = cmd.ExecuteReader())
					{
						while (r.Read())
						{
							cmbRekapTeaching.Items.Add(
								new ComboItem(
									Convert.ToInt64(r["id"]),
									r["teaching"].ToString()));
						}
					}
				}
			}

			if (cmbRekapTeaching.Items.Count > 0)
				cmbRekapTeaching.SelectedIndex = 0;
		}

		private void LoadDashboard()
		{
			lblStatKelasValue.Text = CountValue(
				"SELECT COUNT(DISTINCT class_id) FROM teacher_subjects WHERE teacher_id=@id");

			lblStatMapelValue.Text = CountValue(
				"SELECT COUNT(DISTINCT subject_id) FROM teacher_subjects WHERE teacher_id=@id");

			lblStatSiswaValue.Text = CountValue(
				@"SELECT COUNT(DISTINCT st.id)
                  FROM students st
                  JOIN teacher_subjects ts ON ts.class_id=st.class_id
                  WHERE ts.teacher_id=@id");

			lblStatNilaiValue.Text = CountValue(
				@"SELECT COUNT(g.id)
                  FROM grades g
                  JOIN teacher_subjects ts ON ts.id=g.teacher_subject_id
                  WHERE ts.teacher_id=@id");

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT CONCAT(a.year_name, ' / ', s.semester_name)
                               FROM semesters s
                               JOIN academic_years a ON a.id=s.academic_year_id
                               WHERE s.is_active=1 OR a.is_active=1
                               ORDER BY s.id DESC LIMIT 1";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					object value = cmd.ExecuteScalar();

					lblYearValue.Text = value == null ? "-" : value.ToString();
					lblYearSemester.Text = "Tahun ajaran / semester aktif";
				}
			}
		}

		private string CountValue(string sql)
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", loggedInTeacherId);
					return Convert.ToString(cmd.ExecuteScalar());
				}
			}
		}

		private void LoadKelas()
		{
			if (cmbKelasSemester.SelectedItem == null)
				return;

			long semesterId = ((ComboItem)cmbKelasSemester.SelectedItem).Id;

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT DISTINCT c.class_name AS Kelas,
                                      COUNT(DISTINCT st.id) AS JumlahSiswa
                               FROM teacher_subjects ts
                               JOIN classes c ON c.id=ts.class_id
                               LEFT JOIN students st ON st.class_id=c.id
                               WHERE ts.teacher_id=@teacherId
                               AND ts.semester_id=@semesterId
                               GROUP BY c.id, c.class_name
                               ORDER BY c.class_name";

				MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

				da.SelectCommand.Parameters.AddWithValue(
					"@teacherId", loggedInTeacherId);

				da.SelectCommand.Parameters.AddWithValue(
					"@semesterId", semesterId);

				DataTable dt = new DataTable();
				da.Fill(dt);

				dgvKelas.DataSource = dt;
			}
		}

		private void LoadMapel()
		{
			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT DISTINCT sub.subject_name AS MataPelajaran,
                                      c.class_name AS Kelas
                               FROM teacher_subjects ts
                               JOIN subjects sub ON sub.id=ts.subject_id
                               JOIN classes c ON c.id=ts.class_id
                               WHERE ts.teacher_id=@teacherId
                               ORDER BY sub.subject_name, c.class_name";

				MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

				da.SelectCommand.Parameters.AddWithValue(
					"@teacherId", loggedInTeacherId);

				DataTable dt = new DataTable();
				da.Fill(dt);

				dgvMapel.DataSource = dt;
			}
		}

		private void LoadStudents()
		{
			if (cmbTeaching.SelectedItem == null)
				return;

			long teachingId = ((ComboItem)cmbTeaching.SelectedItem).Id;

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT st.id AS student_id,
                                      st.student_number AS NIS,
                                      u.full_name AS Nama,
                                      g.id AS grade_id,
                                      g.score AS Nilai,
                                      g.description AS Keterangan
                               FROM teacher_subjects ts
                               JOIN students st ON st.class_id=ts.class_id
                               JOIN users u ON u.id=st.user_id
                               LEFT JOIN grades g ON g.student_id=st.id
                                   AND g.teacher_subject_id=ts.id
                               WHERE ts.id=@teachingId
                               ORDER BY u.full_name";

				MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

				da.SelectCommand.Parameters.AddWithValue(
					"@teachingId", teachingId);

				DataTable dt = new DataTable();
				da.Fill(dt);

				dgvGrades.DataSource = dt;

				if (dgvGrades.Columns.Contains("student_id"))
					dgvGrades.Columns["student_id"].Visible = false;

				if (dgvGrades.Columns.Contains("grade_id"))
					dgvGrades.Columns["grade_id"].Visible = false;
			}
		}

		private void SaveGrade()
		{
			if (cmbTeaching.SelectedItem == null ||
				string.IsNullOrWhiteSpace(txtStudentNumber.Text))
			{
				MessageBox.Show("Pilih kelas/mata pelajaran dan siswa terlebih dahulu.");
				return;
			}

			long teachingId = ((ComboItem)cmbTeaching.SelectedItem).Id;
			long studentId = 0;

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string findSql = @"SELECT st.id
                                   FROM students st
                                   WHERE st.student_number=@nis
                                   LIMIT 1";

				using (MySqlCommand find = new MySqlCommand(findSql, conn))
				{
					find.Parameters.AddWithValue(
						"@nis", txtStudentNumber.Text.Trim());

					object result = find.ExecuteScalar();

					if (result == null)
					{
						MessageBox.Show("Siswa tidak ditemukan.");
						return;
					}

					studentId = Convert.ToInt64(result);
				}

				string sql = @"INSERT INTO grades
                               (student_id, teacher_subject_id, score, description)
                               VALUES
                               (@student, @teaching, @score, @description)
                               ON DUPLICATE KEY UPDATE
                               score=VALUES(score),
                               description=VALUES(description),
                               updated_at=NOW()";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@student", studentId);
					cmd.Parameters.AddWithValue("@teaching", teachingId);
					cmd.Parameters.AddWithValue("@score", nudScore.Value);
					cmd.Parameters.AddWithValue(
						"@description", txtGradeDescription.Text.Trim());

					cmd.ExecuteNonQuery();
				}
			}

			MessageBox.Show("Nilai berhasil disimpan.");

			LoadStudents();
			ClearGrade();
		}

		private void DeleteGrade()
		{
			if (selectedGradeId == 0)
			{
				MessageBox.Show("Pilih data nilai yang ingin dihapus.");
				return;
			}

			if (MessageBox.Show(
				"Hapus nilai yang dipilih?",
				"Konfirmasi",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) != DialogResult.Yes)
				return;

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = "DELETE FROM grades WHERE id=@id";

				using (MySqlCommand cmd = new MySqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@id", selectedGradeId);
					cmd.ExecuteNonQuery();
				}
			}

			MessageBox.Show("Nilai berhasil dihapus.");

			LoadStudents();
			ClearGrade();
		}

		private void LoadRekap()
		{
			if (cmbRekapTeaching.SelectedItem == null)
				return;

			long teachingId = ((ComboItem)cmbRekapTeaching.SelectedItem).Id;

			using (MySqlConnection conn = GetConnection())
			{
				conn.Open();

				string sql = @"SELECT st.student_number AS NIS,
                                      u.full_name AS Nama,
                                      g.score AS Nilai,
                                      g.description AS Keterangan
                               FROM grades g
                               JOIN students st ON st.id=g.student_id
                               JOIN users u ON u.id=st.user_id
                               WHERE g.teacher_subject_id=@teachingId
                               ORDER BY u.full_name";

				MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

				da.SelectCommand.Parameters.AddWithValue(
					"@teachingId", teachingId);

				DataTable dt = new DataTable();
				da.Fill(dt);

				dgvRekap.DataSource = dt;

				if (dt.Rows.Count > 0)
				{
					double total = 0;
					double max = double.MinValue;
					double min = double.MaxValue;
					int count = 0;

					foreach (DataRow row in dt.Rows)
					{
						if (row["Nilai"] == DBNull.Value)
							continue;

						double score = Convert.ToDouble(row["Nilai"]);

						total += score;

						if (score > max)
							max = score;

						if (score < min)
							min = score;

						count++;
					}

					lblRekapAvg.Text = count == 0
						? "0" : (total / count).ToString("0.00");

					lblRekapMax.Text = count == 0
						? "0" : max.ToString("0.00");

					lblRekapMin.Text = count == 0
						? "0" : min.ToString("0.00");

					lblRekapCount.Text = count.ToString();
				}
				else
				{
					lblRekapAvg.Text = "0";
					lblRekapMax.Text = "0";
					lblRekapMin.Text = "0";
					lblRekapCount.Text = "0";
				}
			}
		}

		private void ExportRekap()
		{
			if (dgvRekap.Rows.Count == 0)
			{
				MessageBox.Show("Tidak ada data untuk diekspor.");
				return;
			}

			using (SaveFileDialog save = new SaveFileDialog())
			{
				save.Filter = "CSV File (*.csv)|*.csv";
				save.FileName = "Rekap_Nilai.csv";

				if (save.ShowDialog() != DialogResult.OK)
					return;

				using (StreamWriter writer = new StreamWriter(save.FileName))
				{
					for (int i = 0; i < dgvRekap.Columns.Count; i++)
					{
						writer.Write(dgvRekap.Columns[i].HeaderText);

						if (i < dgvRekap.Columns.Count - 1)
							writer.Write(",");
					}

					writer.WriteLine();

					foreach (DataGridViewRow row in dgvRekap.Rows)
					{
						if (row.IsNewRow)
							continue;

						for (int i = 0; i < dgvRekap.Columns.Count; i++)
						{
							string value = row.Cells[i].Value == null
								? "" : row.Cells[i].Value.ToString();

							writer.Write("\"" + value.Replace("\"", "\"\"") + "\"");

							if (i < dgvRekap.Columns.Count - 1)
								writer.Write(",");
						}

						writer.WriteLine();
					}
				}

				MessageBox.Show("Rekap berhasil diekspor.");
			}
		}

		private void ClearGrade()
		{
			selectedGradeId = 0;
			txtStudentNumber.Clear();
			txtStudentName.Clear();
			nudScore.Value = 0;
			txtGradeDescription.Clear();
		}

		private void lblIconDashboard_Click(object sender, EventArgs e)
		{
			btnNavDashboard_Click(sender, e);
		}

		private void lblIconProfil_Click(object sender, EventArgs e)
		{
			btnNavProfil_Click(sender, e);
		}

		private void lblIconKelas_Click(object sender, EventArgs e)
		{
			btnNavKelas_Click(sender, e);
		}

		private void lblIconMapel_Click(object sender, EventArgs e)
		{
			btnNavMapel_Click(sender, e);
		}

		private void lblIconRekap_Click(object sender, EventArgs e)
		{
			btnNavRekap_Click(sender, e);
		}

		private void lblIconLogout_Click(object sender, EventArgs e)
		{
			btnLogout_Click(sender, e);
		}

		private void btnOpenGrade_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageInputNilai, null);
			LoadStudents();
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Fitur ubah password belum tersedia.");
		}

		private void btnNavDashboard_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageDashboard, btnNavDashboard);
			LoadDashboard();
		}

		private void btnNavProfil_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageProfil, btnNavProfil);
			LoadProfile();
		}

		private void btnNavKelas_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageKelas, btnNavKelas);
			LoadKelas();
		}

		private void btnNavMapel_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageMapel, btnNavMapel);
			LoadMapel();
		}

		private void btnNavRekap_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageRekap, btnNavRekap);
			LoadRekap();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Apakah Anda yakin ingin logout?",
				"Konfirmasi Logout",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnKelasRefresh_Click(object sender, EventArgs e)
		{
			LoadKelas();
		}

		private void btnMapelRefresh_Click(object sender, EventArgs e)
		{
			LoadMapel();
		}

		private void btnLoadStudents_Click(object sender, EventArgs e)
		{
			LoadStudents();
		}

		private void btnSaveGrade_Click(object sender, EventArgs e)
		{
			SaveGrade();
		}

		private void btnDeleteGrade_Click(object sender, EventArgs e)
		{
			DeleteGrade();
		}

		private void btnClearGrade_Click(object sender, EventArgs e)
		{
			ClearGrade();
		}

		private void btnRekapLoad_Click(object sender, EventArgs e)
		{
			LoadRekap();
		}

		private void btnRekapExport_Click(object sender, EventArgs e)
		{
			ExportRekap();
		}

		private void dgvGrades_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvGrades.CurrentRow == null)
				return;

			DataGridViewRow row = dgvGrades.CurrentRow;

			if (row.Cells["grade_id"].Value != DBNull.Value &&
				row.Cells["grade_id"].Value != null)
			{
				selectedGradeId = Convert.ToInt64(
					row.Cells["grade_id"].Value);
			}
			else
			{
				selectedGradeId = 0;
			}

			txtStudentNumber.Text =
				Convert.ToString(row.Cells["NIS"].Value);

			txtStudentName.Text =
				Convert.ToString(row.Cells["Nama"].Value);

			if (row.Cells["Nilai"].Value != DBNull.Value &&
				row.Cells["Nilai"].Value != null)
			{
				decimal score = Convert.ToDecimal(
					row.Cells["Nilai"].Value);

				if (score >= nudScore.Minimum &&
					score <= nudScore.Maximum)
				{
					nudScore.Value = score;
				}
			}
			else
			{
				nudScore.Value = 0;
			}

			txtGradeDescription.Text =
				row.Cells["Keterangan"].Value == DBNull.Value
				? "" : Convert.ToString(row.Cells["Keterangan"].Value);
		}

		private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbTeaching.Items.Count > 0)
				LoadStudents();
		}

		private void lblProfile_Click(object sender, EventArgs e)
		{
			ShowPage(pnlPageProfil, btnNavProfil);
			LoadProfile();
		}

		private class ComboItem
		{
			public long Id { get; set; }
			public string Name { get; set; }

			public ComboItem(long id, string name)
			{
				Id = id;
				Name = name;
			}

			public override string ToString()
			{
				return Name;
			}
		}
	}
}