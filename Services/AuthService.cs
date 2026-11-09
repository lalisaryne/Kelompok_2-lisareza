
using System;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;
using AuthenticationAuthorization.Models;

namespace AuthenticationAuthorization.Services
{
	internal class AuthService
	{
		public User Login(string username, string password)
		{
			using (MySqlConnection conn = DatabaseService.GetConnection())
			{
				conn.Open();

				string query = @"
                    SELECT id, username, email, password_hash,
                           full_name, role, is_active
                    FROM users
                    WHERE username = @username
                    LIMIT 1";

				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@username", username);

					using (MySqlDataReader reader = cmd.ExecuteReader())
					{
						if (!reader.Read())
							return null;

						string savedHash = reader["password_hash"].ToString();
						string inputHash = HashPassword(password);

						if (savedHash != inputHash)
							return null;

						if (Convert.ToBoolean(reader["is_active"]) == false)
							return null;

						return new User
						{
							Id = Convert.ToInt64(reader["id"]),
							Username = reader["username"].ToString(),
							Email = reader["email"].ToString(),
							PasswordHash = savedHash,
							FullName = reader["full_name"].ToString(),
							Role = reader["role"].ToString(),
							IsActive = Convert.ToBoolean(reader["is_active"])
						};
					}
				}
			}
		}

		private string HashPassword(string password)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] bytes = sha256.ComputeHash(
					Encoding.UTF8.GetBytes(password));

				StringBuilder builder = new StringBuilder();

				foreach (byte b in bytes)
				{
					builder.Append(b.ToString("x2"));
				}

				return builder.ToString();
			}
		}
	}
}
