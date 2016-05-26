using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace PHP_SRS
{
    class Report
    {
        public void SalesReport()
        {
            TextWriter tw = new StreamWriter("StockSales-Report.txt");
            DBConnect db = new DBConnect();
                
                double total = 0.0;

                tw.WriteLine("SALES REPORTING SYSTEM\n");
                tw.WriteLine("SALES RECORDS REPORT\n");
                tw.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

                if (db.OpenConnection() == true) {
                string query = "SELECT * FROM salesrecords";
                MySqlCommand cmd = new MySqlCommand(query, db.conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    tw.WriteLine(dataReader["id"] + ", " + dataReader["item"] + ", " + dataReader["quantity"] + ", " + dataReader["price"] + ", " +
                        dataReader["date"] + ", " + dataReader["time"] + "\n");
                    total = total + (double)dataReader["price"];
                }

                tw.WriteLine("Total Price amount: " + total + "\n");
                tw.Close();

            }


        }



        }
    }
