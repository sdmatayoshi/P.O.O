using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Program
    {
        private static string nombre;
        private static string curso;
        private static int edad;
        private static int dni;

        static void Main(string[] args)
        {
            


            Console.Write("ingresa la cantidda de alunos: ");
            int numro = int.Parse(Console.ReadLine());

            for (int i = 0; i < numro; i++)
            {
                Console.WriteLine($"ingresar datos parael alumno {i + 1}: " );
                Console.Write("nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("curso: ");
                string curso = Console.ReadLine();
                Console.Write("edad: ");
                int edad = Convert.ToInt32((Console.ReadLine()));
                Console.Write("ndi: ");
                int dni = int.Parse(Console.ReadLine());

                Console.WriteLine($"Total general de alumnos: {numro}");
             }
                //obj
                alumno objalumno = new alumno(nombre, curso, edad, dni);
      
            //mostra datos
            Console.WriteLine("losdatos son: ");
                objalumno.datos();
                

                //////////////////////////////////////
                //Console.WriteLine("ingrese los datos");
                //Console.WriteLine("nombre: ");
                //string nombre = Console.ReadLine();
                //Console.WriteLine("curso: ");
                //char curso = Convert.ToChar(Console.ReadLine());
                //Console.WriteLine("edad: ");
                //int edad = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("dni: ");
                //int DNI = Convert.ToInt32(Console.ReadLine());

           
        }
           
            

        
        class alumno
        {
            //atributs
            string nombre;
            string curso;
            int edad;
            int DNI;

            //contuctor
            public alumno(string nom, string cur, int edd, int dni)
            {
                nombre = nom;
                curso = cur;
                edad = edd;
                DNI = dni;
            }
            //metodos
            public  void datos()
            {
                Console.WriteLine("los nombres es:" +  nombre);
                Console.WriteLine("el curso es : " +  curso);
                Console.WriteLine("la edad es: " +  edad);
                Console.WriteLine("el deni es: " + DNI);
            }
        }
    }
}

