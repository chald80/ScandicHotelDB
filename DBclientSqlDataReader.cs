using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;


namespace ScandicHotelDB
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


                //while (reader.Read())
                //{
                //    ReadSingleRow((IDataRecord)reader);
                //}

                //// Call Close when done reading.
                //reader.Close();

        

                //DataTable schemaTable = reader.GetSchemaTable();
                // foreach (DataRow row in schemaTable.Rows)
                // {
                //     foreach (DataColumn column in schemaTable.Columns)
                //     {
                //         Console.WriteLine(String.Format("{0} = {1}",
                //             column.ColumnName, row[column]));
                //     }
                // }

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

        //private static void ReadSingleRow(IDataRecord record)
        //{
        //    Console.WriteLine(string.Format("{0}, {1}, {2}", record[0], record[1], record[2]));
        //}


    }
}