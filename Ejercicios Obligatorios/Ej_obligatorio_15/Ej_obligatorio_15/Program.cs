using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_15
{
    class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public double Litros { get; set; }
        public double Precio { get; set; }
        public int Estanteria { get; set; }

        public Producto(string id, string nombre, double litros, double precio)
        {
            Id = id;
            Nombre = nombre;
            Litros = litros;
            Precio = precio;
        }

        public virtual double CalcularPrecio()
        {
            return Precio;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Litros: {Litros}L, Precio: {Precio:C}";
        }
    }
    class Agua : Producto
    {
        public string Origen { get; set; }

        public Agua(string id, string nombre, double litros, double precio, string origen)
            : base(id, nombre, litros, precio)
        {
            Origen = origen;
            Estanteria = 1;
        }
    }
    class BebidaAzucarada : Producto
    {
        public string Marca { get; set; }
        public int PorcentajeAzucar { get; set; }
        public bool TienePromocion { get; set; }

        public BebidaAzucarada(string id, string nombre, double litros, double precio, string marca, int porcentajeAzucar, bool tienePromocion)
            : base(id, nombre, litros, precio)
        {
            Marca = marca;
            PorcentajeAzucar = porcentajeAzucar;
            TienePromocion = tienePromocion;
            Estanteria = 2;
        }

        public override double CalcularPrecio()
        {
            double precio = Precio;
            if (TienePromocion)
            {
                precio *= 0.9;
            }
            return precio;
        }

        public override string ToString()
        {
            return base.ToString() + $", Marca: {Marca}, Porcentaje de Azúcar: {PorcentajeAzucar}%, Promoción: {(TienePromocion ? "Sí" : "No")}";
        }
    }
    class Almacen
    {
        private List<Producto> productos;

        public Almacen()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            if (!ProductosContienenID(producto.Id))
            {
                productos.Add(producto);
                Console.WriteLine($"Se se guardó '{producto.Nombre}' en el almacén.");
            }
            else
            {
                Console.WriteLine($"No se pudo guardar '{producto.Nombre}' en el almacén. El ID '{producto.Id}' ya existe.");
            }
        }

        public void EliminarProducto(string id)
        {
            Producto productoEliminar = productos.Find(p => p.Id == id);
            if (productoEliminar != null)
            {
                productos.Remove(productoEliminar);
            }
            else
            {
                Console.WriteLine($"No se encontró ningún producto con el ID '{id}' para eliminar.");
            }
        }

        public double CalcularPrecioTotal()
        {
            double precioTotal = 0.0;
            foreach (Producto producto in productos)
            {
                precioTotal += producto.CalcularPrecio();
            }
            return precioTotal;
        }

        public double CalcularPrecioTotalMarca(string marca)
        {
            double precioTotal = 0.0;
            foreach (Producto producto in productos)
            {
                if (producto is BebidaAzucarada bebida && bebida.Marca == marca)
                {
                    precioTotal += bebida.CalcularPrecio();
                }
            }
            return precioTotal;
        }

        public double CalcularPrecioTotalEstanteria(int estanteria)
        {
            double precioTotal = 0.0;
            foreach (Producto producto in productos)
            {
                if (producto.Estanteria == estanteria)
                {
                    precioTotal += producto.CalcularPrecio();
                }
            }
            return precioTotal;
        }

        public void MostrarInformacion()
        {
            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto.ToString());
            }
        }

        private bool ProductosContienenID(string id)
        {
            return productos.Exists(p => p.Id == id);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Almacen almacen = new Almacen();
            almacen.AgregarProducto(new Agua("001", "Villavicencio", 1.5, 1, "Manantial A"));
            almacen.AgregarProducto(new BebidaAzucarada("002", "Pepsi", 2, 1.5, "Pepsicola", 10, true));
            almacen.AgregarProducto(new BebidaAzucarada("003", "7up", 2, 1.5, "Pepsicola", 12, false));
            Console.WriteLine("Almacén:");
            almacen.MostrarInformacion();
            double precioTotalAlmacen = almacen.CalcularPrecioTotal();
            Console.WriteLine($"Precio total de todas las bebidas en el almacén: {precioTotalAlmacen:C}");
            string marca = "Coca-Cola Company";
            double precioTotalMarca = almacen.CalcularPrecioTotalMarca(marca);
            Console.WriteLine($"Precio total de las bebidas de la marca '{marca}': {precioTotalMarca:C}");
            int estanteria = 1;
            double precioTotalEstanteria = almacen.CalcularPrecioTotalEstanteria(estanteria);
            Console.WriteLine($"Precio total de las bebidas en la estantería {estanteria}: {precioTotalEstanteria:C}");
            string idEliminar = "002";
            almacen.EliminarProducto(idEliminar);
            Console.WriteLine($"Producto con ID '{idEliminar}' eliminado del almacén.");
            Console.WriteLine("Información del Almacén después de eliminar un producto:");
            almacen.MostrarInformacion();
            Console.ReadKey();
        }
    }
}
