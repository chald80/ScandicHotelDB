using System;
using System.Net.Sockets;

namespace ScandicHotelDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DBClient DB = new DBClient();
            DB.Start();
            

        }
    }
}
