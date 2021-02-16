using System;
using System.Net.Sockets;

namespace ScandicHotelDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //DBClient DB = new DBClient();
            DBclientSqlDataReader Reader = new DBclientSqlDataReader();
            Reader.DbReader("Select * From Hotel");
            Reader.DbReader("select * From Room");
            Console.WriteLine("Hello World!");
            
            
        }
    }
}
