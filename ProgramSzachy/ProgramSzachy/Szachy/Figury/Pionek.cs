using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Atrybuty;

namespace ProgramSzachy.Szachy.Figury
{
    public class Pionek : Figura
    {
        /*protected override bool CanBeMoved(string position)
        {
            //kod
            return true;
        }
        */
        public Pionek(string nazwa, Pozycja pozycja, Kolor kolor)
            : base(nazwa, pozycja, kolor)
        {
        }

        public override bool czyMozliwyRuch(Pozycja cel)
        {
            if (cel.X != this.Pozycja.X || cel.Y - 1 != this.Pozycja.Y)
            {
                return false;
            }

            return true;
        }

        public new string ToString()
        {
            return "To skoczek o nazwie: " + nazwa;
        }

        public new string ToString(string czyj)
        {
            return "To " + czyj + " skoczek o nazwie: " + nazwa;
        }
    }
}
