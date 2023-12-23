using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yacht__club;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Office2010.Excel;
using Org.BouncyCastle.Asn1.X509;
using static yacht__club.EnterForm;

namespace yacht__club
{
	public partial class Form1 : Form
	{
		private string activeTable;
		public Dictionary<string, string> SelectedFilters { get; private set; }
		
		private UserRole currentUserRole;

		public Form1(UserRole userRole)
		{
			InitializeComponent();
			currentUserRole = userRole;
			SetupInterfaceBasedOnUserRole();
			dataGridView8.SelectionChanged += new EventHandler(dataGridView8_SelectionChanged);
			InitializeComboBoxValues();
			InitializeDateTimePickerValues();
			InitializeNumericValues();
			dataGridView8.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView8_ColumnHeaderMouseClick);
			InitializeColumnMappings();
		}


		public Form1()
		{
			InitializeComponent();
			dataGridView8.SelectionChanged += new EventHandler(dataGridView8_SelectionChanged);
			InitializeComboBoxValues();
			InitializeDateTimePickerValues();
			InitializeNumericValues();
			dataGridView8.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView8_ColumnHeaderMouseClick);
			InitializeColumnMappings();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Yacht' table. You can move, or remove it, as needed.
			this.yachtTableAdapter.Fill(this.yacht_clubDataSet.Yacht);
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Training' table. You can move, or remove it, as needed.
			this.trainingTableAdapter.Fill(this.yacht_clubDataSet.Training);
            // TODO: This line of code loads data into the 'yacht_clubDataSet.Trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter.Fill(this.yacht_clubDataSet.Trainer);
            // TODO: This line of code loads data into the 'yacht_clubDataSet.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.yacht_clubDataSet.Service);
            // TODO: This line of code loads data into the 'yacht_clubDataSet.Participation' table. You can move, or remove it, as needed.
            this.participationTableAdapter.Fill(this.yacht_clubDataSet.Participation);
            // TODO: This line of code loads data into the 'yacht_clubDataSet.Competition' table. You can move, or remove it, as needed.
            this.competitionTableAdapter.Fill(this.yacht_clubDataSet.Competition);
            // TODO: This line of code loads data into the 'yacht_clubDataSet.ClubMembership' table. You can move, or remove it, as needed.
            this.clubMembershipTableAdapter.Fill(this.yacht_clubDataSet.ClubMembership);
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Participant' table. You can move, or remove it, as needed.
			this.participantTableAdapter.Fill(this.yacht_clubDataSet.Participant);
			dataGridView8.AutoGenerateColumns = true;
			currentPosition = 0;
			UpdateDataGridView();
            btnSortAscending.Visible = btnSortDescending.Visible = false;
			panelSideBar.Visible = false;
			this.Width = 700;
			menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11, FontStyle.Regular);
			menuStrip1.ForeColor = System.Drawing.Color.White;
		}

		private void ResetSortingMode()
        {
            foreach (DataGridViewColumn column in dataGridView8.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
            yachtTableAdapter.Update(yacht_clubDataSet);
            serviceTableAdapter.Update(yacht_clubDataSet);
			participantTableAdapter.Update(yacht_clubDataSet);
			participationTableAdapter.Update(yacht_clubDataSet);
			trainerTableAdapter.Update(yacht_clubDataSet);
			trainingTableAdapter.Update(yacht_clubDataSet);
			clubMembershipTableAdapter.Update(yacht_clubDataSet);
			competitionTableAdapter.Update(yacht_clubDataSet);
		}

		private void dataGridView8_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView8.SelectedRows.Count > 0)
			{
				int index = dataGridView8.SelectedRows[0].Index;
				currentPosition = index;
				UpdateDataGridView();
			}
		}

		private DataTable GetData(string queryString)
		{
			string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);

				DataTable table = new DataTable();
				//MessageBox.Show(queryString);
				adapter.Fill(table);

				return table;
			}
		}

		private void обслуговуванняЯхтToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string query = "SELECT S.service_id AS \"ID обслуговування\", Y.model AS \"Модель яхти\", S.start_date AS \"Дата початку обслуговування\", S.end_date AS \"Дата завершення обслуговування\", S.work_type AS \"Тип роботи\", S.cost AS \"Вартість\", S.specialist AS \"Спеціаліст\" FROM Service S\r\nJOIN Yacht Y ON S.yacht_id = Y.yacht_id;";
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			activeTable = "service";
			labelTotalMembers.Visible = false;
			textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = true;
			btnImportParticipants.Visible = false;
            label2.Text = "Обслуговування яхт";
			currentPosition = 0;
			UpdateDataGridView();
            ResetSortingMode();
			if (panelSideBar.Visible)
			{
				SetupFilters(activeTable);
				if (FilterManager.SelectedFilters.ContainsKey(activeTable))
				{
					LoadSelectedFilters();
					ApplyFilters(FilterManager.SelectedFilters[activeTable]);
				}
				InitializeComboBoxValues();
				InitializeDateTimePickerValues();
				InitializeNumericValues();
			}
		}

		private void яхтиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string query = "SELECT yacht_id, model AS \"Модель\", yacht_type AS \"Тип яхти\", condition AS \"Стан\", manufacturing_year AS \"Рік виготовлення\", rental_cost AS \"Вартість оренди\" FROM Yacht;";
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			activeTable = "yacht";
			labelTotalMembers.Visible = false;
			textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = true;
            btnImportParticipants.Visible = false;
            label2.Text = "Яхти";
			currentPosition = 0;
			UpdateDataGridView();
            ResetSortingMode();
			if (panelSideBar.Visible)
			{
				SetupFilters(activeTable);
				if (FilterManager.SelectedFilters.ContainsKey(activeTable))
				{
					LoadSelectedFilters();
					ApplyFilters(FilterManager.SelectedFilters[activeTable]);
				}
				InitializeComboBoxValues();
				InitializeDateTimePickerValues();
				InitializeNumericValues();
			}
		}

		private void змаганняToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string query = "SELECT competition_id, name AS \"Назва\", date AS \"Дата проведення\", time AS \"Час початку\", location AS \"Місце проведення\", type AS \"Тип змагання\" FROM Competition;";
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			activeTable = "competition";
			labelTotalMembers.Visible = false;
			labelTotalMembers.Visible = false;
			textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = true;
            btnImportParticipants.Visible = false;
            label2.Text = "Змагання";
			currentPosition = 0;
			UpdateDataGridView();
            ResetSortingMode();
			if (panelSideBar.Visible)
			{
				SetupFilters(activeTable);
				if (FilterManager.SelectedFilters.ContainsKey(activeTable))
				{
					LoadSelectedFilters();
					ApplyFilters(FilterManager.SelectedFilters[activeTable]);
				}
				InitializeComboBoxValues();
				InitializeDateTimePickerValues();
				InitializeNumericValues();
			}
		}

		private void участьВЗмагнняхToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string query = "SELECT participation_id, C.name AS \"Змагання\",PT.full_name AS \"Учасник\", Y.model AS \"Яхта\", P.result AS \"Результат\" FROM Participation P\r\nJOIN Competition C ON P.competition_id = C.competition_id\r\nJOIN Participant PT ON P.participant_id = PT.participant_id\r\nJOIN Yacht Y ON P.yacht_id = Y.yacht_id;";
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			activeTable = "participation";
			labelTotalMembers.Visible = false;
			textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = true;
            btnImportParticipants.Visible = false;
            label2.Text = "Участь в змаганнях";
			currentPosition = 0;
			UpdateDataGridView();
            ResetSortingMode();
			if (panelSideBar.Visible)
			{
				SetupFilters(activeTable);
				if (FilterManager.SelectedFilters.ContainsKey(activeTable))
				{
					LoadSelectedFilters();
					ApplyFilters(FilterManager.SelectedFilters[activeTable]);
				}
				InitializeComboBoxValues();
				InitializeDateTimePickerValues();
				InitializeNumericValues();
			}
		}

		private void учасникиЗмаганьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string query = "SELECT participant_id, full_name AS \"Ім'я\", birth_date AS \"Дата народження\", gender AS \"Стать\", phone_number AS \"Номер телефону\", email AS \"Електронна пошта\" FROM Participant;";
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			activeTable = "participant";
			labelTotalMembers.Visible = false;
			btnImportParticipants.Visible = true;
			textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = true;
			label2.Text = "Учасники змагань";
			currentPosition = 0;
			UpdateDataGridView();
            ResetSortingMode();
			if (panelSideBar.Visible)
			{
				SetupFilters(activeTable);
				if (FilterManager.SelectedFilters.ContainsKey(activeTable))
				{
					LoadSelectedFilters();
					ApplyFilters(FilterManager.SelectedFilters[activeTable]);
				}
				InitializeComboBoxValues();
				InitializeDateTimePickerValues();
				InitializeNumericValues();
			}
		}

		private void членствоВКлубіToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string query = "SELECT membership_id, PT.full_name AS \"Член клубу\", CM.join_date AS \"Дата вступу до клубу\" FROM ClubMembership CM\r\nJOIN Participant PT ON CM.participant_id = PT.participant_id;";
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			activeTable = "membership";
			labelTotalMembers.Visible = false;
			textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = true;
            btnImportParticipants.Visible = false;
            label2.Text = "Членство в клубі";
			currentPosition = 0;
			UpdateDataGridView();
            ResetSortingMode();
			if (panelSideBar.Visible)
			{
				SetupFilters(activeTable);
				if (FilterManager.SelectedFilters.ContainsKey(activeTable))
				{
					LoadSelectedFilters();
					ApplyFilters(FilterManager.SelectedFilters[activeTable]);
				}
				InitializeComboBoxValues();
				InitializeDateTimePickerValues();
				InitializeNumericValues();
			}
		}

		private void тренериToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string query = "SELECT trainer_id, full_name AS \"Повне ім'я\", birth_date AS \"Дата народження\", gender AS \"Стать\", phone_number AS \"Номер телефону\", email AS \"Електронна пошта\", experience AS \"Досвід\", specialization AS \"Спеціалізація\" FROM Trainer;";
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			activeTable = "trainer";
			labelTotalMembers.Visible = false;
			textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = true;
            btnImportParticipants.Visible = false;
            label2.Text = "Tренери";
			currentPosition = 0;
			UpdateDataGridView();
            ResetSortingMode();
			if (panelSideBar.Visible)
			{
				SetupFilters(activeTable);
				if (FilterManager.SelectedFilters.ContainsKey(activeTable))
				{
					LoadSelectedFilters();
					ApplyFilters(FilterManager.SelectedFilters[activeTable]);
				}
				InitializeComboBoxValues();
				InitializeDateTimePickerValues();
				InitializeNumericValues();
			}
		}

		private void тренуванняToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string query = "SELECT training_id, PT.full_name AS \"Учасник\", TR.full_name AS \"Тренер\", Y.model AS \"Яхта\", T.date AS \"Дата\", T.start_time AS \"Час початку\", T.end_time AS \"Час завершення\", T.cost AS \"Вартість\" FROM Training T\r\nJOIN Participant PT ON T.participant_id = PT.participant_id\r\nJOIN Trainer TR ON T.trainer_id = TR.trainer_id\r\nJOIN Yacht Y ON T.yacht_id = Y.yacht_id;";
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			activeTable = "training";
			labelTotalMembers.Visible = false;
			textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = true;
            btnImportParticipants.Visible = false;
            label2.Text = "Тренування";
			currentPosition = 0;
			UpdateDataGridView();
            ResetSortingMode();
			if (panelSideBar.Visible)
			{
				SetupFilters(activeTable);
				if (FilterManager.SelectedFilters.ContainsKey(activeTable))
				{
					LoadSelectedFilters();
					ApplyFilters(FilterManager.SelectedFilters[activeTable]);
				}
				InitializeComboBoxValues();
				InitializeDateTimePickerValues();
				InitializeNumericValues();
			}
		}

		private void SetupInterfaceBasedOnUserRole()
		{
			switch (currentUserRole)
			{
				case UserRole.TechnicalStaff:
					EnableLimitedFunctionsForTechnicalStaff();
					break;
				case UserRole.Trainer:
					EnableLimitedFunctionsForTrainer(activeTable);
					break;
				case UserRole.Participant:
					EnableLimitedFunctionsForParticipant(activeTable);
					break;
				default:
					break;
			}
		}

		private void EnableLimitedFunctionsForTechnicalStaff()
		{
			змаганняToolStripMenuItem.Enabled = false;
			участьВЗмагнняхToolStripMenuItem.Enabled = false;
			учасникиЗмаганьToolStripMenuItem.Enabled = false;
			членствоВКлубіToolStripMenuItem.Enabled = false;
			тренериToolStripMenuItem.Enabled = false;
			тренуванняToolStripMenuItem.Enabled = false;
			розкладДляУчасниківToolStripMenuItem.Enabled = false;
			загальнаКількістьЧленівКлубуToolStripMenuItem.Enabled = false;
			розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem.Enabled = false;
			розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1.Enabled = false;
			звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem.Enabled = false;
		}

		private void EnableLimitedFunctionsForTrainer(string activeTable)
		{
			обслуговуванняЯхтToolStripMenuItem.Enabled = false;
			членствоВКлубіToolStripMenuItem.Enabled = false;
			switch (activeTable)
			{
				case "yacht":
					додатиToolStripMenuItem.Enabled = false;
					змінитиToolStripMenuItem.Enabled = false;
					видалитиToolStripMenuItem.Enabled = false;
					break;
				case "competition":
					додатиToolStripMenuItem.Enabled = false;
					змінитиToolStripMenuItem.Enabled = false;
					видалитиToolStripMenuItem.Enabled = false;
					break;
				case "service":
					додатиToolStripMenuItem.Enabled = false;
					змінитиToolStripMenuItem.Enabled = false;
					видалитиToolStripMenuItem.Enabled = false;
					break;
				case "trainer":
					додатиToolStripMenuItem.Enabled = false;
					змінитиToolStripMenuItem.Enabled = false;
					видалитиToolStripMenuItem.Enabled = false;
					break;
				default:
					break;
			}
			статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem.Enabled = false;
			статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem.Enabled = false;
			загальнаКількістьЧленівКлубуToolStripMenuItem.Enabled = false;
			загальнаСтатистикаПроКількістьЯхтToolStripMenuItem.Enabled = false;
			звітПроСтанОбладнанняToolStripMenuItem.Enabled = false;
		}

		private void EnableLimitedFunctionsForParticipant(string activeTable)
		{
			обслуговуванняЯхтToolStripMenuItem.Enabled = false;
			розкладДляУчасниківToolStripMenuItem.Enabled = false;
			switch (activeTable)
			{
				case "yacht":
					додатиToolStripMenuItem.Enabled = false;
					змінитиToolStripMenuItem.Enabled = false;
					видалитиToolStripMenuItem.Enabled = false;
					break;
				case "service":
					додатиToolStripMenuItem.Enabled = false;
					змінитиToolStripMenuItem.Enabled = false;
					видалитиToolStripMenuItem.Enabled = false;
					break;
				case "competition":
					додатиToolStripMenuItem.Enabled = false;
					змінитиToolStripMenuItem.Enabled = false;
					видалитиToolStripMenuItem.Enabled = false;
					break;
				case "participant":
					додатиToolStripMenuItem.Enabled = false;
					змінитиToolStripMenuItem.Enabled = false;
					видалитиToolStripMenuItem.Enabled = false;
					break;
				case "trainer":
					додатиToolStripMenuItem.Enabled = false;
					змінитиToolStripMenuItem.Enabled = false;
					видалитиToolStripMenuItem.Enabled = false;
					break;
				default:
					break;
			}
			статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem.Enabled = false;
			статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem.Enabled = false;
			розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem.Enabled = false;
			звітПроСтанОбладнанняToolStripMenuItem.Enabled = false;
		}

		private bool edit;
		private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (activeTable)
			{
				case "yacht":
					edit = false;
					var edt = new EditYachtForm();
					edt.ShowDialog();
					if (edt.ShowDialog() == DialogResult.OK)
					{
						yachtTableAdapter.Fill(yacht_clubDataSet.Yacht);
						yacht_clubDataSet.AcceptChanges();
						яхтиToolStripMenuItem_Click(this, EventArgs.Empty);
						MessageBox.Show("Запис успішно додано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					break;

				case "service":
					edit = false;
					var edt2 = new EditService();
					edt2.ShowDialog();
					if (edt2.ShowDialog() == DialogResult.OK)
					{
						serviceTableAdapter.Fill(yacht_clubDataSet.Service);
						yacht_clubDataSet.AcceptChanges();
						обслуговуванняЯхтToolStripMenuItem_Click(this, EventArgs.Empty);
						MessageBox.Show("Запис успішно додано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}					
					break;

				case "participant":
					edit = false;
					var edt3 = new EditParticipant();
					edt3.ShowDialog();
					if (edt3.ShowDialog() == DialogResult.OK)
					{
						participantTableAdapter.Fill(yacht_clubDataSet.Participant);
						yacht_clubDataSet.AcceptChanges();
						учасникиЗмаганьToolStripMenuItem_Click(this, EventArgs.Empty);
						MessageBox.Show("Запис успішно додано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					break;

				case "training":
					edit = false;
					var edt4 = new EditTraining();
					edt4.ShowDialog();
					MessageBox.Show("Запис успішно додано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
					trainingTableAdapter.Fill(yacht_clubDataSet.Training);
					yacht_clubDataSet.AcceptChanges();
					тренуванняToolStripMenuItem_Click(this, EventArgs.Empty);
					break;

				case "competition":
					edit = false;
					var edt6 = new EditCompetition();
					if (edt6.ShowDialog() == DialogResult.OK)
					{
						competitionTableAdapter.Fill(yacht_clubDataSet.Competition);
						yacht_clubDataSet.AcceptChanges();
						змаганняToolStripMenuItem_Click(this, EventArgs.Empty);
						MessageBox.Show("Запис успішно додано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					break;


				default:
					edit = false;
					var edt5 = new EditYachtForm();
					edt5.ShowDialog();
					if (edt5.ShowDialog() == DialogResult.OK)
					{
						yachtTableAdapter.Fill(yacht_clubDataSet.Yacht);
						yacht_clubDataSet.AcceptChanges();
						яхтиToolStripMenuItem_Click(this, EventArgs.Empty);
						MessageBox.Show("Запис успішно додано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					break;
			}
		}

		private void змінитиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (activeTable)
			{
				case "yacht":
					edit = true;
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для редагування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						int selectedYachtId = Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value);
						var yachtDataRow = yacht_clubDataSet.Yacht.FindByyacht_id(selectedYachtId);
						if (yachtDataRow != null)
						{
							var edt = new EditYachtForm(
								yachtDataRow.yacht_id,
								yachtDataRow.model,
								yachtDataRow.yacht_type,
								yachtDataRow.condition,
								yachtDataRow.manufacturing_year,
								yachtDataRow.rental_cost
							);
							edt.ShowDialog();
							if (edt.ShowDialog() == DialogResult.OK)
							{
								yachtTableAdapter.Fill(yacht_clubDataSet.Yacht);
								yacht_clubDataSet.AcceptChanges();
								яхтиToolStripMenuItem_Click(this, EventArgs.Empty);
								MessageBox.Show("Запис успішно відредаговано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
					break;

				case "service":
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для редагування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						edit = true;
						int selectedServiceId = Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value);
						var serviceDataRow = yacht_clubDataSet.Service.FindByservice_id(selectedServiceId);
						if (serviceDataRow != null)
						{
							var edt = new EditService(
								serviceDataRow.service_id,
								serviceDataRow.yacht_id,
								serviceDataRow.start_date,
								serviceDataRow.end_date,
								serviceDataRow.work_type,
								serviceDataRow.cost,
								serviceDataRow.specialist
							);
							edt.ShowDialog();
							if (edt.ShowDialog() == DialogResult.OK)
							{
								serviceTableAdapter.Fill(yacht_clubDataSet.Service);
								yacht_clubDataSet.AcceptChanges();
								обслуговуванняЯхтToolStripMenuItem_Click(this, EventArgs.Empty);
								MessageBox.Show("Запис успішно відредаговано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
					break;

				case "participant":
					edit = true;
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для редагування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						int selectedParticipantId = Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value);
						var participantDataRow = yacht_clubDataSet.Participant.FindByparticipant_id(selectedParticipantId);
						if (participantDataRow != null)
						{
							var edt4 = new EditParticipant(
								participantDataRow.participant_id,
								participantDataRow.full_name,
								participantDataRow.birth_date,
								participantDataRow.gender,
								participantDataRow.phone_number,
								participantDataRow.email
							);
							edt4.ShowDialog();
							if (edt4.ShowDialog() == DialogResult.OK)
							{
								participantTableAdapter.Fill(yacht_clubDataSet.Participant);
								yacht_clubDataSet.AcceptChanges();
								учасникиЗмаганьToolStripMenuItem_Click(this, EventArgs.Empty);
								MessageBox.Show("Запис успішно відредаговано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
					break;

				case "competition":
					edit = true;
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для редагування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						int selectedCompetitionId = Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value);
						var competitionDataRow = yacht_clubDataSet.Competition.FindBycompetition_id(selectedCompetitionId);
						if (competitionDataRow != null)
						{
							var edt6 = new EditCompetition(
								competitionDataRow.competition_id,
								competitionDataRow.name,
								competitionDataRow.date,
								competitionDataRow.time,
								competitionDataRow.location,
								competitionDataRow.type
							);
							if (edt6.ShowDialog() == DialogResult.OK)
							{
								competitionTableAdapter.Fill(yacht_clubDataSet.Competition);
								yacht_clubDataSet.AcceptChanges();
								змаганняToolStripMenuItem_Click(this, EventArgs.Empty);
								MessageBox.Show("Запис успішно відредаговано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
					break;

				default:
					edit = true;
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для редагування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						int selectedYachtId = Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value);
						var yachtDataRow = yacht_clubDataSet.Yacht.FindByyacht_id(selectedYachtId);
						if (yachtDataRow != null)
						{
							var edt = new EditYachtForm(
								yachtDataRow.yacht_id,
								yachtDataRow.model,
								yachtDataRow.yacht_type,
								yachtDataRow.condition,
								yachtDataRow.manufacturing_year,
								yachtDataRow.rental_cost
							);
							edt.ShowDialog();
							if (edt.ShowDialog() == DialogResult.OK)
							{
								yachtTableAdapter.Fill(yacht_clubDataSet.Yacht);
								yacht_clubDataSet.AcceptChanges();
								яхтиToolStripMenuItem_Click(this, EventArgs.Empty);
								MessageBox.Show("Запис успішно відредаговано.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
					break;

			}
		}

		private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch (activeTable)
			{
				case "yacht":
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						DialogResult result = MessageBox.Show("Ви точно бажаєте видалити цей рядок?", "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (result == DialogResult.Yes)
						{
							yachtTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value));
							yachtTableAdapter.Fill(yacht_clubDataSet.Yacht);
							yacht_clubDataSet.AcceptChanges();
							яхтиToolStripMenuItem_Click(this, EventArgs.Empty);
							MessageBox.Show("Запис успішно видалено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							return;
						}		
					}
					break;

				case "service":
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						DialogResult result = MessageBox.Show("Ви точно бажаєте видалити цей рядок?", "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (result == DialogResult.Yes)
						{
							serviceTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value));
							serviceTableAdapter.Fill(yacht_clubDataSet.Service);
							yacht_clubDataSet.AcceptChanges();
							обслуговуванняЯхтToolStripMenuItem_Click(this, EventArgs.Empty);
							MessageBox.Show("Запис успішно видалено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							return;
						}
					}
					break;

				case "participant":
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						DialogResult result = MessageBox.Show("Ви точно бажаєте видалити цей рядок?", "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (result == DialogResult.Yes)
						{
							participantTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value));
							participantTableAdapter.Fill(yacht_clubDataSet.Participant);
							yacht_clubDataSet.AcceptChanges();
							учасникиЗмаганьToolStripMenuItem_Click(this, EventArgs.Empty);
							MessageBox.Show("Запис успішно видалено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							return;
						}
					}
					break;

				case "competition":
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						DialogResult result = MessageBox.Show("Ви точно бажаєте видалити цей рядок?", "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (result == DialogResult.Yes)
						{
							int competitionId = Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value);
							int isNull = 0;
							competitionTableAdapter.DeleteQuery(competitionId,isNull, null, isNull, null, isNull, null, isNull, null, isNull, null);
							competitionTableAdapter.Fill(yacht_clubDataSet.Competition);
							yacht_clubDataSet.AcceptChanges();
							змаганняToolStripMenuItem_Click(this, EventArgs.Empty);
							MessageBox.Show("Запис успішно видалено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					break;

				default:
					if (dataGridView8.SelectedRows.Count == 0)
					{
						MessageBox.Show("Будь ласка, оберіть рядок для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						DialogResult result = MessageBox.Show("Ви точно бажаєте видалити цей рядок?", "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (result == DialogResult.Yes)
						{
							yachtTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView8.SelectedRows[0].Cells[0].Value));
							yachtTableAdapter.Fill(yacht_clubDataSet.Yacht);
							yacht_clubDataSet.AcceptChanges();
							яхтиToolStripMenuItem_Click(this, EventArgs.Empty);
							MessageBox.Show("Запис успішно видалено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							return;
						}
					}
					break;

			}
		}

		private void редакторЗапросівToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var qe = new QueryEdit();
			qe.Show();
		}

		private void загальнаСтатистикаПроКількістьЯхтToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True";
			string query = @"SELECT manufacturing_year AS 'Рік виготовлення', COUNT(*) AS 'Кількість яхт' FROM Yacht GROUP BY manufacturing_year;";
			string countQuery = @"SELECT COUNT(*) FROM Yacht;";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dataGridView8.DataSource = dt;
				}
				using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
				{
					conn.Open();
					int totalYachts = (int)countCmd.ExecuteScalar();
					conn.Close();

                    labelTotalMembers.Visible = true;
                    labelTotalMembers.Text = "Загальна кількість яхт: " + totalYachts;
					label2.Visible = true;
                    label2.Text = "Загальна Статистика Про Кількість Яхт";
					textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = btnSortAscending.Visible = btnSortDescending.Visible = btnImportParticipants.Visible = false;
                    ResetSortingMode();
                }
            }
		}

		private void загальнаКількістьЧленівКлубуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True";
			string query = @"SELECT p.full_name AS 'ПІБ', p.birth_date AS 'Дата народження', p.gender AS 'Стать', p.phone_number AS 'Номер телефону', p.email AS 'Електронна пошта'
                     FROM Participant p
                     INNER JOIN ClubMembership cm ON p.participant_id = cm.participant_id;";
			string countQuery = @"SELECT COUNT(*) FROM ClubMembership;"; // Запит для отримання загальної кількості членів клубу

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dataGridView8.DataSource = dt;
				}

				using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
				{
					conn.Open();
					int totalMembers = (int)countCmd.ExecuteScalar();
					conn.Close();

					labelTotalMembers.Text = "Загальна кількість членів клубу: " + totalMembers;
					labelTotalMembers.Visible = true;
                    ResetSortingMode();
                    label2.Visible = true;
                    label2.Text = "Загальна Статистика Про Кількість Членів Клубу";
                    textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = btnSortAscending.Visible = btnSortDescending.Visible = btnImportParticipants.Visible = false;
                }
            }
		}

		private void розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True";
			string query = @"SELECT T.full_name AS 'ПІБ тренера', COUNT(Tr.training_id) AS 'Кількість тренувань за місяць', SUM(Tr.cost) AS 'Сума заробленого за місяць' FROM Trainer T
				JOIN Training Tr ON T.trainer_id = Tr.trainer_id
				WHERE YEAR(Tr.date) = YEAR(GETDATE()) AND MONTH(Tr.date) = MONTH(GETDATE())
				GROUP BY T.full_name;";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dataGridView8.DataSource = dt;
				}
			}
			labelTotalMembers.Visible = false;
            ResetSortingMode();
            label2.Visible = true;
            label2.Text = "Заробітня Плата Тренера За Поточний Місяць";
            textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = btnSortAscending.Visible = btnSortDescending.Visible = btnImportParticipants.Visible = false;
        }

        private void статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True";
			string query = @"SELECT y.model AS 'Модель', y.yacht_type AS 'Тип', y.manufacturing_year AS 'Рік виготовлення', ISNULL(tr.TrainingCount, 0) AS 'Кількість використаннь для тренувань', ISNULL(p.ParticipationCount, 0) AS 'Кількість використаннь для змагань' FROM Yacht y
				LEFT JOIN (SELECT yacht_id, COUNT(*) AS 'TrainingCount' FROM Training 
				WHERE MONTH(date) = MONTH(GETDATE()) AND YEAR(date) = YEAR(GETDATE())
				GROUP BY yacht_id) tr ON y.yacht_id = tr.yacht_id
				LEFT JOIN (SELECT Participation.yacht_id, COUNT(*) AS 'ParticipationCount' FROM Participation 
				INNER JOIN Competition ON Participation.competition_id = Competition.competition_id
				WHERE MONTH(Competition.date) = MONTH(GETDATE()) AND YEAR(Competition.date) = YEAR(GETDATE())
				GROUP BY Participation.yacht_id) p ON y.yacht_id = p.yacht_id;";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dataGridView8.DataSource = dt;
				}
			}
			labelTotalMembers.Visible = false;
            ResetSortingMode();
            label2.Visible = true;
            label2.Text = "Статистика Використання Яхт За Поточний Місяць";
            textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = btnSortAscending.Visible = btnSortDescending.Visible = btnImportParticipants.Visible = false;
        }

        private void розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True";
			string query = @"SELECT T.full_name AS 'ПІБ тренера', COUNT(Tr.training_id) AS 'Кількість тренувань за місяць', SUM(Tr.cost) AS 'Сума заробленого за місяць' FROM Trainer T
				JOIN Training Tr ON T.trainer_id = Tr.trainer_id
				WHERE MONTH(tr.date) = MONTH(DATEADD(month, -1, GETDATE())) AND YEAR(tr.date) = YEAR(DATEADD(month, -1, GETDATE()))
				GROUP BY T.full_name;";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dataGridView8.DataSource = dt;
				}
			}
			labelTotalMembers.Visible = false;
            ResetSortingMode();
            label2.Visible = true;
            label2.Text = "Заробітня Плата Тренера За Минулий Місяць";
            textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = btnSortAscending.Visible = btnSortDescending.Visible = btnImportParticipants.Visible = false;
        }

        private void статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True";
			string query = @"SELECT y.model AS 'Модель', y.yacht_type AS 'Тип', y.manufacturing_year AS 'Рік виготовлення', ISNULL(tr.TrainingCount, 0) AS 'Кількість використаннь для тренувань', ISNULL(p.ParticipationCount, 0) AS 'Кількість використаннь для змагань' FROM Yacht y
				LEFT JOIN (SELECT yacht_id, COUNT(*) AS 'TrainingCount' FROM Training 
				WHERE MONTH(date) = MONTH(DATEADD(month, -1, GETDATE())) AND YEAR(date) = YEAR(DATEADD(month, -1, GETDATE()))
				GROUP BY yacht_id) tr ON y.yacht_id = tr.yacht_id
				LEFT JOIN (SELECT Participation.yacht_id, COUNT(*) AS 'ParticipationCount' FROM Participation 
				INNER JOIN Competition ON Participation.competition_id = Competition.competition_id
				WHERE MONTH(Competition.date) = MONTH(DATEADD(month, -1, GETDATE())) AND YEAR(Competition.date) = YEAR(DATEADD(month, -1, GETDATE()))
				GROUP BY Participation.yacht_id) p ON y.yacht_id = p.yacht_id;";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dataGridView8.DataSource = dt;
				}
			}
			labelTotalMembers.Visible = false;
            ResetSortingMode();
            label2.Visible = true;
            label2.Text = "Статистика Використання Яхт За Минулий Місяць";
            textBoxSearch.Visible = btnSearch.Visible = btnFilter.Visible = btnSortAscending.Visible = btnSortDescending.Visible = btnImportParticipants.Visible = false;
        }

        private void btnImportParticipants_Click(object sender, EventArgs e)
		{
			var importer = new ExcelImporter();
			var databaseManager = new DatabaseManager();

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;
				List<Participant> participants = importer.ImportParticipants(filePath);
				databaseManager.InsertParticipants(participants);
				учасникиЗмаганьToolStripMenuItem_Click(this, EventArgs.Empty);
			}
		}

		private void звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReportForm reportForm = new ReportForm();
			reportForm.Show();
		}

		private void звітПроСтанОбладнанняToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReportForm2 reportForm = new ReportForm2();
			reportForm.Show();
		}

		private void InitializeColumnMappings()
		{
			if (columnMappings == null)
				columnMappings = new Dictionary<string, string>();

			columnMappings.Clear();

			columnMappings.Add("Модель", "model");
			columnMappings.Add("Модель яхти", "Y.model");
			columnMappings.Add("Тип яхти", "yacht_type");
			columnMappings.Add("Стан", "condition");
			columnMappings.Add("Вартість оренди", "rental_cost");
			columnMappings.Add("ID обслуговування", "service_id");
			columnMappings.Add("Дата початку обслуговування", "start_date");
			columnMappings.Add("Дата завершення обслуговування", "end_date");
			columnMappings.Add("Тип роботи", "work_type");
			columnMappings.Add("Вартість", "cost");
			columnMappings.Add("Спеціаліст", "specialist");
			columnMappings.Add("Назва", "name");
			columnMappings.Add("Дата проведення", "date");
			columnMappings.Add("Час початку", "time");
			columnMappings.Add("Місце проведення", "location");
			columnMappings.Add("Тип змагання", "type");
			columnMappings.Add("Учасник", "PT.full_name");
			columnMappings.Add("Тренер", "TR.full_name");
			columnMappings.Add("Яхта", "Y.model");
			columnMappings.Add("Результат", "result");
			columnMappings.Add("Член клубу", "PT.full_name");
			columnMappings.Add("Змагання", "C.name");
			columnMappings.Add("Дата вступу до клубу", "join_date");
			columnMappings.Add("ПІБ", "full_name");
			columnMappings.Add("Повне ім'я", "T.full_name");
			columnMappings.Add("Дата народження", "birth_date");
			columnMappings.Add("Стать", "gender");
			columnMappings.Add("Номер телефону", "phone_number");
			columnMappings.Add("Електронна пошта", "email");
			columnMappings.Add("Досвід", "experience");
			columnMappings.Add("Спеціалізація", "specialization");
			columnMappings.Add("Дата", "date");
			columnMappings.Add("Час завершення", "end_time");
		}

		private string selectedColumnName = string.Empty;
		private Dictionary<string, string> columnMappings;

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string searchText = textBoxSearch.Text;
			string query = "";
			if (!string.IsNullOrEmpty(selectedColumnName))
			{
				switch (activeTable)
				{
					case "yacht":
						query = $"SELECT yacht_id, model AS 'Модель', yacht_type AS 'Тип яхти', condition AS 'Стан', manufacturing_year AS 'Рік виготовлення', rental_cost AS 'Вартість оренди' FROM Yacht WHERE {selectedColumnName} LIKE '%{searchText}%'";
						break;
					case "service":
						query = $"SELECT Y.model AS 'Модель яхти', S.start_date AS 'Дата початку обслуговування', S.end_date AS 'Дата завершення обслуговування', S.work_type AS 'Тип роботи', S.cost AS 'Вартість', S.specialist AS 'Спеціаліст' FROM Service S JOIN Yacht Y ON S.yacht_id = Y.yacht_id WHERE {selectedColumnName} LIKE '%{searchText}%'";
						break;
					case "competition":
						query = $"SELECT competition_id, name AS 'Назва', date AS 'Дата проведення', time AS 'Час початку', location AS 'Місце проведення', type AS 'Тип змагання' FROM Competition WHERE {selectedColumnName} LIKE '%{searchText}%';";
						break;
					case "participant":
						query = $"SELECT participant_id, full_name AS 'ПІБ', birth_date AS 'Дата народження', gender AS 'Стать', phone_number AS 'Номер телефону', email AS 'Електронна пошта' FROM Participant WHERE {selectedColumnName} LIKE '%{searchText}%';";
						break;
					case "participation":
						query = $"SELECT P.participation_id, C.name AS 'Змагання', PT.full_name AS 'Учасник', Y.model AS 'Яхта', P.result AS 'Результат' FROM Participation P JOIN Competition C ON P.competition_id = C.competition_id JOIN Participant PT ON P.participant_id = PT.participant_id JOIN Yacht Y ON P.yacht_id = Y.yacht_id WHERE {selectedColumnName} LIKE '%{searchText}%';";
						break;
					case "membership":
						query = $"SELECT CM.membership_id, PT.full_name AS 'Член клубу', CM.join_date AS 'Дата вступу до клубу' FROM ClubMembership CM JOIN Participant PT ON CM.participant_id = PT.participant_id WHERE [{selectedColumnName}] LIKE '%{searchText}%';";
						break;
					case "trainer":
						query = $"SELECT trainer_id, full_name AS 'ПІБ', birth_date AS 'Дата народження', gender AS 'Стать', phone_number AS 'Номер телефону', email AS 'Електронна пошта', experience AS 'Досвід', specialization AS 'Спеціалізація' FROM Trainer WHERE {selectedColumnName} LIKE '%{searchText}%';";
						break;
					case "training":
						query = $"SELECT T.training_id, PT.full_name AS 'Учасник', TR.full_name AS 'Тренер', Y.model AS 'Яхта', T.date AS 'Дата', T.start_time AS 'Час початку', T.end_time AS 'Час завершення', T.cost AS 'Вартість' FROM Training T JOIN Participant PT ON T.participant_id = PT.participant_id JOIN Trainer TR ON T.trainer_id = TR.trainer_id JOIN Yacht Y ON T.yacht_id = Y.yacht_id WHERE {selectedColumnName} LIKE '%{searchText}%';";
						break;
					default:
						query = $"SELECT * FROM Yacht WHERE [{selectedColumnName}] LIKE '%{searchText}%'";
						break;
				}
			}
			else
			{
				switch (activeTable)
				{
					case "yacht":
						query = $"SELECT yacht_id, model AS 'Модель', yacht_type AS 'Тип яхти', condition AS 'Стан', manufacturing_year AS 'Рік виготовлення', rental_cost AS 'Вартість оренди' FROM Yacht WHERE model LIKE '%{searchText}%' OR yacht_type LIKE '%{searchText}%' OR condition LIKE '%{searchText}%' OR manufacturing_year LIKE '%{searchText}%' OR rental_cost LIKE '%{searchText}%';";
						break;
					case "service":
						query = $"SELECT Y.model AS 'Модель яхти', S.start_date AS 'Дата початку обслуговування', S.end_date AS 'Дата завершення обслуговування', S.work_type AS 'Тип роботи', S.cost AS 'Вартість', S.specialist AS 'Спеціаліст' FROM Service S JOIN Yacht Y ON S.yacht_id = Y.yacht_id WHERE Y.model LIKE '%{searchText}%' OR S.start_date LIKE '%{searchText}%' OR S.end_date LIKE '%{searchText}%' OR S.work_type LIKE '%{searchText}%' OR S.cost LIKE '%{searchText}%' OR S.specialist LIKE '%{searchText}%';";
						break;
					case "competition":
						query = $"SELECT competition_id, name AS 'Назва', date AS 'Дата проведення', time AS 'Час початку', location AS 'Місце проведення', type AS 'Тип змагання' FROM Competition WHERE name LIKE '%{searchText}%' OR date LIKE '%{searchText}%' OR time LIKE '%{searchText}%' OR location LIKE '%{searchText}%' OR type LIKE '%{searchText}%';";
						break;
					case "participant":
						query = $"SELECT participant_id, full_name AS 'ПІБ', birth_date AS 'Дата народження', gender AS 'Стать', phone_number AS 'Номер телефону', email AS 'Електронна пошта' FROM Participant WHERE full_name LIKE '%{searchText}%' OR birth_date LIKE '%{searchText}%' OR gender LIKE '%{searchText}%' OR phone_number LIKE '%{searchText}%' OR email LIKE '%{searchText}%';";
						break;
					case "participation":
						query = $"SELECT P.participation_id, C.name AS 'Змагання', PT.full_name AS 'Учасник', Y.model AS 'Яхта', P.result AS 'Результат' FROM Participation P JOIN Competition C ON P.competition_id = C.competition_id JOIN Participant PT ON P.participant_id = PT.participant_id JOIN Yacht Y ON P.yacht_id = Y.yacht_id WHERE C.name LIKE '%{searchText}%' OR PT.full_name LIKE '%{searchText}%' OR Y.model LIKE '%{searchText}%' OR P.result LIKE '%{searchText}%';";
						break;
					case "membership":
						query = $"SELECT CM.membership_id, PT.full_name AS 'Член клубу', CM.join_date AS 'Дата вступу до клубу' FROM ClubMembership CM JOIN Participant PT ON CM.participant_id = PT.participant_id WHERE PT.full_name LIKE '%{searchText}%' OR CM.join_date LIKE '%{searchText}%';";
						break;
					case "trainer":
						query = $"SELECT trainer_id, full_name AS 'ПІБ', birth_date AS 'Дата народження', gender AS 'Стать', phone_number AS 'Номер телефону', email AS 'Електронна пошта', experience AS 'Досвід', specialization AS 'Спеціалізація' FROM Trainer WHERE full_name LIKE '%{searchText}%' OR birth_date LIKE '%{searchText}%' OR gender LIKE '%{searchText}%' OR phone_number LIKE '%{searchText}%' OR email LIKE '%{searchText}%' OR experience LIKE '%{searchText}%' OR specialization LIKE '%{searchText}%';";
						break;
					case "training":
						query = $"SELECT T.training_id, PT.full_name AS 'Учасник', TR.full_name AS 'Тренер', Y.model AS 'Яхта', T.date AS 'Дата', T.start_time AS 'Час початку', T.end_time AS 'Час завершення', T.cost AS 'Вартість' FROM Training T JOIN Participant PT ON T.participant_id = PT.participant_id JOIN Trainer TR ON T.trainer_id = TR.trainer_id JOIN Yacht Y ON T.yacht_id = Y.yacht_id WHERE PT.full_name LIKE '%{searchText}%' OR TR.full_name LIKE '%{searchText}%' OR Y.model LIKE '%{searchText}%' OR T.date LIKE '%{searchText}%' OR T.start_time LIKE '%{searchText}%' OR T.end_time LIKE '%{searchText}%' OR T.cost LIKE '%{searchText}%';";
						break;
					default:
						query = $"SELECT yacht_id, model AS 'Модель', yacht_type AS 'Тип яхти', condition AS 'Стан', manufacturing_year AS 'Рік виготовлення', rental_cost AS 'Вартість оренди' FROM Yacht WHERE model LIKE '%{searchText}%' OR yacht_type LIKE '%{searchText}%' OR condition LIKE '%{searchText}%' OR manufacturing_year LIKE '%{searchText}%' OR rental_cost LIKE '%{searchText}%';";
						break;
				}
			}
			//MessageBox.Show(query, "SQL Query");
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
		}

		private void Form1_DoubleClick(object sender, EventArgs e)
		{
			string query = "";

			switch (activeTable)
			{
				case "yacht":
					query = "SELECT yacht_id, model AS \"Модель\", yacht_type AS \"Тип яхти\", condition AS \"Стан\", manufacturing_year AS \"Рік виготовлення\", rental_cost AS \"Вартість оренди\" FROM Yacht;";
					break;
				case "service":
					query = "SELECT S.service_id, Y.model AS \"Модель яхти\", S.start_date AS \"Дата початку обслуговування\", S.end_date AS \"Дата завершення обслуговування\", S.work_type AS \"Тип роботи\", S.cost AS \"Вартість\", S.specialist AS \"Спеціаліст\" FROM Service S\r\nJOIN Yacht Y ON S.yacht_id = Y.yacht_id;";
					break;
				case "competition":
					query = "SELECT competition_id, name AS \"Назва\", date AS \"Дата проведення\", time AS \"Час початку\", location AS \"Місце проведення\", type AS \"Тип змагання\" FROM Competition;";
					break;
				case "participation":
					query = "SELECT participation_id, C.name AS \"Змагання\",PT.full_name AS \"Учасник\", Y.model AS \"Яхта\", P.result AS \"Результат\" FROM Participation P\r\nJOIN Competition C ON P.competition_id = C.competition_id\r\nJOIN Participant PT ON P.participant_id = PT.participant_id\r\nJOIN Yacht Y ON P.yacht_id = Y.yacht_id;";
					break;
				case "participant":
					query = "SELECT participant_id, full_name AS \"Ім'я\", birth_date AS \"Дата народження\", gender AS \"Стать\", phone_number AS \"Номер телефону\", email AS \"Електронна пошта\" FROM Participant;";
					break;
				case "membership":
					query = "SELECT membership_id, PT.full_name AS \"Член клубу\", CM.join_date AS \"Дата вступу до клубу\" FROM ClubMembership CM\r\nJOIN Participant PT ON CM.participant_id = PT.participant_id;";
					break;
				case "trainer":
					query = "SELECT trainer_id, full_name AS \"Повне ім'я\", birth_date AS \"Дата народження\", gender AS \"Стать\", phone_number AS \"Номер телефону\", email AS \"Електронна пошта\", experience AS \"Досвід\", specialization AS \"Спеціалізація\" FROM Trainer;";
					break;
				case "training":
					query = "SELECT training_id, PT.full_name AS \"Учасник\", TR.full_name AS \"Тренер\", Y.model AS \"Яхта\", T.date AS \"Дата\", T.start_time AS \"Час початку\", T.end_time AS \"Час завершення\", T.cost AS \"Вартість\" FROM Training T\r\nJOIN Participant PT ON T.participant_id = PT.participant_id\r\nJOIN Trainer TR ON T.trainer_id = TR.trainer_id\r\nJOIN Yacht Y ON T.yacht_id = Y.yacht_id;";
					break;
				default:
					query = "SELECT yacht_id, model AS \"Модель\", yacht_type AS \"Тип яхти\", condition AS \"Стан\", manufacturing_year AS \"Рік виготовлення\", rental_cost AS \"Вартість оренди\" FROM Yacht;";
					break;
			}
		
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			textBoxSearch.Text = "";
		}

		private int currentPosition = 0;
		private void btnFirst_Click(object sender, EventArgs e)
		{
			currentPosition = 0;
			UpdateDataGridView();
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			if (currentPosition > 0)
			{
				currentPosition--;
				UpdateDataGridView();
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (currentPosition < dataGridView8.Rows.Count - 1)
			{
				currentPosition++;
				UpdateDataGridView();
			}
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			currentPosition = dataGridView8.Rows.Count - 1;
			UpdateDataGridView();
		}

        private bool isUpdatingDataGridView = false;
        private void UpdateDataGridView()
		{
            ResetSortingMode();

            if (isUpdatingDataGridView)
                return;

            isUpdatingDataGridView = true;

            dataGridView8.ClearSelection();
            if (dataGridView8.Rows.Count > 0 && currentPosition < dataGridView8.Rows.Count)
            {
                dataGridView8.Rows[currentPosition].Selected = true;
                dataGridView8.FirstDisplayedScrollingRowIndex = currentPosition;
                textBoxCurrentPosition.Text = $"{currentPosition + 1} з {dataGridView8.Rows.Count}";
            }
            else
            {
                textBoxCurrentPosition.Text = $"0 з {dataGridView8.Rows.Count}";
            }

            isUpdatingDataGridView = false;
        }

		private void dataGridView8_SelectionChanged_1(object sender, EventArgs e)
		{
            if (isUpdatingDataGridView)
                return;

            if (dataGridView8.SelectedRows.Count > 0)
            {
                int index = dataGridView8.SelectedRows[0].Index;
                currentPosition = index;
                UpdateDataGridView();
            }
        }

        private DataGridViewColumn selectedColumn;

		private void dataGridView8_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            selectedColumn = dataGridView8.Columns[e.ColumnIndex];
            btnSortAscending.Visible = true;
            btnSortDescending.Visible = true;
			int columnIndex = e.ColumnIndex;
			selectedColumnName = dataGridView8.Columns[e.ColumnIndex].Name;

			foreach (DataGridViewColumn col in dataGridView8.Columns)
			{
				col.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(221, 242, 253);
			}

			dataGridView8.Columns[columnIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(155, 190, 200); ;

			string headerText = dataGridView8.Columns[e.ColumnIndex].HeaderText;

			if (columnMappings.TryGetValue(headerText, out string actualColumnName))
			{
				selectedColumnName = actualColumnName;
			}
			else
			{
				selectedColumnName = string.Empty; 
			}
		}

		private void btnSortAscending_Click(object sender, EventArgs e)
		{
            if (selectedColumn != null)
            {
                dataGridView8.Sort(selectedColumn, ListSortDirection.Ascending);
            }
        }

		private void btnSortDescending_Click(object sender, EventArgs e)
		{
            if (selectedColumn != null)
            {
                dataGridView8.Sort(selectedColumn, ListSortDirection.Descending);
            }
        }


		//Фільтрація
		private Dictionary<string, string> initialComboBoxValues = new Dictionary<string, string>();

		private void InitializeComboBoxValues()
		{
			initialComboBoxValues["comboBox1"] = comboBox1.SelectedItem?.ToString();
			initialComboBoxValues["comboBox2"] = comboBox2.SelectedItem?.ToString();
			initialComboBoxValues["comboBox3"] = comboBox2.SelectedItem?.ToString();
			initialComboBoxValues["comboBox4"] = comboBox2.SelectedItem?.ToString();
		}

		private Dictionary<string, DateTime> initialDateTimeValues = new Dictionary<string, DateTime>();

		private void InitializeDateTimePickerValues()
		{
			initialDateTimeValues["dateTimePicker1"] = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
			initialDateTimeValues["dateTimePicker2"] = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
			initialDateTimeValues["dateTimePicker3"] = new DateTime(dateTimePicker3.Value.Year, dateTimePicker3.Value.Month, dateTimePicker3.Value.Day);
			initialDateTimeValues["dateTimePicker4"] = new DateTime(dateTimePicker4.Value.Year, dateTimePicker4.Value.Month, dateTimePicker4.Value.Day);
		}

		private Dictionary<string, decimal> initialNumericValues = new Dictionary<string, decimal>();

		private void InitializeNumericValues()
		{
			initialNumericValues["numericUpDown1"] = numericUpDown1.Value; 
			initialNumericValues["numericUpDown2"] = numericUpDown2.Value;
		}


		private void btnCancelFilters_Click(object sender, EventArgs e)
		{
			// Очищення ComboBox
			comboBox1.SelectedIndex = -1;
			comboBox2.SelectedIndex = -1;
			comboBox3.SelectedIndex = -1;
			comboBox4.SelectedIndex = -1;

			// Скидання DateTimePicker до сьогоднішньої дати або іншої потрібної дати
			dateTimePicker1.Value = DateTime.Today;
			dateTimePicker2.Value = DateTime.Today;
			dateTimePicker3.Value = DateTime.Today;
			dateTimePicker4.Value = DateTime.Today;

			// Скидання NumericUpDown до початкового значення (може відрізнятися)
			numericUpDown1.Value = numericUpDown1.Minimum;
			numericUpDown2.Value = numericUpDown2.Minimum;

			// Очищення фільтрів
			if (!string.IsNullOrEmpty(activeTable) && FilterManager.SelectedFilters.ContainsKey(activeTable))
			{
				FilterManager.SelectedFilters[activeTable].Clear();
			}
			SelectedFilters.Clear();

			// Відображення базових даних
			string query = GetBaseQuery(activeTable);
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
			dataGridView8.Columns[0].Visible = false;
			textBoxSearch.Text = "";
		}

		private void btnFilterOk_Click(object sender, EventArgs e)
		{
			var currentTableFilters = new Dictionary<string, string>();
			CollectSelectedFilters(activeTable, currentTableFilters);

			var filterInfo = new StringBuilder("Current Table Filters:\n");
			foreach (var filter in currentTableFilters)
			{
				filterInfo.AppendLine($"{filter.Key}: {filter.Value}");
			}
			//MessageBox.Show(filterInfo.ToString(), "Debug - Current Table Filters");

			string applyingFilters = string.Join("\n", currentTableFilters.Select(f => $"{f.Key} = {f.Value}"));
			//MessageBox.Show($"Applying Filters:\n{applyingFilters}", "Applying Filters Debug");

			ApplyFilters(currentTableFilters);
		}

		private void CollectSelectedFilters(string activeTable, Dictionary<string, string> filters)
		{
			switch (activeTable)
			{
				case "yacht":
					AddComboBoxFilter(filters, comboBox1, "yacht_type");
					AddComboBoxFilter(filters, comboBox2, "condition");
					ProcessYearPickers(filters, dateTimePicker1, dateTimePicker2, "manufacturing_year");
					ProcessNumericUpDowns(filters, numericUpDown1, numericUpDown2, "rental_cost");
					break;

				case "service":
					AddComboBoxFilter(filters, comboBox1, "model");
					ProcessDateTimePickers(filters, dateTimePicker1, dateTimePicker2, "start_date");
					ProcessDateTimePickers(filters, dateTimePicker3, dateTimePicker4, "end_date");
					AddComboBoxFilter(filters, comboBox2, "work_type");
					ProcessNumericUpDowns(filters, numericUpDown1, numericUpDown2, "cost");
					AddComboBoxFilter(filters, comboBox3, "specialist");
					break;

				case "competition":
					ProcessDateTimePickers(filters, dateTimePicker1, dateTimePicker2, "date");
					AddComboBoxFilter(filters, comboBox1, "type");
					break;

				case "participant":
					ProcessDateTimePickers(filters, dateTimePicker1, dateTimePicker2, "birth_date");
					AddComboBoxFilter(filters, comboBox1, "gender");
					break;

				case "participation":
					AddComboBoxFilter(filters, comboBox1, "competition");
					AddComboBoxFilter(filters, comboBox2, "participant");
					AddComboBoxFilter(filters, comboBox3, "model");
					AddComboBoxFilter(filters, comboBox4, "result");
					break;

				case "membership":
					ProcessDateTimePickers(filters, dateTimePicker1, dateTimePicker2, "join_date");
					break;

				case "trainer":
					ProcessDateTimePickers(filters, dateTimePicker1, dateTimePicker2, "birth_date");
					AddComboBoxFilter(filters, comboBox1, "gender");
					ProcessNumericUpDowns(filters, numericUpDown1, numericUpDown2, "experience");
					AddComboBoxFilter(filters, comboBox2, "specialization");
					break;

				case "training":
					AddComboBoxFilter(filters, comboBox1, "participant");
					AddComboBoxFilter(filters, comboBox2, "trainer");
					AddComboBoxFilter(filters, comboBox3, "model");
					ProcessDateTimePickers(filters, dateTimePicker1, dateTimePicker2, "date");
					ProcessNumericUpDowns(filters, numericUpDown1, numericUpDown2, "cost");
					break;

				default:
					AddComboBoxFilter(filters, comboBox1, "yacht_type");
					AddComboBoxFilter(filters, comboBox2, "condition");
					ProcessYearPickers(filters, dateTimePicker1, dateTimePicker2, "manufacturing_year");
					ProcessNumericUpDowns(filters, numericUpDown1, numericUpDown2, "rental_cost");
					break;
			}
			if (!string.IsNullOrEmpty(activeTable))
			{
				if (FilterManager.SelectedFilters.ContainsKey(activeTable))
				{
					FilterManager.SelectedFilters[activeTable] = new Dictionary<string, string>(filters);
				}
				else
				{
					FilterManager.SelectedFilters.Add(activeTable, new Dictionary<string, string>(filters));
				}
			}
		}

		private void AddComboBoxFilter(Dictionary<string, string> filters, ComboBox comboBox, string filterName)
		{
			if (comboBox.Visible && comboBox.SelectedItem != null)
			{
				string initialValue = initialComboBoxValues.ContainsKey(comboBox.Name) ? initialComboBoxValues[comboBox.Name] : null;
				string currentValue = comboBox.SelectedItem?.ToString();

				//MessageBox.Show($"ComboBox: Initial value = {initialValue}, Current value = {currentValue}");

				if (!string.Equals(currentValue, initialValue))
				{
					filters[filterName] = currentValue;
					//MessageBox.Show($"Added to filters: {filterName} = {currentValue}");
				}
			}
		}

		private void ProcessDateTimePickers(Dictionary<string, string> filters, DateTimePicker picker1, DateTimePicker picker2, string filterName)
		{
			bool changed1 = picker1.Visible && initialDateTimeValues.ContainsKey(picker1.Name) && picker1.Value.Date != initialDateTimeValues[picker1.Name];
			bool changed2 = picker2.Visible && initialDateTimeValues.ContainsKey(picker2.Name) && picker2.Value.Date != initialDateTimeValues[picker2.Name];
			//MessageBox.Show($"DateTimePicker1: Changed = {changed1}, Initial value = {initialDateTimeValues[picker1.Name]}, Current value = {picker1.Value}");
			//MessageBox.Show($"DateTimePicker2: Changed = {changed2}, Initial value = {initialDateTimeValues[picker2.Name]}, Current value = {picker2.Value}");

			if (changed1 || changed2)
			{
				string value1 = changed1 ? picker1.Value.ToString("yyyy-MM-dd") : "";
				string value2 = changed2 ? picker2.Value.ToString("yyyy-MM-dd") : "";
				filters[filterName] = $"{value1}|{value2}";
			}
		}

		private void ProcessNumericUpDowns(Dictionary<string, string> filters, NumericUpDown numeric1, NumericUpDown numeric2, string filterName)
		{
			bool changed1 = numeric1.Visible && initialNumericValues.ContainsKey(numeric1.Name) && numeric1.Value != initialNumericValues[numeric1.Name];
			bool changed2 = numeric2.Visible && initialNumericValues.ContainsKey(numeric2.Name) && numeric2.Value != initialNumericValues[numeric2.Name];

			//MessageBox.Show($"NumericUpDown1: Changed = {changed1}, Initial value = {initialNumericValues[numeric1.Name]}, Current value = {numeric1.Value}");
			//MessageBox.Show($"NumericUpDown2: Changed = {changed2}, Initial value = {initialNumericValues[numeric2.Name]}, Current value = {numeric2.Value}");

			if (changed1 || changed2)
			{
				string value1 = changed1 ? numeric1.Value.ToString() : "";
				string value2 = changed2 ? numeric2.Value.ToString() : "";
				filters[filterName] = $"{value1}|{value2}";
			}
		}


		private void ProcessYearPickers(Dictionary<string, string> filters, DateTimePicker picker1, DateTimePicker picker2, string filterName)
		{
			bool changed1 = picker1.Visible && initialDateTimeValues.ContainsKey(picker1.Name) && picker1.Value.Year != initialDateTimeValues[picker1.Name].Year;
			bool changed2 = picker2.Visible && initialDateTimeValues.ContainsKey(picker2.Name) && picker2.Value.Year != initialDateTimeValues[picker2.Name].Year;

			//MessageBox.Show($"DateTimePicker1: Changed = {changed1}, Initial value = {initialDateTimeValues[picker1.Name]}, Current value = {picker1.Value}");
			//MessageBox.Show($"DateTimePicker2: Changed = {changed2}, Initial value = {initialDateTimeValues[picker2.Name]}, Current value = {picker2.Value}");


			if (changed1 || changed2)
			{
				string year1 = changed1 ? picker1.Value.ToString("yyyy") : "";
				string year2 = changed2 ? picker2.Value.ToString("yyyy") : "";
				filters[filterName] = $"{year1}|{year2}";
			}
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			this.Width = 1000;
			panelSideBar.Visible = true;
			SelectedFilters = new Dictionary<string, string>();
			var currentTableFilters = new Dictionary<string, string>();

			InitializeComboBoxValues();
			InitializeDateTimePickerValues();
			InitializeNumericValues();
			if (!string.IsNullOrEmpty(activeTable) && FilterManager.SelectedFilters.ContainsKey(activeTable))
			{
				SelectedFilters = FilterManager.SelectedFilters[activeTable];
				LoadSelectedFilters();

				var loadedFiltersInfo = new StringBuilder($"Loaded Filters for '{activeTable}':\n");
				foreach (var filter in SelectedFilters)
				{
					loadedFiltersInfo.AppendLine($"  Filter: {filter.Key}, Value: {filter.Value}");
				}
				//MessageBox.Show(loadedFiltersInfo.ToString(), "Loaded Filters");
			}
			else
			{
				SelectedFilters = new Dictionary<string, string>();
			}
			SetupFilters(activeTable);
			LoadSelectedFilters();
			panelSideBar.Visible = true;
		}

		private void SetupFilters(string activeTable)
		{
			HideAllFilters();

			switch (activeTable)
			{
				case "yacht":
					label_FC1.Text = "Тип:";
					label_FC2.Text = "Стан:";
					label_FD1.Text = "Рік виготовлення:";
					label_FN1.Text = "Вартість оренди:";
					SetupComboBox(comboBox1, label_FC1, GetDataForComboBox("yacht_type", "Yacht"), "yacht_type");
					SetupComboBox(comboBox2, label_FC2, GetDataForComboBox("condition", "Yacht"), "condition");
					SetupYearFilter(label_FD1, dateTimePicker1, dateTimePicker2, panel1, "Рік виготовлення", "manufacturing_year");
					SetupNumericIntervalFilter(label_FN1, numericUpDown1, numericUpDown2, panelN, "Вартість оренди", "rental_cost");
					break;
				case "service":
					label_FC1.Text = "Модель яхти:";
					label_FD1.Text = "Дата початку:";
					label_FD2.Text = "Дата завершення:";
					label_FC2.Text = "Тип роботи:";
					label_FN1.Text = "Вартість роботи:";
					label_FC3.Text = "Спеціаліст:";
					SetupComboBox(comboBox1, label_FC1, GetDataForComboBox("model", "Yacht"), "model");
					SetupIntervalFilter(label_FD1, dateTimePicker1, dateTimePicker2, panel1, "Дата початку", "start_date");
					SetupIntervalFilter(label_FD2, dateTimePicker3, dateTimePicker4, panel2, "Дата завершення", "end_date");
					SetupComboBox(comboBox2, label_FC2, GetDataForComboBox("work_type", "Service"), "work_type");
					SetupNumericIntervalFilter(label_FN1, numericUpDown1, numericUpDown2, panelN, "Вартість роботи", "cost");
					SetupComboBox(comboBox3, label_FC3, GetDataForComboBox("specialist", "Service"), "specialist");
					break;
				case "competition":
					label_FD1.Text = "Дата проведення:";
					label_FC1.Text = "Тип змагання:";
					SetupIntervalFilter(label_FD1, dateTimePicker1, dateTimePicker2, panel1, "Дата проведення", "date");
					SetupComboBox(comboBox1, label_FC1, GetDataForComboBox("type", "Competition"), "type");
					break;
				case "participant":
					label_FD1.Text = "Дата народження:";
					label_FC1.Text = "Стать:";
					SetupIntervalFilter(label_FD1, dateTimePicker1, dateTimePicker2, panel1, "Дата народження", "birth_date");
					SetupComboBox(comboBox1, label_FC1, GetDataForComboBox("gender", "Participant"), "gender");
					break;
				case "participation":
					label_FC1.Text = "Змагання:";
					label_FC2.Text = "Учасник:";
					label_FC3.Text = "Яхта:";
					label_FC4.Text = "Результат:";
					SetupComboBox(comboBox1, label_FC1, GetDataForComboBox("name", "Competition"), "competition");
					SetupComboBox(comboBox2, label_FC2, GetDataForComboBox("full_name", "Participant"), "participant");
					SetupComboBox(comboBox3, label_FC3, GetDataForComboBox("model", "Yacht"), "model");
					SetupComboBox(comboBox4, label_FC4, GetDataForComboBox("result", "Participation"), "result");
					break;
				case "membership":
					label_FD1.Text = "Дата вступу:";
					SetupIntervalFilter(label_FD1, dateTimePicker1, dateTimePicker2, panel1, "Дата вступу", "join_date");
					break;
				case "trainer":
					label_FD1.Text = "Дата народження:";
					label_FC1.Text = "Стать:";
					label_FN1.Text = "Досвід:";
					label_FC2.Text = "Спеціалізація:";
					SetupIntervalFilter(label_FD1, dateTimePicker1, dateTimePicker2, panel1, "Дата народження", "birth_date");
					SetupComboBox(comboBox1, label_FC1, GetDataForComboBox("gender", "Trainer"), "gender");
					SetupNumericIntervalFilter(label_FN1, numericUpDown1, numericUpDown2, panelN, "Досвід", "experience");
					SetupComboBox(comboBox2, label_FC2, GetDataForComboBox("specialization", "Trainer"), "specialization");
					break;
				case "training":
					label_FC1.Text = "Учасник:";
					label_FC2.Text = "Тренер:";
					label_FC3.Text = "Яхта:";
					label_FD1.Text = "Дата:";
					label_FN1.Text = "Вартість:";
					SetupComboBox(comboBox1, label_FC1, GetDataForComboBox("full_name", "Participant"), "participant");
					SetupComboBox(comboBox2, label_FC2, GetDataForComboBox("full_name", "Trainer"), "trainer");
					SetupComboBox(comboBox3, label_FC3, GetDataForComboBox("model", "Yacht"), "model");
					SetupIntervalFilter(label_FD1, dateTimePicker1, dateTimePicker2, panel1, "Дата", "date");
					SetupNumericIntervalFilter(label_FN1, numericUpDown1, numericUpDown2, panelN, "Вартість", "cost");
					break;
				default:
					label_FC1.Text = "Тип:";
					label_FC2.Text = "Стан:";
					label_FD1.Text = "Рік виготовлення:";
					label_FN1.Text = "Вартість оренди:";
					SetupComboBox(comboBox1, label_FC1, GetDataForComboBox("yacht_type", "Yacht"), "yacht_type");
					SetupComboBox(comboBox2, label_FC2, GetDataForComboBox("condition", "Yacht"), "condition");
					SetupYearFilter(label_FD1, dateTimePicker1, dateTimePicker2, panel1, "Рік виготовлення", "manufacturing_year");
					SetupNumericIntervalFilter(label_FN1, numericUpDown1, numericUpDown2, panelN, "Вартість оренди", "rental_cost");
					break;
			}
		}

		private void HideAllFilters()
		{
			comboBox1.Visible = comboBox2.Visible = comboBox3.Visible = comboBox4.Visible = false;
			label_FC1.Visible = label_FC2.Visible = label_FC3.Visible = label_FC4.Visible = label_FD1.Visible = label_FD2.Visible = label_FN1.Visible = false;
			dateTimePicker1.Visible = dateTimePicker2.Visible = dateTimePicker3.Visible = dateTimePicker4.Visible = false;
			numericUpDown1.Visible = numericUpDown2.Visible = numericUpDown3.Visible = numericUpDown4.Visible = false;
			panel1.Visible = dateTimePicker1.Visible;
			panel2.Visible = dateTimePicker3.Visible;
			panelN.Visible = numericUpDown1.Visible;
		}

		private void SetupComboBox(ComboBox comboBox, System.Windows.Forms.Label label, object dataSource, string filterName)
		{
			comboBox.DataSource = dataSource;
			comboBox.Visible = true;
			comboBox.Tag = filterName;
			if (SelectedFilters.TryGetValue(filterName, out string savedValue))
			{
				comboBox.SelectedItem = savedValue;
			}
			else
			{
				comboBox.SelectedIndex = -1;
			}
			label.Visible = true;
		}

		private void SetupIntervalFilter(System.Windows.Forms.Label label, DateTimePicker picker1, DateTimePicker picker2, Panel panel, string labelText, string filterName)
		{
			label.Text = labelText;
			label.Visible = true;
			picker1.Format = DateTimePickerFormat.Custom;
			picker1.CustomFormat = "yyyy-MM-dd";
			picker1.Visible = true;
			picker2.Format = DateTimePickerFormat.Custom;
			picker2.CustomFormat = "yyyy-MM-dd";
			picker2.Visible = true;
			panel.Visible = true;
		}

		private void SetupNumericIntervalFilter(System.Windows.Forms.Label label, NumericUpDown numeric1, NumericUpDown numeric2, Panel panel, string labelText, string filterName)
		{
			label.Text = labelText;
			label.Visible = true;
			numeric1.Visible = true;
			numeric2.Visible = true;
			panel.Visible = true;
		}

		private void SetupYearFilter(System.Windows.Forms.Label label, DateTimePicker picker1, DateTimePicker picker2, Panel panel, string labelText, string filterName)
		{
			label.Text = labelText;
			label.Visible = true;

			picker1.Format = DateTimePickerFormat.Custom;
			picker1.CustomFormat = "yyyy"; 
			picker1.ShowUpDown = true; 

			picker2.Format = DateTimePickerFormat.Custom;
			picker2.CustomFormat = "yyyy";
			picker2.ShowUpDown = true;

			picker1.Visible = true;
			picker2.Visible = true;
			panel.Visible = true;
		}


		private void LoadSelectedFilters()
		{
			if (string.IsNullOrEmpty(activeTable))
			{
				activeTable = "yacht"; 
			}
			if (FilterManager.SelectedFilters.TryGetValue(activeTable, out Dictionary<string, string> selectedFilters))
			{
				foreach (var filter in SelectedFilters)
				{
					if (this.Controls.Find(filter.Key, true).FirstOrDefault() is ComboBox comboBox)
					{
						comboBox.SelectedItem = filter.Value;
						MessageBox.Show($"ComboBox '{comboBox.Name}' SelectedItem: {comboBox.SelectedItem}");

					}
					else if (this.Controls.Find(filter.Key, true).FirstOrDefault() is DateTimePicker dateTimePicker)
					{
						if (DateTime.TryParse(filter.Value, out DateTime parsedDate))
						{
							dateTimePicker.Value = parsedDate;
						}
					}
					else if (this.Controls.Find(filter.Key, true).FirstOrDefault() is NumericUpDown numericUpDown)
					{
						if (decimal.TryParse(filter.Value, out decimal parsedNumber))
						{
							numericUpDown.Value = parsedNumber;
						}
					}
				}
			}
		}

		private List<string> GetDataForComboBox(string columnName, string tableName)
		{
			List<string> results = new List<string>();
			string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True";
			string query = $"SELECT DISTINCT {columnName} FROM {tableName};";
			HashSet<string> uniqueYears = new HashSet<string>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand(query, connection);
				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						results.Add(reader[columnName].ToString());
					}
					reader.Close();
					results.AddRange(uniqueYears);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Помилка при отриманні даних: {ex.Message}");
				}
			}
			return results;
		}

		private void ResetFiltersAndReloadData()
		{
			string query = GetBaseQuery(activeTable);
			DataTable data = GetData(query);
			dataGridView8.DataSource = data;
		}

		public static class FilterManager
		{
			public static Dictionary<string, Dictionary<string, string>> SelectedFilters { get; set; } = new Dictionary<string, Dictionary<string, string>>();
		}

		//private string GetIdForName(string tableName, string columnName, string name)
		//{
		//	string connectionString = "Data Source=DESKTOP-MAHG0NL;Initial Catalog=yacht_club;Integrated Security=True"; // Ваш рядок підключення
		//	string idQuery = "";
		//	switch (columnName)
		//	{
		//		case "participant":
		//			idQuery = "SELECT participant_id FROM Participant WHERE full_name = @name";
		//			break;
		//		case "trainer":
		//			idQuery = "SELECT trainer_id FROM Trainer WHERE full_name = @name";
		//			break;
		//		case "model":
		//			idQuery = "SELECT yacht_id FROM Yacht WHERE model = @name";
		//			break;
		//		case "competition":
		//			idQuery = "SELECT competition_id FROM Competition WHERE name = @name";
		//			break;
		//	}
		//	string id = "";

		//	using (SqlConnection connection = new SqlConnection(connectionString))
		//	{
		//		SqlCommand command = new SqlCommand(idQuery, connection);
		//		command.Parameters.AddWithValue("@name", name);

		//		try
		//		{
		//			connection.Open();
		//			var result = command.ExecuteScalar();
		//			if (result != null)
		//			{
		//				id = result.ToString();
		//			}
		//		}
		//		catch (Exception ex)
		//		{
		//			MessageBox.Show($"Помилка при виконанні запиту до бази даних: {ex.Message}");
		//		}
		//	}

		//	return id;
		//}

		private HashSet<string> decimalColumns = new HashSet<string> { "rental_cost", "cost" };
		private HashSet<string> intColumns = new HashSet<string> { "experience" };
		private HashSet<string> foreignKeyFilters = new HashSet<string> { "model", "trainer", "participant", "competition" };
		private void ApplyFilters(Dictionary<string, string> filters)
		{
			string baseQuery = GetBaseQuery(activeTable);
			string filterQuery = "";

			foreach (var filter in filters)
			{
				if (!string.IsNullOrEmpty(filter.Value))
				{
					string[] filterParts = filter.Value.Split('|');
					string filterValue1 = filterParts[0];
					string filterValue2 = filterParts.Length > 1 ? filterParts[1] : "";
					string filterValue = filter.Value;

					if (!string.IsNullOrEmpty(filterQuery))
						filterQuery += " AND ";

					if (foreignKeyFilters.Contains(filter.Key))
					{
						switch (activeTable)
						{
							case "participation":
								switch (filter.Key)
								{
									case "participant":
										filterQuery += $"PT.full_name = '{filterValue}'";
										break;
									case "model":
										filterQuery += $"Y.{filter.Key} = '{filterValue}'"; 
										break;
									case "competition":
										filterQuery += $"C.name = '{filterValue}'";
										break;
								}
								break;
							case "service":
								if (filter.Key == "model")
								{
									filterQuery += $"Y.{filter.Key} = '{filterValue}'";
								}
								break;
							case "training":
								switch (filter.Key)
								{
									case "participant":
										filterQuery += $"PT.full_name = '{filterValue}'";
										break;
									case "model":
										filterQuery += $"Y.{filter.Key} = '{filterValue}'";
										break;
									case "trainer":
										filterQuery += $"TR.full_name = '{filterValue}'";
										break;
								}
								break;
						}
					}

					else if (decimalColumns.Contains(filter.Key) || intColumns.Contains(filter.Key))
					{
						if (!string.IsNullOrEmpty(filterValue1) && !string.IsNullOrEmpty(filterValue2))
						{
							filterQuery += $"{filter.Key} >= '{filterValue1}' AND {filter.Key} <= '{filterValue2}'";
						}
						else if (!string.IsNullOrEmpty(filterValue1))
						{
							filterQuery += $"{filter.Key} >= '{filterValue1}'";
						}
						else if (!string.IsNullOrEmpty(filterValue2))
						{
							filterQuery += $"{filter.Key} <= '{filterValue2}'";
						}
					}
					else if (filter.Key == "birth_date" || filter.Key == "join_date" || filter.Key == "date")
					{
						if (!string.IsNullOrEmpty(filterValue1) && !string.IsNullOrEmpty(filterValue2))
						{
							filterQuery += $"{filter.Key} >= '{filterValue1}' AND {filter.Key} <= '{filterValue2}'";
						}
						else if (!string.IsNullOrEmpty(filterValue1))
						{
							filterQuery += $"{filter.Key} >= '{filterValue1}'";
						}
						else if (!string.IsNullOrEmpty(filterValue2))
						{
							filterQuery += $"{filter.Key} <= '{filterValue2}'";
						}
					}
					else if (filter.Key == "manufacturing_year")
					{
						if (!string.IsNullOrEmpty(filterValue1) && !string.IsNullOrEmpty(filterValue2))
						{
							filterQuery += $"{filter.Key} >= '{filterValue1}' AND {filter.Key} <= '{filterValue2}'";
						}
						else if (!string.IsNullOrEmpty(filterValue1))
						{
							filterQuery += $"{filter.Key} >= '{filterValue1}'";
						}
						else if (!string.IsNullOrEmpty(filterValue2))
						{
							filterQuery += $"{filter.Key} <= '{filterValue2}'";
						}
					}
					else
					{
						if (!string.IsNullOrEmpty(filterValue1))
						{
							filterQuery += $"{filter.Key} LIKE '%{filterValue1.Replace("'", "''")}%'";
						}
					}
					//MessageBox.Show($"Filter Applied: {filter.Key} with Value: {filter.Value}!!!!!!", "Filter Debug");
				}
			}

			if (!string.IsNullOrEmpty(filterQuery))
				baseQuery += $" WHERE {filterQuery}";

			//MessageBox.Show($"Final Query: {baseQuery}))))))))", "Query Debug");

			DataTable data1 = GetData(baseQuery);
			dataGridView8.DataSource = data1;

			ResetFiltersAndReloadData();
			DataTable data = GetData(baseQuery);
			dataGridView8.DataSource = data;
		}

		private string GetBaseQuery(string activeTable)
		{
			switch (activeTable)
			{
				case "yacht":
					return "SELECT yacht_id, model AS \"Модель\", yacht_type AS \"Тип яхти\", condition AS \"Стан\", manufacturing_year AS \"Рік виготовлення\", rental_cost AS \"Вартість оренди\" FROM Yacht";
				case "service":
					return "SELECT S.service_id, Y.model AS 'Модель яхти', S.start_date AS 'Дата початку', S.end_date AS 'Дата завершення', S.work_type AS 'Тип роботи', S.cost AS 'Вартість', S.specialist AS 'Спеціаліст'\r\nFROM Service S\r\nJOIN Yacht Y ON S.yacht_id = Y.yacht_id";
				case "competition":
					return "SELECT competition_id, name AS \"Назва\", date AS \"Дата проведення\", time AS \"Час початку\", location AS \"Місце проведення\", type AS \"Тип змагання\" FROM Competition";
				case "participation":
					return "SELECT P.participation_id, C.name AS 'Змагання', PT.full_name AS 'Учасник', Y.model AS 'Яхта', P.result AS 'Результат'\r\nFROM Participation P\r\nJOIN Competition C ON P.competition_id = C.competition_id\r\nJOIN Participant PT ON P.participant_id = PT.participant_id\r\nJOIN Yacht Y ON P.yacht_id = Y.yacht_id";
				case "participant":
					return "SELECT participant_id, full_name AS \"Ім'я\", birth_date AS \"Дата народження\", gender AS \"Стать\", phone_number AS \"Номер телефону\", email AS \"Електронна пошта\" FROM Participant";
				case "membership":
					return "SELECT membership_id, PT.full_name AS \"Член клубу\", CM.join_date AS \"Дата вступу до клубу\" FROM ClubMembership CM\r\nJOIN Participant PT ON CM.participant_id = PT.participant_id";
				case "trainer":
					return "SELECT trainer_id, full_name AS \"Повне ім'я\", birth_date AS \"Дата народження\", gender AS \"Стать\", phone_number AS \"Номер телефону\", email AS \"Електронна пошта\", experience AS \"Досвід\", specialization AS \"Спеціалізація\" FROM Trainer";
				case "training":
					return "SELECT T.training_id, PT.full_name AS 'Учасник', TR.full_name AS 'Тренер', Y.model AS 'Яхта', T.date AS 'Дата', T.start_time AS 'Час початку', T.end_time AS 'Час завершення', T.cost AS 'Вартість' FROM Training T JOIN Participant PT ON T.participant_id = PT.participant_id JOIN Trainer TR ON T.trainer_id = TR.trainer_id JOIN Yacht Y ON T.yacht_id = Y.yacht_id";
				default:
					return "SELECT yacht_id, model AS \"Модель\", yacht_type AS \"Тип яхти\", condition AS \"Стан\", manufacturing_year AS \"Рік виготовлення\", rental_cost AS \"Вартість оренди\" FROM Yacht";
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			dateTimePicker1.Tag = true;
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			dateTimePicker2.Tag = true;
		}

		private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
		{
			dateTimePicker3.Tag = true;
		}

		private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
		{
			dateTimePicker4.Tag = true;
		}

		private void closeFPanel_Click(object sender, EventArgs e)
		{
			panelSideBar.Visible = false;
			this.Width -= panelSideBar.Width;
		}

		private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void розкладДляУчасниківToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var rs = new PartScheduleForm();
			rs.ShowDialog();
			trainingTableAdapter.Fill(yacht_clubDataSet.Training);
			trainerTableAdapter.Fill(yacht_clubDataSet.Trainer);
		}
	}
}

