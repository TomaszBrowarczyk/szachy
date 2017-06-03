using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Atrybuty;

namespace ProgramSzachy.Szachy.Figury
{
    public class Wieza : Figura
    {
        /*
         protected override bool CzyMozliwyRuch(string position)
        {
            //kod
            return true;
        }
        */
        public Wieza(string nazwa, Pozycja pozycja, Kolor kolor) : base(nazwa, pozycja, kolor)
        {
        }

        public override bool CzyMozliwyRuch(Pozycja cel)
        {
            if (cel.X != this.Pozycja.X && cel.Y != this.Pozycja.Y)
            {
                return false;
            }

            return true;
        }

    }
}
