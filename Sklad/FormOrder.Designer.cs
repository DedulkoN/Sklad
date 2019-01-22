namespace Sklad
{
    partial class FormOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOrdersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladDataSet = new Sklad.SkladDataSet();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.whoCreateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьскрытьПанельФильтровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выгрузитьДанныеВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSuhepbnmLfyystToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Sklad.SkladDataSetTableAdapters.OrdersTableAdapter();
            this.typeOrdersTableAdapter = new Sklad.SkladDataSetTableAdapters.TypeOrdersTableAdapter();
            this.materialsTableAdapter = new Sklad.SkladDataSetTableAdapters.MaterialsTableAdapter();
            this.usersTableAdapter = new Sklad.SkladDataSetTableAdapters.UsersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxIzm = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonNoAdd = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxAddInfo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxAddMaterial = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAddType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonFiltr = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBoxWho = new System.Windows.Forms.CheckBox();
            this.comboBoxFiltrWho = new System.Windows.Forms.ComboBox();
            this.groupBoxFiltrMaterial = new System.Windows.Forms.GroupBox();
            this.comboBoxFiltrMaterial = new System.Windows.Forms.ComboBox();
            this.checkBoxmaterial = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFiltr = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxFiltrType = new System.Windows.Forms.ComboBox();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBoxFiltrMaterial.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordersIDDataGridViewTextBoxColumn,
            this.typeOrdersIDDataGridViewTextBoxColumn,
            this.dateOrderDataGridViewTextBoxColumn,
            this.materialIdDataGridViewTextBoxColumn,
            this.whoCreateOrderDataGridViewTextBoxColumn,
            this.Count,
            this.Izm,
            this.infoDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // ordersIDDataGridViewTextBoxColumn
            // 
            this.ordersIDDataGridViewTextBoxColumn.DataPropertyName = "OrdersID";
            this.ordersIDDataGridViewTextBoxColumn.HeaderText = "OrdersID";
            this.ordersIDDataGridViewTextBoxColumn.Name = "ordersIDDataGridViewTextBoxColumn";
            this.ordersIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordersIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeOrdersIDDataGridViewTextBoxColumn
            // 
            this.typeOrdersIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typeOrdersIDDataGridViewTextBoxColumn.DataPropertyName = "TypeOrdersID";
            this.typeOrdersIDDataGridViewTextBoxColumn.DataSource = this.typeOrdersBindingSource;
            this.typeOrdersIDDataGridViewTextBoxColumn.DisplayMember = "TypeOrdersName";
            this.typeOrdersIDDataGridViewTextBoxColumn.HeaderText = "Тип ордера";
            this.typeOrdersIDDataGridViewTextBoxColumn.Name = "typeOrdersIDDataGridViewTextBoxColumn";
            this.typeOrdersIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeOrdersIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeOrdersIDDataGridViewTextBoxColumn.ValueMember = "TypeOrdersID";
            this.typeOrdersIDDataGridViewTextBoxColumn.Width = 83;
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
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "DateOrder";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dateOrderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.Width = 58;
            // 
            // materialIdDataGridViewTextBoxColumn
            // 
            this.materialIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialId";
            this.materialIdDataGridViewTextBoxColumn.DataSource = this.materialsBindingSource;
            this.materialIdDataGridViewTextBoxColumn.DisplayMember = "NameMaterial";
            this.materialIdDataGridViewTextBoxColumn.HeaderText = "Материал";
            this.materialIdDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.materialIdDataGridViewTextBoxColumn.Name = "materialIdDataGridViewTextBoxColumn";
            this.materialIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materialIdDataGridViewTextBoxColumn.ValueMember = "MaterialsID";
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.skladDataSet;
            // 
            // whoCreateOrderDataGridViewTextBoxColumn
            // 
            this.whoCreateOrderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.whoCreateOrderDataGridViewTextBoxColumn.DataPropertyName = "WhoCreateOrder";
            this.whoCreateOrderDataGridViewTextBoxColumn.DataSource = this.usersBindingSource;
            this.whoCreateOrderDataGridViewTextBoxColumn.DisplayMember = "UserLogin";
            this.whoCreateOrderDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.whoCreateOrderDataGridViewTextBoxColumn.HeaderText = "Создатель ордера";
            this.whoCreateOrderDataGridViewTextBoxColumn.Name = "whoCreateOrderDataGridViewTextBoxColumn";
            this.whoCreateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.whoCreateOrderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.whoCreateOrderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.whoCreateOrderDataGridViewTextBoxColumn.ValueMember = "UsersID";
            this.whoCreateOrderDataGridViewTextBoxColumn.Width = 114;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.skladDataSet;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // Izm
            // 
            this.Izm.DataPropertyName = "Izm";
            this.Izm.FillWeight = 30F;
            this.Izm.HeaderText = "Единицы измерения";
            this.Izm.Name = "Izm";
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Дополнительная информация";
            this.infoDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.Width = 168;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаписьToolStripMenuItem,
            this.отобразитьскрытьПанельФильтровToolStripMenuItem,
            this.toolStripSeparator1,
            this.выгрузитьДанныеВExcelToolStripMenuItem,
            this.dSuhepbnmLfyystToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(282, 98);
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // отобразитьскрытьПанельФильтровToolStripMenuItem
            // 
            this.отобразитьскрытьПанельФильтровToolStripMenuItem.Name = "отобразитьскрытьПанельФильтровToolStripMenuItem";
            this.отобразитьскрытьПанельФильтровToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.отобразитьскрытьПанельФильтровToolStripMenuItem.Text = "Отобразить/скрыть панель фильтров";
            this.отобразитьскрытьПанельФильтровToolStripMenuItem.Click += new System.EventHandler(this.отобразитьскрытьПанельФильтровToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(278, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // выгрузитьДанныеВExcelToolStripMenuItem
            // 
            this.выгрузитьДанныеВExcelToolStripMenuItem.Name = "выгрузитьДанныеВExcelToolStripMenuItem";
            this.выгрузитьДанныеВExcelToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.выгрузитьДанныеВExcelToolStripMenuItem.Text = "Выгрузить данные в Excel";
            this.выгрузитьДанныеВExcelToolStripMenuItem.Click += new System.EventHandler(this.выгрузитьДанныеВExcelToolStripMenuItem_Click);
            // 
            // dSuhepbnmLfyystToolStripMenuItem
            // 
            this.dSuhepbnmLfyystToolStripMenuItem.Name = "dSuhepbnmLfyystToolStripMenuItem";
            this.dSuhepbnmLfyystToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.dSuhepbnmLfyystToolStripMenuItem.Text = "Выгрузить данные в Word";
            this.dSuhepbnmLfyystToolStripMenuItem.Click += new System.EventHandler(this.dSuhepbnmLfyystToolStripMenuItem_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.skladDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // typeOrdersTableAdapter
            // 
            this.typeOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.buttonNoAdd);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(614, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 524);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxIzm);
            this.groupBox9.Location = new System.Drawing.Point(7, 230);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(169, 53);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ед. изм";
            // 
            // textBoxIzm
            // 
            this.textBoxIzm.Location = new System.Drawing.Point(7, 20);
            this.textBoxIzm.Name = "textBoxIzm";
            this.textBoxIzm.Size = new System.Drawing.Size(151, 20);
            this.textBoxIzm.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDownCount);
            this.groupBox7.Location = new System.Drawing.Point(7, 173);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(169, 50);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Количество";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(7, 20);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(151, 20);
            this.numericUpDownCount.TabIndex = 0;
            // 
            // buttonNoAdd
            // 
            this.buttonNoAdd.Location = new System.Drawing.Point(7, 373);
            this.buttonNoAdd.Name = "buttonNoAdd";
            this.buttonNoAdd.Size = new System.Drawing.Size(169, 23);
            this.buttonNoAdd.TabIndex = 5;
            this.buttonNoAdd.Text = "Отмена";
            this.buttonNoAdd.UseVisualStyleBackColor = true;
            this.buttonNoAdd.Click += new System.EventHandler(this.buttonNoAdd_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(7, 344);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(169, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxAddInfo);
            this.groupBox4.Location = new System.Drawing.Point(7, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Доп. инфо";
            // 
            // textBoxAddInfo
            // 
            this.textBoxAddInfo.Location = new System.Drawing.Point(6, 23);
            this.textBoxAddInfo.Name = "textBoxAddInfo";
            this.textBoxAddInfo.Size = new System.Drawing.Size(156, 20);
            this.textBoxAddInfo.TabIndex = 0;
            this.textBoxAddInfo.Text = "  ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxAddMaterial);
            this.groupBox3.Location = new System.Drawing.Point(7, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Материал";
            // 
            // comboBoxAddMaterial
            // 
            this.comboBoxAddMaterial.DataSource = this.materialsBindingSource;
            this.comboBoxAddMaterial.DisplayMember = "NameMaterial";
            this.comboBoxAddMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddMaterial.FormattingEnabled = true;
            this.comboBoxAddMaterial.Location = new System.Drawing.Point(7, 20);
            this.comboBoxAddMaterial.Name = "comboBoxAddMaterial";
            this.comboBoxAddMaterial.Size = new System.Drawing.Size(151, 21);
            this.comboBoxAddMaterial.TabIndex = 0;
            this.comboBoxAddMaterial.ValueMember = "MaterialsID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerAdd);
            this.groupBox2.Location = new System.Drawing.Point(7, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дата";
            // 
            // dateTimePickerAdd
            // 
            this.dateTimePickerAdd.Location = new System.Drawing.Point(7, 20);
            this.dateTimePickerAdd.Name = "dateTimePickerAdd";
            this.dateTimePickerAdd.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerAdd.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAddType);
            this.groupBox1.Location = new System.Drawing.Point(7, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип ордера";
            // 
            // comboBoxAddType
            // 
            this.comboBoxAddType.DataSource = this.typeOrdersBindingSource;
            this.comboBoxAddType.DisplayMember = "TypeOrdersName";
            this.comboBoxAddType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddType.FormattingEnabled = true;
            this.comboBoxAddType.Location = new System.Drawing.Point(7, 20);
            this.comboBoxAddType.Name = "comboBoxAddType";
            this.comboBoxAddType.Size = new System.Drawing.Size(151, 21);
            this.comboBoxAddType.TabIndex = 0;
            this.comboBoxAddType.ValueMember = "TypeOrdersID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonFiltr);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Controls.Add(this.groupBoxFiltrMaterial);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 119);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.Location = new System.Drawing.Point(3, 90);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(605, 23);
            this.buttonFiltr.TabIndex = 4;
            this.buttonFiltr.Text = "Применить фильтр";
            this.buttonFiltr.UseVisualStyleBackColor = true;
            this.buttonFiltr.Click += new System.EventHandler(this.buttonFiltr_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBoxWho);
            this.groupBox8.Controls.Add(this.comboBoxFiltrWho);
            this.groupBox8.Location = new System.Drawing.Point(444, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(164, 72);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Создатель ордера";
            // 
            // checkBoxWho
            // 
            this.checkBoxWho.AutoSize = true;
            this.checkBoxWho.Location = new System.Drawing.Point(6, 18);
            this.checkBoxWho.Name = "checkBoxWho";
            this.checkBoxWho.Size = new System.Drawing.Size(68, 17);
            this.checkBoxWho.TabIndex = 1;
            this.checkBoxWho.Text = "Активен";
            this.checkBoxWho.UseVisualStyleBackColor = true;
            // 
            // comboBoxFiltrWho
            // 
            this.comboBoxFiltrWho.DataSource = this.usersBindingSource;
            this.comboBoxFiltrWho.DisplayMember = "UserLogin";
            this.comboBoxFiltrWho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrWho.FormattingEnabled = true;
            this.comboBoxFiltrWho.Location = new System.Drawing.Point(6, 42);
            this.comboBoxFiltrWho.Name = "comboBoxFiltrWho";
            this.comboBoxFiltrWho.Size = new System.Drawing.Size(152, 21);
            this.comboBoxFiltrWho.TabIndex = 0;
            this.comboBoxFiltrWho.ValueMember = "UsersID";
            // 
            // groupBoxFiltrMaterial
            // 
            this.groupBoxFiltrMaterial.Controls.Add(this.comboBoxFiltrMaterial);
            this.groupBoxFiltrMaterial.Controls.Add(this.checkBoxmaterial);
            this.groupBoxFiltrMaterial.Location = new System.Drawing.Point(301, 7);
            this.groupBoxFiltrMaterial.Name = "groupBoxFiltrMaterial";
            this.groupBoxFiltrMaterial.Size = new System.Drawing.Size(136, 72);
            this.groupBoxFiltrMaterial.TabIndex = 2;
            this.groupBoxFiltrMaterial.TabStop = false;
            this.groupBoxFiltrMaterial.Text = "Материал";
            // 
            // comboBoxFiltrMaterial
            // 
            this.comboBoxFiltrMaterial.DataSource = this.materialsBindingSource;
            this.comboBoxFiltrMaterial.DisplayMember = "NameMaterial";
            this.comboBoxFiltrMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrMaterial.FormattingEnabled = true;
            this.comboBoxFiltrMaterial.Location = new System.Drawing.Point(6, 42);
            this.comboBoxFiltrMaterial.Name = "comboBoxFiltrMaterial";
            this.comboBoxFiltrMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltrMaterial.TabIndex = 1;
            this.comboBoxFiltrMaterial.ValueMember = "MaterialsID";
            // 
            // checkBoxmaterial
            // 
            this.checkBoxmaterial.AutoSize = true;
            this.checkBoxmaterial.Location = new System.Drawing.Point(7, 18);
            this.checkBoxmaterial.Name = "checkBoxmaterial";
            this.checkBoxmaterial.Size = new System.Drawing.Size(68, 17);
            this.checkBoxmaterial.TabIndex = 0;
            this.checkBoxmaterial.Text = "Активен";
            this.checkBoxmaterial.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimePickerFiltr);
            this.groupBox6.Controls.Add(this.checkBoxDate);
            this.groupBox6.Location = new System.Drawing.Point(153, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(141, 72);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Дата";
            // 
            // dateTimePickerFiltr
            // 
            this.dateTimePickerFiltr.Location = new System.Drawing.Point(7, 42);
            this.dateTimePickerFiltr.Name = "dateTimePickerFiltr";
            this.dateTimePickerFiltr.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerFiltr.TabIndex = 1;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(7, 18);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(68, 17);
            this.checkBoxDate.TabIndex = 0;
            this.checkBoxDate.Text = "Активен";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxFiltrType);
            this.groupBox5.Controls.Add(this.checkBoxType);
            this.groupBox5.Location = new System.Drawing.Point(3, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 73);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Тип ордера";
            // 
            // comboBoxFiltrType
            // 
            this.comboBoxFiltrType.DataSource = this.typeOrdersBindingSource;
            this.comboBoxFiltrType.DisplayMember = "TypeOrdersName";
            this.comboBoxFiltrType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrType.FormattingEnabled = true;
            this.comboBoxFiltrType.Location = new System.Drawing.Point(6, 43);
            this.comboBoxFiltrType.Name = "comboBoxFiltrType";
            this.comboBoxFiltrType.Size = new System.Drawing.Size(128, 21);
            this.comboBoxFiltrType.TabIndex = 1;
            this.comboBoxFiltrType.ValueMember = "TypeOrdersID";
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Location = new System.Drawing.Point(6, 19);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(68, 17);
            this.checkBoxType.TabIndex = 0;
            this.checkBoxType.Text = "Активен";
            this.checkBoxType.UseVisualStyleBackColor = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrder";
            this.Text = "Сахарорафинатный комбинат - Ордера";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBoxFiltrMaterial.ResumeLayout(false);
            this.groupBoxFiltrMaterial.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private SkladDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource typeOrdersBindingSource;
        private SkladDataSetTableAdapters.TypeOrdersTableAdapter typeOrdersTableAdapter;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private SkladDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private SkladDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNoAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxAddInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxAddMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxAddType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonFiltr;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkBoxWho;
        private System.Windows.Forms.ComboBox comboBoxFiltrWho;
        private System.Windows.Forms.GroupBox groupBoxFiltrMaterial;
        private System.Windows.Forms.ComboBox comboBoxFiltrMaterial;
        private System.Windows.Forms.CheckBox checkBoxmaterial;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltr;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxFiltrType;
        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьскрытьПанельФильтровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьДанныеВExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dSuhepbnmLfyystToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBoxIzm;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeOrdersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn whoCreateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izm;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
    }
}