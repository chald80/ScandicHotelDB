using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace ScandicHotelDB
{
    class DBclientSqlDataReader 
    {

        public string QueryString { get; set; }
        public void DbReader(string QueryString)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScandicHotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // queryString => SQL - string eks: delete from Team where id = 44
            //connectionString => Connetion String til databasen se i egenskaber for databasen

            string queryString = QueryString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                     for (int i = 0; i < reader.FieldCount; i++)
                     {
                       Console.WriteLine(reader.GetValue(i));
                     }
                     Console.WriteLine();
                }
            }
        }
    }
}