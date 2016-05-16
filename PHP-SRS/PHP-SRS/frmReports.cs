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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            csv.CSVStock();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            csv.CSVSales();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.SalesReport();
            MessageBox.Show("Total Prices of Sales Generated");
        }
    }
}
