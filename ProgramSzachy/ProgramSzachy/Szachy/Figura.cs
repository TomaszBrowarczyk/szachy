﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSzachy.Szachy
{
    abstract class Figura
    {
        #region Properties

        public string Name { get; set; }
        public string Position { get; set; }
        public string Color { get; set; }

        #endregion

        #region Protected Methods

        protected abstract bool CanBeMoved(string position);

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return $"{Color} {Name}";
        }

        #endregion

        #region Pozycja
        internal class Pozycja
        {
            int x;
            int y;
            string pole;

            public string Pole
            {
                get
                {
                    return pole;
                }

                set
                {
                    pole = value;
                    x = PrzeliczX(pole);
                    y = PrzeliczY(pole);
                }
            }

            public int X
            {
                get
                {
                    return x;
                }
            }

            public int Y
            {
                get
                {
                    return y;
                }
            }

            internal static int PrzeliczX(string pole)
            {
                return pole[0] - 'A' + 1;
            }
            internal static int PrzeliczY(string pole)
            {
                return Int32.Parse(pole.Substring(1));
            }

            public Pozycja()
            {
                pole = null;
                x = 0;
                y = 0;
            }
            public Pozycja(string pole)
            {
                this.Pole = pole;

            }

        }
        #endregion
    }
}
