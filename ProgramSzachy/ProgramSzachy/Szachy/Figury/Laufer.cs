using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSzachy.Szachy.Figury
{
    class Laufer : Figura
    {
        protected override bool CanBeMoved(string position)
        {
            //some code here
            return true;
        }
    }
}
