using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Atrybuty;

namespace ProgramSzachy.Szachy
{
    public delegate void PozycjaZmienionaEventHandler(Pozycja obecnaPozycja);


    public abstract class Figura
    {
        /*
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
        */
      
        protected string nazwa;
        protected Pozycja pozycja;
        protected Kolor kolor;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        #region Pozycja
        public Pozycja Pozycja
        /*{
            get { return pozycja; }
            set { pozycja = value; }
        }
        */
        {
            get { return pozycja; }
            set
            {
                PozycjaZmieniona(pozycja);
                pozycja = value;
            }
        }

        #endregion

        #region Kolor
        public Kolor Kolor
        {
            get { return kolor; }
            set { kolor = value; }
        }

        #endregion

        #region Figura
        public Figura(string nazwa, Pozycja pozycja, Kolor kolor)
        {
            this.nazwa = nazwa;
            this.pozycja = pozycja;
            this.kolor = kolor;
            PozycjaZmieniona = ZmianaPola;
            PozycjaZmieniona += BylRuch;
        }
        #endregion

        public abstract bool CzyMozliwyRuch(Pozycja pozycja);
        public override string ToString()
        {
            return nazwa + " " + kolor + " " + pozycja.X + "," + pozycja.Y;
        }

        private void ZmianaPola(Pozycja obecnaPozycja)
        {
            Console.WriteLine("Zdarzenie 1. Nowa pozycja to: {0} {1}", obecnaPozycja.X, obecnaPozycja.Y);
        }

        
        private void BylRuch(Pozycja obecnaPozycja)
        {
            Console.WriteLine("Zdarzenie 2. Nastapil ruch");
        }

       
        /// delegata
     
        public event PozycjaZmienionaEventHandler PozycjaZmieniona;


    }
}
