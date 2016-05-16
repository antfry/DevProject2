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
    public partial class frmAddNewItem : Form
    {
        public frmAddNewItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStockItems m = new frmStockItems();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name;
            string description;
            string attribute;
            int quantity;
            double price;
            name = textBox1.Text.ToString();
            description = textBox2.ToString();
            attribute = "TEST";
            quantity = Convert.ToInt32(textBox3.Text);
            quantity = int.Parse(textBox3.Text);
            price = Convert.ToDouble(textBox5.Text);
            price = double.Parse(textBox5.Text);


            //Method to Add Item into Database
            AddItem ai = new AddItem();
            ai.InsertIntoTable(name, description, attribute, quantity, price);


            // MessageShow

            MessageBox.Show("Item added to successfully.");

        
        }
    }
}
