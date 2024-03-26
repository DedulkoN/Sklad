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
            this.typeMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new Sklad.SkladDataSet();
            this.departamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stellazhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxStellaz = new System.Windows.Forms.ComboBox();
            this.checkBoxStellaz = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTypeMaterials = new System.Windows.Forms.ComboBox();
            this.checkBoxTypeMaterials = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Стеллаж = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialForShelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialForShelfTableAdapter = new Sklad.SkladDataSetTableAdapters.MaterialForShelfTableAdapter();
            this.view_1TableAdapter = new Sklad.SkladDataSetTableAdapters.View_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.typeMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stellazhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialForShelfBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // departamentBindingSource
            // 
            this.departamentBindingSource.DataMember = "Departament";
            this.departamentBindingSource.DataSource = this.skladDataSet;
            // 
            // stellazhBindingSource
            // 
            this.stellazhBindingSource.DataMember = "Stellazh";
            this.stellazhBindingSource.DataSource = this.skladDataSet;
            // 
            // shelfBindingSource
            // 
            this.shelfBindingSource.DataMember = "Shelf";
            this.shelfBindingSource.DataSource = this.skladDataSet;
            // 
            // purposeBindingSource
            // 
            this.purposeBindingSource.DataMember = "purpose";
            this.purposeBindingSource.DataSource = this.skladDataSet;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.редактироватьЗаписьToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 76);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // редактироватьЗаписьToolStripMenuItem
            // 
            this.редактироватьЗаписьToolStripMenuItem.Name = "редактироватьЗаписьToolStripMenuItem";
            this.редактироватьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.редактироватьЗаписьToolStripMenuItem.Text = "Редактировать запись";
            this.редактироватьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьЗаписьToolStripMenuItem_Click);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
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
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыМатериаловToolStripMenuItem,
            this.отделыToolStripMenuItem,
            this.стеллажиToolStripMenuItem,
            this.полкиToolStripMenuItem,
            this.целиХраненияToolStripMenuItem,
            this.материалыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
//            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
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
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.материалыToolStripMenuItem.Text = "Материалы";
            this.материалыToolStripMenuItem.Click += new System.EventHandler(this.материалыToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Применить фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxStellaz);
            this.groupBox4.Controls.Add(this.checkBoxStellaz);
            this.groupBox4.Location = new System.Drawing.Point(15, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 70);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Полка";
            // 
            // comboBoxStellaz
            // 
            this.comboBoxStellaz.DataSource = this.shelfBindingSource;
            this.comboBoxStellaz.DisplayMember = "ShelfName";
            this.comboBoxStellaz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStellaz.FormattingEnabled = true;
            this.comboBoxStellaz.Location = new System.Drawing.Point(7, 44);
            this.comboBoxStellaz.Name = "comboBoxStellaz";
            this.comboBoxStellaz.Size = new System.Drawing.Size(241, 21);
            this.comboBoxStellaz.TabIndex = 1;
            this.comboBoxStellaz.ValueMember = "ShelfID";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTypeMaterials);
            this.groupBox2.Controls.Add(this.checkBoxTypeMaterials);
            this.groupBox2.Location = new System.Drawing.Point(15, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Материал";
            // 
            // comboBoxTypeMaterials
            // 
            this.comboBoxTypeMaterials.DataSource = this.materialsBindingSource;
            this.comboBoxTypeMaterials.DisplayMember = "NameMaterial";
            this.comboBoxTypeMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeMaterials.FormattingEnabled = true;
            this.comboBoxTypeMaterials.Location = new System.Drawing.Point(7, 41);
            this.comboBoxTypeMaterials.Name = "comboBoxTypeMaterials";
            this.comboBoxTypeMaterials.Size = new System.Drawing.Size(241, 21);
            this.comboBoxTypeMaterials.TabIndex = 1;
            this.comboBoxTypeMaterials.ValueMember = "MaterialsID";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 449);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная панель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idMaterialDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.izmDataGridViewTextBoxColumn,
            this.ShelfID,
            this.Стеллаж});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.view1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(901, 417);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.AllowUserToDeleteRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToDeleteRowsChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMaterialDataGridViewTextBoxColumn
            // 
            this.idMaterialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMaterialDataGridViewTextBoxColumn.DataPropertyName = "IdMaterial";
            this.idMaterialDataGridViewTextBoxColumn.DataSource = this.materialsBindingSource;
            this.idMaterialDataGridViewTextBoxColumn.DisplayMember = "NameMaterial";
            this.idMaterialDataGridViewTextBoxColumn.HeaderText = "Материал";
            this.idMaterialDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.idMaterialDataGridViewTextBoxColumn.Name = "idMaterialDataGridViewTextBoxColumn";
            this.idMaterialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idMaterialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idMaterialDataGridViewTextBoxColumn.ValueMember = "MaterialsID";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // izmDataGridViewTextBoxColumn
            // 
            this.izmDataGridViewTextBoxColumn.DataPropertyName = "Izm";
            this.izmDataGridViewTextBoxColumn.HeaderText = "Единицы измерения";
            this.izmDataGridViewTextBoxColumn.Name = "izmDataGridViewTextBoxColumn";
            // 
            // ShelfID
            // 
            this.ShelfID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ShelfID.DataPropertyName = "ShelfID";
            this.ShelfID.DataSource = this.shelfBindingSource;
            this.ShelfID.DisplayMember = "ShelfName";
            this.ShelfID.HeaderText = "Полка";
            this.ShelfID.MinimumWidth = 100;
            this.ShelfID.Name = "ShelfID";
            this.ShelfID.ValueMember = "ShelfID";
            // 
            // Стеллаж
            // 
            this.Стеллаж.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Стеллаж.DataPropertyName = "StellazhID";
            this.Стеллаж.DataSource = this.stellazhBindingSource;
            this.Стеллаж.DisplayMember = "StellaxzName";
            this.Стеллаж.HeaderText = "Стеллаж";
            this.Стеллаж.MinimumWidth = 100;
            this.Стеллаж.Name = "Стеллаж";
            this.Стеллаж.ReadOnly = true;
            this.Стеллаж.ValueMember = "StellazhID";
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.skladDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фильтры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialForShelfBindingSource
            // 
            this.materialForShelfBindingSource.DataMember = "MaterialForShelf";
            this.materialForShelfBindingSource.DataSource = this.skladDataSet;
            // 
            // materialForShelfTableAdapter
            // 
            this.materialForShelfTableAdapter.ClearBeforeFill = true;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Сахарорафинадный комбинат - Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialForShelfBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridViewComboBoxColumn stellazhIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shelfIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыМатериаловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеллажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem целиХраненияToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxStellaz;
        private System.Windows.Forms.CheckBox checkBoxStellaz;
        private System.Windows.Forms.ComboBox comboBoxTypeMaterials;
        private System.Windows.Forms.CheckBox checkBoxTypeMaterials;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьЗаписьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource materialForShelfBindingSource;
        private SkladDataSetTableAdapters.MaterialForShelfTableAdapter materialForShelfTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private SkladDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ShelfID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Стеллаж;
    }
}

