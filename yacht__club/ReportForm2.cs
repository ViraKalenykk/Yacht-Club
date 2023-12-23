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
	public partial class ReportForm2 : Form
	{
		public ReportForm2()
		{
			InitializeComponent();
		}

		private void ReportForm2_Load(object sender, EventArgs e)
		{
			FillDataGridView();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FillDataGridView()
		{
			string yachtQuery = @"SELECT y.model AS 'Модель яхти', y.manufacturing_year AS 'Рік виготовлення', y.condition AS 'Поточний стан', 
						MAX(s.end_date) AS 'Дата завершення останнього обслуговування', s.work_type AS 'Тип останнього обслуговування', 
						SUM(CASE WHEN YEAR(s.end_date) = YEAR(GETDATE()) THEN s.cost ELSE 0 END) AS 'Вартість обслуговування за рік'
						FROM Yacht y
						LEFT JOIN Service s ON y.yacht_id = s.yacht_id
						GROUP BY y.model, y.manufacturing_year, y.condition, s.work_type";

			using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True"))
			{
				SqlDataAdapter adapter = new SqlDataAdapter(yachtQuery, connection);
				DataTable yachtData = new DataTable();
				adapter.Fill(yachtData);

				dataGridView.DataSource = yachtData;
			}
		}

		private void btnCreateReport_Click(object sender, EventArgs e)
		{
			DGVPrinter dgvPrinter = new DGVPrinter();
			dgvPrinter.CreateReport("Звіт про результати стан обладнання", dataGridView);
		}
	}
}
