using POC.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Repositories.Repository<poco> r = new Repository<poco>();
            r.GetAll();
        }
    }

    public class poco {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
    }
}
