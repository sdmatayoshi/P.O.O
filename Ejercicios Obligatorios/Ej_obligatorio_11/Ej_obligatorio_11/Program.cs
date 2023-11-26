using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_11
{
    class Jugador
    {
        public string Nombre { get; }
        public int Dinero { get; set; }
        public int Victorias { get; set; }

        public Jugador(string nombre, int dineroInicial)
        {
            Nombre = nombre;
            Dinero = dineroInicial;
            Victorias = 0;
        }

        public void GanarPozo(int pozo)
        {
            Dinero += pozo;
            Victorias++;
        }
    }
    class Jugada
    {
        public Jugador Jugador { get; }
        public List<int> Resultados { get; }

        public Jugada(Jugador jugador, List<int> resultados)
        {
            Jugador = jugador;
            Resultados = resultados;
        }
    }
    class Jornada
    {
        public int Numero { get; }
        public int Partidos { get; }
        public List<Jugada> Jugadas { get; }
        public int Pozo { get; set; }

        public Jornada(int numero, int partidos)
        {
            Numero = numero;
            Partidos = partidos;
            Jugadas = new List<Jugada>();
            Pozo = 0;
        }

        public void Apostar(Jugador jugador, List<int> resultados)
        {
            Jugadas.Add(new Jugada(jugador, resultados));
            jugador.Dinero -= 1;
            Pozo += 1;
        }

        public int VerificarAciertos(Jugador jugador)
        {
            Jugada jugada = Jugadas.FirstOrDefault(j => j.Jugador == jugador);

            if (jugada != null)
            {
                int aciertos = 0;
                foreach (int resultado in jugada.Resultados)
                {
                    if (resultado == 2)
                    {
                        aciertos++;
                    }
                }
                return aciertos;
            }

            return 0;
        }

        public override string ToString()
        {
            return $"Jornada {Numero}: Pozo = {Pozo}";
        }
    }
    class Apuesta
    {
        private List<Jugador> jugadores;
        private List<Jornada> jornadas;
        public IConstantes Constantes { get; }

        public Apuesta()
        {
            Constantes = new ConstantesPorra();
            jugadores = new List<Jugador>
        {
            new Jugador("Jugador 1", Constantes.DineroInicial),
            new Jugador("Jugador 2", Constantes.DineroInicial),
            new Jugador("Jugador 3", Constantes.DineroInicial)
        };
            jornadas = new List<Jornada>();
        }

        public void RealizarApuestas(int jornada)
        {
            Jornada nuevaJornada = new Jornada(jornada, Constantes.PartidosPorJornada);
            jornadas.Add(nuevaJornada);

            foreach (Jugador jugador in jugadores)
            {
                if (jugador.Dinero >= Constantes.DineroInicial)
                {
                    List<int> resultados = GenerarResultadosAleatorios(Constantes.PartidosPorJornada);
                    nuevaJornada.Apostar(jugador, resultados);
                }
            }
        }

        public void VerificarAciertos(int jornada)
        {
            Jornada jornadaActual = jornadas.FirstOrDefault(j => j.Numero == jornada);

            if (jornadaActual != null)
            {
                foreach (Jugador jugador in jugadores)
                {
                    if (jugador.Dinero >= Constantes.DineroInicial)
                    {
                        int aciertos = jornadaActual.VerificarAciertos(jugador);
                        if (aciertos >= Constantes.AciertosNecesarios)
                        {
                            jugador.GanarPozo(jornadaActual.Pozo);
                            jornadaActual.Pozo = 0;
                        }
                    }
                }
            }
        }

        public void MostrarResultados()
        {
            foreach (Jornada jornada in jornadas)
            {
                Console.WriteLine(jornada);
            }
        }

        public void MostrarDineroYVictorias()
        {
            foreach (Jugador jugador in jugadores)
            {
                Console.WriteLine($"{jugador.Nombre}: Dinero = {jugador.Dinero}, Victorias = {jugador.Victorias}");
            }
        }

        private List<int> GenerarResultadosAleatorios(int cantidad)
        {
            Random random = new Random();
            List<int> resultados = new List<int>();

            for (int i = 0; i < cantidad; i++)
            {
                resultados.Add(random.Next(0, 3));
            }

            return resultados;
        }
    }
        class ConstantesPorra : IConstantes
    {
        public int DineroInicial => 15;
        public int Jornadas => 3;
        public int PartidosPorJornada => 5;
        public int AciertosNecesarios => 2;
    }
    interface IConstantes
    {
        int DineroInicial { get; }
        int Jornadas { get; }
        int PartidosPorJornada { get; }
        int AciertosNecesarios { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Apuesta apuesta = new Apuesta();

            for (int jornada = 1; jornada <= apuesta.Constantes.Jornadas; jornada++)
            {
                Console.WriteLine($"Jornada {jornada}:");
                apuesta.RealizarApuestas(jornada);
                apuesta.VerificarAciertos(jornada);
                apuesta.MostrarResultados();
            }

            Console.WriteLine("\nResultados finales:");
            apuesta.MostrarDineroYVictorias();
            Console.ReadKey();
        }
    }
}
