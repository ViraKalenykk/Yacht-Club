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
using yacht__club.yacht_clubDataSetTableAdapters;

namespace yacht__club
{
	public partial class EditCompetition : Form
	{
		private readonly int competition_id;
		private readonly bool edit;
		private yacht_clubDataSetTableAdapters.CompetitionTableAdapter сompetitionTableAdapter;

		public EditCompetition()
		{
			InitializeComponent();
			edit = false;
			competitionTableAdapter = new yacht_clubDataSetTableAdapters.CompetitionTableAdapter();
			dateTimePicker_Time.Format = DateTimePickerFormat.Custom;
			dateTimePicker_Time.CustomFormat = "HH:mm";
		}

		public EditCompetition(int id, string name, DateTime date, TimeSpan time, string location, string type)
			: this()
		{
			edit = true;
			competition_id = id;
			textBox_Name.Text = name;
			dateTimePicker_Date.Value = date;
			dateTimePicker_Time.Value = DateTime.Today + time;
			textBox_Location.Text = location;
			comboBox_Type.SelectedItem = type;
		}

		private void EditCompetition_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'yacht_clubDataSet.Competition' table. You can move, or remove it, as needed.
            this.competitionTableAdapter.Fill(this.yacht_clubDataSet.Competition);

        }

		private void button_cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			try
			{
				string name = textBox_Name.Text;
				DateTime date = dateTimePicker_Date.Value;
				TimeSpan time = dateTimePicker_Time.Value.TimeOfDay;
				string location = textBox_Location.Text;
				string type = comboBox_Type.SelectedItem.ToString();

				string timeString = time.ToString(@"hh\:mm");

				if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(type))
				{
					MessageBox.Show("Всі поля повинні бути заповнені.", "Помилка введення");
					return;
				}

				string dateString = date.ToString("yyyy-MM-dd");

				if (edit)
				{
					int isNull = 0; 

					competitionTableAdapter.UpdateQuery(name, date, time, location, type, competition_id, isNull, name, isNull, date, isNull, time, isNull, location, isNull, type, isNull);
				}
				else
				{
					competitionTableAdapter.InsertQuery(name, date, time, location, type);
				}
				this.DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Виникла помилка: " + ex.Message);
			}
		}
	}
}
