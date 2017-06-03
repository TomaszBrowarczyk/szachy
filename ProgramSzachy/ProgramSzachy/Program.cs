using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Atrybuty;
using ProgramSzachy.Szachy.Figury;
using ProgramSzachy.Szachy;

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
            //var cel = new Pozycja(7, 6);
            var figura = szachownica.PobierzFigure(cel);

            Console.WriteLine(figura.ToString());
            Console.WriteLine(((Pionek)figura).ToString()); 
            Console.WriteLine(((Pionek)figura).ToString("moj"));

            szachownica.PrzestawFigure(figura.Pozycja, cel);
            var cel = new Pozycja(7, 6);
            //szachownica.PrzestawFigure(new Pozycja(1, 1), cel);

            szachownica.IleFigur();
        }
        /*
        public static void Przesunieto(object sender, EventArgs e)
        {
            Console.WriteLine("Przesunieto figure: " + sender);
        }
        static void Main(string[] args)
        {
            Pozycja p = new Pozycja("B5");

            Szachownica sz = new Szachownica();

            Pozycja p2 = new Pozycja("D4");
            Figura f = new Pionek(p, Figura.KOLOR_BIALY);
            Console.WriteLine(f.CzyMoznaPrzesunac(p2));

            f.Przesuniecie += Program.Przesunieto;
            f.Przesun(p2);
            Console.WriteLine(sz.IloscFigur());
            sz.figury.Add(f);
            Console.WriteLine(sz.IloscFigur());
        }
        */
        #region Delegata

        public static void DelegateMethod(string Szachownica)
        {
            Console.WriteLine(Szachownica);
        }
        #endregion
    }          
}