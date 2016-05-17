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
        public void InsertIntoTable(string name, string description, string attribute, string quantity, double price)
        {
            DBConnect db = new DBConnect();
            if (db.OpenConnection() == true)
            {
                var cmd = db.conn.CreateCommand();


                cmd.CommandText = "INSERT INTO stocktable(name,quantity,description,attribute,price) VALUES(@name, @quantity, @description, @attribute, @price)";

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
            DBConnect db2 = new DBConnect();
            string selectQuery = "SELECT name, quantity FROM stocktable WHERE name = '" + name + "'";

            db.OpenConnection();
            db2.OpenConnection();


            string updateQuery = "UPDATE stocktable SET quantity = " + quantity + " WHERE name = '" + name + "'";

            MySqlCommand insertCommand = new MySqlCommand(updateQuery, db2.conn);
            insertCommand.ExecuteNonQuery();
        }


        public void Update(string name, int quantity, int minusCheck)
        {
            DBConnect db = new DBConnect();
            DBConnect db2 = new DBConnect();
            int newQty = 0;
            string selectQuery = "SELECT name, quantity FROM stocktable WHERE name = '" + name + "'";

            db.OpenConnection();
            db2.OpenConnection();
            MySqlCommand selectCommand = new MySqlCommand(selectQuery, db.conn);
            MySqlDataReader rdr = selectCommand.ExecuteReader();

            while (rdr.Read())
            {
                newQty = (int)rdr["quantity"];
            }

            if (minusCheck == 0)
            {
                newQty += quantity;
            }
            else {
                newQty -= quantity;
            }

            string updateQuery = "UPDATE stocktable SET quantity = " + newQty + " WHERE name = '" + name + "'";

            MySqlCommand insertCommand = new MySqlCommand(updateQuery, db2.conn);
            insertCommand.ExecuteNonQuery();

            db.CloseConnection();
        }




    }
}
