namespace yacht__club
{
	partial class EditParticipant
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditParticipant));
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_ok = new System.Windows.Forms.Button();
			this.textBox_FullName = new System.Windows.Forms.TextBox();
			this.dateTimePicker_BDate = new System.Windows.Forms.DateTimePicker();
			this.comboBox_Gender = new System.Windows.Forms.ComboBox();
			this.textBox_Phone = new System.Windows.Forms.TextBox();
			this.textBox_Email = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_cancel
			// 
			this.button_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_cancel.Location = new System.Drawing.Point(42, 400);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(127, 35);
			this.button_cancel.TabIndex = 28;
			this.button_cancel.Text = "Скасувати";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_ok
			// 
			this.button_ok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_ok.Location = new System.Drawing.Point(302, 400);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(127, 35);
			this.button_ok.TabIndex = 27;
			this.button_ok.Text = "Зберегти";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// textBox_FullName
			// 
			this.textBox_FullName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_FullName.Location = new System.Drawing.Point(256, 43);
			this.textBox_FullName.Name = "textBox_FullName";
			this.textBox_FullName.Size = new System.Drawing.Size(200, 28);
			this.textBox_FullName.TabIndex = 29;
			// 
			// dateTimePicker_BDate
			// 
			this.dateTimePicker_BDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_BDate.Location = new System.Drawing.Point(256, 103);
			this.dateTimePicker_BDate.Name = "dateTimePicker_BDate";
			this.dateTimePicker_BDate.Size = new System.Drawing.Size(200, 28);
			this.dateTimePicker_BDate.TabIndex = 30;
			// 
			// comboBox_Gender
			// 
			this.comboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Gender.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox_Gender.FormattingEnabled = true;
			this.comboBox_Gender.Items.AddRange(new object[] {
            "Чоловік",
            "Жінка"});
			this.comboBox_Gender.Location = new System.Drawing.Point(256, 160);
			this.comboBox_Gender.Name = "comboBox_Gender";
			this.comboBox_Gender.Size = new System.Drawing.Size(200, 28);
			this.comboBox_Gender.TabIndex = 31;
			// 
			// textBox_Phone
			// 
			this.textBox_Phone.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_Phone.Location = new System.Drawing.Point(256, 221);
			this.textBox_Phone.Name = "textBox_Phone";
			this.textBox_Phone.Size = new System.Drawing.Size(200, 28);
			this.textBox_Phone.TabIndex = 32;
			// 
			// textBox_Email
			// 
			this.textBox_Email.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_Email.Location = new System.Drawing.Point(256, 279);
			this.textBox_Email.Name = "textBox_Email";
			this.textBox_Email.Size = new System.Drawing.Size(200, 28);
			this.textBox_Email.TabIndex = 33;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(38, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 23);
			this.label1.TabIndex = 34;
			this.label1.Text = "ПІБ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(38, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 23);
			this.label2.TabIndex = 35;
			this.label2.Text = "Дата народження";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(38, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 23);
			this.label3.TabIndex = 36;
			this.label3.Text = "Стать";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(38, 226);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 23);
			this.label4.TabIndex = 37;
			this.label4.Text = "Номер телефону";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(38, 284);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(182, 23);
			this.label5.TabIndex = 38;
			this.label5.Text = "Електронна пошта";
			// 
			// EditParticipant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
			this.ClientSize = new System.Drawing.Size(481, 470);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_Email);
			this.Controls.Add(this.textBox_Phone);
			this.Controls.Add(this.comboBox_Gender);
			this.Controls.Add(this.dateTimePicker_BDate);
			this.Controls.Add(this.textBox_FullName);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_ok);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditParticipant";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редагування учасників";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.TextBox textBox_FullName;
		private System.Windows.Forms.DateTimePicker dateTimePicker_BDate;
		private System.Windows.Forms.ComboBox comboBox_Gender;
		private System.Windows.Forms.TextBox textBox_Phone;
		private System.Windows.Forms.TextBox textBox_Email;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}