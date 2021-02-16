using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace ScandicHotelDB
{
    class DBClientExecuteNonQuery
    {
        public void DbQuery()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScandicHotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // queryString => SQL - string eks: delete from Team where id = 44
            //connectionString => Connetion String til databasen se i egenskaber for databasen

            string queryString = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

            }
        }
    }
}
