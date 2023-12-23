namespace yacht__club
{
	partial class EditYachtForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYachtForm));
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_ok = new System.Windows.Forms.Button();
			this.comboBox_cond = new System.Windows.Forms.ComboBox();
			this.textBox_cost = new System.Windows.Forms.TextBox();
			this.textBox_year = new System.Windows.Forms.TextBox();
			this.textBox_type = new System.Windows.Forms.TextBox();
			this.textBox_model = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.yacht_clubDataSet = new yacht__club.yacht_clubDataSet();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// button_cancel
			// 
			this.button_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_cancel.Location = new System.Drawing.Point(40, 345);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(137, 33);
			this.button_cancel.TabIndex = 24;
			this.button_cancel.Text = "Скасувати";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_ok
			// 
			this.button_ok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_ok.Location = new System.Drawing.Point(301, 345);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(137, 33);
			this.button_ok.TabIndex = 23;
			this.button_ok.Text = "Зберегти";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// comboBox_cond
			// 
			this.comboBox_cond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_cond.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox_cond.Items.AddRange(new object[] {
            "готова до використання",
            "потребує ремонту",
            "в ремонті"});
			this.comboBox_cond.Location = new System.Drawing.Point(245, 150);
			this.comboBox_cond.Name = "comboBox_cond";
			this.comboBox_cond.Size = new System.Drawing.Size(193, 30);
			this.comboBox_cond.TabIndex = 22;
			// 
			// textBox_cost
			// 
			this.textBox_cost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_cost.Location = new System.Drawing.Point(245, 252);
			this.textBox_cost.Name = "textBox_cost";
			this.textBox_cost.Size = new System.Drawing.Size(193, 30);
			this.textBox_cost.TabIndex = 21;
			// 
			// textBox_year
			// 
			this.textBox_year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_year.Location = new System.Drawing.Point(245, 202);
			this.textBox_year.Name = "textBox_year";
			this.textBox_year.Size = new System.Drawing.Size(193, 30);
			this.textBox_year.TabIndex = 20;
			// 
			// textBox_type
			// 
			this.textBox_type.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_type.Location = new System.Drawing.Point(245, 102);
			this.textBox_type.Name = "textBox_type";
			this.textBox_type.Size = new System.Drawing.Size(193, 30);
			this.textBox_type.TabIndex = 19;
			// 
			// textBox_model
			// 
			this.textBox_model.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_model.Location = new System.Drawing.Point(245, 49);
			this.textBox_model.Name = "textBox_model";
			this.textBox_model.Size = new System.Drawing.Size(193, 30);
			this.textBox_model.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(36, 259);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(154, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Вартість оренди";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(36, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Рік виготовлення";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(36, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Стан";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(38, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "Тип";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(38, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Модель\r\n";
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
			// EditYachtForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
			this.ClientSize = new System.Drawing.Size(462, 417);
			this.Controls.Add(this.button_cancel);
			this.Controls.Add(this.button_ok);
			this.Controls.Add(this.comboBox_cond);
			this.Controls.Add(this.textBox_cost);
			this.Controls.Add(this.textBox_year);
			this.Controls.Add(this.textBox_type);
			this.Controls.Add(this.textBox_model);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditYachtForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редагування яхт";
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.ComboBox comboBox_cond;
		private System.Windows.Forms.TextBox textBox_cost;
		private System.Windows.Forms.TextBox textBox_year;
		private System.Windows.Forms.TextBox textBox_type;
		private System.Windows.Forms.TextBox textBox_model;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private yacht_clubDataSet yacht_clubDataSet;
	}
}