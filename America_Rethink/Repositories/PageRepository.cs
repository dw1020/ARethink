using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections;

namespace America_Rethink.Repositories
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class PageRepository
    {
        private MySqlConnection connectToDatabase(){
            String connectionStr = ConfigurationManager.ConnectionStrings["remoteConnection"].ToString();
            MySqlConnection connection = new MySqlConnection(connectionStr);
            return connection;
        }

        public string PageRepo(){
            MySqlConnection conn = connectToDatabase();
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Page";

            MySqlDataReader rdr = command.ExecuteReader();

            conn.Close();

            return rdr.ToString();
            



        }

        public Page GetPage(string PageName){
            //Connect and open the connection
            MySqlConnection conn = connectToDatabase();
            conn.Open();

            //create the command
            var command = conn.CreateCommand();

            command.CommandText = "";
        }
    }
}
