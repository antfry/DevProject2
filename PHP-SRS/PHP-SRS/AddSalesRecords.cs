using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PHP_SRS
{
    class AddSalesRecords
    {
        public void InsertIntoTable(string item, int quantity, double price, string date, string time)
        {
            DBConnect db = new DBConnect();
            db.OpenConnection();
    
            string insertQuery = "INSERT INTO salesrecords (item, quantity, price, date, time) VALUES ('" + item + "', " + quantity + ", " + price + ", '" + date + "', '" + time + "')";
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, db.conn);
            insertCommand.ExecuteNonQuery();
        }
    }
}
