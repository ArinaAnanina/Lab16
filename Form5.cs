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
    public delegate void SubmitHandler3(Order customer);
    public partial class Form5 : Form
    {
        public SubmitHandler3 onSubmit;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new tempdbEntities();
            string[] subs = comboBox1.Text.Split(' ');

            Int32 id = Convert.ToInt32(textBox1.Text);
            int idCustomer = Convert.ToInt32(subs[0]);
            System.DateTime data = dateTimePicker1.Value;
            int trackNumber = Convert.ToInt32(textBox4.Text);
            onSubmit.Invoke(new Order(id, idCustomer, data, trackNumber));
            this.Close();
        }
    }
}
