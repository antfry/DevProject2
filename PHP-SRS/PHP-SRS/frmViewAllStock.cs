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
    public partial class frmViewAllStock : Form
    {
        public frmViewAllStock()
        {
            InitializeComponent();
            StockSales st = new StockSales();
            st.SelectFromTable("SELECT * FROM stocktable", dataGridStock);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStockItems m = new frmStockItems();
            m.Show();
            this.Close();
        }

        private void dataGridSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
