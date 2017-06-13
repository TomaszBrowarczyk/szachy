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
         * Lab3
         * obsługa zdarzeń 
         * musi wypisać na konsole np. przesunieto 
         * 
         * metody rozszerzające 
         * klasa string
         * X (this string)
         * string x;
         *      y.x(...)
         *      
         *   --
         *   string y = ......
         *   y IsCapitalized      this szachownica 
         *   
         *   ---
         *   delegaty
         *   
         *lab4
         * Zaimplementuj wzorce projektowe:
         * - Toolbox (Singleton Toolbox) do przechowywania szachownicy
         * - Metoda wytwórcza (Factory) do generowania figur szachowych
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
        /*
        
        #region zdarzenia
        public class Stock
        {
            string symbol;
            decimal price;
            public Stock (string symbol) { this.symbol = symbol; }
            public event EventHandler PriceChanged;
            protected virtual void OnPriceChanged (EventArgs e)
            {
                if (PriceChanged != null) PriceChanged(this, e);
            }
            public decimal Price
            {
                get { return price; }
                set
                {
                    if (price == value) return;
                    price = value;
                    OnPriceChanged(EventArgs.Empty);
                }
            }
        }
        #endregion
        */


        #region Singleton


        public class Singleton
        {
            // the single instance is defined in a static field
            private static readonly Singleton _instance = new Singleton();

            // constructor private so users can't instantiate on their own
            private Singleton()
            {
                //Class initialization goes here.
            }

            public void someSingletonMethod()
            {
                //Some method that acts on the Singleton.
            }

            private static Singleton _instance;
            // read-only property that returns the static field
            public static Singleton Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new Singleton();
                    return _instance;
                }
            }
        }

        public class SingletonController : MonoBehaviour
        {
            //Create a local reference so that the editor can read it.
            public Singleton instance;
            void Awake()
            {
                instance = Singleton.Instance;
            }
            //You can reference the singleton instance directly, but it might be better to just reflect its methods in the controller.
            public void someMethod()
            {
                instance.someSingletonMethod();
            }
        }



        public class Singleton : MonoBehavior
        {
            private static Singleton _instance;

            public static Singleton Instance
            {
                get { return _instance; }
            }

            private void Awake()
            {
                if (_instance != null && _instance != this)
                {
                    Destroy(this.gameObject);
                }
                else
                {
                    _instance = this;
                    DontDestroyOnLoad(this.GameObject);
                }
            }
        }


#endregion


        #region Toolbox
        public class Toolbox
        {
            private static Toolbox _instance;

            public static Toolbox Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new Toolbox();
                    }
                    return _instance;
                }
            }

            protected Toolbox()
            {
                Initialize();
            }

            protected void Initialize()
            {
                // Your code here
            }

            private MyComponent _myComponent;

            public MyComponent MyComponent()
            {
                get {
                    return _myComponent();
                }
            }
     ... 

     // Optional: standard extension allowing
     // runtime registration of global objects. 
     private Map components;

            public Object GetComponent(String componentName)
            {
                return components.Get(componentName);
            }

            public void RegisterComponent(String componentName, Object component)
            {
                components.Put(componentName, component);
            }

            public void DeregisterComponent(String componentName)
            {
                components.Remove(componentName);
            }

        }
        #endregion

        #region Factory
        class ServerFactory
        {
            public:
        // By default return a RealServer
        ServerInterface& getServer();

            // Set a non default server:
            void setServer(ServerInterface& server);
        };

        class ServerInterface { /* define Interface */ };

        class RealServer : public ServerInterface {}; // This is a singleton (potentially)

        class TestServer : public ServerInterface {}; // This need not be.

        #endregion
    }
}
