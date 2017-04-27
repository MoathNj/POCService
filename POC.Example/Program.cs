using Arch.POC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection s = new Connection();
            s.Connect();
        }
    }
}
