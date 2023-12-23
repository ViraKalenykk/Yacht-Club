namespace yacht__club
{
	partial class EditTraining
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTraining));
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_ok = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox_Prt = new System.Windows.Forms.ComboBox();
			this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.yacht_clubDataSet = new yacht__club.yacht_clubDataSet();
			this.comboBox_Tr = new System.Windows.Forms.ComboBox();
			this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox_Y = new System.Windows.Forms.ComboBox();
			this.yachtBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_St = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_E = new System.Windows.Forms.DateTimePicker();
			this.numericUpDown_Pr = new System.Windows.Forms.NumericUpDown();
			this.participantTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.ParticipantTableAdapter();
			this.trainerTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.TrainerTableAdapter();
			this.yachtTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.YachtTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yachtBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pr)).BeginInit();
			this.SuspendLayout();
			// 
			// button_cancel
			// 
			this.button_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_cancel.Location = new System.Drawing.Point(33, 469);
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
			this.button_ok.Location = new System.Drawing.Point(340, 469);
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
			this.label5.Location = new System.Drawing.Point(40, 274);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 23);
			this.label5.TabIndex = 43;
			this.label5.Text = "Час початку";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(40, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 23);
			this.label4.TabIndex = 42;
			this.label4.Text = "Дата";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(40, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 23);
			this.label3.TabIndex = 41;
			this.label3.Text = "Яхта";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(40, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 23);
			this.label2.TabIndex = 40;
			this.label2.Text = "Тренер";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(40, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 23);
			this.label1.TabIndex = 39;
			this.label1.Text = "Учасник";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(40, 393);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 23);
			this.label6.TabIndex = 45;
			this.label6.Text = "Вартість";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new System.Drawing.Point(40, 335);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(160, 23);
			this.label7.TabIndex = 44;
			this.label7.Text = "Час завершення";
			// 
			// comboBox_Prt
			// 
			this.comboBox_Prt.DataSource = this.participantBindingSource;
			this.comboBox_Prt.DisplayMember = "full_name";
			this.comboBox_Prt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Prt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox_Prt.FormattingEnabled = true;
			this.comboBox_Prt.Location = new System.Drawing.Point(215, 33);
			this.comboBox_Prt.Name = "comboBox_Prt";
			this.comboBox_Prt.Size = new System.Drawing.Size(252, 28);
			this.comboBox_Prt.TabIndex = 46;
			this.comboBox_Prt.ValueMember = "participant_id";
			// 
			// participantBindingSource
			// 
			this.participantBindingSource.DataMember = "Participant";
			this.participantBindingSource.DataSource = this.bindingSource1;
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
			// comboBox_Tr
			// 
			this.comboBox_Tr.DataSource = this.trainerBindingSource;
			this.comboBox_Tr.DisplayMember = "full_name";
			this.comboBox_Tr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Tr.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox_Tr.FormattingEnabled = true;
			this.comboBox_Tr.Location = new System.Drawing.Point(215, 91);
			this.comboBox_Tr.Name = "comboBox_Tr";
			this.comboBox_Tr.Size = new System.Drawing.Size(252, 28);
			this.comboBox_Tr.TabIndex = 47;
			this.comboBox_Tr.ValueMember = "trainer_id";
			// 
			// trainerBindingSource
			// 
			this.trainerBindingSource.DataMember = "Trainer";
			this.trainerBindingSource.DataSource = this.bindingSource1;
			// 
			// comboBox_Y
			// 
			this.comboBox_Y.DataSource = this.yachtBindingSource;
			this.comboBox_Y.DisplayMember = "model";
			this.comboBox_Y.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Y.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox_Y.FormattingEnabled = true;
			this.comboBox_Y.Location = new System.Drawing.Point(215, 150);
			this.comboBox_Y.Name = "comboBox_Y";
			this.comboBox_Y.Size = new System.Drawing.Size(252, 28);
			this.comboBox_Y.TabIndex = 48;
			this.comboBox_Y.ValueMember = "yacht_id";
			// 
			// yachtBindingSource
			// 
			this.yachtBindingSource.DataMember = "Yacht";
			this.yachtBindingSource.DataSource = this.bindingSource1;
			// 
			// dateTimePicker_Date
			// 
			this.dateTimePicker_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_Date.Location = new System.Drawing.Point(215, 209);
			this.dateTimePicker_Date.MinDate = new System.DateTime(2023, 12, 22, 0, 0, 0, 0);
			this.dateTimePicker_Date.Name = "dateTimePicker_Date";
			this.dateTimePicker_Date.Size = new System.Drawing.Size(252, 30);
			this.dateTimePicker_Date.TabIndex = 49;
			// 
			// dateTimePicker_St
			// 
			this.dateTimePicker_St.Checked = false;
			this.dateTimePicker_St.CustomFormat = "";
			this.dateTimePicker_St.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_St.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker_St.Location = new System.Drawing.Point(215, 267);
			this.dateTimePicker_St.Name = "dateTimePicker_St";
			this.dateTimePicker_St.Size = new System.Drawing.Size(252, 30);
			this.dateTimePicker_St.TabIndex = 50;
			// 
			// dateTimePicker_E
			// 
			this.dateTimePicker_E.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_E.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker_E.Location = new System.Drawing.Point(215, 328);
			this.dateTimePicker_E.Name = "dateTimePicker_E";
			this.dateTimePicker_E.Size = new System.Drawing.Size(252, 30);
			this.dateTimePicker_E.TabIndex = 51;
			// 
			// numericUpDown_Pr
			// 
			this.numericUpDown_Pr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDown_Pr.Location = new System.Drawing.Point(215, 386);
			this.numericUpDown_Pr.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
			this.numericUpDown_Pr.Name = "numericUpDown_Pr";
			this.numericUpDown_Pr.Size = new System.Drawing.Size(252, 30);
			this.numericUpDown_Pr.TabIndex = 52;
			// 
			// participantTableAdapter
			// 
			this.participantTableAdapter.ClearBeforeFill = true;
			// 
			// trainerTableAdapter
			// 
			this.trainerTableAdapter.ClearBeforeFill = true;
			// 
			// yachtTableAdapter
			// 
			this.yachtTableAdapter.ClearBeforeFill = true;
			// 
			// EditTraining
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
			this.ClientSize = new System.Drawing.Size(505, 529);
			this.Controls.Add(this.numericUpDown_Pr);
			this.Controls.Add(this.dateTimePicker_E);
			this.Controls.Add(this.dateTimePicker_St);
			this.Controls.Add(this.dateTimePicker_Date);
			this.Controls.Add(this.comboBox_Y);
			this.Controls.Add(this.comboBox_Tr);
			this.Controls.Add(this.comboBox_Prt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_ok);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditTraining";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редагування тренувань";
			this.Load += new System.EventHandler(this.EditTraining_Load);
			((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yachtBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pr)).EndInit();
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox_Prt;
		private System.Windows.Forms.ComboBox comboBox_Tr;
		private System.Windows.Forms.ComboBox comboBox_Y;
		private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
		private System.Windows.Forms.DateTimePicker dateTimePicker_St;
		private System.Windows.Forms.DateTimePicker dateTimePicker_E;
		private System.Windows.Forms.NumericUpDown numericUpDown_Pr;
		private System.Windows.Forms.BindingSource bindingSource1;
		private yacht_clubDataSet yacht_clubDataSet;
		private System.Windows.Forms.BindingSource participantBindingSource;
		private yacht_clubDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter;
		private System.Windows.Forms.BindingSource trainerBindingSource;
		private yacht_clubDataSetTableAdapters.TrainerTableAdapter trainerTableAdapter;
		private System.Windows.Forms.BindingSource yachtBindingSource;
		private yacht_clubDataSetTableAdapters.YachtTableAdapter yachtTableAdapter;
	}
}