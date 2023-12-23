namespace yacht__club
{
	partial class Form1
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.yachtTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.YachtTableAdapter();
			this.trainingTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.TrainingTableAdapter();
			this.trainerTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.TrainerTableAdapter();
			this.serviceTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.ServiceTableAdapter();
			this.participationTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.ParticipationTableAdapter();
			this.competitionTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.CompetitionTableAdapter();
			this.clubMembershipTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.ClubMembershipTableAdapter();
			this.participantTableAdapter = new yacht__club.yacht_clubDataSetTableAdapters.ParticipantTableAdapter();
			this.yachtBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.yacht_clubDataSet = new yacht__club.yacht_clubDataSet();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.інформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.яхтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обслуговуванняЯхтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.змаганняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.участьВЗмагнняхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.учасникиЗмаганьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.членствоВКлубіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.тренериToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.тренуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.виглядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.редакторЗапросівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.розкладДляУчасниківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.змінитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.статистикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загальнаСтатистикаПроКількістьЯхтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.загальнаКількістьЧленівКлубуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.звітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.звітПроСтанОбладнанняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.participationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.competitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clubMembershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView8 = new System.Windows.Forms.DataGridView();
			this.yachtidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yachttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.manufacturingyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rentalcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelTotalMembers = new System.Windows.Forms.Label();
			this.btnImportParticipants = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.btnFilter = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.textBoxCurrentPosition = new System.Windows.Forms.TextBox();
			this.btnSortAscending = new System.Windows.Forms.Button();
			this.btnSortDescending = new System.Windows.Forms.Button();
			this.panelSideBar = new System.Windows.Forms.FlowLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.closeFPanel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label_FC1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label_FC2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label_FC3 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label_FC4 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label_FD2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.label_FD1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label_FN1 = new System.Windows.Forms.Label();
			this.panelN = new System.Windows.Forms.Panel();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panelB = new System.Windows.Forms.Panel();
			this.btnFilterOk = new System.Windows.Forms.Button();
			this.btnCancelFilters = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.yachtBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trainingBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.participationBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clubMembershipBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
			this.panelSideBar.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelN.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panelB.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			this.SuspendLayout();
			// 
			// yachtTableAdapter
			// 
			this.yachtTableAdapter.ClearBeforeFill = true;
			// 
			// trainingTableAdapter
			// 
			this.trainingTableAdapter.ClearBeforeFill = true;
			// 
			// trainerTableAdapter
			// 
			this.trainerTableAdapter.ClearBeforeFill = true;
			// 
			// serviceTableAdapter
			// 
			this.serviceTableAdapter.ClearBeforeFill = true;
			// 
			// participationTableAdapter
			// 
			this.participationTableAdapter.ClearBeforeFill = true;
			// 
			// competitionTableAdapter
			// 
			this.competitionTableAdapter.ClearBeforeFill = true;
			// 
			// clubMembershipTableAdapter
			// 
			this.clubMembershipTableAdapter.ClearBeforeFill = true;
			// 
			// participantTableAdapter
			// 
			this.participantTableAdapter.ClearBeforeFill = true;
			// 
			// yachtBindingSource
			// 
			this.yachtBindingSource.DataMember = "Yacht";
			this.yachtBindingSource.DataSource = this.bindingSource1;
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
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вийтиToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// вийтиToolStripMenuItem
			// 
			this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
			this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
			this.вийтиToolStripMenuItem.Text = "Вийти";
			this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
			// 
			// інформаціяToolStripMenuItem
			// 
			this.інформаціяToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
			this.інформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.яхтиToolStripMenuItem,
            this.обслуговуванняЯхтToolStripMenuItem,
            this.змаганняToolStripMenuItem,
            this.участьВЗмагнняхToolStripMenuItem,
            this.учасникиЗмаганьToolStripMenuItem,
            this.членствоВКлубіToolStripMenuItem,
            this.тренериToolStripMenuItem,
            this.тренуванняToolStripMenuItem});
			this.інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
			this.інформаціяToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
			this.інформаціяToolStripMenuItem.Text = "Інформація";
			// 
			// яхтиToolStripMenuItem
			// 
			this.яхтиToolStripMenuItem.Name = "яхтиToolStripMenuItem";
			this.яхтиToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
			this.яхтиToolStripMenuItem.Text = "Яхти";
			this.яхтиToolStripMenuItem.Click += new System.EventHandler(this.яхтиToolStripMenuItem_Click);
			// 
			// обслуговуванняЯхтToolStripMenuItem
			// 
			this.обслуговуванняЯхтToolStripMenuItem.Name = "обслуговуванняЯхтToolStripMenuItem";
			this.обслуговуванняЯхтToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
			this.обслуговуванняЯхтToolStripMenuItem.Text = "Обслуговування яхт";
			this.обслуговуванняЯхтToolStripMenuItem.Click += new System.EventHandler(this.обслуговуванняЯхтToolStripMenuItem_Click);
			// 
			// змаганняToolStripMenuItem
			// 
			this.змаганняToolStripMenuItem.Name = "змаганняToolStripMenuItem";
			this.змаганняToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
			this.змаганняToolStripMenuItem.Text = "Змагання";
			this.змаганняToolStripMenuItem.Click += new System.EventHandler(this.змаганняToolStripMenuItem_Click);
			// 
			// участьВЗмагнняхToolStripMenuItem
			// 
			this.участьВЗмагнняхToolStripMenuItem.Name = "участьВЗмагнняхToolStripMenuItem";
			this.участьВЗмагнняхToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
			this.участьВЗмагнняхToolStripMenuItem.Text = "Участь в змагннях";
			this.участьВЗмагнняхToolStripMenuItem.Click += new System.EventHandler(this.участьВЗмагнняхToolStripMenuItem_Click);
			// 
			// учасникиЗмаганьToolStripMenuItem
			// 
			this.учасникиЗмаганьToolStripMenuItem.Name = "учасникиЗмаганьToolStripMenuItem";
			this.учасникиЗмаганьToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
			this.учасникиЗмаганьToolStripMenuItem.Text = "Учасники змагань";
			this.учасникиЗмаганьToolStripMenuItem.Click += new System.EventHandler(this.учасникиЗмаганьToolStripMenuItem_Click);
			// 
			// членствоВКлубіToolStripMenuItem
			// 
			this.членствоВКлубіToolStripMenuItem.Name = "членствоВКлубіToolStripMenuItem";
			this.членствоВКлубіToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
			this.членствоВКлубіToolStripMenuItem.Text = "Членство в клубі";
			this.членствоВКлубіToolStripMenuItem.Click += new System.EventHandler(this.членствоВКлубіToolStripMenuItem_Click);
			// 
			// тренериToolStripMenuItem
			// 
			this.тренериToolStripMenuItem.Name = "тренериToolStripMenuItem";
			this.тренериToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
			this.тренериToolStripMenuItem.Text = "Тренери";
			this.тренериToolStripMenuItem.Click += new System.EventHandler(this.тренериToolStripMenuItem_Click);
			// 
			// тренуванняToolStripMenuItem
			// 
			this.тренуванняToolStripMenuItem.Name = "тренуванняToolStripMenuItem";
			this.тренуванняToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
			this.тренуванняToolStripMenuItem.Text = "Тренування";
			this.тренуванняToolStripMenuItem.Click += new System.EventHandler(this.тренуванняToolStripMenuItem_Click);
			// 
			// виглядToolStripMenuItem
			// 
			this.виглядToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
			this.виглядToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакторЗапросівToolStripMenuItem,
            this.розкладДляУчасниківToolStripMenuItem});
			this.виглядToolStripMenuItem.Name = "виглядToolStripMenuItem";
			this.виглядToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
			this.виглядToolStripMenuItem.Text = "Вигляд";
			// 
			// редакторЗапросівToolStripMenuItem
			// 
			this.редакторЗапросівToolStripMenuItem.Name = "редакторЗапросівToolStripMenuItem";
			this.редакторЗапросівToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
			this.редакторЗапросівToolStripMenuItem.Text = "Редактор запитів";
			this.редакторЗапросівToolStripMenuItem.Click += new System.EventHandler(this.редакторЗапросівToolStripMenuItem_Click);
			// 
			// розкладДляУчасниківToolStripMenuItem
			// 
			this.розкладДляУчасниківToolStripMenuItem.Name = "розкладДляУчасниківToolStripMenuItem";
			this.розкладДляУчасниківToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
			this.розкладДляУчасниківToolStripMenuItem.Text = "Розклад для тренерів";
			this.розкладДляУчасниківToolStripMenuItem.Click += new System.EventHandler(this.розкладДляУчасниківToolStripMenuItem_Click);
			// 
			// редагуватиToolStripMenuItem
			// 
			this.редагуватиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
			this.редагуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.змінитиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
			this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
			this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
			this.редагуватиToolStripMenuItem.Text = "Редагувати";
			// 
			// додатиToolStripMenuItem
			// 
			this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
			this.додатиToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
			this.додатиToolStripMenuItem.Text = "Додати";
			this.додатиToolStripMenuItem.Click += new System.EventHandler(this.додатиToolStripMenuItem_Click);
			// 
			// змінитиToolStripMenuItem
			// 
			this.змінитиToolStripMenuItem.Name = "змінитиToolStripMenuItem";
			this.змінитиToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
			this.змінитиToolStripMenuItem.Text = "Змінити";
			this.змінитиToolStripMenuItem.Click += new System.EventHandler(this.змінитиToolStripMenuItem_Click);
			// 
			// видалитиToolStripMenuItem
			// 
			this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
			this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
			this.видалитиToolStripMenuItem.Text = "Видалити";
			this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.інформаціяToolStripMenuItem,
            this.виглядToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.статистикиToolStripMenuItem,
            this.звітиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1309, 28);
			this.menuStrip1.TabIndex = 16;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// статистикиToolStripMenuItem
			// 
			this.статистикиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
			this.статистикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загальнаСтатистикаПроКількістьЯхтToolStripMenuItem,
            this.загальнаКількістьЧленівКлубуToolStripMenuItem,
            this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem,
            this.статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem,
            this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1,
            this.статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem});
			this.статистикиToolStripMenuItem.Name = "статистикиToolStripMenuItem";
			this.статистикиToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
			this.статистикиToolStripMenuItem.Text = "Статистики";
			// 
			// загальнаСтатистикаПроКількістьЯхтToolStripMenuItem
			// 
			this.загальнаСтатистикаПроКількістьЯхтToolStripMenuItem.Name = "загальнаСтатистикаПроКількістьЯхтToolStripMenuItem";
			this.загальнаСтатистикаПроКількістьЯхтToolStripMenuItem.Size = new System.Drawing.Size(497, 26);
			this.загальнаСтатистикаПроКількістьЯхтToolStripMenuItem.Text = "Загальна статистика про кількість яхт";
			this.загальнаСтатистикаПроКількістьЯхтToolStripMenuItem.Click += new System.EventHandler(this.загальнаСтатистикаПроКількістьЯхтToolStripMenuItem_Click);
			// 
			// загальнаКількістьЧленівКлубуToolStripMenuItem
			// 
			this.загальнаКількістьЧленівКлубуToolStripMenuItem.Name = "загальнаКількістьЧленівКлубуToolStripMenuItem";
			this.загальнаКількістьЧленівКлубуToolStripMenuItem.Size = new System.Drawing.Size(497, 26);
			this.загальнаКількістьЧленівКлубуToolStripMenuItem.Text = "Загальна кількість членів клубу";
			this.загальнаКількістьЧленівКлубуToolStripMenuItem.Click += new System.EventHandler(this.загальнаКількістьЧленівКлубуToolStripMenuItem_Click);
			// 
			// розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem
			// 
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem.Name = "розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem";
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem.Size = new System.Drawing.Size(497, 26);
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem.Text = "Розрахунок заробітної плати тренера за поточний місяць";
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem.Click += new System.EventHandler(this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem_Click);
			// 
			// статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem
			// 
			this.статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem.Name = "статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem";
			this.статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem.Size = new System.Drawing.Size(497, 26);
			this.статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem.Text = "Статистика використання яхт за поточний місяць";
			this.статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem.Click += new System.EventHandler(this.статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem_Click);
			// 
			// розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1
			// 
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1.Name = "розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1";
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1.Size = new System.Drawing.Size(497, 26);
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1.Text = "Розрахунок заробітної плати тренера за минулий місяць";
			this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1.Click += new System.EventHandler(this.розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1_Click);
			// 
			// статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem
			// 
			this.статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem.Name = "статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem";
			this.статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem.Size = new System.Drawing.Size(497, 26);
			this.статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem.Text = "Статистика використання яхт за минулий місяць";
			this.статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem.Click += new System.EventHandler(this.статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem_Click);
			// 
			// звітиToolStripMenuItem
			// 
			this.звітиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
			this.звітиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem,
            this.звітПроСтанОбладнанняToolStripMenuItem});
			this.звітиToolStripMenuItem.Name = "звітиToolStripMenuItem";
			this.звітиToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.звітиToolStripMenuItem.Text = "Звіти";
			// 
			// звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem
			// 
			this.звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem.Name = "звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem";
			this.звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
			this.звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem.Text = "Звіт про результати останнього змагання";
			this.звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem.Click += new System.EventHandler(this.звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem_Click);
			// 
			// звітПроСтанОбладнанняToolStripMenuItem
			// 
			this.звітПроСтанОбладнанняToolStripMenuItem.Name = "звітПроСтанОбладнанняToolStripMenuItem";
			this.звітПроСтанОбладнанняToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
			this.звітПроСтанОбладнанняToolStripMenuItem.Text = "Звіт про стан обладнання";
			this.звітПроСтанОбладнанняToolStripMenuItem.Click += new System.EventHandler(this.звітПроСтанОбладнанняToolStripMenuItem_Click);
			// 
			// trainingBindingSource
			// 
			this.trainingBindingSource.DataMember = "Training";
			this.trainingBindingSource.DataSource = this.bindingSource1;
			// 
			// trainerBindingSource
			// 
			this.trainerBindingSource.DataMember = "Trainer";
			this.trainerBindingSource.DataSource = this.bindingSource1;
			// 
			// serviceBindingSource
			// 
			this.serviceBindingSource.DataMember = "Service";
			this.serviceBindingSource.DataSource = this.bindingSource1;
			// 
			// participationBindingSource
			// 
			this.participationBindingSource.DataMember = "Participation";
			this.participationBindingSource.DataSource = this.bindingSource1;
			// 
			// competitionBindingSource
			// 
			this.competitionBindingSource.DataMember = "Competition";
			this.competitionBindingSource.DataSource = this.bindingSource1;
			// 
			// clubMembershipBindingSource
			// 
			this.clubMembershipBindingSource.DataMember = "ClubMembership";
			this.clubMembershipBindingSource.DataSource = this.bindingSource1;
			// 
			// participantBindingSource
			// 
			this.participantBindingSource.DataMember = "Participant";
			this.participantBindingSource.DataSource = this.bindingSource1;
			// 
			// dataGridView8
			// 
			this.dataGridView8.AllowUserToAddRows = false;
			this.dataGridView8.AllowUserToDeleteRows = false;
			this.dataGridView8.AllowUserToOrderColumns = true;
			this.dataGridView8.AllowUserToResizeColumns = false;
			this.dataGridView8.AllowUserToResizeRows = false;
			this.dataGridView8.AutoGenerateColumns = false;
			this.dataGridView8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yachtidDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yachttypeDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.manufacturingyearDataGridViewTextBoxColumn,
            this.rentalcostDataGridViewTextBoxColumn});
			this.dataGridView8.DataSource = this.yachtBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView8.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView8.Location = new System.Drawing.Point(0, 238);
			this.dataGridView8.Name = "dataGridView8";
			this.dataGridView8.RowHeadersWidth = 51;
			this.dataGridView8.RowTemplate.Height = 24;
			this.dataGridView8.Size = new System.Drawing.Size(904, 514);
			this.dataGridView8.TabIndex = 14;
			this.dataGridView8.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView8_CellContentClick);
			this.dataGridView8.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView8_ColumnHeaderMouseClick);
			this.dataGridView8.SelectionChanged += new System.EventHandler(this.dataGridView8_SelectionChanged_1);
			// 
			// yachtidDataGridViewTextBoxColumn
			// 
			this.yachtidDataGridViewTextBoxColumn.DataPropertyName = "yacht_id";
			this.yachtidDataGridViewTextBoxColumn.HeaderText = "yacht_id";
			this.yachtidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.yachtidDataGridViewTextBoxColumn.Name = "yachtidDataGridViewTextBoxColumn";
			this.yachtidDataGridViewTextBoxColumn.ReadOnly = true;
			this.yachtidDataGridViewTextBoxColumn.Visible = false;
			// 
			// modelDataGridViewTextBoxColumn
			// 
			this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
			this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
			this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
			// 
			// yachttypeDataGridViewTextBoxColumn
			// 
			this.yachttypeDataGridViewTextBoxColumn.DataPropertyName = "yacht_type";
			this.yachttypeDataGridViewTextBoxColumn.HeaderText = "Тип яхти";
			this.yachttypeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.yachttypeDataGridViewTextBoxColumn.Name = "yachttypeDataGridViewTextBoxColumn";
			// 
			// conditionDataGridViewTextBoxColumn
			// 
			this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
			this.conditionDataGridViewTextBoxColumn.HeaderText = "Стан";
			this.conditionDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
			// 
			// manufacturingyearDataGridViewTextBoxColumn
			// 
			this.manufacturingyearDataGridViewTextBoxColumn.DataPropertyName = "manufacturing_year";
			this.manufacturingyearDataGridViewTextBoxColumn.HeaderText = "Рік виготовлення";
			this.manufacturingyearDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.manufacturingyearDataGridViewTextBoxColumn.Name = "manufacturingyearDataGridViewTextBoxColumn";
			// 
			// rentalcostDataGridViewTextBoxColumn
			// 
			this.rentalcostDataGridViewTextBoxColumn.DataPropertyName = "rental_cost";
			this.rentalcostDataGridViewTextBoxColumn.HeaderText = "Вартість оренди";
			this.rentalcostDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.rentalcostDataGridViewTextBoxColumn.Name = "rentalcostDataGridViewTextBoxColumn";
			// 
			// labelTotalMembers
			// 
			this.labelTotalMembers.AutoSize = true;
			this.labelTotalMembers.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTotalMembers.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.labelTotalMembers.Location = new System.Drawing.Point(9, 184);
			this.labelTotalMembers.Name = "labelTotalMembers";
			this.labelTotalMembers.Size = new System.Drawing.Size(355, 25);
			this.labelTotalMembers.TabIndex = 17;
			this.labelTotalMembers.Text = "Загальна кількість членів клубу:";
			this.labelTotalMembers.Visible = false;
			// 
			// btnImportParticipants
			// 
			this.btnImportParticipants.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnImportParticipants.Location = new System.Drawing.Point(642, 183);
			this.btnImportParticipants.Name = "btnImportParticipants";
			this.btnImportParticipants.Size = new System.Drawing.Size(234, 31);
			this.btnImportParticipants.TabIndex = 18;
			this.btnImportParticipants.Text = "Імпортувати з файлу";
			this.btnImportParticipants.UseVisualStyleBackColor = true;
			this.btnImportParticipants.Visible = false;
			this.btnImportParticipants.Click += new System.EventHandler(this.btnImportParticipants_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSearch.Location = new System.Drawing.Point(789, 43);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(103, 34);
			this.btnSearch.TabIndex = 19;
			this.btnSearch.Text = "Пошук";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSearch.Location = new System.Drawing.Point(551, 45);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(212, 28);
			this.textBoxSearch.TabIndex = 20;
			// 
			// btnFilter
			// 
			this.btnFilter.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnFilter.Location = new System.Drawing.Point(789, 85);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(103, 37);
			this.btnFilter.TabIndex = 22;
			this.btnFilter.Text = "Фільтри";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(95, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 32);
			this.label2.TabIndex = 23;
			this.label2.Text = "Яхти";
			// 
			// btnFirst
			// 
			this.btnFirst.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnFirst.Location = new System.Drawing.Point(14, 44);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(41, 29);
			this.btnFirst.TabIndex = 24;
			this.btnFirst.Text = "|<";
			this.btnFirst.UseVisualStyleBackColor = true;
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPrevious.Location = new System.Drawing.Point(60, 44);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(35, 29);
			this.btnPrevious.TabIndex = 25;
			this.btnPrevious.Text = "<";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNext.Location = new System.Drawing.Point(175, 45);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(34, 28);
			this.btnNext.TabIndex = 26;
			this.btnNext.Text = ">";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnLast
			// 
			this.btnLast.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLast.Location = new System.Drawing.Point(215, 45);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(41, 28);
			this.btnLast.TabIndex = 27;
			this.btnLast.Text = ">|";
			this.btnLast.UseVisualStyleBackColor = true;
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// textBoxCurrentPosition
			// 
			this.textBoxCurrentPosition.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCurrentPosition.Location = new System.Drawing.Point(101, 45);
			this.textBoxCurrentPosition.Name = "textBoxCurrentPosition";
			this.textBoxCurrentPosition.ReadOnly = true;
			this.textBoxCurrentPosition.Size = new System.Drawing.Size(68, 28);
			this.textBoxCurrentPosition.TabIndex = 28;
			// 
			// btnSortAscending
			// 
			this.btnSortAscending.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSortAscending.Location = new System.Drawing.Point(789, 128);
			this.btnSortAscending.Name = "btnSortAscending";
			this.btnSortAscending.Size = new System.Drawing.Size(34, 29);
			this.btnSortAscending.TabIndex = 29;
			this.btnSortAscending.Text = "▼";
			this.btnSortAscending.UseVisualStyleBackColor = true;
			this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click);
			// 
			// btnSortDescending
			// 
			this.btnSortDescending.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSortDescending.Location = new System.Drawing.Point(860, 128);
			this.btnSortDescending.Name = "btnSortDescending";
			this.btnSortDescending.Size = new System.Drawing.Size(32, 29);
			this.btnSortDescending.TabIndex = 30;
			this.btnSortDescending.Text = "▲";
			this.btnSortDescending.UseVisualStyleBackColor = true;
			this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
			// 
			// panelSideBar
			// 
			this.panelSideBar.Controls.Add(this.panel5);
			this.panelSideBar.Controls.Add(this.label_FC1);
			this.panelSideBar.Controls.Add(this.comboBox1);
			this.panelSideBar.Controls.Add(this.label_FC2);
			this.panelSideBar.Controls.Add(this.comboBox2);
			this.panelSideBar.Controls.Add(this.label_FC3);
			this.panelSideBar.Controls.Add(this.comboBox3);
			this.panelSideBar.Controls.Add(this.label_FC4);
			this.panelSideBar.Controls.Add(this.comboBox4);
			this.panelSideBar.Controls.Add(this.label_FD2);
			this.panelSideBar.Controls.Add(this.panel2);
			this.panelSideBar.Controls.Add(this.label_FD1);
			this.panelSideBar.Controls.Add(this.panel1);
			this.panelSideBar.Controls.Add(this.label_FN1);
			this.panelSideBar.Controls.Add(this.panelN);
			this.panelSideBar.Controls.Add(this.panelB);
			this.panelSideBar.Controls.Add(this.panel4);
			this.panelSideBar.Controls.Add(this.panel3);
			this.panelSideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.panelSideBar.Location = new System.Drawing.Point(898, 31);
			this.panelSideBar.Name = "panelSideBar";
			this.panelSideBar.Size = new System.Drawing.Size(411, 709);
			this.panelSideBar.TabIndex = 31;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.closeFPanel);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panel5.Location = new System.Drawing.Point(3, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(397, 45);
			this.panel5.TabIndex = 32;
			// 
			// closeFPanel
			// 
			this.closeFPanel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeFPanel.Location = new System.Drawing.Point(358, 1);
			this.closeFPanel.Name = "closeFPanel";
			this.closeFPanel.Size = new System.Drawing.Size(39, 33);
			this.closeFPanel.TabIndex = 32;
			this.closeFPanel.Text = "×";
			this.closeFPanel.UseVisualStyleBackColor = true;
			this.closeFPanel.Click += new System.EventHandler(this.closeFPanel_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(156, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Фільтри";
			// 
			// label_FC1
			// 
			this.label_FC1.AutoSize = true;
			this.label_FC1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_FC1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label_FC1.Location = new System.Drawing.Point(20, 61);
			this.label_FC1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.label_FC1.Name = "label_FC1";
			this.label_FC1.Size = new System.Drawing.Size(87, 20);
			this.label_FC1.TabIndex = 0;
			this.label_FC1.Text = "label_FC1";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(20, 101);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(381, 28);
			this.comboBox1.TabIndex = 1;
			// 
			// label_FC2
			// 
			this.label_FC2.AutoSize = true;
			this.label_FC2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_FC2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label_FC2.Location = new System.Drawing.Point(20, 149);
			this.label_FC2.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.label_FC2.Name = "label_FC2";
			this.label_FC2.Size = new System.Drawing.Size(55, 20);
			this.label_FC2.TabIndex = 2;
			this.label_FC2.Text = "label3";
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(20, 189);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(381, 28);
			this.comboBox2.TabIndex = 3;
			// 
			// label_FC3
			// 
			this.label_FC3.AutoSize = true;
			this.label_FC3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_FC3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label_FC3.Location = new System.Drawing.Point(20, 237);
			this.label_FC3.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.label_FC3.Name = "label_FC3";
			this.label_FC3.Size = new System.Drawing.Size(55, 20);
			this.label_FC3.TabIndex = 7;
			this.label_FC3.Text = "label6";
			// 
			// comboBox3
			// 
			this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(20, 277);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(381, 28);
			this.comboBox3.TabIndex = 8;
			// 
			// label_FC4
			// 
			this.label_FC4.AutoSize = true;
			this.label_FC4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_FC4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label_FC4.Location = new System.Drawing.Point(20, 325);
			this.label_FC4.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.label_FC4.Name = "label_FC4";
			this.label_FC4.Size = new System.Drawing.Size(55, 20);
			this.label_FC4.TabIndex = 9;
			this.label_FC4.Text = "label7";
			// 
			// comboBox4
			// 
			this.comboBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(20, 365);
			this.comboBox4.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(381, 28);
			this.comboBox4.TabIndex = 10;
			// 
			// label_FD2
			// 
			this.label_FD2.AutoSize = true;
			this.label_FD2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_FD2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label_FD2.Location = new System.Drawing.Point(20, 413);
			this.label_FD2.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.label_FD2.Name = "label_FD2";
			this.label_FD2.Size = new System.Drawing.Size(55, 20);
			this.label_FD2.TabIndex = 11;
			this.label_FD2.Text = "label8";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dateTimePicker3);
			this.panel2.Controls.Add(this.dateTimePicker4);
			this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panel2.Location = new System.Drawing.Point(20, 453);
			this.panel2.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(408, 51);
			this.panel2.TabIndex = 12;
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Location = new System.Drawing.Point(0, 3);
			this.dateTimePicker3.MaxDate = new System.DateTime(2023, 12, 30, 0, 0, 0, 0);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(180, 28);
			this.dateTimePicker3.TabIndex = 1;
			this.dateTimePicker3.Value = new System.DateTime(2023, 12, 19, 0, 0, 0, 0);
			this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
			// 
			// dateTimePicker4
			// 
			this.dateTimePicker4.Location = new System.Drawing.Point(201, 3);
			this.dateTimePicker4.MaxDate = new System.DateTime(2023, 12, 30, 0, 0, 0, 0);
			this.dateTimePicker4.MinDate = new System.DateTime(2023, 12, 19, 0, 0, 0, 0);
			this.dateTimePicker4.Name = "dateTimePicker4";
			this.dateTimePicker4.Size = new System.Drawing.Size(180, 28);
			this.dateTimePicker4.TabIndex = 0;
			this.dateTimePicker4.Value = new System.DateTime(2023, 12, 20, 0, 0, 0, 0);
			this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
			// 
			// label_FD1
			// 
			this.label_FD1.AutoSize = true;
			this.label_FD1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_FD1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label_FD1.Location = new System.Drawing.Point(20, 524);
			this.label_FD1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.label_FD1.Name = "label_FD1";
			this.label_FD1.Size = new System.Drawing.Size(55, 20);
			this.label_FD1.TabIndex = 4;
			this.label_FD1.Text = "label4";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dateTimePicker2);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panel1.Location = new System.Drawing.Point(20, 564);
			this.panel1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(408, 51);
			this.panel1.TabIndex = 5;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(201, 4);
			this.dateTimePicker2.MaxDate = new System.DateTime(2023, 12, 30, 0, 0, 0, 0);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(180, 28);
			this.dateTimePicker2.TabIndex = 1;
			this.dateTimePicker2.Value = new System.DateTime(2023, 12, 19, 0, 0, 0, 0);
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(0, 4);
			this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 30, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(180, 28);
			this.dateTimePicker1.TabIndex = 0;
			this.dateTimePicker1.Value = new System.DateTime(2023, 12, 19, 0, 0, 0, 0);
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label_FN1
			// 
			this.label_FN1.AutoSize = true;
			this.label_FN1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_FN1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label_FN1.Location = new System.Drawing.Point(20, 635);
			this.label_FN1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.label_FN1.Name = "label_FN1";
			this.label_FN1.Size = new System.Drawing.Size(55, 20);
			this.label_FN1.TabIndex = 6;
			this.label_FN1.Text = "label5";
			// 
			// panelN
			// 
			this.panelN.Controls.Add(this.numericUpDown2);
			this.panelN.Controls.Add(this.numericUpDown1);
			this.panelN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panelN.Location = new System.Drawing.Point(468, 10);
			this.panelN.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.panelN.Name = "panelN";
			this.panelN.Size = new System.Drawing.Size(408, 51);
			this.panelN.TabIndex = 6;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(201, 3);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(180, 28);
			this.numericUpDown2.TabIndex = 1;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(1, 3);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(179, 28);
			this.numericUpDown1.TabIndex = 0;
			// 
			// panelB
			// 
			this.panelB.Controls.Add(this.btnFilterOk);
			this.panelB.Controls.Add(this.btnCancelFilters);
			this.panelB.Location = new System.Drawing.Point(451, 74);
			this.panelB.Name = "panelB";
			this.panelB.Size = new System.Drawing.Size(398, 48);
			this.panelB.TabIndex = 32;
			// 
			// btnFilterOk
			// 
			this.btnFilterOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnFilterOk.Location = new System.Drawing.Point(227, 9);
			this.btnFilterOk.Name = "btnFilterOk";
			this.btnFilterOk.Size = new System.Drawing.Size(168, 36);
			this.btnFilterOk.TabIndex = 1;
			this.btnFilterOk.Text = "Застосувати";
			this.btnFilterOk.UseVisualStyleBackColor = true;
			this.btnFilterOk.Click += new System.EventHandler(this.btnFilterOk_Click);
			// 
			// btnCancelFilters
			// 
			this.btnCancelFilters.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancelFilters.Location = new System.Drawing.Point(18, 9);
			this.btnCancelFilters.Name = "btnCancelFilters";
			this.btnCancelFilters.Size = new System.Drawing.Size(179, 36);
			this.btnCancelFilters.TabIndex = 0;
			this.btnCancelFilters.Text = "Скинути фільтри";
			this.btnCancelFilters.UseVisualStyleBackColor = true;
			this.btnCancelFilters.Click += new System.EventHandler(this.btnCancelFilters_Click);
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(451, 128);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 100);
			this.panel4.TabIndex = 14;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.numericUpDown3);
			this.panel3.Controls.Add(this.numericUpDown4);
			this.panel3.Location = new System.Drawing.Point(468, 241);
			this.panel3.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(408, 51);
			this.panel3.TabIndex = 13;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(201, 3);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(180, 22);
			this.numericUpDown3.TabIndex = 1;
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(1, 3);
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(179, 22);
			this.numericUpDown4.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
			this.ClientSize = new System.Drawing.Size(1309, 752);
			this.Controls.Add(this.panelSideBar);
			this.Controls.Add(this.btnSortDescending);
			this.Controls.Add(this.btnSortAscending);
			this.Controls.Add(this.textBoxCurrentPosition);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnImportParticipants);
			this.Controls.Add(this.labelTotalMembers);
			this.Controls.Add(this.dataGridView8);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ІС \"Яхт-клуб\"";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
			((System.ComponentModel.ISupportInitialize)(this.yachtBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yacht_clubDataSet)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trainingBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.participationBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.competitionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clubMembershipBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
			this.panelSideBar.ResumeLayout(false);
			this.panelSideBar.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panelN.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panelB.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private yacht_clubDataSetTableAdapters.YachtTableAdapter yachtTableAdapter;
		private yacht_clubDataSetTableAdapters.TrainingTableAdapter trainingTableAdapter;
		private yacht_clubDataSetTableAdapters.TrainerTableAdapter trainerTableAdapter;
		private yacht_clubDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
		private yacht_clubDataSetTableAdapters.ParticipationTableAdapter participationTableAdapter;
		private yacht_clubDataSetTableAdapters.CompetitionTableAdapter competitionTableAdapter;
		private yacht_clubDataSetTableAdapters.ClubMembershipTableAdapter clubMembershipTableAdapter;
		private yacht_clubDataSetTableAdapters.ParticipantTableAdapter participantTableAdapter;
		private System.Windows.Forms.BindingSource yachtBindingSource;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem яхтиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem обслуговуванняЯхтToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem змаганняToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem участьВЗмагнняхToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem учасникиЗмаганьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem членствоВКлубіToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem тренериToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem тренуванняToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem виглядToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem редакторЗапросівToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem змінитиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.BindingSource trainingBindingSource;
		private System.Windows.Forms.BindingSource trainerBindingSource;
		private System.Windows.Forms.BindingSource serviceBindingSource;
		private System.Windows.Forms.BindingSource participationBindingSource;
		private System.Windows.Forms.BindingSource competitionBindingSource;
		private System.Windows.Forms.BindingSource clubMembershipBindingSource;
		private yacht_clubDataSet yacht_clubDataSet;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.BindingSource participantBindingSource;
		private System.Windows.Forms.DataGridView dataGridView8;
		private System.Windows.Forms.ToolStripMenuItem статистикиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem загальнаСтатистикаПроКількістьЯхтToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem загальнаКількістьЧленівКлубуToolStripMenuItem;
		private System.Windows.Forms.Label labelTotalMembers;
		private System.Windows.Forms.ToolStripMenuItem розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem статистикаВикористанняЯхтЗаПоточнийМісяцьToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn yachtidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yachttypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn manufacturingyearDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rentalcostDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripMenuItem розрахунокЗаробітноїПлатиТренераЗаМинулийМісяцьToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem статистикаВикористанняЯхтЗаМинулийМісяцьToolStripMenuItem;
		private System.Windows.Forms.Button btnImportParticipants;
		private System.Windows.Forms.ToolStripMenuItem звітиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem звітПроРезультатиОстанньогоЗмаганняToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem звітПроСтанОбладнанняToolStripMenuItem;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.TextBox textBoxCurrentPosition;
		private System.Windows.Forms.Button btnSortAscending;
		private System.Windows.Forms.Button btnSortDescending;
		private System.Windows.Forms.FlowLayoutPanel panelSideBar;
		private System.Windows.Forms.Label label_FC1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label_FC2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label_FD1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label_FN1;
		private System.Windows.Forms.Panel panelN;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label_FC3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label_FC4;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label_FD2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DateTimePicker dateTimePicker4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.Panel panelB;
		private System.Windows.Forms.Button btnFilterOk;
		private System.Windows.Forms.Button btnCancelFilters;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button closeFPanel;
		private System.Windows.Forms.ToolStripMenuItem розкладДляУчасниківToolStripMenuItem;
	}
}

