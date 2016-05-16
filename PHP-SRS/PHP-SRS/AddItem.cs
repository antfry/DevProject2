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


                cmd.CommandText = "INSERT INTO stocktable(name,quantity,description,attribute,price) VALUES(@name, @description, @attribute, @quantity, @price)";

                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@attribute", attribute);         
                cmd.ExecuteNonQuery();


            }
        }


    }
}
