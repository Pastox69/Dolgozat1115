using Negyzetdoga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockadoga
{
    class Teszt
    {
        static void Main(string[] args)
        {

            NegyszogClass szenvedes = new NegyszogClass(9, 8);
            szenvedes.SetKerulet();
            szenvedes.SetTerulet();


            Console.WriteLine("A négyszög kerülete: {0:0.00}, területe {1:0.00}", szenvedes.getKerulet(), szenvedes.getTerulet());

            Console.ReadKey();

        }
    }
}
