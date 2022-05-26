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
    public delegate void SubmitHandler2(Product product);
    public partial class Form3 : Form
    {
        public SubmitHandler2 onSubmit;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new tempdbEntities();

            Int32 id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            
            onSubmit.Invoke(new Product(id, name));
            this.Close();
        }
    }
}
