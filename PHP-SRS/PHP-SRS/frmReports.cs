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
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            csv.CSVStockSales();
            MessageBox.Show("Sales Record Exported to CSV-StockSales.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            csv.CSVStockSales();
            MessageBox.Show("Sales Record Exported to CSV-StockSales.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.SalesReport();
            MessageBox.Show("Total Prices of Sales Generated");
        }
    }
}
