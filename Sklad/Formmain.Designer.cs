namespace Sklad
{
    partial class FormMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMaterialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new Sklad.SkladDataSet();
            this.departamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stellazhIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stellazhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelfIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.shelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purposeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.purposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отобразитьПанельФильтровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new Sklad.SkladDataSetTableAdapters.MaterialsTableAdapter();
            this.typeMaterialTableAdapter = new Sklad.SkladDataSetTableAdapters.TypeMaterialTableAdapter();
            this.departamentTableAdapter = new Sklad.SkladDataSetTableAdapters.DepartamentTableAdapter();
            this.stellazhTableAdapter = new Sklad.SkladDataSetTableAdapters.StellazhTableAdapter();
            this.shelfTableAdapter = new Sklad.SkladDataSetTableAdapters.ShelfTableAdapter();
            this.purposeTableAdapter = new Sklad.SkladDataSetTableAdapters.purposeTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыМатериаловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеллажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.целиХраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ордераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxStellaz = new System.Windows.Forms.ComboBox();
            this.checkBoxStellaz = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxDepartement = new System.Windows.Forms.ComboBox();
            this.checkBoxDepartement = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTypeMaterials = new System.Windows.Forms.ComboBox();
            this.checkBoxTypeMaterials = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.dsuhepbnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stellazhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialsIDDataGridViewTextBoxColumn,
            this.nameMaterialDataGridViewTextBoxColumn,
            this.typeMaterialIDDataGridViewTextBoxColumn,
            this.departamentIDDataGridViewTextBoxColumn,
            this.stellazhIDDataGridViewTextBoxColumn,
            this.shelfIDDataGridViewTextBoxColumn,
            this.purposeIDDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.materialsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 369);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.AllowUserToDeleteRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToDeleteRowsChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // materialsIDDataGridViewTextBoxColumn
            // 
            this.materialsIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialsID";
            this.materialsIDDataGridViewTextBoxColumn.HeaderText = "MaterialsID";
            this.materialsIDDataGridViewTextBoxColumn.Name = "materialsIDDataGridViewTextBoxColumn";
            this.materialsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialsIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameMaterialDataGridViewTextBoxColumn
            // 
            this.nameMaterialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameMaterialDataGridViewTextBoxColumn.DataPropertyName = "NameMaterial";
            this.nameMaterialDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameMaterialDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nameMaterialDataGridViewTextBoxColumn.Name = "nameMaterialDataGridViewTextBoxColumn";
            // 
            // typeMaterialIDDataGridViewTextBoxColumn
            // 
            this.typeMaterialIDDataGridViewTextBoxColumn.DataPropertyName = "TypeMaterialID";
            this.typeMaterialIDDataGridViewTextBoxColumn.DataSource = this.typeMaterialBindingSource;
            this.typeMaterialIDDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.typeMaterialIDDataGridViewTextBoxColumn.HeaderText = "Тип материалов";
            this.typeMaterialIDDataGridViewTextBoxColumn.Name = "typeMaterialIDDataGridViewTextBoxColumn";
            this.typeMaterialIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeMaterialIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeMaterialIDDataGridViewTextBoxColumn.ValueMember = "TypeID";
            // 
            // typeMaterialBindingSource
            // 
            this.typeMaterialBindingSource.DataMember = "TypeMaterial";
            this.typeMaterialBindingSource.DataSource = this.skladDataSet;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentIDDataGridViewTextBoxColumn
            // 
            this.departamentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartamentID";
            this.departamentIDDataGridViewTextBoxColumn.DataSource = this.departamentBindingSource;
            this.departamentIDDataGridViewTextBoxColumn.DisplayMember = "DepartamentName";
            this.departamentIDDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.departamentIDDataGridViewTextBoxColumn.Name = "departamentIDDataGridViewTextBoxColumn";
            this.departamentIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.departamentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.departamentIDDataGridViewTextBoxColumn.ValueMember = "DepartamentID";
            // 
            // departamentBindingSource
            // 
            this.departamentBindingSource.DataMember = "Departament";
            this.departamentBindingSource.DataSource = this.skladDataSet;
            // 
            // stellazhIDDataGridViewTextBoxColumn
            // 
            this.stellazhIDDataGridViewTextBoxColumn.DataPropertyName = "StellazhID";
            this.stellazhIDDataGridViewTextBoxColumn.DataSource = this.stellazhBindingSource;
            this.stellazhIDDataGridViewTextBoxColumn.DisplayMember = "StellaxzName";
            this.stellazhIDDataGridViewTextBoxColumn.HeaderText = "Стеллаж";
            this.stellazhIDDataGridViewTextBoxColumn.Name = "stellazhIDDataGridViewTextBoxColumn";
            this.stellazhIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stellazhIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stellazhIDDataGridViewTextBoxColumn.ValueMember = "StellazhID";
            // 
            // stellazhBindingSource
            // 
            this.stellazhBindingSource.DataMember = "Stellazh";
            this.stellazhBindingSource.DataSource = this.skladDataSet;
            // 
            // shelfIDDataGridViewTextBoxColumn
            // 
            this.shelfIDDataGridViewTextBoxColumn.DataPropertyName = "ShelfID";
            this.shelfIDDataGridViewTextBoxColumn.DataSource = this.shelfBindingSource;
            this.shelfIDDataGridViewTextBoxColumn.DisplayMember = "ShelfName";
            this.shelfIDDataGridViewTextBoxColumn.HeaderText = "Полка";
            this.shelfIDDataGridViewTextBoxColumn.Name = "shelfIDDataGridViewTextBoxColumn";
            this.shelfIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shelfIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shelfIDDataGridViewTextBoxColumn.ValueMember = "ShelfID";
            // 
            // shelfBindingSource
            // 
            this.shelfBindingSource.DataMember = "Shelf";
            this.shelfBindingSource.DataSource = this.skladDataSet;
            // 
            // purposeIDDataGridViewTextBoxColumn
            // 
            this.purposeIDDataGridViewTextBoxColumn.DataPropertyName = "purposeID";
            this.purposeIDDataGridViewTextBoxColumn.DataSource = this.purposeBindingSource;
            this.purposeIDDataGridViewTextBoxColumn.DisplayMember = "purposeName";
            this.purposeIDDataGridViewTextBoxColumn.HeaderText = "Цель хранения";
            this.purposeIDDataGridViewTextBoxColumn.Name = "purposeIDDataGridViewTextBoxColumn";
            this.purposeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.purposeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.purposeIDDataGridViewTextBoxColumn.ValueMember = "purposeID";
            // 
            // purposeBindingSource
            // 
            this.purposeBindingSource.DataMember = "purpose";
            this.purposeBindingSource.DataSource = this.skladDataSet;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отобразитьПанельФильтровToolStripMenuItem,
            this.dsuhepbnmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(238, 48);
            // 
            // отобразитьПанельФильтровToolStripMenuItem
            // 
            this.отобразитьПанельФильтровToolStripMenuItem.Name = "отобразитьПанельФильтровToolStripMenuItem";
            this.отобразитьПанельФильтровToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.отобразитьПанельФильтровToolStripMenuItem.Text = "Отобразить панель фильтров";
            this.отобразитьПанельФильтровToolStripMenuItem.Click += new System.EventHandler(this.отобразитьПанельФильтровToolStripMenuItem_Click);
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.skladDataSet;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // typeMaterialTableAdapter
            // 
            this.typeMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // departamentTableAdapter
            // 
            this.departamentTableAdapter.ClearBeforeFill = true;
            // 
            // stellazhTableAdapter
            // 
            this.stellazhTableAdapter.ClearBeforeFill = true;
            // 
            // shelfTableAdapter
            // 
            this.shelfTableAdapter.ClearBeforeFill = true;
            // 
            // purposeTableAdapter
            // 
            this.purposeTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.ордераToolStripMenuItem,
            this.панельАдминистратораToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыМатериаловToolStripMenuItem,
            this.отделыToolStripMenuItem,
            this.стеллажиToolStripMenuItem,
            this.полкиToolStripMenuItem,
            this.целиХраненияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // типыМатериаловToolStripMenuItem
            // 
            this.типыМатериаловToolStripMenuItem.Name = "типыМатериаловToolStripMenuItem";
            this.типыМатериаловToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.типыМатериаловToolStripMenuItem.Text = "Типы материалов";
            this.типыМатериаловToolStripMenuItem.Click += new System.EventHandler(this.типыМатериаловToolStripMenuItem_Click);
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отделыToolStripMenuItem.Text = "Отделы";
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.отделыToolStripMenuItem_Click);
            // 
            // стеллажиToolStripMenuItem
            // 
            this.стеллажиToolStripMenuItem.Name = "стеллажиToolStripMenuItem";
            this.стеллажиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.стеллажиToolStripMenuItem.Text = "Стеллажи";
            this.стеллажиToolStripMenuItem.Click += new System.EventHandler(this.стеллажиToolStripMenuItem_Click);
            // 
            // полкиToolStripMenuItem
            // 
            this.полкиToolStripMenuItem.Name = "полкиToolStripMenuItem";
            this.полкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.полкиToolStripMenuItem.Text = "Полки";
            this.полкиToolStripMenuItem.Click += new System.EventHandler(this.полкиToolStripMenuItem_Click);
            // 
            // целиХраненияToolStripMenuItem
            // 
            this.целиХраненияToolStripMenuItem.Name = "целиХраненияToolStripMenuItem";
            this.целиХраненияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.целиХраненияToolStripMenuItem.Text = "Цели хранения";
            this.целиХраненияToolStripMenuItem.Click += new System.EventHandler(this.целиХраненияToolStripMenuItem_Click);
            // 
            // ордераToolStripMenuItem
            // 
            this.ордераToolStripMenuItem.Name = "ордераToolStripMenuItem";
            this.ордераToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ордераToolStripMenuItem.Text = "Ордера";
            this.ордераToolStripMenuItem.Click += new System.EventHandler(this.ордераToolStripMenuItem_Click);
            // 
            // панельАдминистратораToolStripMenuItem
            // 
            this.панельАдминистратораToolStripMenuItem.Name = "панельАдминистратораToolStripMenuItem";
            this.панельАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.панельАдминистратораToolStripMenuItem.Text = "Панель администратора";
            this.панельАдминистратораToolStripMenuItem.Click += new System.EventHandler(this.панельАдминистратораToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 80);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Скрыть панель фильтров";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(757, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Применить фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxStellaz);
            this.groupBox4.Controls.Add(this.checkBoxStellaz);
            this.groupBox4.Location = new System.Drawing.Point(599, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 70);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Стеллаж";
            // 
            // comboBoxStellaz
            // 
            this.comboBoxStellaz.DataSource = this.stellazhBindingSource;
            this.comboBoxStellaz.DisplayMember = "StellazhID";
            this.comboBoxStellaz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStellaz.FormattingEnabled = true;
            this.comboBoxStellaz.Location = new System.Drawing.Point(7, 44);
            this.comboBoxStellaz.Name = "comboBoxStellaz";
            this.comboBoxStellaz.Size = new System.Drawing.Size(142, 21);
            this.comboBoxStellaz.TabIndex = 1;
            this.comboBoxStellaz.ValueMember = "StellazhID";
            // 
            // checkBoxStellaz
            // 
            this.checkBoxStellaz.AutoSize = true;
            this.checkBoxStellaz.Location = new System.Drawing.Point(7, 20);
            this.checkBoxStellaz.Name = "checkBoxStellaz";
            this.checkBoxStellaz.Size = new System.Drawing.Size(68, 17);
            this.checkBoxStellaz.TabIndex = 0;
            this.checkBoxStellaz.Text = "Активен";
            this.checkBoxStellaz.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxDepartement);
            this.groupBox3.Controls.Add(this.checkBoxDepartement);
            this.groupBox3.Location = new System.Drawing.Point(393, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отдел";
            // 
            // comboBoxDepartement
            // 
            this.comboBoxDepartement.DataSource = this.departamentBindingSource;
            this.comboBoxDepartement.DisplayMember = "DepartamentName";
            this.comboBoxDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartement.FormattingEnabled = true;
            this.comboBoxDepartement.Location = new System.Drawing.Point(7, 41);
            this.comboBoxDepartement.Name = "comboBoxDepartement";
            this.comboBoxDepartement.Size = new System.Drawing.Size(187, 21);
            this.comboBoxDepartement.TabIndex = 1;
            this.comboBoxDepartement.ValueMember = "DepartamentID";
            // 
            // checkBoxDepartement
            // 
            this.checkBoxDepartement.AutoSize = true;
            this.checkBoxDepartement.Location = new System.Drawing.Point(7, 20);
            this.checkBoxDepartement.Name = "checkBoxDepartement";
            this.checkBoxDepartement.Size = new System.Drawing.Size(68, 17);
            this.checkBoxDepartement.TabIndex = 0;
            this.checkBoxDepartement.Text = "Активен";
            this.checkBoxDepartement.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTypeMaterials);
            this.groupBox2.Controls.Add(this.checkBoxTypeMaterials);
            this.groupBox2.Location = new System.Drawing.Point(211, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип материалов";
            // 
            // comboBoxTypeMaterials
            // 
            this.comboBoxTypeMaterials.DataSource = this.typeMaterialBindingSource;
            this.comboBoxTypeMaterials.DisplayMember = "TypeName";
            this.comboBoxTypeMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeMaterials.FormattingEnabled = true;
            this.comboBoxTypeMaterials.Location = new System.Drawing.Point(7, 41);
            this.comboBoxTypeMaterials.Name = "comboBoxTypeMaterials";
            this.comboBoxTypeMaterials.Size = new System.Drawing.Size(161, 21);
            this.comboBoxTypeMaterials.TabIndex = 1;
            this.comboBoxTypeMaterials.ValueMember = "TypeID";
            // 
            // checkBoxTypeMaterials
            // 
            this.checkBoxTypeMaterials.AutoSize = true;
            this.checkBoxTypeMaterials.Location = new System.Drawing.Point(7, 18);
            this.checkBoxTypeMaterials.Name = "checkBoxTypeMaterials";
            this.checkBoxTypeMaterials.Size = new System.Drawing.Size(68, 17);
            this.checkBoxTypeMaterials.TabIndex = 0;
            this.checkBoxTypeMaterials.Text = "Активен";
            this.checkBoxTypeMaterials.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.checkBoxName);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр по наименованию";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(7, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(7, 20);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(68, 17);
            this.checkBoxName.TabIndex = 0;
            this.checkBoxName.Text = "Активен";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // dsuhepbnmToolStripMenuItem
            // 
            this.dsuhepbnmToolStripMenuItem.Name = "dsuhepbnmToolStripMenuItem";
            this.dsuhepbnmToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.dsuhepbnmToolStripMenuItem.Text = "Выгрузить данные в Excel";
            this.dsuhepbnmToolStripMenuItem.Click += new System.EventHandler(this.dsuhepbnmToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stellazhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private SkladDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.BindingSource typeMaterialBindingSource;
        private SkladDataSetTableAdapters.TypeMaterialTableAdapter typeMaterialTableAdapter;
        private System.Windows.Forms.BindingSource departamentBindingSource;
        private SkladDataSetTableAdapters.DepartamentTableAdapter departamentTableAdapter;
        private System.Windows.Forms.BindingSource stellazhBindingSource;
        private SkladDataSetTableAdapters.StellazhTableAdapter stellazhTableAdapter;
        private System.Windows.Forms.BindingSource shelfBindingSource;
        private SkladDataSetTableAdapters.ShelfTableAdapter shelfTableAdapter;
        private System.Windows.Forms.BindingSource purposeBindingSource;
        private SkladDataSetTableAdapters.purposeTableAdapter purposeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeMaterialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn departamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn stellazhIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shelfIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn purposeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельАдминистратораToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem типыМатериаловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеллажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem целиХраненияToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxStellaz;
        private System.Windows.Forms.CheckBox checkBoxStellaz;
        private System.Windows.Forms.ComboBox comboBoxDepartement;
        private System.Windows.Forms.CheckBox checkBoxDepartement;
        private System.Windows.Forms.ComboBox comboBoxTypeMaterials;
        private System.Windows.Forms.CheckBox checkBoxTypeMaterials;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отобразитьПанельФильтровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ордераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsuhepbnmToolStripMenuItem;
    }
}

