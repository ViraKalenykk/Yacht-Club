using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using yacht__club.yacht_clubDataSetTableAdapters;


namespace yacht__club
{
	public partial class EditYachtForm : Form
	{
		private readonly int yacht_id;
		private readonly bool edit;
		private yacht_clubDataSetTableAdapters.YachtTableAdapter yachtTableAdapter;

		public EditYachtForm()
		{
			InitializeComponent();
			edit = false;
			yachtTableAdapter = new yacht_clubDataSetTableAdapters.YachtTableAdapter();
	}

		public EditYachtForm(int id, string model, string yachtType, string condition, int year, decimal cost)
			: this()
		{
			edit = true;
			yacht_id = id;
			textBox_model.Text = model;
			textBox_type.Text = yachtType;
			comboBox_cond.SelectedItem = condition;
			textBox_year.Text = year.ToString();
			textBox_cost.Text = cost.ToString();
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			try
			{
				string model = textBox_model.Text;
				string type = textBox_type.Text;
				string condition = comboBox_cond.SelectedItem.ToString();
				int year = Int32.Parse(textBox_year.Text);
				decimal cost = Decimal.Parse(textBox_cost.Text);

				if (string.IsNullOrWhiteSpace(model) || model.Length > 50)
					throw new Exception("Заповніть поле, використовуючи до 50-ти символів.");

				if (string.IsNullOrWhiteSpace(type) || type.Length > 50)
					throw new Exception("Заповніть поле, використовуючи до 50-ти символів.");

				if (string.IsNullOrWhiteSpace(condition) || condition.Length > 50)
					throw new Exception("Заповніть поле, використовуючи до 50-ти символів.");

				if (!Regex.IsMatch(textBox_year.Text, @"^\d{4}$") || int.Parse(textBox_year.Text) < 1900 || int.Parse(textBox_year.Text) > 2023)
				{
					MessageBox.Show("Рік виробництва повинен бути числом з чотирма цифрами між 1900 та 2023.");
					return;
				}

				if (!decimal.TryParse(textBox_cost.Text, out decimal costValue))
				{
					MessageBox.Show("Вартість повинна бути десятковим числом.");
					return;
				}

				if (edit)
				{
					// Оновлення існуючого запису
					yachtTableAdapter.UpdateQuery(model, type, condition, year, cost, yacht_id);
				}
				else
				{
					// Додавання нового запису
					yachtTableAdapter.InsertQuery(model, type, condition, year, cost);
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
