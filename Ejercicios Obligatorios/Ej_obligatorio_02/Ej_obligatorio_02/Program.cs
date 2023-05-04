using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_02
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public int dni;
        public char sexo;
        public double peso;
        public double altura;

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
