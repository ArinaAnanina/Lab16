
namespace Lab16_Базы_данных_
{
    partial class Form1
    {
        public string[] cities = new string[12] { "", "Perm", "Moscow", "Ufa", "St.Petersburg", "Kirov", "Penza", "Novosibirsk", "Volgograd", "Voronezh", "Dmitrov", "Kazan" };
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
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.EditProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderListButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.OrdersTab.SuspendLayout();
            this.CustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.AllowUserToAddRows = false;
            this.OrdersGrid.AllowUserToDeleteRows = false;
            this.OrdersGrid.AutoGenerateColumns = false;
            this.OrdersGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OrdersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idCustomerDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.trackNumberDataGridViewTextBoxColumn,
            this.OrderListButton,
            this.EditOrder,
            this.DeleteOrder});
            this.OrdersGrid.DataSource = this.orderBindingSource1;
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrdersGrid.Location = new System.Drawing.Point(3, 48);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrdersGrid.RowHeadersWidth = 50;
            this.OrdersGrid.RowTemplate.Height = 24;
            this.OrdersGrid.Size = new System.Drawing.Size(1247, 420);
            this.OrdersGrid.TabIndex = 0;
            this.OrdersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGrid_CellContentClick);
            this.OrdersGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.OrdersGrid_CellFormatting);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(2, 3);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(220, 39);
            this.AddOrderButton.TabIndex = 1;
            this.AddOrderButton.Text = "Add Element";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OrdersTab);
            this.tabControl1.Controls.Add(this.CustomersTab);
            this.tabControl1.Controls.Add(this.ProductsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1261, 500);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Tag = "";
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.AddOrderButton);
            this.OrdersTab.Controls.Add(this.OrdersGrid);
            this.OrdersTab.Location = new System.Drawing.Point(4, 25);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTab.Size = new System.Drawing.Size(1253, 471);
            this.OrdersTab.TabIndex = 0;
            this.OrdersTab.Text = "Заказы";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.comboBox1);
            this.CustomersTab.Controls.Add(this.label2);
            this.CustomersTab.Controls.Add(this.textBox1);
            this.CustomersTab.Controls.Add(this.label1);
            this.CustomersTab.Controls.Add(this.AddCustomerButton);
            this.CustomersTab.Controls.Add(this.CustomersGrid);
            this.CustomersTab.Location = new System.Drawing.Point(4, 25);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTab.Size = new System.Drawing.Size(1253, 471);
            this.CustomersTab.TabIndex = 1;
            this.CustomersTab.Text = "Клиенты";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(781, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Показать всех, кто живёт в городе:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по ключу:";
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(3, 3);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(220, 39);
            this.AddCustomerButton.TabIndex = 3;
            this.AddCustomerButton.Text = "Add Element";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.AllowUserToAddRows = false;
            this.CustomersGrid.AllowUserToDeleteRows = false;
            this.CustomersGrid.AutoGenerateColumns = false;
            this.CustomersGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.CustomersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.ChangeCustomer,
            this.DeleteCustomer});
            this.CustomersGrid.DataSource = this.customerBindingSource3;
            this.CustomersGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomersGrid.Location = new System.Drawing.Point(3, 48);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.ReadOnly = true;
            this.CustomersGrid.RowHeadersWidth = 51;
            this.CustomersGrid.RowTemplate.Height = 24;
            this.CustomersGrid.Size = new System.Drawing.Size(1247, 420);
            this.CustomersGrid.TabIndex = 2;
            this.CustomersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGrid_CellContentClick);
            this.CustomersGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CustomersGrid_CellFormatting);
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.AddProductButton);
            this.ProductsTab.Controls.Add(this.ProductsGrid);
            this.ProductsTab.Location = new System.Drawing.Point(4, 25);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Size = new System.Drawing.Size(1253, 471);
            this.ProductsTab.TabIndex = 2;
            this.ProductsTab.Text = "Товары";
            this.ProductsTab.UseVisualStyleBackColor = true;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(3, 3);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(220, 39);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Add Element";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AutoGenerateColumns = false;
            this.ProductsGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ProductsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1,
            this.EditProduct,
            this.DeleteProduct});
            this.ProductsGrid.DataSource = this.productBindingSource;
            this.ProductsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProductsGrid.Location = new System.Drawing.Point(0, 49);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.RowHeadersWidth = 51;
            this.ProductsGrid.RowTemplate.Height = 24;
            this.ProductsGrid.Size = new System.Drawing.Size(1253, 422);
            this.ProductsGrid.TabIndex = 0;
            this.ProductsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellContentClick);
            // 
            // EditProduct
            // 
            this.EditProduct.DataPropertyName = "Id";
            this.EditProduct.HeaderText = "Edit";
            this.EditProduct.MinimumWidth = 6;
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Text = "Edit";
            this.EditProduct.UseColumnTextForButtonValue = true;
            this.EditProduct.Width = 125;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.DataPropertyName = "Id";
            this.DeleteProduct.HeaderText = "Delete";
            this.DeleteProduct.MinimumWidth = 6;
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseColumnTextForButtonValue = true;
            this.DeleteProduct.Width = 125;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(Lab16_Базы_данных_.Order);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // ChangeCustomer
            // 
            this.ChangeCustomer.DataPropertyName = "Id";
            this.ChangeCustomer.HeaderText = "Edit";
            this.ChangeCustomer.MinimumWidth = 6;
            this.ChangeCustomer.Name = "ChangeCustomer";
            this.ChangeCustomer.ReadOnly = true;
            this.ChangeCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChangeCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChangeCustomer.Text = "Edit";
            this.ChangeCustomer.UseColumnTextForButtonValue = true;
            this.ChangeCustomer.Width = 125;
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.DataPropertyName = "Id";
            this.DeleteCustomer.HeaderText = "Delete";
            this.DeleteCustomer.MinimumWidth = 6;
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.ReadOnly = true;
            this.DeleteCustomer.Text = "Delete";
            this.DeleteCustomer.UseColumnTextForButtonValue = true;
            this.DeleteCustomer.Width = 125;
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataSource = typeof(Lab16_Базы_данных_.Customer);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lab16_Базы_данных_.Product);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Lab16_Базы_данных_.Order);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Lab16_Базы_данных_.Form1);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idCustomerDataGridViewTextBoxColumn
            // 
            this.idCustomerDataGridViewTextBoxColumn.DataPropertyName = "Customers";
            this.idCustomerDataGridViewTextBoxColumn.HeaderText = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCustomerDataGridViewTextBoxColumn.Name = "idCustomerDataGridViewTextBoxColumn";
            this.idCustomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // trackNumberDataGridViewTextBoxColumn
            // 
            this.trackNumberDataGridViewTextBoxColumn.DataPropertyName = "TrackNumber";
            this.trackNumberDataGridViewTextBoxColumn.HeaderText = "TrackNumber";
            this.trackNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trackNumberDataGridViewTextBoxColumn.Name = "trackNumberDataGridViewTextBoxColumn";
            this.trackNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.trackNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrderListButton
            // 
            this.OrderListButton.DataPropertyName = "OrderList";
            this.OrderListButton.HeaderText = "OrderList";
            this.OrderListButton.MinimumWidth = 6;
            this.OrderListButton.Name = "OrderListButton";
            this.OrderListButton.ReadOnly = true;
            this.OrderListButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderListButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OrderListButton.Text = "Open";
            this.OrderListButton.UseColumnTextForButtonValue = true;
            this.OrderListButton.Width = 125;
            // 
            // EditOrder
            // 
            this.EditOrder.DataPropertyName = "Id";
            this.EditOrder.HeaderText = "Edit";
            this.EditOrder.MinimumWidth = 6;
            this.EditOrder.Name = "EditOrder";
            this.EditOrder.ReadOnly = true;
            this.EditOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditOrder.Text = "Edit";
            this.EditOrder.UseColumnTextForButtonValue = true;
            this.EditOrder.Width = 125;
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.DataPropertyName = "Id";
            this.DeleteOrder.HeaderText = "Delete";
            this.DeleteOrder.MinimumWidth = 6;
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.ReadOnly = true;
            this.DeleteOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteOrder.Text = "Delete";
            this.DeleteOrder.UseColumnTextForButtonValue = true;
            this.DeleteOrder.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.OrdersTab.ResumeLayout(false);
            this.CustomersTab.ResumeLayout(false);
            this.CustomersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.TabPage CustomersTab;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.TabPage ProductsTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ChangeCustomer;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCustomer;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn EditProduct;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn OrderListButton;
        private System.Windows.Forms.DataGridViewButtonColumn EditOrder;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteOrder;
    }
}

