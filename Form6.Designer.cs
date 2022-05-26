using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace Lab16_Базы_данных_
{
    partial class Form6
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
        private static List<string> GetProducts()
        {
            var context = new tempdbEntities();
            var query = from o in context.Products
                        select o.Id + " " + o.Name;
            var product = query.ToList();
            return product;
        }
        public string GetCurrentProduct(int idProduct)
        {
            List<string> products = GetProducts();
            foreach (string s in products)
            {
                if (s.Contains(idProduct.ToString()))
                {
                    return s;
                }
            }
            return "";
        }
        
        public void ShowChange(OrderList order)
        {
            this.Text = "CHANGE";
            this.label1.Text = "Изменение элемента";
            this.button1.Text = "Изменить";
            this.textBox1.Text = order.Id.ToString();
            this.textBox1.ReadOnly = true;
            this.comboBox1.DataSource = GetProducts();
            this.comboBox1.Text = GetCurrentProduct(order.ProductId);
            this.textBox2.Text = order.ProductId.ToString();
            this.textBox3.Text = order.Count.ToString();
            Show();
        }
        public void ShowAdd(int id, int idOrder)
        {
            this.textBox1.Text = (id + 1).ToString();
            this.textBox2.Text = (idOrder ).ToString();
            this.comboBox1.DataSource = GetProducts();
            Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(326, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 22);
            this.textBox1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Выберите товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Номер заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Добавление элемента";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(326, 22);
            this.textBox2.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Id";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 301);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(326, 22);
            this.textBox3.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Введите кол-во";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "ADD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}