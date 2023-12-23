namespace yacht__club
{
	partial class PartScheduleForm
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
			System.Windows.Forms.Label full_nameLabel;
			System.Windows.Forms.Label birth_dateLabel;
			System.Windows.Forms.Label genderLabel;
			System.Windows.Forms.Label phone_numberLabel;
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label experienceLabel;
			System.Windows.Forms.Label specializationLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartScheduleForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button_ok = new System.Windows.Forms.Button();
			this.yacht_clubDataSet = new yacht__club.yacht_clubDataSet();
			this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.trainerTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.TrainerTableAdapter();
			this.tableAdapterManager = new yacht__club.yacht_clubDataSetTableAdapters.TableAdapterManager();
			this.trainingTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.TrainingTableAdapter();
			this.trainerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.trainerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.full_nameTextBox = new System.Windows.Forms.TextBox();
			this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.genderTextBox = new System.Windows.Forms.TextBox();
			this.phone_numberTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.experienceTextBox = new System.Windows.Forms.TextBox();
			this.specializationTextBox = new System.Windows.Forms.TextBox();
			this.trainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.trainingDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			full_nameLabel = new System.Windows.Forms.Label();
			birth_dateLabel = new System.Windows.Forms.Label();
			genderLabel = new System.Windows.Forms.Label();
			phone_numberLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			experienceLabel = new System.Windows.Forms.Label();
			specializationLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trainerBindingNavigator)).BeginInit();
			this.trainerBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trainingBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trainingDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// full_nameLabel
			// 
			full_nameLabel.AutoSize = true;
			full_nameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			full_nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			full_nameLabel.Location = new System.Drawing.Point(31, 71);
			full_nameLabel.Name = "full_nameLabel";
			full_nameLabel.Size = new System.Drawing.Size(47, 22);
			full_nameLabel.TabIndex = 31;
			full_nameLabel.Text = "ПІБ:";
			// 
			// birth_dateLabel
			// 
			birth_dateLabel.AutoSize = true;
			birth_dateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			birth_dateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			birth_dateLabel.Location = new System.Drawing.Point(31, 118);
			birth_dateLabel.Name = "birth_dateLabel";
			birth_dateLabel.Size = new System.Drawing.Size(164, 22);
			birth_dateLabel.TabIndex = 33;
			birth_dateLabel.Text = "Дата народження:";
			// 
			// genderLabel
			// 
			genderLabel.AutoSize = true;
			genderLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			genderLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			genderLabel.Location = new System.Drawing.Point(31, 165);
			genderLabel.Name = "genderLabel";
			genderLabel.Size = new System.Drawing.Size(64, 22);
			genderLabel.TabIndex = 35;
			genderLabel.Text = "Стать:";
			// 
			// phone_numberLabel
			// 
			phone_numberLabel.AutoSize = true;
			phone_numberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			phone_numberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			phone_numberLabel.Location = new System.Drawing.Point(31, 215);
			phone_numberLabel.Name = "phone_numberLabel";
			phone_numberLabel.Size = new System.Drawing.Size(157, 22);
			phone_numberLabel.TabIndex = 37;
			phone_numberLabel.Text = "Номер телефону:";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			emailLabel.Location = new System.Drawing.Point(565, 69);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(72, 22);
			emailLabel.TabIndex = 39;
			emailLabel.Text = "Пошта:";
			// 
			// experienceLabel
			// 
			experienceLabel.AutoSize = true;
			experienceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			experienceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			experienceLabel.Location = new System.Drawing.Point(565, 116);
			experienceLabel.Name = "experienceLabel";
			experienceLabel.Size = new System.Drawing.Size(74, 22);
			experienceLabel.TabIndex = 41;
			experienceLabel.Text = "Досвід:";
			// 
			// specializationLabel
			// 
			specializationLabel.AutoSize = true;
			specializationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			specializationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			specializationLabel.Location = new System.Drawing.Point(565, 168);
			specializationLabel.Name = "specializationLabel";
			specializationLabel.Size = new System.Drawing.Size(134, 22);
			specializationLabel.TabIndex = 43;
			specializationLabel.Text = "Спеціалізація:";
			// 
			// button_ok
			// 
			this.button_ok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_ok.Location = new System.Drawing.Point(743, 233);
			this.button_ok.Name = "button_ok";
			this.button_ok.Size = new System.Drawing.Size(219, 35);
			this.button_ok.TabIndex = 28;
			this.button_ok.Text = "Підтвердити зміни";
			this.button_ok.UseVisualStyleBackColor = true;
			this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
			// 
			// yacht_clubDataSet
			// 
			this.yacht_clubDataSet.DataSetName = "yacht_clubDataSet";
			this.yacht_clubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// trainerBindingSource
			// 
			this.trainerBindingSource.DataMember = "Trainer";
			this.trainerBindingSource.DataSource = this.yacht_clubDataSet;
			// 
			// trainerTableAdapter
			// 
			this.trainerTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ClubMembershipTableAdapter = null;
			this.tableAdapterManager.CompetitionTableAdapter = null;
			this.tableAdapterManager.ParticipantTableAdapter = null;
			this.tableAdapterManager.ParticipationTableAdapter = null;
			this.tableAdapterManager.ServiceTableAdapter = null;
			this.tableAdapterManager.TrainerTableAdapter = this.trainerTableAdapter;
			this.tableAdapterManager.TrainingTableAdapter = this.trainingTableAdapter;
			this.tableAdapterManager.UpdateOrder = yacht__club.yacht_clubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.YachtTableAdapter = null;
			// 
			// trainingTableAdapter
			// 
			this.trainingTableAdapter.ClearBeforeFill = true;
			// 
			// trainerBindingNavigator
			// 
			this.trainerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.trainerBindingNavigator.BindingSource = this.trainerBindingSource;
			this.trainerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.trainerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.trainerBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.trainerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.trainerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.trainerBindingNavigatorSaveItem});
			this.trainerBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.trainerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.trainerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.trainerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.trainerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.trainerBindingNavigator.Name = "trainerBindingNavigator";
			this.trainerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.trainerBindingNavigator.Size = new System.Drawing.Size(1004, 31);
			this.trainerBindingNavigator.TabIndex = 29;
			this.trainerBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// trainerBindingNavigatorSaveItem
			// 
			this.trainerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.trainerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("trainerBindingNavigatorSaveItem.Image")));
			this.trainerBindingNavigatorSaveItem.Name = "trainerBindingNavigatorSaveItem";
			this.trainerBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
			this.trainerBindingNavigatorSaveItem.Text = "Save Data";
			this.trainerBindingNavigatorSaveItem.Click += new System.EventHandler(this.trainerBindingNavigatorSaveItem_Click_1);
			// 
			// full_nameTextBox
			// 
			this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainerBindingSource, "full_name", true));
			this.full_nameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.full_nameTextBox.Location = new System.Drawing.Point(260, 66);
			this.full_nameTextBox.Name = "full_nameTextBox";
			this.full_nameTextBox.Size = new System.Drawing.Size(200, 30);
			this.full_nameTextBox.TabIndex = 32;
			// 
			// birth_dateDateTimePicker
			// 
			this.birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trainerBindingSource, "birth_date", true));
			this.birth_dateDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.birth_dateDateTimePicker.Location = new System.Drawing.Point(260, 112);
			this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
			this.birth_dateDateTimePicker.Size = new System.Drawing.Size(200, 30);
			this.birth_dateDateTimePicker.TabIndex = 34;
			// 
			// genderTextBox
			// 
			this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainerBindingSource, "gender", true));
			this.genderTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.genderTextBox.Location = new System.Drawing.Point(260, 160);
			this.genderTextBox.Name = "genderTextBox";
			this.genderTextBox.Size = new System.Drawing.Size(200, 30);
			this.genderTextBox.TabIndex = 36;
			// 
			// phone_numberTextBox
			// 
			this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainerBindingSource, "phone_number", true));
			this.phone_numberTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.phone_numberTextBox.Location = new System.Drawing.Point(260, 210);
			this.phone_numberTextBox.Name = "phone_numberTextBox";
			this.phone_numberTextBox.Size = new System.Drawing.Size(200, 30);
			this.phone_numberTextBox.TabIndex = 38;
			// 
			// emailTextBox
			// 
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainerBindingSource, "email", true));
			this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.emailTextBox.Location = new System.Drawing.Point(762, 63);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(200, 30);
			this.emailTextBox.TabIndex = 40;
			// 
			// experienceTextBox
			// 
			this.experienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainerBindingSource, "experience", true));
			this.experienceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.experienceTextBox.Location = new System.Drawing.Point(762, 110);
			this.experienceTextBox.Name = "experienceTextBox";
			this.experienceTextBox.Size = new System.Drawing.Size(200, 30);
			this.experienceTextBox.TabIndex = 42;
			// 
			// specializationTextBox
			// 
			this.specializationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainerBindingSource, "specialization", true));
			this.specializationTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.specializationTextBox.Location = new System.Drawing.Point(762, 162);
			this.specializationTextBox.Name = "specializationTextBox";
			this.specializationTextBox.Size = new System.Drawing.Size(200, 30);
			this.specializationTextBox.TabIndex = 44;
			// 
			// trainingBindingSource
			// 
			this.trainingBindingSource.DataMember = "FK__Training__traine__4AB81AF0";
			this.trainingBindingSource.DataSource = this.trainerBindingSource;
			// 
			// trainingDataGridView
			// 
			this.trainingDataGridView.AllowUserToAddRows = false;
			this.trainingDataGridView.AllowUserToDeleteRows = false;
			this.trainingDataGridView.AutoGenerateColumns = false;
			this.trainingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.trainingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.trainingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.trainingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.trainingDataGridView.DataSource = this.trainingBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.trainingDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.trainingDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.trainingDataGridView.Location = new System.Drawing.Point(0, 299);
			this.trainingDataGridView.Name = "trainingDataGridView";
			this.trainingDataGridView.RowHeadersWidth = 51;
			this.trainingDataGridView.RowTemplate.Height = 24;
			this.trainingDataGridView.Size = new System.Drawing.Size(1004, 375);
			this.trainingDataGridView.TabIndex = 44;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "training_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "training_id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "participant_id";
			this.dataGridViewTextBoxColumn2.HeaderText = "Учасник";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "trainer_id";
			this.dataGridViewTextBoxColumn3.HeaderText = "Тренер";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "yacht_id";
			this.dataGridViewTextBoxColumn4.HeaderText = "Яхта";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
			this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "start_time";
			this.dataGridViewTextBoxColumn6.HeaderText = "Час початку";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "end_time";
			this.dataGridViewTextBoxColumn7.HeaderText = "Час завершення";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "cost";
			this.dataGridViewTextBoxColumn8.HeaderText = "Вартість";
			this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// PartScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
			this.ClientSize = new System.Drawing.Size(1004, 674);
			this.Controls.Add(this.trainingDataGridView);
			this.Controls.Add(full_nameLabel);
			this.Controls.Add(this.full_nameTextBox);
			this.Controls.Add(birth_dateLabel);
			this.Controls.Add(this.birth_dateDateTimePicker);
			this.Controls.Add(genderLabel);
			this.Controls.Add(this.genderTextBox);
			this.Controls.Add(phone_numberLabel);
			this.Controls.Add(this.phone_numberTextBox);
			this.Controls.Add(emailLabel);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(experienceLabel);
			this.Controls.Add(this.experienceTextBox);
			this.Controls.Add(specializationLabel);
			this.Controls.Add(this.specializationTextBox);
			this.Controls.Add(this.trainerBindingNavigator);
			this.Controls.Add(this.button_ok);
			this.Name = "PartScheduleForm";
			this.Text = "Розклад для тренерів";
			this.Load += new System.EventHandler(this.PartScheduleForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trainerBindingNavigator)).EndInit();
			this.trainerBindingNavigator.ResumeLayout(false);
			this.trainerBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trainingBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trainingDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_ok;
		private yacht_clubDataSet yacht_clubDataSet;
		private System.Windows.Forms.BindingSource trainerBindingSource;
		private yacht_clubDataSetTableAdapters.TrainerTableAdapter trainerTableAdapter;
		private yacht_clubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator trainerBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton trainerBindingNavigatorSaveItem;
		private yacht_clubDataSetTableAdapters.TrainingTableAdapter trainingTableAdapter;
		private System.Windows.Forms.TextBox full_nameTextBox;
		private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
		private System.Windows.Forms.TextBox genderTextBox;
		private System.Windows.Forms.TextBox phone_numberTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox experienceTextBox;
		private System.Windows.Forms.TextBox specializationTextBox;
		private System.Windows.Forms.BindingSource trainingBindingSource;
		private System.Windows.Forms.DataGridView trainingDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
	}
}