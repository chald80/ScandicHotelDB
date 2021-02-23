using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;


/*namespace ScandicHotelDB
{
    class DBclientSqlDataReader
    {



        public void DbReader(string QueryString)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScandicHotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            string queryString = QueryString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow((IDataRecord)reader);
                }

                //Call Close when done reading.
                reader.Close();

            }

        }

        static void ReadSingleRow(IDataRecord record)
        {
            for (int i = 0; i < record.FieldCount; i++) 
            {
                Console.Write("{0},    ", record[i]);
            }
            Console.WriteLine();

        }




    }
}*/

