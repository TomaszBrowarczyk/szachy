using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSzachy.Atrybuty
{
    public static class EnumExtensions
    {
        public static string Name(this Kolory kolor)
        {
            return Enum.GetName(typeof(Kolory), kolor);
        }
    }
}
