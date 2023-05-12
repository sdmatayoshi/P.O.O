using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_02
{
    class Persona
    {
        public string nombre = "Elpepe";
        public int edad = 18;
        public int dni = 47127984;
        public char sexo = 'M';
        public double peso = 50.0;
        public double altura = 1.70;

        public Persona()
        {
        }
        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }
        public Persona(string nombre, int edad, int dni, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
        }

        public Persona(string nombre, int edad, int dni, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }


        public float calcularIMC()
        {
            double peso_ideal = peso / (Math.Pow(altura, 2));
            int num = 0;

            if (peso_ideal < 20)
            {
                num = -1;
            }
            else if (peso_ideal >= 20 && peso_ideal <= 25)
            {
                num = 0;
            }
            else if (peso_ideal > 25)
            {
                num = 1;
            }
            return num;
        }

        public bool esMayorDeEdad()
        {
            bool esMayor = false;
            if (this.edad >= 18) { 
            esMayor = true;
            }
            return esMayor;
        }
        public char comprobarSexo(char g)
        {
            const string gp = "MF";
            if (gp.Contains(g))
            {
                this.sexo = g;
            }
            else
            {
                this.sexo = 'M';
            }
            return this.sexo;
        }
        public int generaDNI()
        {
            Random rnd = new Random();
            int dni = rnd.Next(100000000, 99999999);
            return dni;
        }
        public string Nombre
        {
            set { nombre = value; }
        }
        public int Edad
        {
            set { edad = value; }
        }
        public char Sexo
        {
            set { sexo = value; }
        }
        public float Peso
        {
            set { peso = value; }
        }
        public float Altura
        {
            set { altura = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args) {
            Persona[] personas = new Persona[3];
            personas[0] = new Persona("Juana", 25, 23432873,'F',52.4,1.6);
            personas[1] = new Persona("Pedro", 15, 23432873, 'M');
            personas[2] = new Persona();
            int cp = 0;
            foreach (Persona p in personas)
            {
                float ideal = personas[cp].calcularIMC();
                if (ideal == -1)
                {
                    Console.WriteLine((cp + 1) + ". Deficiente");
                }
                else if (ideal == 0)
                {
                    Console.WriteLine((cp + 1) + ". Ideal");
                }
                else if (ideal == 1)
                {
                    Console.WriteLine((cp + 1) + ". Sobrepeso");
                }

                cp++;
            }


            int cp2 = 0;
            foreach (Persona p in personas)
            {
                bool mayor = personas[cp2].esMayorDeEdad();
                if (mayor == true)
                {
                    Console.WriteLine((cp2 + 1) + ". Es mayor de edad");
                }
                else
                {
                    Console.WriteLine((cp2 + 1) + ". Es menor de edad");

                }
                cp2++;
            }

            int cp3 = 0;
            foreach (Persona p in personas)
            {
                float ideal = personas[cp3].calcularIMC();
                string peso_valor = null;
                bool mayor = personas[cp3].esMayorDeEdad();
                string mayormenor = null;


                if (ideal == -1)
                {
                    peso_valor = "(Deficiente)";
                }
                else if (ideal == 0)
                {
                    peso_valor = "(Ideal)";
                }
                else if (ideal == 1)
                {
                    peso_valor = "(Sobrepeso)";
                }

                if (mayor == true)
                {
                    mayormenor = " (Es mayor de edad)";
                }
                else
                {
                    mayormenor = " (Es menor de edad)";

                }


                Console.WriteLine((cp3 + 1) + 
                    ". " + 
                    personas[cp3].nombre +
                    " | "+ 
                    personas[cp3].edad + mayormenor +
                    " | "+ 
                    personas[cp3].dni +
                    " | "+ 
                    personas[cp3].peso + "kg "+ peso_valor + 
                    " | "+
                    personas[cp3].altura + "m");

                
                cp3++;
            }
            Console.ReadKey();
        }
    }
}
