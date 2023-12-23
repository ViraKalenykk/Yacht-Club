using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yacht__club
{
	public partial class PartScheduleForm : Form
	{
		public PartScheduleForm()
		{
			InitializeComponent();
		}

		private void trainerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.trainerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.yacht_clubDataSet);

        }

		private void PartScheduleForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Training' table. You can move, or remove it, as needed.
			this.trainingTableAdapter.Fill(this.yacht_clubDataSet.Training);
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Trainer' table. You can move, or remove it, as needed.
			this.trainerTableAdapter.Fill(this.yacht_clubDataSet.Trainer);
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Trainer' table. You can move, or remove it, as needed.
			this.trainerTableAdapter.Fill(this.yacht_clubDataSet.Trainer);
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Training' table. You can move, or remove it, as needed.
			this.trainingTableAdapter.Fill(this.yacht_clubDataSet.Training);
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Participant' table. You can move, or remove it, as needed.
			//try
			//{
			//	this.trainingTableAdapter.FillBy(this.yacht_clubDataSet.Training);
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show("Помилка при завантаженні даних: " + ex.Message);
			//}
			//FillTrainingTableWithCustomQuery();
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ви дійсно бажаєте підтвердити зміни?", "Зміна даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				trainerBindingSource.EndEdit();
				trainerTableAdapter.Update(yacht_clubDataSet);
				trainingTableAdapter.Update(yacht_clubDataSet);
			}
		}

		private void trainerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.trainerBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.yacht_clubDataSet);
		}

		private void FillTrainingTableWithCustomQuery()
		{
			string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True;";
			string query = "SELECT training_id, PT.full_name AS \"Учасник\", TR.full_name AS \"Тренер\", Y.model AS \"Яхта\", \r\nT.date AS \"Дата\", T.start_time AS \"Час початку\", T.end_time AS \"Час завершення\", T.cost AS \"Вартість\" \r\nFROM Training T \r\nJOIN Participant PT ON T.participant_id = PT.participant_id\r\nJOIN Trainer TR ON T.trainer_id = TR.trainer_id\r\nJOIN Yacht Y ON T.yacht_id = Y.yacht_id;";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					trainingDataGridView.DataSource = dataTable;
				}
			}
		}
	}
}
