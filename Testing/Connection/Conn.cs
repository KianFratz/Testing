using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Testing.Connection
{
    internal class Conn
    {
        private string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Kian Fratz Pagobo\\Testing\\Testing\\bin\\Debug\\TestingDB.accdb\"";
        private OleDbConnection connection;
        public void OpenConnection()
        {
            connection = new OleDbConnection(ConnectionString); 
            connection.Open();
        }
    }
}
