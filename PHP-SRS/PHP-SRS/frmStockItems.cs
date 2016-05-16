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
    public partial class frmStockItems : Form
    {
        public frmStockItems()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Main m = new Main();
            m.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddNewItem m = new frmAddNewItem();
            m.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUpdateItem m = new frmUpdateItem();
            m.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmViewAllStock m = new frmViewAllStock();
            m.Show();
            this.Hide();
        }
    }
}
