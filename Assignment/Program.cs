using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLibrary;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            db.Start();
        }
    }
}
