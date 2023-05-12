using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_01
{
    public class Cuenta
    {
        public string titular;
        public double cantidad;

        public Cuenta()
        {
        }
        public Cuenta(string titular)
        {
            this.titular = titular;
        }
        public Cuenta(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        A:
            Console.Clear();
            string titular = null;
            string opcion = null;
            string opcion2 = null;
            //double cantidad_en_cuenta = 0;   
            double cantidad = 0;
            Cuenta[] cuenta = new Cuenta[1];
            Console.WriteLine("Ingrese el nombre del titular de la cuenta:");
            titular = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(titular)==false)
            {
                cuenta[0] = new Cuenta(titular);
                Console.Write("Bienvenido " + cuenta[0].titular +". ");
                B:
                Console.WriteLine("Elija la operación que desea realizar.");
                Console.WriteLine("1. Ingresar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Ver cuenta");
                opcion = Console.ReadLine();
                if (opcion == "1") 
                {
                C:
                    Console.Clear();
                    Console.Write("Escriba el monto a ingresar: ");
                    cantidad = double.Parse(Console.ReadLine());
                    if (cantidad > 0)
                    {
                        //cantidad_en_cuenta = cantidad_en_cuenta + cantidad;
                        cuenta[0].cantidad = cuenta[0].cantidad + cantidad;
                        Console.WriteLine("se han ingresado $" + cuenta[0].cantidad +" en la cuenta.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Elija la operación que desea realizar.");
                        Console.WriteLine("1. Volver a ingresar");
                        Console.WriteLine("2. Volver atrás");
                        opcion2 = Console.ReadLine();
                        if (opcion2 == "1")
                        {
                            goto C;
                        }
                        else if (opcion2 == "2")
                        {
                            Console.Clear();
                            goto B;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una cantidad válida.");
                        Console.ReadKey();
                        goto C;
                    }
                }
                else if(opcion == "2")
                {
                    D:
                    Console.Clear();
                    Console.Write("Escriba el monto a retirar: ");
                    cantidad = double.Parse(Console.ReadLine());
                    if (cantidad > 0)
                    {
                        //if (cantidad_en_cuenta > 0)
                        if(cantidad < cuenta[0].cantidad)
                        {
                        //cantidad_en_cuenta = cantidad_en_cuenta - cantidad;
                        cuenta[0].cantidad = cuenta[0].cantidad - cantidad;
                        Console.WriteLine("se han retirado $" + cantidad + " de la cuenta.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Elija la operación que desea realizar.");
                        Console.WriteLine("1. Volver a retirar");
                        Console.WriteLine("2. Volver atrás");
                        }/*else if (cantidad_en_cuenta < 0)
                        {
                            cantidad_en_cuenta = cantidad_en_cuenta + cantidad;
                            Console.WriteLine("el saldo ingresado supera la cantidad almacenada en su cuenta");
                            Console.WriteLine(" ");
                            Console.WriteLine("Elija la operación que desea realizar.");
                            Console.WriteLine("1. Volver a ingresar la cantidad a retirar");
                            Console.WriteLine("2. Volver atrás");
                        }*/
                        else if (cantidad > cuenta[0].cantidad)
                        {
                            Console.WriteLine("el saldo ingresado supera la cantidad almacenada en su cuenta");
                            Console.WriteLine("se han retirado $" + cuenta[0].cantidad + " de la cuenta.");
                            cuenta[0].cantidad = 0;
                            Console.WriteLine(" ");
                            Console.WriteLine("Elija la operación que desea realizar.");
                            Console.WriteLine("1. Volver a ingresar la cantidad a retirar");
                            Console.WriteLine("2. Volver atrás");
                        }
                        
                        opcion2 = Console.ReadLine();
                        if (opcion2 == "1")
                        {
                            goto D;
                        }
                        else if (opcion2 == "2")
                        {
                            Console.Clear();
                            goto B;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una cantidad válida.");
                        Console.ReadKey();
                        goto D;
                    }
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("Nombre del titular: " + cuenta[0].titular);
                    Console.WriteLine("Saldo: $"+cuenta[0].cantidad);
                    Console.WriteLine("Presione cualquier tecla para volver.");
                    Console.ReadKey();
                    goto B;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Elija una opción válida.");
                    Console.ReadKey();
                    Console.Clear();
                    goto B;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ingrese un nombre válido.");
                Console.ReadKey();
                goto A;
            }
        }
    }
}
