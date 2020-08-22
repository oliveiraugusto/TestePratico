using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestePratico
{
    public static class Keys
    {
        public static string ConnectionString { get; } = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=testepratico;Integrated Security=True";
    }
}
