using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSzachy.Atrybuty
{
    public class Pozycja
    {
        #region Wlasciowsci
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        #endregion

        #region Konstruktor i Destrktor
        public Pozycja(int x, int y)
        /*{
            this.x = x;
            this.y = y;
        */}
                    
        {
            this.x = x;
            this.y = y;
        }

    #endregion
}
}
