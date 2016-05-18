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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMakeSale m = new frmMakeSale();
            m.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmViewSales m = new frmViewSales();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();

            this.Close();
        }
    }
}
