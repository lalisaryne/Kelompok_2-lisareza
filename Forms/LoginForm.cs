using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthenticationAuthorization.Services;
using AuthenticationAuthorization.Models;

namespace Siakada
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

		private void LoginForm_Load(object sender, EventArgs e)
		{
			txtUsername.Focus();

			AuthenticationAuthorization.Services.DatabaseService.TestConnection();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text.Trim();
			string password = txtPassword.Text;

			if (username == "" || password == "")
			{
				MessageBox.Show("Username dan password wajib diisi!");
				return;
			}

			try
			{
				AuthService auth = new AuthService();
				User user = auth.Login(username, password);

				if (user == null)
				{
					MessageBox.Show("Username atau password salah!");
					return;
				}

				MessageBox.Show("Login berhasil! Selamat datang, " + user.FullName);

				this.Hide();

				if (user.Role == "Admin")
				{
					new AdminForm(user.Id).ShowDialog();
				}
				else if (user.Role == "Guru")
				{
					new GuruForm().ShowDialog();
				}
				else if (user.Role == "Siswa")
				{
					new SiswaForm().ShowDialog();
				}

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Terjadi kesalahan: " + ex.Message);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}