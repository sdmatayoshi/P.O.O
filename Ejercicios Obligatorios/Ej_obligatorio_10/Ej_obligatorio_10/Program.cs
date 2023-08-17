using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_10
{
    class Carta
    {
        int numero;
        string palo;

        public Carta()
        {
        }

        public Carta(string palo,int numero)
        {
            this.palo = palo;
            this.numero = numero;
            
        }
        public string getPalo()
        {
            return palo;
        }
        public int getNumero()
        {
            return numero;
        }
        public string mostrar() 
        { 
            return palo + numero.ToString();
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            List<Carta> baraja = new List<Carta>();
            int a = 1;
            string palo = null;
            for (int i = 1; i < 13; i++)
            {
                if (a == 1)
                {
                    palo = "espadas";
                }
                if (a == 2)
                {
                    palo = "bastos";
                }
                if (a == 3)
                {
                    palo = "oros";
                }
                if (a == 4)
                {
                    palo = "copas";
                }
                if (i == 8)
                {
                    i = 10;
                }
                baraja.Add(new Carta(palo, i));
                if (a < 5)
                {
                    if (i == 12)
                    {
                        i = 0;
                        a++;
                    }
                }
            }
            Random rand = new Random();
            baraja = baraja.OrderBy(_ => rand.Next(0, baraja.Count())).ToList();

            for (int i = 0; i < baraja.Count(); i++)
            {
                Console.WriteLine(baraja[i].mostrar());
            }
            Console.ReadKey();
        }
    }
}
