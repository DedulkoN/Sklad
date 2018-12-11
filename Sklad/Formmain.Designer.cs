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
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new Sklad.SkladDataSetTableAdapters.MaterialsTableAdapter();
            this.typeMaterialTableAdapter = new Sklad.SkladDataSetTableAdapters.TypeMaterialTableAdapter();
            this.departamentTableAdapter = new Sklad.SkladDataSetTableAdapters.DepartamentTableAdapter();
            this.stellazhTableAdapter = new Sklad.SkladDataSetTableAdapters.StellazhTableAdapter();
            this.shelfTableAdapter = new Sklad.SkladDataSetTableAdapters.ShelfTableAdapter();
            this.purposeTableAdapter = new Sklad.SkladDataSetTableAdapters.purposeTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.типыМатериаловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеллажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.целиХраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stellazhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dataGridView1.DataSource = this.materialsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 349);
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
            this.помощьToolStripMenuItem,
            this.панельАдминистратораToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
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
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // панельАдминистратораToolStripMenuItem
            // 
            this.панельАдминистратораToolStripMenuItem.Name = "панельАдминистратораToolStripMenuItem";
            this.панельАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.панельАдминистратораToolStripMenuItem.Text = "Панель администратора";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 100);
            this.panel1.TabIndex = 11;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 473);
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
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельАдминистратораToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem типыМатериаловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеллажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem целиХраненияToolStripMenuItem;
    }
}

