using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using yacht__club;


public class ExcelImporter
{
	public List<Participant> ImportParticipants(string filePath)
	{
		if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
		{
			throw new FileNotFoundException("Файл не знайдено.");
		}

		var participants = new List<Participant>();
		var validator = new ParticipantValidator();

		try
		{
			using (var workbook = new XLWorkbook(filePath))
		{
			var worksheet = workbook.Worksheet(1);
			var range = worksheet.RangeUsed();

			foreach (var row in range.Rows())
			{
				if (row.RowNumber() == 1) continue;

				var participant = new Participant
				{
					FullName = row.Cell(1).GetValue<string>(),
					BirthDate = DateTime.Parse(row.Cell(2).GetValue<string>()),
					Gender = row.Cell(3).GetValue<string>(),
					PhoneNumber = row.Cell(4).GetValue<string>(),
					Email = row.Cell(5).GetValue<string>()
				};

				if (validator.Validate(participant, out List<string> errorMessages))
				{
					participants.Add(participant);
				}
				else
				{
					foreach (var error in errorMessages)
					{
						MessageBox.Show(error, "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		}
		catch (System.IO.IOException)
		{
			MessageBox.Show("Файл не може бути доступний, оскільки він вже використовується іншим процесом. Будь ласка, закрийте всі програми, що можуть використовувати цей файл, та спробуйте знову.", "Помилка доступу до файлу", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return new List<Participant>(); 
		}

		return participants;
	} 
}


	public class ParticipantValidator
	{
		public bool Validate(Participant participant, out List<string> errorMessages)
		{
			errorMessages = new List<string>();

			if (string.IsNullOrWhiteSpace(participant.FullName))
				errorMessages.Add("Ім'я учасника не може бути порожнім.");

			if (participant.BirthDate == default(DateTime))
				errorMessages.Add("Необхідно вказати дату народження.");

			if (!IsValidPhoneNumber(participant.PhoneNumber))
				errorMessages.Add("Номер телефону має невірний формат.");

			if (!IsValidEmail(participant.Email))
				errorMessages.Add("Електронна адреса має невірний формат.");

			return errorMessages.Count == 0;
		}

		private bool IsValidPhoneNumber(string phoneNumber)
		{
			return Regex.IsMatch(phoneNumber, @"^\d{10}$");
		}

		private bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}
	}

