using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Szachy;
using ProgramSzachy.Szachy.Figury;

namespace ProgramSzachy.Atrybuty
{
    static class PozycjaWyjsciowa
    {
        public static Figura CreateFigure(TypyFigur figure, Colors color, Pozycja pos = null)
        {
            /*
             Figura retFigura = null;
             
            swifch (figure)
             */ 
        }

        #region Factory
        /*
        http://www.dofactory.com/net/factory-method-design-pattern
        
        class ServerFactory
        {
            public:
        // By default return a RealServer
        ServerInterface& getServer();

            // Set a non default server:
            void setServer(ServerInterface& server);
        };

        class ServerInterface { // define Interface // };

        class RealServer : public ServerInterface {}; // This is a singleton (potentially)

        class TestServer : public ServerInterface {}; // This need not be.


        */

        Figura retFigura = null;

            switch (Figura)
            {
                
                case TypyFigur.Krol:
                    {
                        retFigure = new Krol(Kolor.Name(), pos);
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Figura", "Nieznany typ figury");
                    }
            }

            return retFigura;
        
        #endregion
    }
}
