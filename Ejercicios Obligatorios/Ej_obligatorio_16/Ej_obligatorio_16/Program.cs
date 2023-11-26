using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_16
{
    class Contacto
    {
        public string Nombre { get; }
        public string Telefono { get; }

        public Contacto(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public override bool Equals(object obj)
        {
            if (obj is Contacto otroContacto)
            {
                return Nombre.Equals(otroContacto.Nombre);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
    }
    class Agenda
    {
        private List<Contacto> contactos;
    private int capacidadMaxima;

    public Agenda(int capacidadMaxima = 10)
    {
        contactos = new List<Contacto>();
        this.capacidadMaxima = capacidadMaxima;
    }

    public bool AniadirContacto(Contacto contacto)
    {
        if (contactos.Count >= capacidadMaxima || ExisteContacto(contacto))
        {
            return false;
        }
        contactos.Add(contacto);
        return true;
    }

    public bool ExisteContacto(Contacto contacto)
    {
        return contactos.Contains(contacto);
    }

    public void ListarContactos()
    {
        foreach (Contacto contacto in contactos)
        {
            Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}");
        }
    }

    public Contacto BuscaContacto(string nombre)
    {
        return contactos.Find(c => c.Nombre.Equals(nombre));
    }

    public bool EliminarContacto(Contacto contacto)
    {
        return contactos.Remove(contacto);
    }

    public bool AgendaLlena()
    {
        return contactos.Count >= capacidadMaxima;
    }

    public int HuecosLibres()
    {
        return capacidadMaxima - contactos.Count;
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            int opcion;
            do
            {
                Console.WriteLine("1. Añadir nuevo contacto");
                Console.WriteLine("2. Comprobar si existe el contacto");
                Console.WriteLine("3. Ver todos los contactos");
                Console.WriteLine("4. Buscar por nombre");
                Console.WriteLine("5. Eliminar");
                Console.WriteLine("6. Ver disponibilidad");
                Console.WriteLine("7. Ver espacio disponible");
                Console.WriteLine("8. Salir");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Clear();

                    switch (opcion)
                    {

                        case 1:

                            Console.Write("Ingrese el nombre del contacto: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Ingrese el teléfono del contacto: ");
                            string telefono = Console.ReadLine();
                            Contacto nuevoContacto = new Contacto(nombre, telefono);
                            if (agenda.AniadirContacto(nuevoContacto))
                            {
                                Console.WriteLine("Contacto añadido correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("No se pudo añadir el contacto. Agenda llena o nombre duplicado.");
                            }
                            Console.Clear();

                            break;

                        case 2:
                            Console.Write("Ingrese el nombre del contacto a comprobar: ");
                            string nombreComprobar = Console.ReadLine();
                            if (agenda.ExisteContacto(new Contacto(nombreComprobar, "")))
                            {
                                Console.WriteLine("El contacto existe en la agenda.");
                            }
                            else
                            {
                                Console.WriteLine("El contacto no existe en la agenda.");

                            }


                            break;

                        case 3:
                            Console.WriteLine("Lista de Contactos:");
                            agenda.ListarContactos();

                            break;

                        case 4:
                            Console.Write("Ingrese el nombre del contacto a buscar: ");
                            string nombreBuscar = Console.ReadLine();
                            Contacto contactoEncontrado = agenda.BuscaContacto(nombreBuscar);
                            if (contactoEncontrado != null)
                            {
                                Console.WriteLine($"Nombre: {contactoEncontrado.Nombre}, Teléfono: {contactoEncontrado.Telefono}");
                            }
                            else
                            {
                                Console.WriteLine("El contacto no fue encontrado.");


                            }

                            break;

                        case 5:
                            Console.Write("INombre del contacto a eliminar: ");
                            string nombreEliminar = Console.ReadLine();
                            Contacto contactoAEliminar = new Contacto(nombreEliminar, "");
                            if (agenda.EliminarContacto(contactoAEliminar))
                            {
                                Console.WriteLine("Contacto eliminado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("El contacto no se ha encontrado");
                            }

                            break;

                        case 6:
                            if (agenda.AgendaLlena())
                            {
                                Console.WriteLine("No hay espacio disponible");
                            }
                            else
                            {
                                Console.WriteLine("Hay espacio disponible");
                            }

                            break;

                        case 7:
                            Console.WriteLine($"Espacio disponible en la agenda: {agenda.HuecosLibres()} contactos");
                            break;

                        case 8:
                            Console.WriteLine("Saliendo del programa.");
                            Console.Clear();

                            break;

                        default:
                            Console.Clear();

                            break;
                    }
                }

            }

            while (opcion != 8);
            Console.ReadKey();
        }
    }
}
