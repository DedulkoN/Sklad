namespace Sklad
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new Sklad.SkladDataSet();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new Sklad.SkladDataSetTableAdapters.MaterialsTableAdapter();
            this.typeMaterialTableAdapter = new Sklad.SkladDataSetTableAdapters.TypeMaterialTableAdapter();
            this.departamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentTableAdapter = new Sklad.SkladDataSetTableAdapters.DepartamentTableAdapter();
            this.stellazhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stellazhTableAdapter = new Sklad.SkladDataSetTableAdapters.StellazhTableAdapter();
            this.shelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelfTableAdapter = new Sklad.SkladDataSetTableAdapters.ShelfTableAdapter();
            this.purposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purposeTableAdapter = new Sklad.SkladDataSetTableAdapters.purposeTableAdapter();
            this.materialsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMaterialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.stellazhIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.shelfIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.purposeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stellazhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 300);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.AllowUserToDeleteRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToDeleteRowsChanged);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
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
            // departamentBindingSource
            // 
            this.departamentBindingSource.DataMember = "Departament";
            this.departamentBindingSource.DataSource = this.skladDataSet;
            // 
            // departamentTableAdapter
            // 
            this.departamentTableAdapter.ClearBeforeFill = true;
            // 
            // stellazhBindingSource
            // 
            this.stellazhBindingSource.DataMember = "Stellazh";
            this.stellazhBindingSource.DataSource = this.skladDataSet;
            // 
            // stellazhTableAdapter
            // 
            this.stellazhTableAdapter.ClearBeforeFill = true;
            // 
            // shelfBindingSource
            // 
            this.shelfBindingSource.DataMember = "Shelf";
            this.shelfBindingSource.DataSource = this.skladDataSet;
            // 
            // shelfTableAdapter
            // 
            this.shelfTableAdapter.ClearBeforeFill = true;
            // 
            // purposeBindingSource
            // 
            this.purposeBindingSource.DataMember = "purpose";
            this.purposeBindingSource.DataSource = this.skladDataSet;
            // 
            // purposeTableAdapter
            // 
            this.purposeTableAdapter.ClearBeforeFill = true;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(893, 300);
            this.splitContainer1.SplitterDistance = 749;
            this.splitContainer1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 324);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stellazhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

