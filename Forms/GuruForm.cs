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
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnExportGrade_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void dgvGrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbInputGrade_Enter(object sender, EventArgs e)
        {

        }

        private void nudScore_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}