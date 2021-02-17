using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;


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
                int count = reader.FieldCount;

                while (reader.Read())
                {
                    
                    switch (reader.FieldCount)
                    {
                        case 0:
                            Console.WriteLine("No Rows");
                            break;
                        case 1:
                            ReadSingleRow1((IDataRecord)reader);
                            break;
                        case 2:
                            ReadSingleRow2((IDataRecord)reader);
                            break;
                        case 3:
                            ReadSingleRow3((IDataRecord)reader);
                            break;
                        case 4:
                            ReadSingleRow4((IDataRecord)reader);
                            break;
                        case 5:
                            ReadSingleRow5((IDataRecord)reader);
                            break;
                        default:
                            Console.WriteLine("To Many Rows");
                            break;
                        
                    }
                }

                //Call Close when done reading.
                reader.Close();

                
            }

        }
        

        private static void ReadSingleRow1(IDataRecord record)
        {
            Console.WriteLine(string.Format("{0}", record[0]));
        }

        private static void ReadSingleRow2(IDataRecord record)
        {
            Console.WriteLine(string.Format("{0}, {1}", record[0], record[1]));
        }

        private static void ReadSingleRow3(IDataRecord record)
        {
            Console.WriteLine(string.Format("{0}, {1}, {2}", record[0], record[1], record[2]));
        }

        private static void ReadSingleRow4(IDataRecord record)
        {
            Console.WriteLine(string.Format("{0}, {1}, {2}, {3}", record[0], record[1], record[2], record[3]));
        }

        private static void ReadSingleRow5(IDataRecord record)
        {
            Console.WriteLine(string.Format("{0}, {1}, {2}, {3}, {4}", record[0], record[1], record[2], record[3], record[4]));
        }

        
    }
}