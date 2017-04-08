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
            //Pionek
            Pionek b = new Pionek();
            b.Name = "Pionek";
            b.Color = "Czarny";

            Console.WriteLine(b.ToString());
            Console.ReadKey();

            
            Pozycja p = new Pozycja("B5");
            Console.WriteLine(p.X);
            */

            var szachownica = new Szachownica();
            var cel = new Pozycja(2, 1);
            var figura = szachownica.PobierzFigure(cel);

            Console.WriteLine(figura.ToString());
            Console.WriteLine(((Pionek)figura).ToString()); // Ta sama metoda ToString zwraca co innego w zaleznosci do czego rzutujemy.
            Console.WriteLine(((Pionek)figura).ToString("moj")); // Metode nadpisana przez 'new' mozna przeciazac.

            szachownica.PrzestawFigure(new Pozycja(1, 1), cel);


        }
    }

        
}
