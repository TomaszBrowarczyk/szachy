using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Szachy.Figury;

namespace ProgramSzachy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pionek
            Pionek b = new Pionek();
            b.Name = "Pionek";
            b.Color = "Czarny";

            Console.WriteLine(b.ToString());
            Console.ReadKey();

            /*
            Pozycja p = new Pozycja("B5");
            Console.WriteLine(p.X);
            */
        }
    }

        
}
