namespace Sklad
{
    partial class FormDepartament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartament));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departamentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOSypervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new Sklad.SkladDataSet();
            this.departamentTableAdapter = new Sklad.SkladDataSetTableAdapters.DepartamentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departamentIDDataGridViewTextBoxColumn,
            this.departamentNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.fIOSypervisorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departamentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // departamentIDDataGridViewTextBoxColumn
            // 
            this.departamentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartamentID";
            this.departamentIDDataGridViewTextBoxColumn.HeaderText = "DepartamentID";
            this.departamentIDDataGridViewTextBoxColumn.Name = "departamentIDDataGridViewTextBoxColumn";
            this.departamentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.departamentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // departamentNameDataGridViewTextBoxColumn
            // 
            this.departamentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departamentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartamentName";
            this.departamentNameDataGridViewTextBoxColumn.HeaderText = "Название отдела";
            this.departamentNameDataGridViewTextBoxColumn.Name = "departamentNameDataGridViewTextBoxColumn";
            this.departamentNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // fIOSypervisorDataGridViewTextBoxColumn
            // 
            this.fIOSypervisorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fIOSypervisorDataGridViewTextBoxColumn.DataPropertyName = "FIOSypervisor";
            this.fIOSypervisorDataGridViewTextBoxColumn.HeaderText = "ФИО начальника отдела";
            this.fIOSypervisorDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.fIOSypervisorDataGridViewTextBoxColumn.Name = "fIOSypervisorDataGridViewTextBoxColumn";
            // 
            // departamentBindingSource
            // 
            this.departamentBindingSource.DataMember = "Departament";
            this.departamentBindingSource.DataSource = this.skladDataSet;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentTableAdapter
            // 
            this.departamentTableAdapter.ClearBeforeFill = true;
            // 
            // FormDepartament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDepartament";
            this.Text = "Сахарорафинатный комбинат -Отделы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDepartament_FormClosed);
            this.Load += new System.EventHandler(this.FormDepartament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource departamentBindingSource;
        private SkladDataSetTableAdapters.DepartamentTableAdapter departamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOSypervisorDataGridViewTextBoxColumn;
    }
}