using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yacht__club
{
	public partial class EnterForm : Form
	{
		public UserRole CurrentUserRole { get; private set; } = UserRole.None;
		public bool SuccessfulLogin { get; private set; } = false;
		public EnterForm()
		{
			InitializeComponent();
			textBox_password.PasswordChar = '•';
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			string username = textBox_login.Text;
			string password = textBox_password.Text;

			CurrentUserRole = AuthenticateUser(username, password);

			if (CurrentUserRole != UserRole.None)
			{
				switch (CurrentUserRole)
				{
					case UserRole.Administrator:
						MessageBox.Show("Вітаємо! \nВиконано вхід в якості адміністратора.");
						break;
					case UserRole.Trainer:
						MessageBox.Show("Вітаємо! \nВиконано вхід в якості тренера.");
						break;
					case UserRole.Participant:
						MessageBox.Show("Вхід як Учасник.");
						break;
					case UserRole.TechnicalStaff:
						MessageBox.Show("Вітаємо! \nВиконано вхід в якості предстаника технічного персоналу.");
						break;
					case UserRole.None:
					default:
						// Якщо введені невірні дані
						MessageBox.Show("Неправильне ім'я користувача або пароль.");
						break;
				}

				SuccessfulLogin = true;
				this.Close();
			}
			else
			{
				MessageBox.Show("Неправильне ім'я користувача або пароль.");
			}
		}

		private UserRole AuthenticateUser(string username, string password)
		{
			if (username == "admin" && password == "admin123")
				return UserRole.Administrator;
			else if (username == "trainer" && password == "trainer123")
				return UserRole.Trainer;
			else if (username == "participant" && password == "participant123")
				return UserRole.Participant;
			else if (username == "staff" && password == "staff123")
				return UserRole.TechnicalStaff;

			return UserRole.None;
		}

		public enum UserRole
		{
			Administrator,
			Trainer,
			Participant,
			TechnicalStaff,
			None
		}
	}


}
