using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections;
using America_Rethink.Objects;
using System.IO;

namespace America_Rethink.Repositories
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class PageRepository
    {
        private MySqlConnection ConnectToDatabase(){
            String connectionStr = ConfigurationManager.ConnectionStrings["remoteConnection"].ToString();
            MySqlConnection connection = new MySqlConnection(connectionStr);
            return connection;
        }

        public string PageRepo(){
            MySqlConnection conn = ConnectToDatabase();
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Page";

            MySqlDataReader rdr = command.ExecuteReader();

            conn.Close();

            return rdr.ToString();

        }

        public Page GetPage(string PageName){
            try
            {
                //Connect and open the connection
                MySqlConnection conn = ConnectToDatabase();
                conn.Open();

                //create the command
                var command = conn.CreateCommand();

                //Read sql from file
                FileInfo file = new FileInfo("SQL/GetPage.sql");
                string script = file.OpenText().ReadToEnd();


                command.CommandText = script;

                command.Parameters.AddWithValue("?PageID", PageName);
                command.Prepare();

                MySqlDataReader rdr = command.ExecuteReader();

                rdr.Read();

                //Make the Page Object
                Page resultingPage = new Page();

                resultingPage.URL = rdr["URL"].ToString();
                resultingPage.PageID = rdr["PageID"].ToString();
                resultingPage.PageType = rdr["PageType"].ToString();
                resultingPage.PageName = rdr["PageName"].ToString();
                resultingPage.ActiveFrom = DateTime.Parse(rdr["ActiveFrom"].ToString());
                resultingPage.ActiveTo = DateTime.Parse(rdr["ActiveTo"].ToString());
                resultingPage.CreatedBy = rdr["CreatedBy"].ToString();
                resultingPage.CreatedDate = DateTime.Parse(rdr["CreatedDate"].ToString());
                resultingPage.LastUpdatedBy = rdr["LastUpdatedBy"].ToString();
                resultingPage.LastUpdatedDate = DateTime.Parse(rdr["LastUpdatedDate"].ToString());

                //close connection
                conn.Close();

                //return the new page
                return resultingPage;
            }
            catch(MySqlException ex){
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
                return null;
            }

        }
    }
}
