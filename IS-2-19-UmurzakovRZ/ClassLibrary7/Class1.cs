using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7
{
    public class Con
    {
        public static string C()
        {
            const string Host = "caseum.ru";
            const int Port = 33333;
            const string User = "test_user";
            const string Db = "db_test";
            const string Pass = "test_pass";
            string connStr = $"server={Host};" +
            $"port={Port};" +
            $"user={User};" +
            $"database={Db};" +
            $"password={Pass};";
            return connStr;
        }
    }
}
