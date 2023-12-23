using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using yacht__club;
using static ExcelImporter;

public class DatabaseManager
{
	private string connectionString;

	public DatabaseManager()
	{
		connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True";
	}

	public void InsertParticipants(List<Participant> participants)
	{
		int addedParticipantsCount = 0;
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			connection.Open();

			foreach (var participant in participants)
			{
				string checkQuery = @"SELECT COUNT(*) FROM Participant WHERE full_name = @FullName AND birth_date = @BirthDate";
				using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
				{
					checkCommand.Parameters.Add(new SqlParameter("@FullName", System.Data.SqlDbType.VarChar) { Value = participant.FullName });
					checkCommand.Parameters.Add(new SqlParameter("@BirthDate", System.Data.SqlDbType.Date) { Value = participant.BirthDate });

					int exists = (int)checkCommand.ExecuteScalar();
					if (exists > 0)
					{
						MessageBox.Show($"Учасник/ця {participant.FullName} вже існує в базі даних. Його/її не буде додано.", "Імпорт учасників", MessageBoxButtons.OK, MessageBoxIcon.Information);
						continue;
					}
				}

				string query = @"INSERT INTO Participant (full_name, birth_date, gender, phone_number, email)
                                 VALUES (@FullName, @BirthDate, @Gender, @PhoneNumber, @Email)";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.Add(new SqlParameter("@FullName", System.Data.SqlDbType.VarChar) { Value = participant.FullName });
					command.Parameters.Add(new SqlParameter("@BirthDate", System.Data.SqlDbType.Date) { Value = participant.BirthDate });
					command.Parameters.Add(new SqlParameter("@Gender", System.Data.SqlDbType.VarChar) { Value = participant.Gender });
					command.Parameters.Add(new SqlParameter("@PhoneNumber", System.Data.SqlDbType.VarChar) { Value = (object)participant.PhoneNumber ?? DBNull.Value });
					command.Parameters.Add(new SqlParameter("@Email", System.Data.SqlDbType.VarChar) { Value = (object)participant.Email ?? DBNull.Value });

					command.ExecuteNonQuery();
					addedParticipantsCount++;
				}
			}
			connection.Close();
		}
		if (addedParticipantsCount > 0)
		{
			MessageBox.Show($"{addedParticipantsCount} учасників успішно додано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		else
		{
			MessageBox.Show("Жодного нового учасника не було додано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}

