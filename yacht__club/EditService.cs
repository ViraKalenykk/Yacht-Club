using DocumentFormat.OpenXml.Wordprocessing;
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
	public partial class EditService : Form
	{
		private readonly int service_id;
        private readonly bool edit;
        private ServiceTableAdapter serviceTableAdapter;

        public EditService()
        {
            InitializeComponent();
            edit = false;
            serviceTableAdapter = new ServiceTableAdapter();
        }

		private void EditService_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Yacht' table. You can move, or remove it, as needed.
			this.yachtTableAdapter.Fill(this.yacht_clubDataSet.Yacht);
			// TODO: This line of code loads data into the 'yacht_clubDataSet.Service' table. You can move, or remove it, as needed.
			this.serviceTableAdapter.Fill(this.yacht_clubDataSet.Service);
		}

		public EditService(int id, int yachtId, DateTime startDate, DateTime endDate, string workType, decimal cost, string specialist)
	: this()
		{
			edit = true;
			service_id = id;
			comboBox_Yacht.SelectedValue = yachtId;
			dateTimePicker_StartDate.Value = startDate;
			dateTimePicker_EndDate.Value = endDate;
			textBox_WorkType.Text = workType;
			textBox_Cost.Text = cost.ToString();
			textBox_Specialist.Text = specialist;
		}

		private void button_ok_Click_1(object sender, EventArgs e)
		{
			try
			{
				int yachtId = Convert.ToInt32(comboBox_Yacht.SelectedValue);
				DateTime startDate = dateTimePicker_StartDate.Value;
				DateTime endDate = dateTimePicker_EndDate.Value;
				string workType = textBox_WorkType.Text;
				decimal cost = Decimal.Parse(textBox_Cost.Text);
				string specialist = textBox_Specialist.Text;

				string startDateString = startDate.ToString("yyyy-MM-dd");
				string endDateString = endDate.ToString("yyyy-MM-dd");

                if (edit)
				{
					serviceTableAdapter.UpdateQuery(yachtId, startDateString, endDateString, workType, cost, specialist, service_id);
				}
				else
				{
					serviceTableAdapter.InsertQuery(yachtId, startDateString, endDateString, workType, cost, specialist);
				}
				this.DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Виникла помилка: " + ex.Message);
			}
		}

		private void button_cancel_Click_1(object sender, EventArgs e)
		{
			Close();
		}
	}
}
