using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleAppADONetHandMadeConnect
{
    class Program
    {
        private static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;"+
            "AttachDbFilename=F:\\ConsoleAppADONetHandMadeConnect\\ConsoleAppADONetHandMadeConnect\\LocalDB.mdf;Integrated Security = True; Connect Timeout = 30";
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Select DemoValue from Demo where DemoID = 1";
            connection.Open();
            string result = (string)command.ExecuteScalar();
            connection.Close();

            Console.WriteLine(result);
            Console.Read();
        }            
    }
}
