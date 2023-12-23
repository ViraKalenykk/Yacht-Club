namespace yacht__club
{
	partial class ReportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
			this.yacht_clubDataSet1 = new yacht__club.yacht_clubDataSet();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btnCreateReport = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// yacht_clubDataSet1
			// 
			this.yacht_clubDataSet1.DataSetName = "yacht_clubDataSet";
			this.yacht_clubDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView
			// 
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(36, 41);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(729, 405);
			this.dataGridView.TabIndex = 0;
			// 
			// btnCreateReport
			// 
			this.btnCreateReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCreateReport.Location = new System.Drawing.Point(604, 467);
			this.btnCreateReport.Name = "btnCreateReport";
			this.btnCreateReport.Size = new System.Drawing.Size(160, 33);
			this.btnCreateReport.TabIndex = 1;
			this.btnCreateReport.Text = "Створити звіт";
			this.btnCreateReport.UseVisualStyleBackColor = true;
			this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(424, 467);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(160, 33);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Скасувати";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
			this.ClientSize = new System.Drawing.Size(800, 524);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCreateReport);
			this.Controls.Add(this.dataGridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Передогляд звіту";
			this.Load += new System.EventHandler(this.ReportForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private yacht_clubDataSet yacht_clubDataSet1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnCreateReport;
		private System.Windows.Forms.Button btnCancel;
	}
}