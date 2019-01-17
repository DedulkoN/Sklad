namespace Sklad
{
    partial class FormPolka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPolka));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new Sklad.SkladDataSet();
            this.shelfTableAdapter = new Sklad.SkladDataSetTableAdapters.ShelfTableAdapter();
            this.stellazhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stellazhTableAdapter = new Sklad.SkladDataSetTableAdapters.StellazhTableAdapter();
            this.shelfIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StellazhID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stellazhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shelfIDDataGridViewTextBoxColumn,
            this.shelfNameDataGridViewTextBoxColumn,
            this.StellazhID});
            this.dataGridView1.DataSource = this.shelfBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // shelfBindingSource
            // 
            this.shelfBindingSource.DataMember = "Shelf";
            this.shelfBindingSource.DataSource = this.skladDataSet;
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "SkladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shelfTableAdapter
            // 
            this.shelfTableAdapter.ClearBeforeFill = true;
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
            // shelfIDDataGridViewTextBoxColumn
            // 
            this.shelfIDDataGridViewTextBoxColumn.DataPropertyName = "ShelfID";
            this.shelfIDDataGridViewTextBoxColumn.HeaderText = "ShelfID";
            this.shelfIDDataGridViewTextBoxColumn.Name = "shelfIDDataGridViewTextBoxColumn";
            this.shelfIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shelfIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // shelfNameDataGridViewTextBoxColumn
            // 
            this.shelfNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shelfNameDataGridViewTextBoxColumn.DataPropertyName = "ShelfName";
            this.shelfNameDataGridViewTextBoxColumn.HeaderText = "Название полки";
            this.shelfNameDataGridViewTextBoxColumn.Name = "shelfNameDataGridViewTextBoxColumn";
            // 
            // StellazhID
            // 
            this.StellazhID.DataPropertyName = "StellazhID";
            this.StellazhID.DataSource = this.stellazhBindingSource;
            this.StellazhID.DisplayMember = "StellaxzName";
            this.StellazhID.HeaderText = "Стеллаж";
            this.StellazhID.Name = "StellazhID";
            this.StellazhID.ValueMember = "StellazhID";
            // 
            // FormPolka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPolka";
            this.Text = "Полки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPolka_FormClosed);
            this.Load += new System.EventHandler(this.FormPolka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stellazhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource shelfBindingSource;
        private SkladDataSetTableAdapters.ShelfTableAdapter shelfTableAdapter;
        private System.Windows.Forms.BindingSource stellazhBindingSource;
        private SkladDataSetTableAdapters.StellazhTableAdapter stellazhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn StellazhID;
    }
}