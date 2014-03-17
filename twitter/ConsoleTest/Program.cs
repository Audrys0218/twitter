using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Authentication stuff = new Authentication();
            int status = stuff.Authenticate();
        }
    }
}
