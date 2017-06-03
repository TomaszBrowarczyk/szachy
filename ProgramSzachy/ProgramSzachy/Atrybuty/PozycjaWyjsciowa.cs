using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Szachy;
using ProgramSzachy.Szachy.Figury;

namespace ProgramSzachy.Atrybuty
{
    static class PozycjaWyjsciowa
    {
        public static Figura CreateFigure(TypyFigur figure, Colors color, Pozycja pos = null)
        {
            /*
             Figura retFigura = null;
             
            swifch (figure)
             */ 
        }

                 
        Figura retFigura = null;

            switch (Figura)
            {
                
                case TypyFigur.Krol:
                    {
                        retFigure = new Krol(Kolor.Name(), pos);
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Figura", "Nieznany typ figury");
                    }
            }

            return retFigura;

            */ 
    }
}
