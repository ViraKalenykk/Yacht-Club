using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yacht__club.yacht_clubDataSetTableAdapters;

namespace yacht__club
{
	public partial class EditParticipant : Form
	{
		private readonly int participant_id;
		private readonly bool edit;
		private yacht_clubDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter;

		public EditParticipant()
		{
			InitializeComponent();
			edit = false;
			participantTableAdapter = new yacht_clubDataSetTableAdapters.ParticipantTableAdapter();
		}

		public EditParticipant(int id, string name, DateTime birthDate, string gender, string phone, string email)
	: this()
		{
			edit = true;
			participant_id = id;
			textBox_FullName.Text = name;
			dateTimePicker_BDate.Value = birthDate;
			comboBox_Gender.SelectedItem = gender;
			textBox_Phone.Text = phone;
			textBox_Email.Text = email;
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			try
			{
				string name = textBox_FullName.Text;
				DateTime birthDate = dateTimePicker_BDate.Value;
				string gender = comboBox_Gender.SelectedItem.ToString();
				string phone = textBox_Phone.Text;
				string email = textBox_Email.Text;

				if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
				{
					MessageBox.Show("Всі поля повинні бути заповнені.", "Помилка введення");
					return;
				}

				if (!phone.StartsWith("0") || phone.Length != 10)
				{
					MessageBox.Show("Номер телефону має починатися з 0 і містити 10 цифр.", "Помилка введення");
					return;
				}

				if (!email.Contains("@"))
				{
					MessageBox.Show("Пошта має містити знак '@'.", "Помилка введення");
					return;
				}

				string birthDateString = birthDate.ToString("yyyy-MM-dd");

				if (edit)
				{
					participantTableAdapter.UpdateQuery(name, birthDateString, gender, phone, email, participant_id);
				}
				else
				{
					participantTableAdapter.InsertQuery(name, birthDateString, gender, phone, email);
				}
				this.DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Виникла помилка: " + ex.Message);
			}
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
