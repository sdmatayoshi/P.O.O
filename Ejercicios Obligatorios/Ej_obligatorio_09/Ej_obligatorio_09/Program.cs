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
        bool ocupado;
        public Asiento() { }

        public Asiento(int columna, char fila, bool ocupado)
        {
            this.columna = columna;
            this.fila = fila;
            this.ocupado = ocupado;
        }

        public Asiento(bool ocupado)
        {
            this.ocupado = ocupado;
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
        bool Ocupado
        {
            get { return ocupado; }
            set { ocupado = value; }
        }
        public string nombre()
        {
            return fila + "" + columna + " ";
        }
        public bool isOcupado()
        {
            return ocupado;
        }
    }
    
    class Pelicula
    {
        string titulo;
        double duracion;
        int edadMinima;
        string director;
        int precio;

        public Pelicula()
        {
        }

        public Pelicula(string titulo, double duracion, int edadMinima, string director, int precio)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
            this.precio = precio;
        }
        string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        double Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        int EdadMinima
        {
            get { return edadMinima; }
            set { edadMinima = value; }
        }
        string Director
        {
            get { return director; }
            set { director = value; }
        }
        int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int minimo()
        {
            return edadMinima;
        }
        public int precioEntrada()
        {
            return precio;
        }
        public string datos()
        {
            return titulo +", "+ director +", "+ duracion +"h, "+ edadMinima+", $"+precio;
        }
    }
    class Espectador
    {
        string nombre;
        int edad;
        double dinero;
        bool conLugar;

        public Espectador()
        {
        }

        public Espectador(bool conLugar)
        {
            this.conLugar = conLugar;
        }

        public Espectador(string nombre, int edad, double dinero, bool conLugar)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
            this.conLugar = conLugar;
        }
        string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        double Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }
        bool ConLugar
        {
            get { return conLugar; }
            set { conLugar = value; }
        }
        public string datos()
        {
            return nombre +"("+ edad+") ";
        }
        public bool lugar()
        {
            return conLugar;
        }
        public double plata()
        {
            return dinero;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;
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
            Espectador[] espectadores = new Espectador[100];
            Pelicula[] peli = new Pelicula[2];
            int[] minimo = new int[3] {15,18,20};
            int[] entrada = new int[3] { 500, 600, 1000 };
            string[] titulo = new string[3] { "Tonari no Totoro", "Sen to Chihiro no Kamikakuji", "Gake no ue no Ponyo" };
            int edadminima = random.Next(0,4);
            int title = random.Next(0, 4);
            int valorEntrada = random.Next(0, 4);
            for (int i = 0; i<1;i++)
            {
            peli[0] = new Pelicula(titulo[title], 1.45, minimo[edadminima], "Hayao Miyasaki", entrada[valorEntrada]);
            }
            


            for (int i = 0; i <filas; i++)
            {
                char ch = Convert.ToChar(i + 65);
                letras.Add(ch);
            }
            
                
            
            int l = 0;
            int n = 1;
            for (int j = 0; j < (columnas * filas); j++)
            {
               
                asientos[j] = new Asiento(n, letras[l], false);
                n++;
                if (n == filas + 1)
                {
                    l++;
                    n = 1;
                }
                if (l == filas)
                {
                    l = 0;
                }
            }
            int a = 0;

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 100; i++)
                {
                    int edad = random.Next(14, 41);
                    int dinero = random.Next(499, 1001);
                    espectadores[i] = new Espectador("Juan", edad, dinero, false);
                }

                if (asientos[a].isOcupado() == false && espectadores[a].lugar() == false)
                {
                    asientos[a] = new Asiento(true);
                    espectadores[a] = new Espectador(true);
                }

                for (int i = 0; i < asientos.Count(); i++)
                {
                    if (asientos[i] != null)
                    {
                        if (asientos[i].isOcupado() == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Write(asientos[i].nombre());

                        if ((i + 1) % columnas == 0)
                        {
                            Console.Write("\n");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }





                //int l = 0;
                //int n = 1;
                //bool ocupado = false;
                //for (int j = 0; j < (columnas * filas); j++)
                //{
                //    if (espectadores[j].lugar() == true && espectadores[j].plata() >= peli[0].precioEntrada())
                //    {
                //        ocupado = true;
                //    }
                //    else
                //    {
                //        ocupado = false;
                //    }
                //    asientos[j] = new Asiento(n, letras[l], ocupado);
                //    n++;
                //    if (n == filas + 1)
                //    {
                //        l++;
                //        n = 1;
                //    }
                //    if (l == filas)
                //    {
                //        l = 0;
                //    }
                //}










                Console.Write(peli[0].datos());
                a++;
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
