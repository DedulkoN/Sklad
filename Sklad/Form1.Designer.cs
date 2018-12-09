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
            this.skladDataSet = new Sklad.SkladDataSet();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new Sklad.SkladDataSetTableAdapters.MaterialsTableAdapter();
            this.materialsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMaterialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stellazhIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(720, 261);
            this.dataGridView1.TabIndex = 0;
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
            // materialsIDDataGridViewTextBoxColumn
            // 
            this.materialsIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialsID";
            this.materialsIDDataGridViewTextBoxColumn.HeaderText = "MaterialsID";
            this.materialsIDDataGridViewTextBoxColumn.Name = "materialsIDDataGridViewTextBoxColumn";
            this.materialsIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameMaterialDataGridViewTextBoxColumn
            // 
            this.nameMaterialDataGridViewTextBoxColumn.DataPropertyName = "NameMaterial";
            this.nameMaterialDataGridViewTextBoxColumn.HeaderText = "NameMaterial";
            this.nameMaterialDataGridViewTextBoxColumn.Name = "nameMaterialDataGridViewTextBoxColumn";
            // 
            // typeMaterialIDDataGridViewTextBoxColumn
            // 
            this.typeMaterialIDDataGridViewTextBoxColumn.DataPropertyName = "TypeMaterialID";
            this.typeMaterialIDDataGridViewTextBoxColumn.HeaderText = "TypeMaterialID";
            this.typeMaterialIDDataGridViewTextBoxColumn.Name = "typeMaterialIDDataGridViewTextBoxColumn";
            // 
            // departamentIDDataGridViewTextBoxColumn
            // 
            this.departamentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartamentID";
            this.departamentIDDataGridViewTextBoxColumn.HeaderText = "DepartamentID";
            this.departamentIDDataGridViewTextBoxColumn.Name = "departamentIDDataGridViewTextBoxColumn";
            // 
            // stellazhIDDataGridViewTextBoxColumn
            // 
            this.stellazhIDDataGridViewTextBoxColumn.DataPropertyName = "StellazhID";
            this.stellazhIDDataGridViewTextBoxColumn.HeaderText = "StellazhID";
            this.stellazhIDDataGridViewTextBoxColumn.Name = "stellazhIDDataGridViewTextBoxColumn";
            // 
            // shelfIDDataGridViewTextBoxColumn
            // 
            this.shelfIDDataGridViewTextBoxColumn.DataPropertyName = "ShelfID";
            this.shelfIDDataGridViewTextBoxColumn.HeaderText = "ShelfID";
            this.shelfIDDataGridViewTextBoxColumn.Name = "shelfIDDataGridViewTextBoxColumn";
            // 
            // purposeIDDataGridViewTextBoxColumn
            // 
            this.purposeIDDataGridViewTextBoxColumn.DataPropertyName = "purposeID";
            this.purposeIDDataGridViewTextBoxColumn.HeaderText = "purposeID";
            this.purposeIDDataGridViewTextBoxColumn.Name = "purposeIDDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private SkladDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeMaterialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stellazhIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeIDDataGridViewTextBoxColumn;
    }
}

