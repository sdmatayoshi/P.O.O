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
        public float peso;
        public float altura;

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona(string nombre, int edad, int dni, char sexo, float peso, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
        public int calcularIMC(float peso, float altura)
        {
            double peso_ideal = peso / (Math.Pow(altura, 2));
            //int ans;
            if (peso_ideal < 20)
            {
                return -1;
            }
            else if (peso_ideal >= 20 && peso_ideal <= 25)
            {
                return 0;
            }
            else if (peso_ideal > 25)
            {
                return 1;
            }
            return peso_ideal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
