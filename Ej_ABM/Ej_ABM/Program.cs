using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_ABM
{
    public class Usuario
    {
        public string nombre;
        public int dni;

        public Usuario()
        {
        }
        public Usuario(string nombre)
        {
            this.nombre = nombre;
        }
        public Usuario(int dni)
        {
            this.dni = dni;
        }
        public Usuario(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A:
            Console.Clear();
            string nombre = null;
            int dni = 0;
            List<Usuario> usuario = new List<Usuario>();
            ConsoleKeyInfo tecla;
            string[] menu = {
                "              Nuevo usuario                   ",
                "              Modificar usuario               ",
                "              Eliminar usuario                ",
                "              Listar                          "
            };

            int posMenu = 0;
            Console.CursorVisible = false;
            for (int i = 0; i < menu.Count(); i++)
            {
                Console.SetCursorPosition(30, i + 10);
                if (i == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(menu[i]);
            }

            while (true)
            {
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (posMenu < menu.Count() - 1)
                    {
                        Console.SetCursorPosition(30, posMenu + 10);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(menu[posMenu]);
                        posMenu++;
                        Console.SetCursorPosition(30, posMenu + 10);
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(menu[posMenu]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(30, posMenu + 10);
                        Console.Write(menu[posMenu]);
                        posMenu = 0;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(30, posMenu + 10);
                        Console.Write(menu[posMenu]);
                    }
                }
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (posMenu > 0)
                    {
                        Console.SetCursorPosition(30, posMenu + 10);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(menu[posMenu]);
                        posMenu--;
                        Console.SetCursorPosition(30, posMenu + 10);
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(menu[posMenu]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(30, posMenu + 10);
                        Console.Write(menu[posMenu]);
                        posMenu = menu.Count() - 1;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(30, posMenu + 10);
                        Console.Write(menu[posMenu]);
                    }
                }
                if (tecla.Key == ConsoleKey.Enter && posMenu == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.Write("Ingrese su nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.Write("INgrese su DNI: ");
                    dni = int.Parse(Console.ReadLine());
                    usuario.Add(new Usuario(nombre, dni));
                    Console.WriteLine("El usuario se ha creado correctamente");
                    Console.ReadKey();
                    goto A;
                }
                else if (tecla.Key == ConsoleKey.Enter && posMenu == 1)
                {
                    string select;
                    int valor;
                    string op = null;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.Write("Ingrese el nombre o DNI del usuario que quiere modificar: ");
                    select = Console.ReadLine();
                    bool isNaN = int.TryParse(select, out valor);
                    if (isNaN == true)
                    {
                        for (int i = 0; i < usuario.Count(); i++)
                        {
                            if (usuario[i].dni == valor)
                            {
                                int pos = usuario[i].dni;
                                Console.WriteLine("1. modificar nombre");
                                Console.WriteLine("2. modificar dni");
                                if (op == "1")
                                {
                                    Console.Write("Ingrese el nuevo nombre: ");
                                    nombre = Console.ReadLine();
                                    var replace = new Usuario(nombre);
                                    var usu = usuario.FirstOrDefault(n=>n.nombre == replace.nombre);
                                    usuario.Remove(usu);
                                    usuario.Add(replace);
                                    Console.ReadKey();
                                    goto A;
                                }
                                else if(op == "2")
                                {
                                    Console.Write("Ingrese el nuevo dni: ");
                                    dni = int.Parse(Console.ReadLine());
                                    var replace = new Usuario(dni);
                                    var usu = usuario.FirstOrDefault(d => d.dni == replace.dni);
                                    usuario.Remove(usu);
                                    usuario.Add(replace);
                                    Console.ReadKey();
                                    goto A;
                                }
                            }
                        }
                       
                    }
                    else
                    {
                        valor = int.Parse(select);
                        for (int i = 0; i < usuario.Count(); i++)
                        {
                            if (usuario[i].dni == valor)
                            {
                                int pos = usuario[i].dni;
                                Console.WriteLine("1. modificar nombre");
                                Console.WriteLine("2. modificar dni");
                                if (op == "1")
                                {
                                    Console.Write("Ingrese el nuevo nombre: ");
                                    nombre = Console.ReadLine();
                                    var replace = new Usuario(nombre);
                                    var usu = usuario.FirstOrDefault(n => n.nombre == replace.nombre);
                                    usuario.Remove(usu);
                                    usuario.Add(replace);
                                    Console.ReadKey();
                                    goto A;
                                }
                                else if (op == "2")
                                {
                                    Console.Write("Ingrese el nuevo dni: ");
                                    dni = int.Parse(Console.ReadLine());
                                    var replace = new Usuario(dni);
                                    var usu = usuario.FirstOrDefault(d => d.dni == replace.dni);
                                    usuario.Remove(usu);
                                    usuario.Add(replace);
                                    Console.ReadKey();
                                    goto A;
                                }
                            }
                        }
                    }
                }
                else if (tecla.Key == ConsoleKey.Enter && posMenu == 2)
                {
                     string select;
                     int valor;
                     Console.BackgroundColor = ConsoleColor.Black;
                     Console.ForegroundColor = ConsoleColor.White;
                     Console.Clear();
                     Console.Write("Ingrese el nombre o DNI del usuario que quiere eliminar: ");
                     select = Console.ReadLine();
                     bool isNaN = int.TryParse(select, out valor);
                     if (isNaN == true)
                     {
                         for (int i = 0; i < usuario.Count(); i++)
                         {
                             if (usuario[i].dni == valor)
                             {
                                Console.WriteLine("Se ha eliminado el usuario"+ usuario[i] +"correctamente");
                                usuario.RemoveAt(i);
                                Console.ReadKey();
                                goto A;
                            }
                         }
                     }
                     else
                     {
                         valor = int.Parse(select);
                         for (int i = 0; i < usuario.Count(); i++)
                         {
                            if (usuario[i].dni == valor)
                            {
                                Console.WriteLine("Se ha eliminado el usuario" + usuario[i] + "correctamente");
                                usuario.RemoveAt(i);
                                Console.ReadKey();
                                goto A;
                            }
                         }
                     }
                }
                else if (tecla.Key == ConsoleKey.Enter && posMenu == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    for (int i = 0;i < usuario.Count();i++)
                    {
                        Console.Write(usuario[i].nombre + " ");
                        Console.WriteLine(usuario[i].dni);
                        
                    }
                    Console.ReadKey();
                    goto A;
                }
            }
        }
    }
}
