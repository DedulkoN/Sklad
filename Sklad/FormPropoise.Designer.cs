namespace Sklad
{
    partial class FormPropoise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPropoise));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.purposeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new Sklad.SkladDataSet();
            this.purposeTableAdapter = new Sklad.SkladDataSetTableAdapters.purposeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purposeIDDataGridViewTextBoxColumn,
            this.purposeNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purposeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // purposeIDDataGridViewTextBoxColumn
            // 
            this.purposeIDDataGridViewTextBoxColumn.DataPropertyName = "purposeID";
            this.purposeIDDataGridViewTextBoxColumn.HeaderText = "purposeID";
            this.purposeIDDataGridViewTextBoxColumn.Name = "purposeIDDataGridViewTextBoxColumn";
            this.purposeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.purposeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // purposeNameDataGridViewTextBoxColumn
            // 
            this.purposeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purposeNameDataGridViewTextBoxColumn.DataPropertyName = "purposeName";
            this.purposeNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.purposeNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.purposeNameDataGridViewTextBoxColumn.Name = "purposeNameDataGridViewTextBoxColumn";
            // 
            // purposeBindingSource
            // 
            this.purposeBindingSource.DataMember = "purpose";
            this.purposeBindingSource.DataSource = this.skladDataSet;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purposeTableAdapter
            // 
            this.purposeTableAdapter.ClearBeforeFill = true;
            // 
            // FormPropoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPropoise";
            this.Text = "ОАО \"БААЗ\" - Цели хранения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPropoise_FormClosed);
            this.Load += new System.EventHandler(this.FormPropoise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource purposeBindingSource;
        private SkladDataSetTableAdapters.purposeTableAdapter purposeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeNameDataGridViewTextBoxColumn;
    }
}