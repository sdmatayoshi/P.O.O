using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_12
{
    class Jugador
    {
        public int Id { get; }
        public string Nombre { get; }
        public bool Vivo { get; set; }

        public Jugador(int id)
        {
            Id = id;
            Nombre = "Jugador " + id;
            Vivo = true;
        }

        public void Disparar(Revolver revolver)
        {
            if (revolver.Disparar())
            {
                Vivo = false;
                Console.WriteLine(Nombre + " ha muerto.");
            }
            else
            {
                Console.WriteLine(Nombre + " ha sobrevivido.");
            }
        }
    }
    class Revolver
    {
        private int posicionActual;
        private int posicionBala;
        private Random random;

        public Revolver()
        {
            random = new Random();
            posicionActual = 0;
            posicionBala = random.Next(1, 7);
        }

        public bool Disparar()
        {
            if (posicionActual == posicionBala)
            {
                return true;
            }
            else
            {
                SiguienteBala();
                return false;
            }
        }

        public void SiguienteBala()
        {
            posicionActual = (posicionActual % 6) + 1;
        }
    }
    class Juego
    {
        private List<Jugador> jugadores;
        private Revolver revolver;

        public Juego(int numJugadores)
        {
            jugadores = new List<Jugador>();
            for (int i = 1; i <= numJugadores; i++)
            {
                jugadores.Add(new Jugador(i));
            }
            revolver = new Revolver();
        }
        public void IniciarJuego()
        {
            while (true)
            {
                foreach (Jugador jugador in jugadores)
                {
                    if (jugador.Vivo)
                    {
                        Console.WriteLine("\nTurno " + jugador.Id);
                        jugador.Disparar(revolver);
                        if (!jugador.Vivo)
                        {
                            if (FinJuego())
                                return;
                        }
                        Console.WriteLine("Enter = Continuar");
                        Console.ReadLine();
                    }
                }
            }
        }
        public bool FinJuego()
        {
            foreach (Jugador jugador in jugadores)
            {
                if (jugador.Vivo)
                {
                    return false;
                }
            }
            Console.WriteLine("\nTodos los jugadores han muerto. El juego ha terminado.");
            return true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de jugadores (1~6): ");
            int numJugadores = LeerEntero(1, 6);

            Juego juego = new Juego(numJugadores);
            juego.IniciarJuego();

            Console.WriteLine("\nFin del juego.");
            Console.ReadKey();
        }
        static int LeerEntero(int min, int max)
        {
            int valor;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out valor) && valor >= min && valor <= max)
                {
                    return valor;
                }
                Console.Write("Entrada inválida. Ingrese un número entre " + min + " y " + max + ": ");
            }
        }
    }
}
