using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace PHP_SRS
{
    class AddItem
    {
        public void InsertIntoTable(string name, string description, string attribute, int quantity, double price)
        {
            DBConnect db = new DBConnect();
            if (db.OpenConnection() == true)
            {
                var cmd = db.conn.CreateCommand();


                cmd.CommandText = "INSERT INTO StockTable(Name,Description,Attribute,Quantity,Price) VALUES(@name, @description, @price, @attribute, @quantity, @price)";

                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@attribute", attribute);         
                cmd.ExecuteNonQuery();


            }
        }


        public void UpdateTableByName(string name, int quantity, int minusCheck)
        {
            DBConnect db = new DBConnect();
            if (db.OpenConnection() == true)
            {
                string selectCommand = "SELECT Name, Quantity FROM StockTable WHERE Name = '" + name + "'";
                MySqlCommand cmd = new MySqlCommand(selectCommand, db.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int newQty = 0;

                while (rdr.Read())
                {
                    newQty = (int)rdr["Quantity"];
                }

                if (minusCheck == 0)
                {
                    newQty += quantity;
                }
                else {
                    newQty -= quantity;
                }

                string updateQuery = "UPDATE StockTable SET Quantity = " + newQty + " WHERE Name = '" + name + "'";

                MySqlCommand insertCommand = new MySqlCommand(updateQuery, db.conn);

                insertCommand.ExecuteNonQuery();


            }
        }

    }
}
