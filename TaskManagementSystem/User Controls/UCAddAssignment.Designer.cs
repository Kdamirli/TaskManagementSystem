namespace TaskManagementSystem.User_Controls
{
    partial class UCAddAssignment
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ucAssignment = new TaskManagementSystem.ucAssignment();
            this.viewAssignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAssignmentTableAdapter = new TaskManagementSystem.ucAssignmentTableAdapters.viewAssignmentTableAdapter();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоДнейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусВыполненияDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.датаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.причинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПроектаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.cbEmp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDue = new Guna.UI2.WinForms.Guna2ComboBox();
            this.checkBoxStatus = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dtControl = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbReason = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucAssignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Назначить задание";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имяDataGridViewTextBoxColumn,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.количествоДнейDataGridViewTextBoxColumn,
            this.статусВыполненияDataGridViewCheckBoxColumn,
            this.датаОкончанияDataGridViewTextBoxColumn,
            this.причинаDataGridViewTextBoxColumn,
            this.названиеПроектаDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.viewAssignmentBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(3, 57);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(443, 369);
            this.guna2DataGridView1.TabIndex = 24;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ucAssignment
            // 
            this.ucAssignment.DataSetName = "ucAssignment";
            this.ucAssignment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewAssignmentBindingSource
            // 
            this.viewAssignmentBindingSource.DataMember = "viewAssignment";
            this.viewAssignmentBindingSource.DataSource = this.ucAssignment;
            // 
            // viewAssignmentTableAdapter
            // 
            this.viewAssignmentTableAdapter.ClearBeforeFill = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            this.датаНачалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоДнейDataGridViewTextBoxColumn
            // 
            this.количествоДнейDataGridViewTextBoxColumn.DataPropertyName = "Дни";
            this.количествоДнейDataGridViewTextBoxColumn.HeaderText = "Дни";
            this.количествоДнейDataGridViewTextBoxColumn.Name = "количествоДнейDataGridViewTextBoxColumn";
            this.количествоДнейDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусВыполненияDataGridViewCheckBoxColumn
            // 
            this.статусВыполненияDataGridViewCheckBoxColumn.DataPropertyName = "Статус выполнения";
            this.статусВыполненияDataGridViewCheckBoxColumn.HeaderText = "Статус";
            this.статусВыполненияDataGridViewCheckBoxColumn.Name = "статусВыполненияDataGridViewCheckBoxColumn";
            this.статусВыполненияDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // датаОкончанияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.HeaderText = "Конец";
            this.датаОкончанияDataGridViewTextBoxColumn.Name = "датаОкончанияDataGridViewTextBoxColumn";
            this.датаОкончанияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // причинаDataGridViewTextBoxColumn
            // 
            this.причинаDataGridViewTextBoxColumn.DataPropertyName = "Причина";
            this.причинаDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.причинаDataGridViewTextBoxColumn.Name = "причинаDataGridViewTextBoxColumn";
            this.причинаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеПроектаDataGridViewTextBoxColumn
            // 
            this.названиеПроектаDataGridViewTextBoxColumn.DataPropertyName = "Название проекта";
            this.названиеПроектаDataGridViewTextBoxColumn.HeaderText = "Проект";
            this.названиеПроектаDataGridViewTextBoxColumn.Name = "названиеПроектаDataGridViewTextBoxColumn";
            this.названиеПроектаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btAdd
            // 
            this.btAdd.Animated = true;
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btAdd.BorderColor = System.Drawing.Color.White;
            this.btAdd.BorderRadius = 15;
            this.btAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btAdd.BorderThickness = 1;
            this.btAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btAdd.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btAdd.CheckedState.Parent = this.btAdd;
            this.btAdd.CustomImages.Parent = this.btAdd;
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.btAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.HoverState.Parent = this.btAdd;
            this.btAdd.Location = new System.Drawing.Point(249, 432);
            this.btAdd.Name = "btAdd";
            this.btAdd.ShadowDecoration.Parent = this.btAdd;
            this.btAdd.Size = new System.Drawing.Size(197, 45);
            this.btAdd.TabIndex = 46;
            this.btAdd.Text = "Назначить";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbEmp
            // 
            this.cbEmp.Animated = true;
            this.cbEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbEmp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbEmp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmp.FocusedState.Parent = this.cbEmp;
            this.cbEmp.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbEmp.ForeColor = System.Drawing.Color.White;
            this.cbEmp.HoverState.Parent = this.cbEmp;
            this.cbEmp.ItemHeight = 30;
            this.cbEmp.ItemsAppearance.Parent = this.cbEmp;
            this.cbEmp.Location = new System.Drawing.Point(468, 26);
            this.cbEmp.Name = "cbEmp";
            this.cbEmp.ShadowDecoration.Parent = this.cbEmp;
            this.cbEmp.Size = new System.Drawing.Size(284, 36);
            this.cbEmp.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbEmp.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(464, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Дата начала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(464, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Работник";
            // 
            // dtStart
            // 
            this.dtStart.Animated = true;
            this.dtStart.BorderColor = System.Drawing.Color.White;
            this.dtStart.BorderThickness = 1;
            this.dtStart.CheckedState.Parent = this.dtStart;
            this.dtStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.dtStart.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtStart.ForeColor = System.Drawing.Color.White;
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtStart.HoverState.Parent = this.dtStart;
            this.dtStart.Location = new System.Drawing.Point(468, 99);
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShadowDecoration.Parent = this.dtStart;
            this.dtStart.Size = new System.Drawing.Size(236, 36);
            this.dtStart.TabIndex = 47;
            this.dtStart.Value = new System.DateTime(2022, 3, 30, 18, 24, 47, 785);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(464, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Продолжительность";
            // 
            // cbDue
            // 
            this.cbDue.Animated = true;
            this.cbDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbDue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbDue.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDue.FocusedState.Parent = this.cbDue;
            this.cbDue.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbDue.ForeColor = System.Drawing.Color.White;
            this.cbDue.HoverState.Parent = this.cbDue;
            this.cbDue.ItemHeight = 30;
            this.cbDue.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cbDue.ItemsAppearance.Parent = this.cbDue;
            this.cbDue.Location = new System.Drawing.Point(468, 176);
            this.cbDue.Name = "cbDue";
            this.cbDue.ShadowDecoration.Parent = this.cbDue;
            this.cbDue.Size = new System.Drawing.Size(284, 36);
            this.cbDue.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbDue.TabIndex = 49;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxStatus.CheckedState.BorderRadius = 0;
            this.checkBoxStatus.CheckedState.BorderThickness = 0;
            this.checkBoxStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxStatus.ForeColor = System.Drawing.Color.White;
            this.checkBoxStatus.Location = new System.Drawing.Point(468, 231);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(172, 24);
            this.checkBoxStatus.TabIndex = 51;
            this.checkBoxStatus.Text = "Статус выполнения";
            this.checkBoxStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxStatus.UncheckedState.BorderRadius = 0;
            this.checkBoxStatus.UncheckedState.BorderThickness = 0;
            this.checkBoxStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // dtControl
            // 
            this.dtControl.Animated = true;
            this.dtControl.BorderColor = System.Drawing.Color.White;
            this.dtControl.BorderThickness = 1;
            this.dtControl.CheckedState.Parent = this.dtControl;
            this.dtControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.dtControl.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtControl.ForeColor = System.Drawing.Color.White;
            this.dtControl.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtControl.HoverState.Parent = this.dtControl;
            this.dtControl.Location = new System.Drawing.Point(468, 282);
            this.dtControl.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtControl.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtControl.Name = "dtControl";
            this.dtControl.ShadowDecoration.Parent = this.dtControl;
            this.dtControl.Size = new System.Drawing.Size(236, 36);
            this.dtControl.TabIndex = 53;
            this.dtControl.Value = new System.DateTime(2022, 3, 30, 18, 24, 47, 785);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(464, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Дата проверки";
            // 
            // cbReason
            // 
            this.cbReason.Animated = true;
            this.cbReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbReason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReason.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbReason.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbReason.FocusedState.Parent = this.cbReason;
            this.cbReason.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbReason.ForeColor = System.Drawing.Color.White;
            this.cbReason.HoverState.Parent = this.cbReason;
            this.cbReason.ItemHeight = 30;
            this.cbReason.Items.AddRange(new object[] {
            "Уважительная",
            "Неуважительная"});
            this.cbReason.ItemsAppearance.Parent = this.cbReason;
            this.cbReason.Location = new System.Drawing.Point(468, 346);
            this.cbReason.Name = "cbReason";
            this.cbReason.ShadowDecoration.Parent = this.cbReason;
            this.cbReason.Size = new System.Drawing.Size(284, 36);
            this.cbReason.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbReason.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(464, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Причина";
            // 
            // cbProject
            // 
            this.cbProject.Animated = true;
            this.cbProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbProject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbProject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProject.FocusedState.Parent = this.cbProject;
            this.cbProject.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbProject.ForeColor = System.Drawing.Color.White;
            this.cbProject.HoverState.Parent = this.cbProject;
            this.cbProject.ItemHeight = 30;
            this.cbProject.ItemsAppearance.Parent = this.cbProject;
            this.cbProject.Location = new System.Drawing.Point(468, 432);
            this.cbProject.Name = "cbProject";
            this.cbProject.ShadowDecoration.Parent = this.cbProject;
            this.cbProject.Size = new System.Drawing.Size(284, 36);
            this.cbProject.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbProject.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(464, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Проект";
            // 
            // UCAddAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbReason);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.cbDue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UCAddAssignment";
            this.Size = new System.Drawing.Size(786, 492);
            this.Load += new System.EventHandler(this.UCAddAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucAssignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAssignmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоДнейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn статусВыполненияDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПроектаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewAssignmentBindingSource;
        private ucAssignment ucAssignment;
        private ucAssignmentTableAdapters.viewAssignmentTableAdapter viewAssignmentTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtStart;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbDue;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtControl;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbReason;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbProject;
        private System.Windows.Forms.Label label7;
    }
}
