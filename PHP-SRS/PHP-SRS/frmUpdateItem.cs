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

            string name = textBox1.ToString();



            UpdateTableByName(string name, int quantity, int minusCheck)
        }
    }
}
