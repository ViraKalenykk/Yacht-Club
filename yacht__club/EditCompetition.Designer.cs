namespace yacht__club
{
	partial class EditCompetition
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCompetition));
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_ok = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_Name = new System.Windows.Forms.TextBox();
			this.textBox_Location = new System.Windows.Forms.TextBox();
			this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_Time = new System.Windows.Forms.DateTimePicker();
			this.comboBox_Type = new System.Windows.Forms.ComboBox();
			this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.yacht_clubDataSet = new yacht__club.yacht_clubDataSet();
			this.competitionTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.CompetitionTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// button_cancel
			// 
			this.button_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_cancel.Location = new System.Drawing.Point(46, 415);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(127, 35);
			this.button_cancel.TabIndex = 30;
			this.button_cancel.Text = "Скасувати";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_ok
			// 
			this.button_ok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_ok.Location = new System.Drawing.Point(285, 415);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(127, 35);
			this.button_ok.TabIndex = 29;
			this.button_ok.Text = "Зберегти";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(42, 302);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 23);
			this.label5.TabIndex = 43;
			this.label5.Text = "Тип";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(42, 244);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 23);
			this.label4.TabIndex = 42;
			this.label4.Text = "Локація";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(42, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 23);
			this.label3.TabIndex = 41;
			this.label3.Text = "Час";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(42, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 23);
			this.label2.TabIndex = 40;
			this.label2.Text = "Дата ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(42, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 39;
			this.label1.Text = "Назва";
			// 
			// textBox_Name
			// 
			this.textBox_Name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_Name.Location = new System.Drawing.Point(178, 61);
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.Size = new System.Drawing.Size(234, 28);
			this.textBox_Name.TabIndex = 44;
			// 
			// textBox_Location
			// 
			this.textBox_Location.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_Location.Location = new System.Drawing.Point(178, 239);
			this.textBox_Location.Name = "textBox_Location";
			this.textBox_Location.Size = new System.Drawing.Size(234, 28);
			this.textBox_Location.TabIndex = 45;
			// 
			// dateTimePicker_Date
			// 
			this.dateTimePicker_Date.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_Date.Location = new System.Drawing.Point(178, 119);
			this.dateTimePicker_Date.MinDate = new System.DateTime(1959, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker_Date.Name = "dateTimePicker_Date";
			this.dateTimePicker_Date.Size = new System.Drawing.Size(234, 28);
			this.dateTimePicker_Date.TabIndex = 46;
			this.dateTimePicker_Date.Value = new System.DateTime(2121, 7, 31, 0, 0, 0, 0);
			// 
			// dateTimePicker_Time
			// 
			this.dateTimePicker_Time.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_Time.Location = new System.Drawing.Point(178, 178);
			this.dateTimePicker_Time.Name = "dateTimePicker_Time";
			this.dateTimePicker_Time.Size = new System.Drawing.Size(234, 28);
			this.dateTimePicker_Time.TabIndex = 47;
			// 
			// comboBox_Type
			// 
			this.comboBox_Type.DataSource = this.competitionBindingSource;
			this.comboBox_Type.DisplayMember = "type";
			this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Type.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox_Type.FormattingEnabled = true;
			this.comboBox_Type.Location = new System.Drawing.Point(178, 297);
			this.comboBox_Type.Name = "comboBox_Type";
			this.comboBox_Type.Size = new System.Drawing.Size(234, 28);
			this.comboBox_Type.TabIndex = 48;
			this.comboBox_Type.ValueMember = "type";
			// 
			// competitionBindingSource
			// 
			this.competitionBindingSource.DataMember = "Competition";
			this.competitionBindingSource.DataSource = this.bindingSource1;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.yacht_clubDataSet;
			this.bindingSource1.Position = 0;
			// 
			// yacht_clubDataSet
			// 
			this.yacht_clubDataSet.DataSetName = "yacht_clubDataSet";
			this.yacht_clubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// competitionTableAdapter
			// 
			this.competitionTableAdapter.ClearBeforeFill = true;
			// 
			// EditCompetition
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
			this.ClientSize = new System.Drawing.Size(457, 497);
			this.Controls.Add(this.comboBox_Type);
			this.Controls.Add(this.dateTimePicker_Time);
			this.Controls.Add(this.dateTimePicker_Date);
			this.Controls.Add(this.textBox_Location);
			this.Controls.Add(this.textBox_Name);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_ok);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditCompetition";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редагування змагань";
			this.Load += new System.EventHandler(this.EditCompetition_Load);
			((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_Name;
		private System.Windows.Forms.TextBox textBox_Location;
		private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
		private System.Windows.Forms.DateTimePicker dateTimePicker_Time;
		private System.Windows.Forms.ComboBox comboBox_Type;
		private System.Windows.Forms.BindingSource bindingSource1;
		private yacht_clubDataSet yacht_clubDataSet;
		private System.Windows.Forms.BindingSource competitionBindingSource;
		private yacht_clubDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
	}
}