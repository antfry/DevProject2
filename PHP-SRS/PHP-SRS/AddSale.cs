using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace PHP_SRS
{
    class AddSale
    {
        public void InsertIntoTable(string name, int quantity, double price)
        {
            DBConnect db = new DBConnect();
            if (db.OpenConnection() == true)
            {
                var cmd = db.conn.CreateCommand();


                cmd.CommandText = "INSERT INTO stocksales(name,quantity,price) VALUES(@name, @quantity, @price)";

                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();


            }
        }


    }
}
