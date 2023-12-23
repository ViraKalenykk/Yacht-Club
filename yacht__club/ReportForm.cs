using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGVPrinterHelper;
using System.Windows.Forms;
using yacht__club;
using System.Data.SqlClient;

namespace yacht__club
{
	public partial class ReportForm : Form
	{
		public ReportForm()
		{
			InitializeComponent();
		}

		private string lastCompetitionName;
		private void btnCreateReport_Click(object sender, EventArgs e)
		{
			DGVPrinter dgvPrinter = new DGVPrinter();
			dgvPrinter.CreateReport("Звіт про результати '" + lastCompetitionName + "'", dataGridView);
		}

		private void FillDataGridView()
		{
			string tableQuery = @"SELECT p.full_name AS 'Учасник', y.model AS 'Модель яхти', y.manufacturing_year AS 'Рік виготовлення яхти', pa.result AS 'Місце учасника'
				FROM Competition c
				JOIN Participation pa ON c.competition_id = pa.competition_id
				JOIN Participant p ON pa.participant_id = p.participant_id
				JOIN Yacht y ON pa.yacht_id = y.yacht_id
				WHERE c.date = (SELECT MAX(date) FROM Competition WHERE date <= GETDATE())";

			string nameQuery = @"SELECT TOP 1 c.name AS 'Назва' FROM Competition c
				WHERE c.date <= GETDATE()
				ORDER BY c.date DESC";

			using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True"))
			{
				SqlCommand command = new SqlCommand(nameQuery, connection);
				connection.Open();
				lastCompetitionName = command.ExecuteScalar()?.ToString() ?? "останнього змагання";
				connection.Close();

				SqlDataAdapter adapter = new SqlDataAdapter(tableQuery, connection);
				DataTable tableData = new DataTable();
				adapter.Fill(tableData);

				dataGridView.DataSource = tableData;
			}
		}

		private void ReportForm_Load(object sender, EventArgs e)
		{
			FillDataGridView();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
