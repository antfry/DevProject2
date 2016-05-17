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
    public partial class frmCreateSale : Form
    {
        public frmCreateSale()
        {
            InitializeComponent();



            comboBox1.Items.Clear();

            comboBox1.Items.Insert(0, "");

            StockTake st = new StockTake();
            List<string> results = st.GetItemRows("SELECT * FROM stocktable");
            for (int i = 0; i < results.Count; i++)
            {
                comboBox1.Items.Insert((i + 1), results[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            string time = DateTime.Now.Hour + ":" + DateTime.Now.Minute.ToString();

            int item = comboBox1.SelectedIndex;
            string itemString = "" + item;
            string inputQty = textBox1.Text;
            int outputQty;
            string name = "";
            double price = 0;

            if (item > 0)
            {
                StockTake st = new StockTake();
                name = st.GetName(itemString);
                price = st.GetPrice(itemString);

                if (int.TryParse(inputQty, out outputQty))
                {
                    price = price * outputQty;

                    AddItem ai = new AddItem();
                    ai.Update(name, outputQty, 1);
                    AddSalesRecords asr = new AddSalesRecords();
                    asr.InsertIntoTable(name, outputQty, price, date, time);

                    MessageBox.Show("You have succesfully sold " + outputQty + " " + name + "'s for $" + price + ".");

                }
                else {
                    MessageBox.Show("The Quantity value must be a number. \nPlease try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //confirmsale_l.Text = "Quantity can only be numeric.";
                }

            }
            else {
                MessageBox.Show("You have not yet chosen an Item from the list. \nPlease try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //confirmsale_l.Text = "You have not yet chosen an item.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
