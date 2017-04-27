using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using ServiceStack.Data;

namespace POC.Data.Repositories
{
    public class Repository<T>
    {
        protected IDbConnection db;
        public IDbConnectionFactory DbFactory { get; set; }
        public Repository()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
             DbFactory = new OrmLiteConnectionFactory(
             connectionString,
             MySqlDialect.Provider);
        }
        IDbConnection Db
        {
            get
            {
                return db = DbFactory.Open();
            }
        }

        public List<T> GetAll()
        {
            return Db.Select<T>();
        }

        public void Add(T model)
        {
            Db.Insert<T>();
           
        }
        public void Dispose()
        {
            if (db != null)
                db.Dispose();
        }
    }

}
