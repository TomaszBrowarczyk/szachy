using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Atrybuty;

namespace ProgramSzachy.Szachy.Figury
{
    internal class Skoczek : Figura
    {
        /*
        protected override bool CzyMozliwyRuch(string position)
        {
            //kod
            return true;
        }
        */
        public Skoczek(string nazwa, Pozycja pozycja, Kolor kolor) : base(nazwa, pozycja, kolor)
        {
        }

        public override bool CzyMozliwyRuch(Pozycja cel)
        {
            if ((cel.X != this.Pozycja.X + 1 && cel.Y != this.Pozycja.Y + 2) &&
                (cel.X != this.Pozycja.X - 2 && cel.Y != this.Pozycja.Y + 1) &&
                (cel.X != this.Pozycja.X + 3 && cel.Y != this.Pozycja.Y - 1) &&
                (cel.X != this.Pozycja.X - 1 && cel.Y != this.Pozycja.Y - 3))
            {
                return false;
            }

            return true;
        }

    }
}
