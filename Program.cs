
using AuthenticationAuthorization;
using Siakada;
using System;
using System.Windows.Forms;

namespace AuthenticationAuthorization
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.Run(new LoginForm());
		}
	}
}
