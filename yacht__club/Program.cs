using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yacht__club
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			EnterForm enterForm = new EnterForm();
			Application.Run(enterForm);

			if (enterForm.SuccessfulLogin)
			{
				Form1 mainForm = new Form1(enterForm.CurrentUserRole);
				Application.Run(mainForm);
			}
		}
	}
}
