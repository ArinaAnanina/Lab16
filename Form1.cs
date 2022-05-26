using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16_Базы_данных_
{
    public partial class Form1 : Form
    {

        public CustomersFilter customersFilter = new CustomersFilter();


        public Form1()
        {
            InitializeComponent();
            GridUpdate();
            GridUpdate2();
            GridUpdate3();
            comboBox1.DataSource = cities;
        }
        private void GridUpdate()
        {
            List<Customer> c = GetCustomer();
            CustomersGrid.DataSource = c;
        }
        private void GridUpdate2()
        {
            List<Product> pr = GetProducts();
            ProductsGrid.DataSource = pr;
        }
        private void GridUpdate3()
        {
            List<Order> or = GetOrders();
            OrdersGrid.DataSource = or;
        }
        private List<Customer> GetCustomer()
        {
            var context = new tempdbEntities();
            var customersDB = context.Customers;

            IQueryable<Customer> customersQuery = null;

            if (customersFilter.Id != "")
            {
                customersQuery = customersDB.Where(o => o.Name == customersFilter.Id);
            }
            if (customersFilter.Location != "")
            {
                customersQuery = customersDB.Where(o => o.Location == customersFilter.Location) ;
            }
            return customersQuery != null ? customersQuery.ToList() : customersDB.ToList();
        }
        private List<Order> GetOrders()
        {
            var context = new tempdbEntities();
            var products = context.Order.ToList();
            return products;
        }
        private List<Product> GetProducts()
        {
            var context = new tempdbEntities();
            var products = context.Products.ToList();
            return products;
        }
        private void CustomersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomersGrid.Columns[e.ColumnIndex].Name == "DeleteCustomer")
            {
                
                if (MessageBox.Show($"Вы действительно хотите удалить этот элемент {CustomersGrid[0, e.RowIndex].Value}?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tempdbEntities context = new tempdbEntities();
                    Customer currentCustomer = (CustomersGrid.DataSource as List<Customer>)[e.RowIndex];

                    Customer order = context.Customers
                        .Where(o => o.Id == currentCustomer.Id)
                        .FirstOrDefault();

                    context.Customers.Remove(order);
                    context.SaveChanges();
                    GridUpdate();
                }
            }
            if (CustomersGrid.Columns[e.ColumnIndex].Name == "ChangeCustomer")
            {
                Customer currentCustomer = (CustomersGrid.DataSource as List<Customer>)[e.RowIndex];

                Form2 form = new Form2();
                form.ShowChange(currentCustomer);
                form.onSubmit += (customer) => {
                    tempdbEntities context = new tempdbEntities();

                    Customer dbCustomer = context.Customers.Find(customer.Id);
                    dbCustomer.Name = customer.Name;
                    dbCustomer.Surname = customer.Surname;
                    dbCustomer.Age = customer.Age;
                    dbCustomer.Location = customer.Location;

                    context.SaveChanges();
                    GridUpdate();
                };
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            int custId = 0;
            if (CustomersGrid.Rows.Count != 0)
            {
                custId = (CustomersGrid.DataSource as List<Customer>)[CustomersGrid.Rows.Count - 1].Id;
            }
            form.ShowAdd(custId);
            form.onSubmit += (customer) => {
                tempdbEntities context = new tempdbEntities();

                context.Customers.Add(customer);

                context.SaveChanges();
                GridUpdate();
            };
        }

        private void ProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsGrid.Columns[e.ColumnIndex].Name == "DeleteProduct")
            {

                if (MessageBox.Show($"Вы действительно хотите удалить этот элемент {ProductsGrid[0, e.RowIndex].Value}?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tempdbEntities context = new tempdbEntities();
                    Product currentProduct = (ProductsGrid.DataSource as List<Product>)[e.RowIndex];

                    Product order = context.Products
                        .Where(o => o.Id == currentProduct.Id)
                        .FirstOrDefault();

                    context.Products.Remove(order);
                    context.SaveChanges();
                    GridUpdate2();
                }
            }
            if (ProductsGrid.Columns[e.ColumnIndex].Name == "EditProduct")
            {
                Product currentProduct = (ProductsGrid.DataSource as List<Product>)[e.RowIndex];

                Form3 form = new Form3();
                form.ShowChange(currentProduct);
                form.onSubmit += (product) => {
                    tempdbEntities context = new tempdbEntities();

                    Product dbProduct = context.Products.Find(product.Id);
                    dbProduct.Name = product.Name;

                    context.SaveChanges();
                    GridUpdate2();
                };
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            int prodId = 0;
            if (ProductsGrid.Rows.Count != 0)
            {
                prodId = (ProductsGrid.DataSource as List<Product>)[ProductsGrid.Rows.Count - 1].Id;
            }
            
            form.ShowAdd(prodId);
            form.onSubmit += (product) => {
                tempdbEntities context = new tempdbEntities();

                context.Products.Add(product);

                context.SaveChanges();
                GridUpdate2();
            };
        }

        private void OrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrdersGrid.Columns[e.ColumnIndex].Name == "OrderListButton")
            {
                Order currentOrder = (OrdersGrid.DataSource as List<Order>)[e.RowIndex];
                Form4 form = new Form4(currentOrder);
                int id = currentOrder.Id;
                form.GridUpdate();
                //form.Show();
            }
            if (OrdersGrid.Columns[e.ColumnIndex].Name == "DeleteOrder")
            {

                if (MessageBox.Show($"Вы действительно хотите удалить этот элемент {OrdersGrid[0, e.RowIndex].Value}?", "Messege", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tempdbEntities context = new tempdbEntities();
                    Order currentOrder = (OrdersGrid.DataSource as List<Order>)[e.RowIndex];

                    Order order = context.Order
                        .Where(o => o.Id == currentOrder.Id)
                        .FirstOrDefault();

                    context.Order.Remove(order);
                    context.SaveChanges();
                    GridUpdate3();
                }
            }
            if (OrdersGrid.Columns[e.ColumnIndex].Name == "EditOrder")
            {
                Order currentOrder = (OrdersGrid.DataSource as List<Order>)[e.RowIndex];

                Form5 form = new Form5();
                form.ShowChange(currentOrder);
                form.onSubmit += (order) => {
                    tempdbEntities context = new tempdbEntities();

                    Order dbProduct = context.Order.Find(order.Id);
                    dbProduct.IdCustomer = order.IdCustomer;
                    dbProduct.OrderDate = order.OrderDate;
                    dbProduct.TrackNumber = order.TrackNumber;

                    context.SaveChanges();
                    GridUpdate3();
                };
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            int orderId = 0;
            if (OrdersGrid.Rows.Count != 0)
            {
                orderId = (OrdersGrid.DataSource as List<Order>)[OrdersGrid.Rows.Count - 1].Id;
            }
            form.ShowAdd(orderId);
            form.onSubmit += (order) => {
                tempdbEntities context = new tempdbEntities();

                context.Order.Add(order);

                context.SaveChanges();
                GridUpdate3();
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string location = comboBox1.Text;
                customersFilter.Location = location;
            }
            catch
            {
                customersFilter.Location = "";
            }
            GridUpdate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text;
                customersFilter.Id = id;
            } catch
            {
                customersFilter.Id = "";
            }
            GridUpdate();
        }

        private void CustomersGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void OrdersGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.OrdersGrid.Columns[e.ColumnIndex].Name == "idCustomerDataGridViewTextBoxColumn")
            {
                Customer cust = e.Value as Customer;

                e.Value = $"{cust.Name} {cust.Surname}";
                e.FormattingApplied = true;
            }
        }
    }
    public class CustomersFilter
    {
        public string Id;
        public string Location;
        public CustomersFilter()
        {
            this.Id = "";
            this.Location = "";
        }
    }
}
