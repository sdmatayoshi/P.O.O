using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_10
{
    class Carta
    {
        public int num_car;
        public string palo;

        public Carta(int num_car, string palo)
        {
            this.num_car = num_car;
            this.palo = palo;
        }

        public override string ToString()
        {
            return num_car + " de " + palo;
        }
    }
        class Baraja
        {
        private List<Carta> cartas;
        private List<Carta> usadas;
        private List<Carta> mano;
        private Random random;

        public Baraja()
        {
            cartas = new List<Carta>();
            mano = new List<Carta>();
            random = new Random();

            string[] palos = { "oro", "espada", "copa", "palo" };

            foreach (string p in palos)
            {
                for (int nc = 1; nc <= 12; nc++)
                {
                    if (nc != 8 && nc != 9)
                    {
                        cartas.Add(new Carta(nc, p));
                    }
                }
            }
        }

        public void barajar()
        {
            for (int i = cartas.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                Carta temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }
        }

        public Carta SiguienteCarta()
        {
            if (cartas.Count > 0)
            {
                Carta carta = cartas[0];
                usadas.Add(cartas[0]);
                cartas.RemoveAt(0);
                mano.Add(carta);
                return carta;
            }
            else
            {
                Console.WriteLine("Sin cartas en la baraja");
                return null;
            }
        }

        public int CartasDisponibles()
        {
            return cartas.Count;
        }

        public List<Carta> DarCartas(int cantidad)
        {
            List<Carta> mano = new List<Carta>();

            for (int i = 0; i < cantidad; i++)
            {
                Carta carta = SiguienteCarta();
                if (carta != null)
                {
                    mano.Add(carta);
                }
                else
                {
                    Console.WriteLine("Sin cartas suficientes");
                    break;
                }
            }

            return mano;
        }

        public List<Carta> CartasMonton()
        {
            return mano;
        }

        public void MostrarBaraja()
        {
            foreach (Carta carta in cartas)
            {
                Console.WriteLine(carta);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Carta> baraja = new List<Carta>();
            List<Carta> usadas = new List<Carta>();
            int p = 1;
            string palo = null;
            for (int i = 1; i < 13; i++)
            {
                if (p == 1)
                {
                    palo = "oro";
                }
                if (p == 2)
                {
                    palo = "copa";
                }
                if (p == 3)
                {
                    palo = "espada";
                }
                if (p == 4)
                {
                    palo = "palo";
                }
                if (i == 8)
                {
                    i = 10;
                }
                baraja.Add(new Carta(i, palo));
                if (p < 5)
                {
                    if (i == 12)
                    {
                        i = 0;
                        p++;
                    }
                }
            }
            int total_ini = baraja.Count();
            while (true)
            {

                
                string opcion = "0";
                string sel = null;
                int cant = 0;
                while (opcion == "0")
                {
                    Console.WriteLine("1. Barajar");
                    Console.WriteLine("2. Dar siguiente");
                    Console.WriteLine("3. Ver cantidad disponible");
                    Console.WriteLine("4. Dar [X] cartas");
                    Console.WriteLine("5. Ver pila de descarte");
                    Console.WriteLine("6. Ver baraja");
                    opcion = Console.ReadLine();
                }
                while (opcion == "1")
                {
                    Console.WriteLine("Barajando...");
                    Random rand = new Random();
                    baraja = baraja.OrderBy(_ => rand.Next(0, baraja.Count())).ToList();
                    opcion = "0";
                }
                
                
                while (opcion == "2")
                {
                    Console.WriteLine("1. Ver siguiente");
                    Console.WriteLine("2. Volver");
                    sel = Console.ReadLine();
                    if (sel == "1")
                    {
                        Console.WriteLine(" '"+baraja[0].ToString()+"' ");
                        Console.WriteLine(" ");
                        usadas.Add(baraja[0]);
                        baraja.RemoveAt(0);
                        sel = null;
                    }
                    else if (sel == "2")
                    {
                        sel = null;
                        opcion = "0";
                        
                    }

                }
                while (opcion == "3")
                {
                    Console.WriteLine("Hay "+baraja.Count()+" cartas disponibles de "+total_ini);
                    opcion = "0";
                }
                while (opcion == "4")
                {
                    Console.WriteLine("1. Ingresar cantidad");
                    Console.WriteLine("2. Volver");
                    sel = Console.ReadLine();
                    if (sel == "1")
                    {
                        Console.Write("Cantidad: ");
                        cant = int.Parse(Console.ReadLine());
                        for (int i = 0; i<cant; i++)
                        {
                            Console.WriteLine(baraja[0].ToString());
                            usadas.Add(baraja[0]);
                            baraja.RemoveAt(0);
                        }
                    }
                    else if(sel == "2")
                    {
                        sel = null;
                        opcion = "0";
                    }
                }
                while (opcion == "5")
                {
                    foreach (Carta c in usadas)
                    {
                        Console.WriteLine(c.ToString());
                    }
                }
                while (opcion == "6")
                {
                    foreach (Carta c in baraja)
                    {
                        Console.WriteLine(c.ToString());
                    }
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
