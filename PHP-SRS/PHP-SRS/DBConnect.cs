using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PHP_SRS
{
    public class DBConnect
    {
        public MySqlConnection conn;
        public string connString;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        public void Initialize()
        {
            string connString = "Server=110.22.83.243;Port=3306;Database=Pharmacy;Uid=root;password=alpine12";
            conn = new MySqlConnection(connString);
        }

        public void Test1()
        {
            //Open Connection
            if (this.OpenConnection() == true)
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO stocktable(id,name,quantity,description, attribute, price) VALUES(@name, @quantity, @description, @attribute, @price)";
                cmd.Parameters.AddWithValue("@id", "4");
                cmd.Parameters.AddWithValue("@price", "4");
                cmd.Parameters.AddWithValue("@quantity", "4");
                cmd.Parameters.AddWithValue("@itemname", "TEST4");
                // Create command and assign the query and conn from the constructor.

                //Execute Query
                cmd.ExecuteNonQuery();


                //Close Connection
                this.CloseConnection();

            }
        }


        //Open Connection
        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Unable to connect to server");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid user/pass");
                        break;
                    default:
                        Console.WriteLine("Unknown Error");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


    }
}