using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AuthenticationAuthorization.Services
{
	internal class DatabaseService
	{
		private static string connectionString =
			"Server=127.0.0.1;" +
			"Port=3306;" +
			"Database=siakada;" +
			"Uid=root;" +
			"Pwd=;";

		public static MySqlConnection GetConnection()
		{
			return new MySqlConnection(connectionString);
		}

		public static void TestConnection()
		{
			try
			{
				using (MySqlConnection conn = GetConnection())
				{
					conn.Open();
					MessageBox.Show(
						"Koneksi database berhasil!",
						"Sukses"
					);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Koneksi gagal: " + ex.Message,
					"Error"
				);
			}
		}
	}
}