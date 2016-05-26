using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace PHP_SRS
{
    class CSV
    {
        public void CSVStockSales()
        {
            //change
            TextWriter tw = new StreamWriter("CSVStockSales.txt");
            DBConnect db = new DBConnect();
            tw.WriteLine("SALES REPORTING SYSTEM\n");
            tw.WriteLine("ALL SALES RECORDS\n");
            tw.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

            if (db.OpenConnection() == true)
            {
                string query = "SELECT * FROM salesrecords";
                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    tw.WriteLine(dataReader["id"] + ", " + dataReader["item"] + ", " + dataReader["quantity"] + ", " + dataReader["price"] + ", " + ", " + dataReader["date"] + ", " + dataReader["time"] + " \n");
                }
                tw.Close();

            }
        }



        public void CSVStockTake()
        {
            TextWriter tw = new StreamWriter("CSVStockTake.txt");
            DBConnect db = new DBConnect();
            tw.WriteLine("SALES REPORTING SYSTEM\n");
            tw.WriteLine("ALL SALES RECORDS\n");
            tw.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

            if (db.OpenConnection() == true)
            {
                string query = "SELECT * FROM stocktable";
                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    tw.WriteLine(dataReader["id"] + ", " + dataReader["name"] + ", " + dataReader["description"] + ", " + dataReader["attribute"] + ", " + dataReader["quantity"] + ", " + dataReader["price"] + "\n");
                }
                tw.Close();

            }

        }
    }
}