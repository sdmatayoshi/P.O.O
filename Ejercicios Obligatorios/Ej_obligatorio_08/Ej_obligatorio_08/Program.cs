using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_08
{
    class Persona
    {
        public string nombre;
        public int edad;
        public char sexo;
        public Persona() { }
        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
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
        char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        Random falta()
        {
            Random rnd = new Random();
            return rnd;
        }
       
    }
    class Profesor : Persona
    {
        string materia;
        public Profesor() { }
        public Profesor(string nombre, int edad, char sexo, string materia) : base(nombre, edad, sexo)
        {
            this.materia = materia;
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
        char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public int falta()
        {
            Random rnd = new Random();
            int prof = rnd.Next(1, 6);
            return prof;
        }
    }
    class Alumno : Persona
    {
        int calificacion;
        public Alumno() { }
        public Alumno(string nombre, int edad, char sexo, int calificacion) : base(nombre, edad, sexo)
        {
            this.calificacion = calificacion;
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
        char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        public int falta()
        {
            Random rnd = new Random();
            int alum = rnd.Next(1, 3);
            return alum;
        }
    }
    class Aula
    {
        int identificador;
        int max_estudiantes = 30;
        string materia;
        bool sin_profe = false;
        int alumnos_faltas = 0;
        bool hay_clase = false;
        public Aula() { }

        public Aula(int identificador, int max_estudiantes, string materia, bool sin_profe, int alumnos_faltas, bool hay_clase)
        {
            this.identificador = identificador;
            this.max_estudiantes = max_estudiantes;
            this.materia = materia;
            this.sin_profe = sin_profe;
            this.alumnos_faltas = alumnos_faltas;
            this.hay_clase = hay_clase;
        }
        int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }
        int Max_estudiantes
        {
            get { return max_estudiantes; }
            set { max_estudiantes = value; }
        }
        string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        bool Hay_clase
        {
            get { return hay_clase; }
            set { hay_clase = value; }
        }
        public string clase()
        {
            string prof = null;
            string clase = null;
            if (sin_profe == true)
            {
                prof = "faltó";
            }
            else
            {
                prof = "no faltó";
            }
            if (hay_clase == true)
            {
                clase = "hay";
            }
            else
            {
                clase = "no hay";
            }
            return "En el aula N°" + identificador + " faltaron " + alumnos_faltas + " alumnos de " + max_estudiantes + ", y el profe " + prof + " por lo tanto " + clase + " clases en esta aula debio a ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            string causa = null;
            int cantidad_al = 0;
            int cantidad_au = 0;
            Console.Write("Ingrese la cantidad de aaulas: ");
            cantidad_au = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de alumnos: ");
            cantidad_al = int.Parse(Console.ReadLine());
            for (int m = 0; m < cantidad_au; m++)
            {
                string[] materias = { "Matemáticas", "Filosofía", "Física" };
                Random rnd = new Random();
                int x = 0;
                int contador_faltas_alumnos = 0;
                bool contador_falta_profesor = false;
                bool sin_clase = false;
                Alumno[] alumnos = new Alumno[30];
            for (int i = 0; i < 30; i++)
            {
                alumnos[i] = new Alumno("Pepe", 15, 'M', 7);
            }
            foreach (Alumno a in alumnos)
            {

                //Console.WriteLine("- Alumno: " + alumnos[x].nombre + " " + alumnos[x].falta() + "\n");
                if (alumnos[x].falta() == 2)
                {
                    contador_faltas_alumnos++;
                }

                    System.Threading.Thread.Sleep(100);
                    x++;
            }



            Profesor[] profesores = new Profesor[1];
            profesores[0] = new Profesor("Juan", 20, 'M', "matematicas");
            if (profesores[0].falta() == 5)
            {
                contador_falta_profesor = true;
            }
            else
            {
                contador_falta_profesor = false;
            }



            Aula[] aulas = new Aula[cantidad_au];
            if (contador_faltas_alumnos >= (cantidad_al/2) && contador_falta_profesor == false)
            {
                sin_clase = false;
                    causa = "que faltó la mayoria de los alumnos";
            } else if (contador_faltas_alumnos < (cantidad_al / 2) && contador_falta_profesor == true)
            {
                sin_clase = false;
                    causa = "que no hay un docente disponible";
            } else if (contador_faltas_alumnos >= (cantidad_al / 2) && contador_falta_profesor == true)
            {
                sin_clase = false;
                    causa = "que faltó la mayoria de los alumnos y no hay un docente disponible";
            } else if (contador_faltas_alumnos < (cantidad_al / 2) && contador_falta_profesor == false)
            {
                sin_clase = true;
                    causa = "-";
            }


            int materia = rnd.Next(0, 3);
            aulas[m] = new Aula(m, cantidad_al, materias[materia], contador_falta_profesor, contador_faltas_alumnos, sin_clase);


            Console.WriteLine(aulas[m].clase()+causa);
                Array.Clear(profesores, 0, profesores.Length);
                Array.Clear(alumnos, 0, alumnos.Length);
                System.Threading.Thread.Sleep(100);
            }

            Console.ReadKey();
        }
    }
}
