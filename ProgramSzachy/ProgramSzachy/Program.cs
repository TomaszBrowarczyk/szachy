using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramSzachy.Atrybuty;
using ProgramSzachy.Szachy.Figury;
using ProgramSzachy.Szachy;

namespace ProgramSzachy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            Pozycja p = new Pozycja("B5");
            Console.WriteLine(p.X);
            */

            var szachownica = new Szachownica();
            //var cel = new Pozycja(7, 6);
            var figura = szachownica.PobierzFigure(cel);

            Console.WriteLine(figura.ToString());
            Console.WriteLine(((Pionek)figura).ToString()); 
            Console.WriteLine(((Pionek)figura).ToString("moj"));

            szachownica.PrzestawFigure(figura.Pozycja, cel);
            var cel = new Pozycja(7, 6);
            //szachownica.PrzestawFigure(new Pozycja(1, 1), cel);

            szachownica.IleFigur();
        }
        /*
        public static void Przesunieto(object sender, EventArgs e)
        {
            Console.WriteLine("Przesunieto figure: " + sender);
        }
        static void Main(string[] args)
        {
            Pozycja p = new Pozycja("B5");

            Szachownica sz = new Szachownica();

            Pozycja p2 = new Pozycja("D4");
            Figura f = new Pionek(p, Figura.KOLOR_BIALY);
            Console.WriteLine(f.CzyMoznaPrzesunac(p2));

            f.Przesuniecie += Program.Przesunieto;
            f.Przesun(p2);
            Console.WriteLine(sz.IloscFigur());
            sz.figury.Add(f);
            Console.WriteLine(sz.IloscFigur());
        }
        */
        #region Delegata

        public static void DelegateMethod(string Szachownica)
        {
            Console.WriteLine(Szachownica);
        }
        #endregion



        #region Singleton
        /*

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

        */


        public sealed class PrzechowajSzachownice
        {
            static readonly PrzechowajSzachownice _instance = new PrzechowajSzachownice();
            public static PrzechowajSzachownice Instance
            {
                get
                {
                    return _instance;
                }
            }

            PrzechowajSzachownice()
            {
                // Initialize.
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

    }
}