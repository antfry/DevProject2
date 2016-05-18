using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRS
{
    public partial class frmMakeSale : Form
    {
        public frmMakeSale()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name;
            string description;
            string attribute;
            int quantity;
            double price;
            name = textBox1.ToString();
            quantity = Convert.ToInt32(comboBox1.Text);
            quantity = int.Parse(comboBox1.Text);
            price = Convert.ToDouble(textBox5.Text);
            price = double.Parse(textBox5.Text);


            //Method to Add Item into Database
            AddSale s = new AddSale();
            s.InsertIntoTable(name, quantity, price);


            // MessageShow

            MessageBox.Show("Item added to successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSales m = new frmSales();
            m.Show();
            this.Hide();
        }

    }
}
