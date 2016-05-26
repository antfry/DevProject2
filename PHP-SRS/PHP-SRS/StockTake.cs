using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PHP_SRS
{
    class StockTake
    {
        public void SelectFromTable(string selectQuery, DataGridView dataGridStock)
        {
            string query = selectQuery; //Acquires the SQL SELECT statement from the reference
            DBConnect db = new DBConnect();

            try
            {
                if (db.OpenConnection() == true)
                {

                    DataSet ds = new DataSet();

                    var mysqlDA = new MySqlDataAdapter(selectQuery, db.conn);
                    mysqlDA.Fill(ds);
                    dataGridStock.DataSource = ds.Tables[0].DefaultView;
                }
            }
            catch
            {
                throw;
            }
        }





        public List<string> GetNameRows(string selectQuery)
        {
            DBConnect db = new DBConnect();
            List<string> results = new List<string>();

            db.OpenConnection();
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, db.conn);
                MySqlDataReader readResults = selectCommand.ExecuteReader();

                while (readResults.Read())
                {
                    results.Add("" + readResults["name"]);
                }
                return results;
        }



        public string GetName(string id)
        {
            DBConnect db = new DBConnect();
            AddItem ai = new AddItem();

            string selectQuery = "SELECT Name FROM stocktable WHERE ID = " + id;
            string name = "";

            db.OpenConnection(); //Opens the connection


            MySqlCommand selectCommand = new MySqlCommand(selectQuery, db.conn);
            MySqlDataReader readResults = selectCommand.ExecuteReader();

            while (readResults.Read())
            {
                name = "" + readResults["name"];
            }

            db.CloseConnection();

            return name;
        }

        public double GetPrice(string id)
        {
            DBConnect db = new DBConnect();
            AddItem ai = new AddItem();
            string selectQuery = "SELECT Price FROM stocktable WHERE ID = " + id;
            double price = 0;

            db.OpenConnection();    

            MySqlCommand selectCommand = new MySqlCommand(selectQuery, db.conn);
            MySqlDataReader readResults = selectCommand.ExecuteReader();

            while (readResults.Read())
            {
                price = (double)readResults["price"];
            }
            return price;

        }

        public int GetQuantity(string id)
        {
            DBConnect db = new DBConnect();
            AddItem ai = new AddItem();
            string selectQuery = "SELECT quantity FROM stocktable WHERE ID = " + id;
            int quantity = 0;

            db.OpenConnection(); //Opens the connection           
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, db.conn);
            MySqlDataReader readResults = selectCommand.ExecuteReader();

            while (readResults.Read())
            {
                quantity = (int)readResults["quantity"];
            }

            db.CloseConnection();

            return quantity;
        }

        public List<string> GetItemRows(string selectQuery)
        {
            DBConnect db = new DBConnect();

            List<string> results = new List<string>();

            db.OpenConnection();

            AddItem ai = new AddItem();

            MySqlCommand selectCommand = new MySqlCommand(selectQuery, db.conn);
            MySqlDataReader readResults = selectCommand.ExecuteReader();

            while (readResults.Read())
            {
                results.Add("Item: " + readResults["Name"] + ", Quantity: " + readResults["Quantity"] + ", Price: " + readResults["Price"]);
            }

            db.CloseConnection();

            return results;
        }











    }


}

