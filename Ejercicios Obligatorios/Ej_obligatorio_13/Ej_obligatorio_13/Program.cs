using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_13
{
    class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
        public const double PLUS = 300;

        public Empleado(string nombre, int edad, double salario)
        {
            Nombre = nombre;
            Edad = edad;
            Salario = salario;
        }

        public virtual void Plus()
        {
            if (Edad > 30)
            {
                Salario += PLUS;
            }
        }

        public override string ToString()
        {
            return $"{Nombre}, Edad: {Edad}, Salario: {Salario}";
        }
    }
    class Repartidor : Empleado
    {
        public string Zona { get; set; }

        public Repartidor(string nombre, int edad, double salario, string zona)
            : base(nombre, edad, salario)
        {
            Zona = zona;
        }

        public override void Plus()
        {
            base.Plus();
            if (Edad < 25 && Zona == "Zona 3")
            {
                Salario += PLUS;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Zona: {Zona}";
        }
    }
    class Comercial : Empleado
    {
        public double Comision { get; set; }

        public Comercial(string nombre, int edad, double salario, double comision)
            : base(nombre, edad, salario)
        {
            Comision = comision;
        }

        public override void Plus()
        {
            base.Plus();
            if (Comision > 200)
            {
                Salario += PLUS;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Comisión: {Comision}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Comercial comercial1 = new Comercial("Comercial 1", 35, 1500, 300);
            Comercial comercial2 = new Comercial("Comercial 2", 25, 2500, 250);
            Repartidor repartidor1 = new Repartidor("Repartidor 1", 22, 1200, "Zona 3");
            Repartidor repartidor2 = new Repartidor("Repartidor 2", 28, 1800, "Zona 2");

            Console.WriteLine("(PLUS sin aplicar)");
            Console.WriteLine(comercial1);
            Console.WriteLine(comercial2);
            Console.WriteLine(repartidor1);
            Console.WriteLine(repartidor2);

            AplicarPlus(comercial1);
            AplicarPlus(comercial2);
            AplicarPlus(repartidor1);
            AplicarPlus(repartidor2);

            Console.WriteLine("(PLUS aplicado)");
            Console.WriteLine(comercial1);
            Console.WriteLine(comercial2);
            Console.WriteLine(repartidor1);
            Console.WriteLine(repartidor2);
            Console.ReadKey();
        }

        static void AplicarPlus(Empleado empleado)
        {
            empleado.Plus();
        }
    }
}