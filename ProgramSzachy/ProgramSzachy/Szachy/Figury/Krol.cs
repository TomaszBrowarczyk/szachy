using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Atrybuty;

namespace ProgramSzachy.Szachy.Figury
{
    public class Krol : Figura
    {
        /*
        protected override bool CzyMozliwyRuch(string position)
        {
            //kod
            return true;
        }
        */
        public Krol(string nazwa, Pozycja pozycja, Kolor kolor)
            : base(nazwa, pozycja, kolor)
        {
        }

        public override bool CzyMozliwyRuch(Pozycja cel)
        {
            if ((Math.Abs(cel.X - this.Pozycja.X) == 1 && cel.Y == this.Pozycja.Y) ||
                (Math.Abs(cel.Y - this.Pozycja.Y) == 1 && cel.X == this.Pozycja.X))
            {
                return true;
            }

            return false;
        }
    }
}
