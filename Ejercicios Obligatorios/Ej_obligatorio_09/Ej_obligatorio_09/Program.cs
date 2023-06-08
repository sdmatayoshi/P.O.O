using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_09
{
    class Sala
    {
        int columnas = 9;
        int filas = 8;
        string pelicula = string.Empty;

        public Sala()
        {
        }

        public Sala(int columnas, int filas, string pelicula)
        {
            this.columnas = columnas;
            this.filas = filas;
            this.pelicula = pelicula;
        }
    }
    class Asiento
    {
        int columna;
        char fila;

        public Asiento() { }

        public Asiento(int columna, char fila)
        {
            this.columna = columna;
            this.fila = fila;
        }
         int Columna
        {
          get { return columna; }
          set { columna = value; }
        }
        char Fila
        {
            get { return fila; }
            set { fila = value; }
        }
        public string nombre()
        {
            return fila + " " + columna;
        }
    }
    class Prueba
    {
        int num1;
        int num2;

        public Prueba() { }

        public Prueba(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public string nombre()
        {
            return num2 + " " + num1;
        }
    }
    class Pelicula
    {
        string titulo;
        double duración;
        int edadMínima;
        string director;
    }
    class Espectador
    {
        string nombre;
        int edad;
        double dinero;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;
            int num = 0;
            List<char> letras = new List<char>();
            Console.Write("Filas:");
            filas = int.Parse(Console.ReadLine());
            Console.Write("Columnas:");
            columnas = int.Parse(Console.ReadLine());
            Random random = new Random();
            char c = Convert.ToChar(random.Next(65, (columnas+65)));
            if (columnas>90)
            {
                Console.Write("Elija un numero válido");
                Console.ReadKey();
            }
            Sala[] sala = new Sala[1];

            Asiento[] asientos = new Asiento[(filas*columnas)];
            Prueba[] test = new Prueba[(filas * columnas)];

            for (int i = 0; i <filas; i++)
            {
                char ch = Convert.ToChar(i + 65);
                letras.Add(ch);
            }

            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < (columnas*filas); j++)
            //    {
            //    asientos[j]=new Asiento(j, letras[i]);
            //    }
            //}

                int l = 0;
                int n = 1;
                for (int j = 0; j < (columnas * filas); j++)
                {
                    asientos[j] = new Asiento(n, letras[l]);
                    n++;
                    if (n == filas+1){
                        l++;
                        n = 1;
                    }
                if (l == filas)
                {
                    l = 0;
                }
            }


            //for (int i = 0; i < asientos.Count(); i++)
            //{
            //    if (asientos[i] != null)
            //    {
            //        Console.WriteLine(asientos[i].nombre());
            //    }
            //    else
            //    {
            //        Console.WriteLine("null");
            //    }
            //}
            for (int i = 0; i < test.Count(); i++)
            {
                if (asientos[i] != null)
                {
                    Console.WriteLine(asientos[i].nombre()+"\n");
                }
            }
            Pelicula[] pelicula = new Pelicula[1];
            
            Espectador[] espectadores = new Espectador[72];

            Console.ReadKey();
        }
    }
}
