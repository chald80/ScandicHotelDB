using System;
using System.Net.Sockets;

namespace ScandicHotelDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DBClient DB = new DBClient();
            

            Console.WriteLine("Hotel DataBase");
            DB.DbReader("Select * From Hotel");
            Console.WriteLine("Booking DataBase");
            DB.DbReader("Select * From Booking");
            Console.WriteLine("Room DataBase");
            DB.DbReader("select * from Room");
            Console.WriteLine("Guest DataBase");
            DB.DbReader("select * from Guest");
            Console.WriteLine("Hotel DataBase after insert");
            DB.DbQuery("INSERT INTO Hotel VALUES (101,'The Pope','Vaticanstreet 1 1111 Bishopcity')");
            DB.DbReader("Select * From Hotel");
            Console.WriteLine("Hotel DataBase after delete");
            DB.DbQuery("Delete from Hotel where Hotel_No = 101 ");
            DB.DbReader("Select * From Hotel");
            Console.WriteLine("Hotel DataBase done");




            Console.WriteLine();

        }
    }
}
