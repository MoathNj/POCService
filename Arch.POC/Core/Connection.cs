using Arch.POC.Models;
using ServiceStack.OrmLite;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.POC.Core
{
    public class Connection
    {
        public void Connect()
        {
            var connectionString = "server=localhost;userId=root;password=123;Database=POCDB;";
            var dbFactory = new OrmLiteConnectionFactory(
    connectionString,
    MySqlDialect.Provider);

            using (var db = dbFactory.Open())
            {
                if (db.CreateTableIfNotExists<Users>())
                {
                    db.Insert(new Users { Id = 1, UserName = "Seed Data" });
                }

                var result = db.SingleById<Users>(1);
                result.PrintDump(); //= {Id: 1, Name:Seed Data}
            }
        }
    }
}
