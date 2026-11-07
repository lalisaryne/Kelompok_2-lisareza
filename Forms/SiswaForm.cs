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
    public partial class SiswaForm : Form
    {
        public SiswaForm()
        {
            InitializeComponent();
        }

        private void SiswaForm_Load(object sender, EventArgs e)
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

        private void cmbSemesterSiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnRefreshNilai_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void btnPrintNilai_Click(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void dgvGradesSiswa_SelectionChanged(object sender, EventArgs e)
        {
            // TODO: implementasikan logika (query ke database siakada)
        }

        private void txtParentPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}