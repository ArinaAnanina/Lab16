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
    public delegate void SubmitHandler(Customer customer);
    public partial class Form2 : Form
    {

        public SubmitHandler onSubmit;
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var context = new tempdbEntities();

            Int32 id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string surname = textBox3.Text;
            short age = Convert.ToInt16(textBox4.Text);
            string location = textBox5.Text;

            onSubmit.Invoke(new Customer(id, name, surname, age, location));
            this.Close();
        }
    }
}
