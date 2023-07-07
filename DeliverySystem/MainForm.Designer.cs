namespace DeliverySystem
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddCourier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.btnAssignCourier = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btnAddCourier);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Курьеры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddCourier
            // 
            this.btnAddCourier.Location = new System.Drawing.Point(16, 17);
            this.btnAddCourier.Name = "btnAddCourier";
            this.btnAddCourier.Size = new System.Drawing.Size(113, 36);
            this.btnAddCourier.TabIndex = 1;
            this.btnAddCourier.Text = "Добавить";
            this.btnAddCourier.UseVisualStyleBackColor = true;
            this.btnAddCourier.Click += new System.EventHandler(this.btnAddCourier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.maxWeightDataGridViewTextBoxColumn,
            this.isAvailableDataGridViewCheckBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(933, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxWeightDataGridViewTextBoxColumn
            // 
            this.maxWeightDataGridViewTextBoxColumn.DataPropertyName = "MaxWeight";
            this.maxWeightDataGridViewTextBoxColumn.HeaderText = "Максимальный вес";
            this.maxWeightDataGridViewTextBoxColumn.Name = "maxWeightDataGridViewTextBoxColumn";
            this.maxWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            this.isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            this.isAvailableDataGridViewCheckBoxColumn.HeaderText = "Свободен";
            this.isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            this.isAvailableDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Расположение";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courierBindingSource
            // 
            this.courierBindingSource.DataSource = typeof(DeliverySystem.Courier);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.btnCompleteOrder);
            this.tabPage2.Controls.Add(this.btnAssignCourier);
            this.tabPage2.Controls.Add(this.btnAddOrder);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(297, 17);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(146, 36);
            this.btnCompleteOrder.TabIndex = 5;
            this.btnCompleteOrder.Text = "Заказ доставлен";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // btnAssignCourier
            // 
            this.btnAssignCourier.Location = new System.Drawing.Point(145, 17);
            this.btnAssignCourier.Name = "btnAssignCourier";
            this.btnAssignCourier.Size = new System.Drawing.Size(146, 36);
            this.btnAssignCourier.TabIndex = 4;
            this.btnAssignCourier.Text = "Назначить курьера";
            this.btnAssignCourier.UseVisualStyleBackColor = true;
            this.btnAssignCourier.Click += new System.EventHandler(this.btnAssignCourier_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(26, 17);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(113, 36);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "Добавить";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.startPointDataGridViewTextBoxColumn,
            this.finishPointDataGridViewTextBoxColumn,
            this.startDateDeliveryDataGridViewTextBoxColumn,
            this.finishDateDeliveryDataGridViewTextBoxColumn,
            this.courierDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(26, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(933, 412);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startPointDataGridViewTextBoxColumn
            // 
            this.startPointDataGridViewTextBoxColumn.DataPropertyName = "StartPoint";
            this.startPointDataGridViewTextBoxColumn.HeaderText = "Начальная точка";
            this.startPointDataGridViewTextBoxColumn.Name = "startPointDataGridViewTextBoxColumn";
            this.startPointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishPointDataGridViewTextBoxColumn
            // 
            this.finishPointDataGridViewTextBoxColumn.DataPropertyName = "FinishPoint";
            this.finishPointDataGridViewTextBoxColumn.HeaderText = "Конечная точка";
            this.finishPointDataGridViewTextBoxColumn.Name = "finishPointDataGridViewTextBoxColumn";
            this.finishPointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDeliveryDataGridViewTextBoxColumn
            // 
            this.startDateDeliveryDataGridViewTextBoxColumn.DataPropertyName = "StartDateDelivery";
            this.startDateDeliveryDataGridViewTextBoxColumn.HeaderText = "Начало доставки";
            this.startDateDeliveryDataGridViewTextBoxColumn.Name = "startDateDeliveryDataGridViewTextBoxColumn";
            this.startDateDeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishDateDeliveryDataGridViewTextBoxColumn
            // 
            this.finishDateDeliveryDataGridViewTextBoxColumn.DataPropertyName = "FinishDateDelivery";
            this.finishDateDeliveryDataGridViewTextBoxColumn.HeaderText = "Окончание доставки";
            this.finishDateDeliveryDataGridViewTextBoxColumn.Name = "finishDateDeliveryDataGridViewTextBoxColumn";
            this.finishDateDeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courierDataGridViewTextBoxColumn
            // 
            this.courierDataGridViewTextBoxColumn.DataPropertyName = "Courier";
            this.courierDataGridViewTextBoxColumn.HeaderText = "Курьер";
            this.courierDataGridViewTextBoxColumn.Name = "courierDataGridViewTextBoxColumn";
            this.courierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DeliverySystem.Order);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все курьеры",
            "Свободные",
            "Занятые"});
            this.comboBox1.Location = new System.Drawing.Point(183, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Все заказы",
            "Новые",
            "В работе",
            "Завершенные"});
            this.comboBox2.Location = new System.Drawing.Point(489, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 27);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 601);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courierBindingSource;
        private System.Windows.Forms.Button btnAddCourier;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button btnAssignCourier;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

