﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSzachy.Szachy.Figury
{
    class Krol : Figura
    {
        protected override bool CanBeMoved(string position)
        {
            //kod
            return true;
        }
    }
}