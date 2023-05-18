using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_ejercicios_con_listas2
{
    class Program
    {
        class Persona
        {
            public string nombre;
            public string apellido;

            public Persona()
            {
            }
            public Persona(string nombre, string apellido)
            {
                this.nombre = nombre;
                this.apellido = apellido;
            }
            public string mostrarPersona()
            {
                return apellido + ", " + nombre;
            }

        }
        class ComparadorPersona : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return x.apellido.CompareTo(y.apellido);
            }
        }
        static void Main(string[] args)
        {
            //Nombres
            string[] noms = { "Martin", "Patricio", "Joaquin", "Pablo", "Sofia", "Juan Cruz", "Henry", "Nahiara", "Akemi", "Agustin", "Belen", "Juana" };
            //Apellidos
            string[] apes = { "Mendelewicz", "Lipfeld", "Bassi", "Chinen", "Benasi", "You", "Wu", "Matusevich", "Kasai", "Rojas", "Katogi", "Grifero" };
            //Random
            Random rnd = new Random();
            int nomape = rnd.Next(0, 12);
            //Listas de paises
            List<Persona> Arg = new List<Persona>();

            //Obtener tiempo
            DateTime hora = DateTime.Now;
            DateTime horaActual = DateTime.Now;
            TimeSpan tiempoTrasncurrido;

            while (true)
            {

                horaActual = DateTime.Now;
                tiempoTrasncurrido = horaActual - hora;
                if (tiempoTrasncurrido.Seconds == 60)
                {
                    hora = DateTime.Now;
                    for (int i = 0; i < Arg.Count - 1; i++)
                    {
                        Arg.RemoveAt(i);
                    }
                }
                //nacimientos en argentina
                if (tiempoTrasncurrido.Seconds == 30)
                {
                    hora = DateTime.Now;
                    Arg.Add(new Persona(noms[nomape], apes[nomape]));

                }
                //nacimientos en brasil
                
                //mostrar lista
                if (tiempoTrasncurrido.Seconds == 10)
                {
                    Console.Clear();
                    Console.WriteLine("┌────────────────────────────────────────────────────────────────────────┐");
                    Console.WriteLine("│Ejercicio con listas. (refrecado por última vez a: " + hora + ")│");
                    Console.WriteLine("├────────────────────────────────────────────────────────────────────────┤");
                    Console.WriteLine(" Argentina:");
                    foreach (var persona in Arg)
                    {
                        Console.WriteLine(persona.nombre + ", " + persona.apellido);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" En Argentina viven " + Arg.Count + " personas en total");
                    Console.WriteLine(" ");
                    Console.WriteLine("└────────────────────────────────────────────────────────────────────────┘");
                }
            }
        }
    }
}
