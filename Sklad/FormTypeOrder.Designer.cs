namespace Sklad
{
    partial class FormTypeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTypeOrder));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeOrdersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOrdersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new Sklad.SkladDataSet();
            this.typeOrdersTableAdapter = new Sklad.SkladDataSetTableAdapters.TypeOrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeOrdersIDDataGridViewTextBoxColumn,
            this.typeOrdersNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.typeOrdersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // typeOrdersIDDataGridViewTextBoxColumn
            // 
            this.typeOrdersIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeOrdersIDDataGridViewTextBoxColumn.DataPropertyName = "TypeOrdersID";
            this.typeOrdersIDDataGridViewTextBoxColumn.HeaderText = "TypeOrdersID";
            this.typeOrdersIDDataGridViewTextBoxColumn.Name = "typeOrdersIDDataGridViewTextBoxColumn";
            this.typeOrdersIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeOrdersIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeOrdersNameDataGridViewTextBoxColumn
            // 
            this.typeOrdersNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeOrdersNameDataGridViewTextBoxColumn.DataPropertyName = "TypeOrdersName";
            this.typeOrdersNameDataGridViewTextBoxColumn.HeaderText = "Название типа ордера";
            this.typeOrdersNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.typeOrdersNameDataGridViewTextBoxColumn.Name = "typeOrdersNameDataGridViewTextBoxColumn";
            // 
            // typeOrdersBindingSource
            // 
            this.typeOrdersBindingSource.DataMember = "TypeOrders";
            this.typeOrdersBindingSource.DataSource = this.skladDataSet;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeOrdersTableAdapter
            // 
            this.typeOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // FormTypeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTypeOrder";
            this.Text = "Сахарорафинатный комбинат - Типы ордеров";
            this.Load += new System.EventHandler(this.FormTypeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource typeOrdersBindingSource;
        private SkladDataSetTableAdapters.TypeOrdersTableAdapter typeOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOrdersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOrdersNameDataGridViewTextBoxColumn;
    }
}