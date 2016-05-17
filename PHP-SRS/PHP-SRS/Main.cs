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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();




            StockTake st = new StockTake();
            List<string> rows = st.GetNameRows("SELECT * FROM stocktable");

            textBox1.Text = "";

            int quantity;
            string name;

            if (rows.Count() == 0)
            {
                textBox1.Text = "There are no critical items.";
            }

            for (int i = 0; i < rows.Count(); i++)
            {
                name = st.GetName("" + (i + 1));
                quantity = st.GetQuantity("" + (i + 1));

                if (quantity < 50)
                {
                    textBox1.Text += name + " only has " + quantity + " items in stock!\n";
                }
            }








        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStockItems m = new frmStockItems();
            m.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSales m = new frmSales();
            m.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReports m = new frmReports();
            m.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
