using System;

namespace ScandicHotelDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DBClient DB = new DBClient();
            Console.WriteLine("Hello World!");
            DB.Start();
            
        }
    }
}
