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
             if(CheckBounds(Consts.BOARD_SIZE, charToChessInt(X), Y))
            {
                this.X = X;
                this.Y = Y;
                this.iX = charToChessInt(X);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }*/
                    
        {
            this.x = x;
            this.y = y;
        }

        #endregion
        
        #region Private Methods
        /*
        private bool CheckBounds(int boardSize, params int[] values)
        {
            bool result = true;

            foreach (int value in values)
            {
                if (!(value >= 0 && value - 1 <= boardSize))
                {
                    result = false;
                }
            }

            return result;
        }

        private int charToChessInt(char c)
        {
            return c - 65;
        }
        */
        #endregion
    }
}
