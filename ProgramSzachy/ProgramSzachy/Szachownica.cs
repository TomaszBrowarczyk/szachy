using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Atrybuty;
using ProgramSzachy.Szachy;
using ProgramSzachy.Szachy.Figury;

namespace ProgramSzachy
{
    public class Szachownica
    {
        private List<Figura> Figury;
        /*
         *modyfikatory, new, override
         * szachownica, indekser
         * interface, iserializable
         * 
         */

        public Szachownica()
        {
            Figury = new List<Figura>();
            Figury.Add(new Pionek("Pionek 1", new Pozycja(0, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 2", new Pozycja(1, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 3", new Pozycja(2, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 4", new Pozycja(3, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 5", new Pozycja(4, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 6", new Pozycja(5, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 7", new Pozycja(6, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 8", new Pozycja(7, 1), Kolor.Bialy));
            Figury.Add(new Wieza("Wieza 1", new Pozycja(0, 0), Kolor.Bialy));
            Figury.Add(new Wieza("Wieza 2", new Pozycja(7, 0), Kolor.Bialy));
            Figury.Add(new Krol("Krol", new Pozycja(4, 0), Kolor.Bialy));
            Figury.Add(new Krol("Skoczek", new Pozycja(1, 0), Kolor.Bialy));
            Figury.Add(new Krol("Skoczek", new Pozycja(4, 0), Kolor.Bialy));

            Figury.Add(new Pionek("Pionek 1", new Pozycja(0, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 2", new Pozycja(1, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 3", new Pozycja(2, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 4", new Pozycja(3, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 5", new Pozycja(4, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 6", new Pozycja(5, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 7", new Pozycja(6, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 8", new Pozycja(7, 6), Kolor.Czarny));
            Figury.Add(new Wieza("Wieza 1", new Pozycja(0, 7), Kolor.Czarny));
            Figury.Add(new Wieza("Wieza 2", new Pozycja(7, 7), Kolor.Czarny));
            Figury.Add(new Krol("Krol", new Pozycja(4, 7), Kolor.Czarny));
            Figury.Add(new Krol("Skoczek", new Pozycja(1, 7), Kolor.Czarny));
            Figury.Add(new Krol("Skoczek", new Pozycja(4, 7), Kolor.Czarny));
        }

        public static Szachownica Instance
        {
            get
            {
                return Szachownica;
            }
        }

        static Szachownica()
        {

        }
        /*
        private Szachownica()
        {
            plansza = new string[boardSize, boardSize];
            plansza.Fill(fillPattern1, fillPattern2, boardSize);
        }
        */
        public Figura PobierzFigure(Pozycja pozycja)
        {
            foreach (var figura in Figury)
            {
                if (pozycja.X == figura.Pozycja.X && pozycja.Y == figura.Pozycja.Y)
                {
                    return figura;
                }
            }

            return null;
        }


        public bool PrzestawFigure(Pozycja staraPozycja, Pozycja nowaPozycja)
        {
            Figura figura = PobierzFigure(staraPozycja);

            if (figura != null && PobierzFigure(nowaPozycja) == null && figura.CzyMozliwyRuch(nowaPozycja))
            {
                Console.WriteLine(figura.ToString());
                figura.Pozycja = nowaPozycja;
                return true;
            }

            return false;
        }
        #region Wlasciwosci

        public string this[Figura f, Pozycja pos]
        {
            get
            {
                return board[pos.iX, pos.Y];
            }
            set
            {
                f.Position = pos;
                board[pos.iX, pos.Y] = value;
            }
        }

        #endregion
    }
}
