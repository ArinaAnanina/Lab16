using System.Collections.Generic;
using System.Linq;
using System;

namespace Lab16_Базы_данных_
{
    partial class Form4
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
        public void GridUpdate()
        {
            int count = 0;
            Show();
            var context = new tempdbEntities();
            var query = context.OrderList
                        .Where(o => o.OrderId == currentOrder.Id).Select(o => o);
            var counts = context.OrderList.Where(o => o.OrderId == currentOrder.Id).Select(o => o.Count);
            if (counts.Count() == 0)
            {
                count = 0;
            }
            else
            {
                count = counts.Sum();
            }
            textBox1.Text = count.ToString();
            var orders = query.ToList();
            OrderListGrid.DataSource = orders;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OrderListGrid = new System.Windows.Forms.DataGridView();
            this.AddOrderListButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditOrderList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteOrderList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderListGrid
            // 
            this.OrderListGrid.AutoGenerateColumns = false;
            this.OrderListGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OrderListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.EditOrderList,
            this.DeleteOrderList});
            this.OrderListGrid.DataSource = this.orderListBindingSource;
            this.OrderListGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderListGrid.Location = new System.Drawing.Point(0, 54);
            this.OrderListGrid.Name = "OrderListGrid";
            this.OrderListGrid.RowHeadersWidth = 51;
            this.OrderListGrid.RowTemplate.Height = 24;
            this.OrderListGrid.Size = new System.Drawing.Size(1122, 412);
            this.OrderListGrid.TabIndex = 0;
            this.OrderListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderListGrid_CellContentClick);
            this.OrderListGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.OrderListGrid_CellFormatting_1);
            // 
            // AddOrderListButton
            // 
            this.AddOrderListButton.Location = new System.Drawing.Point(0, 5);
            this.AddOrderListButton.Name = "AddOrderListButton";
            this.AddOrderListButton.Size = new System.Drawing.Size(203, 43);
            this.AddOrderListButton.TabIndex = 1;
            this.AddOrderListButton.Text = "Add Element";
            this.AddOrderListButton.UseVisualStyleBackColor = true;
            this.AddOrderListButton.Click += new System.EventHandler(this.AddOrderListButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Общее кол-во товаров:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(426, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 3;
            // 
            // EditOrderList
            // 
            this.EditOrderList.HeaderText = "Edit";
            this.EditOrderList.MinimumWidth = 6;
            this.EditOrderList.Name = "EditOrderList";
            this.EditOrderList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditOrderList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditOrderList.Text = "Edit";
            this.EditOrderList.UseColumnTextForButtonValue = true;
            this.EditOrderList.Width = 125;
            // 
            // DeleteOrderList
            // 
            this.DeleteOrderList.HeaderText = "Delete";
            this.DeleteOrderList.MinimumWidth = 6;
            this.DeleteOrderList.Name = "DeleteOrderList";
            this.DeleteOrderList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteOrderList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteOrderList.Text = "Delete";
            this.DeleteOrderList.UseColumnTextForButtonValue = true;
            this.DeleteOrderList.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "Products";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderListBindingSource
            // 
            this.orderListBindingSource.DataSource = typeof(Lab16_Базы_данных_.OrderList);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 466);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddOrderListButton);
            this.Controls.Add(this.OrderListGrid);
            this.Name = "Form4";
            this.Text = "OrderList";
            this.Shown += new System.EventHandler(this.Form4_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderListGrid;
        private System.Windows.Forms.BindingSource orderListBindingSource;
        private System.Windows.Forms.Button AddOrderListButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditOrderList;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteOrderList;
    }
}