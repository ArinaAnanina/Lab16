using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16_Базы_данных_
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using(IDbConnection connection = new SqlConnection(Properties.Settings.Default.DdConnection))
            {
                /*IDbCommand command = new SqlCommand("SELECT * FROM Customers");
                command.Connection = connection;
                connection.Open();
                IDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Идентификатор: {reader.GetInt32(0)} \t Данные: {reader.GetString(1)}, {reader.GetString(2)}, {(Int16)reader.GetValue(3)} ");
                }
                
                var cust = GetCustomer();
                foreach (Customer c in cust)
                {
                    Console.WriteLine($"Идентификатор: {c.Id}, Имя {c.Name}, Фамилия {c.Surname}, Возраст {c.Age}, Город проживания {c.Location}");
                }*/
                //var cust = GetCustomer();
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
        private static List<Customer> GetCustomer()
        {
            var context = new tempdbEntities();
            var customers = context.Customers.ToList();
            return customers;
        }
    }
}
