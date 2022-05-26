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
    public delegate void SubmitHandler4(OrderList customer);
    public partial class Form6 : Form
    {
        public SubmitHandler4 onSubmit;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new tempdbEntities();
            string[] subs = comboBox1.Text.Split(' ');

            int id = Convert.ToInt32(textBox1.Text);
            int idOrder = Convert.ToInt32(textBox2.Text);
            int idProduct = Convert.ToInt32(subs[0]);
            int count= Convert.ToInt32(textBox3.Text);
            onSubmit.Invoke(new OrderList(id, idOrder, idProduct, count));
            this.Close();
        }
    }
}
