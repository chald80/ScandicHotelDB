using System;
using System.Net.Sockets;

namespace ScandicHotelDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DBClient DB = new DBClient();
            
            DBclientSqlDataReader reader = new DBclientSqlDataReader();
            DBClientExecuteNonQuery nonQuery = new DBClientExecuteNonQuery();

            Console.WriteLine("Hotel DataBase");
            reader.DbReader("Select * From Hotel");
            Console.WriteLine("Booking DataBase");
            reader.DbReader("Select * From Booking");
            Console.WriteLine("Room DataBase");
            reader.DbReader("select * from Room");
            Console.WriteLine("Guest DataBase");
            reader.DbReader("select * from Guest");
            //NonQuery.DbQuery("INSERT INTO Hotel VALUES (101,'The Pope','Vaticanstreet 1 1111 Bishopcity')");
            
            Console.WriteLine();

        }
    }
}
