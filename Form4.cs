using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16_Базы_данных_
{
    public partial class Form4 : Form
    {
        Order currentOrder;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Order order)
        {
            currentOrder = order;
            InitializeComponent();
        }
        public List<OrderList> GetOrderLists()
        {
            var context = new tempdbEntities();
            var orders = context.OrderList.ToList();
            return orders;
        }
        private void AddOrderListButton_Click(object sender, EventArgs e)
        {
            int id;
            Form6 form = new Form6();
            List<OrderList> orl = GetOrderLists();
            OrderList lastOrder = orl[orl.Count - 1];
            id = lastOrder.Id;
            
            form.ShowAdd(id, currentOrder.Id);
            form.onSubmit += (order) => {
                tempdbEntities context = new tempdbEntities();

                context.OrderList.Add(order);

                context.SaveChanges();
                GridUpdate();
            };

        }

        private void OrderListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrderListGrid.Columns[e.ColumnIndex].Name == "DeleteOrderList")
            {

                if (MessageBox.Show($"Вы действительно хотите удалить этот элемент {OrderListGrid[0, e.RowIndex].Value}?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tempdbEntities context = new tempdbEntities();
                    OrderList currentOrder = (OrderListGrid.DataSource as List<OrderList>)[e.RowIndex];

                    OrderList order = context.OrderList
                        .Where(o => o.Id == currentOrder.Id)
                        .FirstOrDefault();

                    context.OrderList.Remove(order);
                    context.SaveChanges();
                    GridUpdate();
                }
            }
            if (OrderListGrid.Columns[e.ColumnIndex].Name == "EditOrderList")
            {
                OrderList currentOrder = (OrderListGrid.DataSource as List<OrderList>)[e.RowIndex];

                Form6 form = new Form6();
                form.ShowChange(currentOrder);
                form.onSubmit += (order) => {
                    tempdbEntities context = new tempdbEntities();

                    OrderList dbProduct = context.OrderList.Find(order.Id);
                    dbProduct.ProductId = order.ProductId;
                    dbProduct.Count = order.Count;

                    context.SaveChanges();
                    GridUpdate();
                };
            }
        }
        
        private void Form4_Shown(object sender, EventArgs e)
        {
            
        }

        private void OrderListGrid_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.OrderListGrid.Columns[e.ColumnIndex].Name == "productIdDataGridViewTextBoxColumn")
            {
                Product cust = e.Value as Product;

                e.Value = $"{cust.Name}";
                e.FormattingApplied = true;
            }
        }
    }
}
