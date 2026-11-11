using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Siakada
{
    public partial class GuruForm : Form
    {
        public GuruForm()
        {
            InitializeComponent();
        }

        private void GuruForm_Load(object sender, EventArgs e)
        {
            ShowPage(pnlPageDashboard, btnNavDashboard);
            LoadDashboard();
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
        }

        private void lblIconProfil_Click(object sender, EventArgs e)
        {
            btnNavProfil.PerformClick();
        }

        private void btnNavKelas_Click(object sender, EventArgs e)
        {
            ShowPage(pnlPageKelas, btnNavKelas);
        }

        private void lblIconKelas_Click(object sender, EventArgs e)
        {
            btnNavKelas.PerformClick();
        }

        private void btnNavMapel_Click(object sender, EventArgs e)
        {
            ShowPage(pnlPageMapel, btnNavMapel);
        }

        private void lblIconMapel_Click(object sender, EventArgs e)
        {
            btnNavMapel.PerformClick();
        }

        private void btnNavRekap_Click(object sender, EventArgs e)
        {
            ShowPage(pnlPageRekap, btnNavRekap);
        }

        private void lblIconRekap_Click(object sender, EventArgs e)
        {
            btnNavRekap.PerformClick();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblIconLogout_Click(object sender, EventArgs e)
        {
            btnLogout.PerformClick();
        }

        private void btnOpenGrade_Click(object sender, EventArgs e)
        {
            // Halaman Input Nilai tidak punya menu di sidebar; dibuka lewat tombol ini.
            // Menu Dashboard tetap ditandai aktif.
            ShowPage(pnlPageInputNilai, btnNavDashboard);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnKelasRefresh_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnMapelRefresh_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void dgvGrades_SelectionChanged(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnClearGrade_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnRekapLoad_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnRekapExport_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private readonly System.Drawing.Color NavNormalBg = System.Drawing.Color.FromArgb(240, 244, 251);
        private readonly System.Drawing.Color NavNormalFg = System.Drawing.Color.FromArgb(30, 41, 59);
        private readonly System.Drawing.Color NavActiveBg = System.Drawing.Color.FromArgb(219, 232, 250);
        private readonly System.Drawing.Color NavActiveFg = System.Drawing.Color.FromArgb(11, 92, 191);

        // Tampilkan satu halaman (panel) dan tandai menu yang aktif.
        // Di Designer semua panel halaman bertumpuk: pakai View > Other Windows > Document Outline
        // atau klik kanan > Send to Back / Bring to Front untuk memilih panel yang mau diedit.
        private void ShowPage(Panel page, Button activeButton)
        {
            page.BringToFront();
            foreach (Control c in pnlSidebar.Controls)
            {
                if (c is Button b && b.Name.StartsWith("btnNav"))
                    SetNavStyle(b, false);
            }
            if (activeButton != null) SetNavStyle(activeButton, true);
        }

        private void SetNavStyle(Button b, bool active)
        {
            b.BackColor = active ? NavActiveBg : NavNormalBg;
            b.ForeColor = active ? NavActiveFg : NavNormalFg;
            foreach (Control icon in b.Controls) icon.ForeColor = b.ForeColor;
        }

        private void LoadDashboard()
        {
            // TODO: isi dashboard dari database (parameter: teacher_id guru login)
            // Tahun ajaran aktif -> lblYearValue / lblYearSemester:
            //   SELECT ay.year_name, s.semester_name FROM semesters s
            //   JOIN academic_years ay ON ay.id = s.academic_year_id WHERE s.is_active = TRUE;
            // Total Kelas  -> lblStatKelasValue : COUNT(DISTINCT ts.class_id)
            // Mata Pelajaran -> lblStatMapelValue : COUNT(DISTINCT ts.subject_id)
            // Total Siswa  -> lblStatSiswaValue : COUNT(st.id) siswa pada kelas yang diampu
            // Data Nilai   -> lblStatNilaiValue : COUNT(g.id) nilai yang sudah diinput
            //   (semua dari teacher_subjects ts WHERE ts.teacher_id = @teacherId AND ts.semester_id = @semesterId)
        }
    }
}