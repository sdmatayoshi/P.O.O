using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace Ej_obligatorio_05
{
    class Serie
    {
        public string titulo = "default_serie_example_name=dragon_ball_z";
        public int temporadas = 3;
        public bool entregado = false;
        public string genero = "defaul_type=shounen";
        public string creador = "default_athor_name=reichacht";

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, int temporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.temporadas = temporadas;
            this.genero = genero;
            this.creador = creador;
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int Temporadas
        {
            get { return temporadas; }
            set { temporadas = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Creador
        {
            get { return creador; }
            set { genero = value; }
        }

            public bool entregar()
            {
                return entregado = true;
            }
            public bool devolver()
            {
                return entregado = false;
            }
            public bool isEntregado()
            {
                return entregado;
            }
    }

    class Videojuego
    {
        public string titulo = "default_game_title=minecraft";
        public float horas_estimadas = 10;
        public bool entregado = false;
        public string genero = "default_game_type=adventure";
        public string compañia = "default_developer_name=v-chan_studios";

        public Videojuego()
        {
        }

        public Videojuego(string titulo, float horas_estimadas)
        {
            this.titulo = titulo;
            this.horas_estimadas = horas_estimadas;
        }

        public Videojuego(string titulo, float horas_estimadas, string genero, string compañia) : this(titulo, horas_estimadas)
        {
            this.titulo = titulo;
            this.horas_estimadas = horas_estimadas;
            this.genero = genero;
            this.compañia = compañia;
            

        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public float Horas_estimadas
        {
            get { return horas_estimadas; }
            set { horas_estimadas = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Compañia
        {
            get { return compañia; }
            set { compañia = value; }
        }
       
            public bool entregar()
            {
                return entregado = true;
            }
            public bool devolver()
            {
                return entregado = false;
            }
            public bool isEntregado()
            {
                return entregado;
            }
    } 
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Serie[] series = new Serie[5];
            series[0] = new Serie("Jojo's Bizarre Adventure", 7, "Acción", "Hirohiko Araki");
            series[1] = new Serie("Tensei Shittara Slime Datta Ken", "Fuse");
            series[2] = new Serie();
            series[3] = new Serie("Toaru Kagaku no Railgun", 3, "Ficción", "Kazuma Kamachi");
            series[4] = new Serie("Ore no Imouto ga Konna ni Kawaii Wake ga Nai", "Tsukasa Fushimi");
            Videojuego[] videojuegos = new Videojuego[5];
            videojuegos[0] = new Videojuego("Touhou", 14, "Bullet Hell", "Zun");
            videojuegos[1] = new Videojuego();
            videojuegos[2] = new Videojuego();
            videojuegos[3] = new Videojuego("Blue Archive", 6);
            videojuegos[4] = new Videojuego("Phigros", 20, "Ritmo", "Pigeon Games");
            List<Serie> series_entregadas = new List<Serie>();
            List<Videojuego> juegos_entregados = new List<Videojuego>();
            int contserentre = 0;
            int contvidentre = 0;
            int cs = 0;
            int cv = 0;
            int cont = 0;
            float horas;
            float puente;

            foreach (Serie s in series)
            {
                series[0].entregar();
                series[4].entregar();
                series[3].entregar();
            }
            foreach (Videojuego v in videojuegos)
            {
                videojuegos[0].entregar();
                videojuegos[3].entregar();
            }
            foreach (Serie s in series)
            {
                if (series[cs].entregado == true)
                {
                    contserentre ++;
                    series_entregadas.Add(series[cs]);
                }
                cs++;
            }
            foreach (Videojuego v in videojuegos)
            {
                if (videojuegos[cv].entregado == true)
                {
                    contvidentre++;
                    juegos_entregados.Add(videojuegos[cv]);
                }
                cv++;
            }
            //foreach (Videojuego v in videojuegos)
            //{
                
            //    horas = videojuegos[cont].horas_estimadas;
            //    puente = videojuegos[cont+1].horas_estimadas;
            //    if (horas < puente)
            //    {
            //        horas = puente;
            //        puente = videojuegos[cont + 1].horas_estimadas; ;
            //    }
            //    cont++;
            //}
            Console.WriteLine("Series entregadas: "+contserentre);

            //int a = 0;
            for(int a=0;a<series.Count();a++)
            {
                if (series[a].entregado == true)
                {
                    Console.WriteLine(series[a].titulo);
                }
                //a++;
            }
            Console.WriteLine("Juegos entregados: "+ contvidentre);
            //int b = 0;
            for (int b = 0; b < series.Count(); b++)
            {
                if (videojuegos[b].entregado == true)
                {
                    Console.WriteLine(videojuegos[b].titulo);
                }
                //b++;
            }
            Console.ReadKey();  
        }
    }
}
