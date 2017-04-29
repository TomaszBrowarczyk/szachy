using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Atrybuty;
using ProgramSzachy.Szachy.Figury;

namespace ProgramSzachy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            Pozycja p = new Pozycja("B5");
            Console.WriteLine(p.X);
            */

            var szachownica = new Szachownica();
            var cel = new Pozycja(7, 6);
            var figura = szachownica.PobierzFigure(cel);

            Console.WriteLine(figura.ToString());
            Console.WriteLine(((Pionek)figura).ToString()); 
            Console.WriteLine(((Pionek)figura).ToString("moj"));

            szachownica.PrzestawFigure(new Pozycja(1, 1), cel);

        }
    }          
}