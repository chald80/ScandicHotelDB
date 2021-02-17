using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace ScandicHotelDB
{
    public class DBClient
    {

        public DBClient()
        {
            DBClientExecuteNonQuery dbClientExecuteNonQuery = new DBClientExecuteNonQuery();
            DBclientSqlDataReader dbclientSqlDataReader = new DBclientSqlDataReader();   
        }
        
    }
}
    