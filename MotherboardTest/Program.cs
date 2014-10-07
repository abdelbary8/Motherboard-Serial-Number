using Motherboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherboardTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Board mb = new Board();
            Console.WriteLine(mb.SerialNumber());
            Console.ReadKey();

        }
    }
}
