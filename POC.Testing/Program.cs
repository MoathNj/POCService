using POC.Data.Repositories;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Testing
{
    class Program
    {
       
        static void Main(string[] args)
        {
            new AppHost().Init().Start("http://*:8088/");
            "ServiceStack Self Host with Razor listening at http://127.0.0.1:8088".Print();
            Process.Start("http://127.0.0.1:8088/");

            Console.ReadLine();
            Data.Repositories.Repository<poco> r = new Repository<poco>();
            poco p = new poco() {
                Id=1,
                EMail="a@a.com",
                Password="123",
                UserName="Moath"
            };
            r.Add(p);
            
            var test = r.GetAll();
        }
    }

    public class poco {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
    }
}
