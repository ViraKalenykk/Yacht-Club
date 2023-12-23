using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yacht__club.yacht_clubDataSetTableAdapters;

namespace yacht__club
{
	public partial class EditTraining : Form
	{
		private readonly int training_id;
		private readonly bool edit;
		private TrainingTableAdapter trainingTableAdapter;

		public EditTraining()
		{
			InitializeComponent();
			edit = false;
			trainingTableAdapter = new TrainingTableAdapter();
		}

		private void button_cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		public EditTraining(int id, int participantId, int trainerId, int yachtId, DateTime date, TimeSpan startTime, TimeSpan endTime, decimal cost)
			: this()
		{
			edit = true;
			training_id = id;

			comboBox_Prt.SelectedValue = participantId;
			comboBox_Tr.SelectedValue = trainerId;
			comboBox_Y.SelectedValue = yachtId;
			dateTimePicker_Date.Value = date;
			dateTimePicker_St.Value = DateTime.Today.Add(startTime);
			dateTimePicker_E.Value = DateTime.Today.Add(endTime);
			numericUpDown_Pr.Value = cost;
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			try
			{
				int participantId = (int)comboBox_Prt.SelectedValue;
				int trainerId = (int)comboBox_Tr.SelectedValue;
				int yachtId = (int)comboBox_Y.SelectedValue;
				DateTime date = dateTimePicker_Date.Value;
				TimeSpan startTime = dateTimePicker_St.Value.TimeOfDay;
				TimeSpan endTime = dateTimePicker_E.Value.TimeOfDay;
				decimal cost = numericUpDown_Pr.Value;

				string DateString = date.ToString("yyyy-MM-dd");
				string startTimeString = startTime.ToString("HH:mm");
				string endTimeString = endTime.ToString("HH:mm");

				if (edit)
				{
					//trainingTableAdapter.UpdateTrainingQuery(participantId, trainerId, yachtId, date, startTime, endTime, cost, training_id, IsNull_participant_id);
				}
				else
				{
					trainingTableAdapter.InsertQuery(participantId, trainerId, yachtId, date, startTime, endTime, cost);
				}
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Виникла помилка: " + ex.Message);
			}
		}

		private void EditTraining_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Yacht' table. You can move, or remove it, as needed.
			this.yachtTableAdapter.Fill(this.yacht_clubDataSet.Yacht);
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Trainer' table. You can move, or remove it, as needed.
			this.trainerTableAdapter.Fill(this.yacht_clubDataSet.Trainer);
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Participant' table. You can move, or remove it, as needed.
			this.participantTableAdapter.Fill(this.yacht_clubDataSet.Participant);

		}
	}
}
