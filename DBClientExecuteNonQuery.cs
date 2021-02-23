/*using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace ScandicHotelDB
{
    class DBClientExecuteNonQuery
    {
        public void DbQuery(string QueryString)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScandicHotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
          

            string queryString = QueryString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

            }
        }
    }
}*/
