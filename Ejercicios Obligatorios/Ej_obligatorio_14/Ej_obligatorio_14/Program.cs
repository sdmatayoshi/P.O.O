using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_14
{
    class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public virtual double Calcular(int cantidad)
        {
            return Precio * cantidad;
        }

        public override string ToString()
        {
            return $"{Nombre}, Precio: {Precio}";
        }
    }
    class Perecedero : Producto
    {
        public int DiasCaducar { get; set; }

        public Perecedero(string nombre, double precio, int diasCaducar)
            : base(nombre, precio)
        {
            DiasCaducar = diasCaducar;
        }

        public override double Calcular(int cantidad)
        {
            double precio = base.Calcular(cantidad);

            if (DiasCaducar == 1)
            {
                return precio / 4;
            }
            else if (DiasCaducar == 2)
            {
                return precio / 3;
            }
            else if (DiasCaducar == 3)
            {
                return precio / 2;
            }

            return precio;
        }

        public override string ToString()
        {
            return base.ToString() + $", Días a caducar: {DiasCaducar}";
        }
    }
    class NoPerecedero : Producto
    {
        public string Tipo { get; set; }

        public NoPerecedero(string nombre, double precio, string tipo)
            : base(nombre, precio)
        {
            Tipo = tipo;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto[] productos = new Producto[6];

            productos[0] = new Producto("Producto A", 10.0);
            productos[1] = new Producto("Producto B", 15.0);
            productos[2] = new Producto("Producto C", 5.0);
            productos[3] = new Perecedero("Perecedero A", 8.0, 1);
            productos[4] = new Perecedero("Perecedero B", 12.0, 3);
            productos[5] = new NoPerecedero("No Perecedero A", 20.0, "Tipo X");

            CalcularPrecioTotal(productos, 5);

            Console.ReadLine();
        }
        static void CalcularPrecioTotal(Producto[] productos, int cantidad)
        {
            double precioTotal = 0.0;

            foreach (Producto producto in productos)
            {
                precioTotal += producto.Calcular(cantidad);
            }

            Console.WriteLine($"Precio total por vender {cantidad} productos de cada tipo: EU${precioTotal}.");
        }
    }
}