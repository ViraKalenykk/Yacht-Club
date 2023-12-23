namespace yacht__club
{
	partial class EditService
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditService));
			this.comboBox_Yacht = new System.Windows.Forms.ComboBox();
			this.yachtBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.yacht_clubDataSet = new yacht__club.yacht_clubDataSet();
			this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
			this.textBox_WorkType = new System.Windows.Forms.TextBox();
			this.textBox_Cost = new System.Windows.Forms.TextBox();
			this.textBox_Specialist = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_ok = new System.Windows.Forms.Button();
			this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.serviceTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.ServiceTableAdapter();
			this.yachtTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.YachtTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.yachtBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox_Yacht
			// 
			this.comboBox_Yacht.DataSource = this.yachtBindingSource;
			this.comboBox_Yacht.DisplayMember = "model";
			this.comboBox_Yacht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Yacht.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox_Yacht.FormattingEnabled = true;
			this.comboBox_Yacht.Location = new System.Drawing.Point(224, 50);
			this.comboBox_Yacht.Name = "comboBox_Yacht";
			this.comboBox_Yacht.Size = new System.Drawing.Size(222, 30);
			this.comboBox_Yacht.TabIndex = 0;
			this.comboBox_Yacht.ValueMember = "yacht_id";
			// 
			// yachtBindingSource
			// 
			this.yachtBindingSource.DataMember = "Yacht";
			this.yachtBindingSource.DataSource = this.yacht_clubDataSet;
			// 
			// yacht_clubDataSet
			// 
			this.yacht_clubDataSet.DataSetName = "yacht_clubDataSet";
			this.yacht_clubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dateTimePicker_StartDate
			// 
			this.dateTimePicker_StartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_StartDate.Location = new System.Drawing.Point(224, 105);
			this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
			this.dateTimePicker_StartDate.Size = new System.Drawing.Size(222, 30);
			this.dateTimePicker_StartDate.TabIndex = 1;
			// 
			// dateTimePicker_EndDate
			// 
			this.dateTimePicker_EndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_EndDate.Location = new System.Drawing.Point(224, 156);
			this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
			this.dateTimePicker_EndDate.Size = new System.Drawing.Size(222, 30);
			this.dateTimePicker_EndDate.TabIndex = 2;
			// 
			// textBox_WorkType
			// 
			this.textBox_WorkType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_WorkType.Location = new System.Drawing.Point(224, 212);
			this.textBox_WorkType.Name = "textBox_WorkType";
			this.textBox_WorkType.Size = new System.Drawing.Size(222, 30);
			this.textBox_WorkType.TabIndex = 3;
			// 
			// textBox_Cost
			// 
			this.textBox_Cost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_Cost.Location = new System.Drawing.Point(224, 263);
			this.textBox_Cost.Name = "textBox_Cost";
			this.textBox_Cost.Size = new System.Drawing.Size(222, 30);
			this.textBox_Cost.TabIndex = 4;
			// 
			// textBox_Specialist
			// 
			this.textBox_Specialist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_Specialist.Location = new System.Drawing.Point(224, 320);
			this.textBox_Specialist.Name = "textBox_Specialist";
			this.textBox_Specialist.Size = new System.Drawing.Size(222, 30);
			this.textBox_Specialist.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(26, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Яхта";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(26, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Дата початку";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(26, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Дата завершення";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(26, 221);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Тип роботи";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(26, 269);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Вартість роботи";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(29, 328);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "ПІБ спеціаліста";
			// 
			// button_cancel
			// 
			this.button_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_cancel.Location = new System.Drawing.Point(33, 409);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(131, 33);
			this.button_cancel.TabIndex = 26;
			this.button_cancel.Text = "Скасувати";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click_1);
			// 
			// button_ok
			// 
			this.button_ok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_ok.Location = new System.Drawing.Point(315, 409);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(131, 33);
			this.button_ok.TabIndex = 25;
			this.button_ok.Text = "Зберегти";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click_1);
			// 
			// serviceBindingSource
			// 
			this.serviceBindingSource.DataMember = "Service";
			this.serviceBindingSource.DataSource = this.yacht_clubDataSet;
			// 
			// serviceTableAdapter
			// 
			this.serviceTableAdapter.ClearBeforeFill = true;
			// 
			// yachtTableAdapter
			// 
			this.yachtTableAdapter.ClearBeforeFill = true;
			// 
			// EditService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
			this.ClientSize = new System.Drawing.Size(475, 477);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_Specialist);
			this.Controls.Add(this.textBox_Cost);
			this.Controls.Add(this.textBox_WorkType);
			this.Controls.Add(this.dateTimePicker_EndDate);
			this.Controls.Add(this.dateTimePicker_StartDate);
			this.Controls.Add(this.comboBox_Yacht);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditService";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редагування обслуговування";
			this.Load += new System.EventHandler(this.EditService_Load);
			((System.ComponentModel.ISupportInitialize)(this.yachtBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox_Yacht;
		private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
		private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
		private System.Windows.Forms.TextBox textBox_WorkType;
		private System.Windows.Forms.TextBox textBox_Cost;
		private System.Windows.Forms.TextBox textBox_Specialist;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_ok;
		private yacht_clubDataSet yacht_clubDataSet;
		private System.Windows.Forms.BindingSource serviceBindingSource;
		private System.Windows.Forms.BindingSource yachtBindingSource;
		private yacht_clubDataSetTableAdapters.YachtTableAdapter yachtTableAdapter;
	}
}