using ServiceStack;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Data.DB
{
    public class Config
    {
       public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        public Config(OrmLiteConnectionFactory db)
        {
            var dbFactory = new OrmLiteConnectionFactory(
             connectionString,
             MySqlDialect.Provider);
        }
    }
}
