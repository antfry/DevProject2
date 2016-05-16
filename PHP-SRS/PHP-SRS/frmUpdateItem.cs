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
    public partial class frmUpdateItem : Form
    {
        public frmUpdateItem()
        {
            InitializeComponent();

            comboBox1.Items.Clear();

            StockTake st = new StockTake();

            List<string> results = st.GetNameRows("SELECT name FROM stocktable");

            for (int i = 0; i < results.Count; i++)
            {
                comboBox1.Items.Insert(i, results[i]);
            }

        }

        private void frmUpdateItem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStockItems m = new frmStockItems();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputID = comboBox1.GetItemText(comboBox1.SelectedItem);
            //string inputID = comboBox1.GetItemText(comboBox1.SelectedItem);
            string inputQty = textBox1.Text;

            int value1;
            int inputQtyOut = 0;

            if (inputID == "" || inputQty == "")
            {
                MessageBox.Show("Nothing has been chosen or entered. \nPlease try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                if (int.TryParse(inputQty, out value1))
                {
                    inputQtyOut = value1;

                    AddItem ai = new AddItem();
                    ai.UpdateTableByName(inputID, inputQtyOut, 0);

                    MessageBox.Show("The item has been updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //confirmbyid_label.Text = "The item has been updated.";
                }
                else {
                    MessageBox.Show("The Quantity Value must be a number. \nPlease try again.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //confirmbyid_label.Text = "Quantity needs numeric input only.";
                }
            }

            textBox1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
