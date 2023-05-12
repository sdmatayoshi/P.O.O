using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace Ej_obligatorio_05
{
    class Libro
    {
        public string titulo;
        public int ISBN;
        public int paginas;
        public string autor;

        public Libro()
        {
        }


        public Libro(string titulo, int ISBN, int paginas, string creador)
        {
            this.titulo = titulo;
            this.ISBN = ISBN;
            this.paginas = paginas;
            this.autor = creador;
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int ISBN_
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Libro[] libros = new Libro[2];
            libros[0] = new Libro("Project Achtrellion vol.1", 345783912, 25, "reichsacht");
            libros[1] = new Libro("Wings of Fire", 573850204, 337, "Tui T. Sutherland");
            List<Libro> libros_list = new List<Libro>();


            Console.WriteLine("----------------Series----------------");
            int a = 0;
            foreach (Libro l in libros)
            {

                Console.WriteLine("- Título: " + libros[a].titulo);
                Console.WriteLine("- ISBN: " + libros[a].ISBN);
                Console.WriteLine("- N° Páginas: " + libros[a].paginas);
                Console.WriteLine("- Autor/a: " + libros[a].autor);
                Console.WriteLine(" ");
                a++;
            }



            Console.WriteLine(" ");
            int maxl = libros[0].paginas;
            for (int i = 0; i < 2; i++)
            {
                if (libros[i].paginas > maxl)
                    maxl = libros[i].paginas;
            }

            //int c1 = 0;
            //foreach (Libro v in libros)
            //{
            //    if (maxl < libros[c1].paginas )
            //    {
            //        maxl=libros[c1].paginas;
            //        c1++;
            //    }

            //}

            for (int i = 0; i < 2; i++)
            {
                if (libros[i].paginas == maxl)
                {
                    Console.WriteLine("Libro con mayor cantidad de páginas: ");
                    Console.WriteLine("- Título: " + libros[i].titulo);
                }

            } 
            Console.ReadKey();
        }
    }
}
