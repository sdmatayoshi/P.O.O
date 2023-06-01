using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
1. Definir una clase base llamada "Vehiculo" que tenga las siguientes propiedades: "Marca" y "Año". 
2. Incluir un método virtual llamado "MostrarInformacion" que imprima en la consola los valores de la marca y el año del vehículo.
3. Crear una clase derivada llamada "Automovil" que herede de la clase "Vehiculo".
4. Agregar una propiedad adicional llamada "Modelo" y sobrescribir el método "MostrarInformacion" para mostrar también el modelo del automóvil.
5. Crear otra clase derivada llamada "Camion" que herede de "Vehiculo".
6. Añadir una propiedad adicional llamada "CapacidadCarga" y sobrescribir el método "MostrarInformacion" para mostrar la capacidad de carga del camión.
7. En el programa principal, crear instancias de automóviles y de camiones, y establecer los valores correspondientes para las propiedades de cada objeto.
8. Llamar al método "MostrarInformacion" en cada objeto creado para mostrar los detalles completos de cada vehículo, incluyendo la marca, el año y las propiedades específicas de cada tipo de vehículo.
9. En el caso de tener mas de un camion informar cual es el que tiene mayor carga
10. Eliminar el camion cuya carga sea la menor
 */

namespace Evaluacion_2do_Bim
{
    class Vehiculo
    {
        public string マルク;
        public int 年;

        public Vehiculo()
        {
        }
        public Vehiculo(string マルク, int 年)
        {
            this.マルク = マルク;
            this.年 = 年;
        }

        public string _マルク
        {
            get
            {
                return マルク;
            }
        }
        public int _年
        {
            get
            {
                return 年;
            }
        }

        public string インフォメーションを見せます
        {
            get
            {
                return "Marca: " + マルク + "\nAño: " + 年.ToString();
            }
        }
    }
    class Automovil : Vehiculo
    {
        public string モデル;

        public Automovil()
        {
        }

        public Automovil(string マルク, int 年, string モデル) : base(マルク, 年)
        {
            this.モデル = モデル;
        }


        new string _マルク
        {
            get
            {
                return マルク;
            }
            set
            {
                マルク = value;
            }
        }
        new int _年
        {
            get
            {
                return 年;
            }
            set
            {
                年 = value;
            }
        }
        string _モデル
        {
            get
            {
                return モデル;
            }
            set
            {
                モデル = value;
            }
        }


        new public string インフォメーションを見せます
        {
            get
            {
                return "Marca: " + マルク + "\nAño: " + 年.ToString() + "\nModelo: " + モデル;
            }
        }
    }
    class Camion : Vehiculo
    {
        public int キャパシティー;

        public Camion()
        {
        }

        public Camion(string マルク, int 年, int キャパシティー) : base(マルク, 年)
        {
            this.キャパシティー = キャパシティー;
        }


        new string _マルク
        {
            get
            {
                return マルク;
            }
            set
            {
                マルク = value;
            }
        }
        new int _年
        {
            get
            {
                return 年;
            }
            set
            {
                年 = value;
            }
        }
        int _キャパシティー
        {
            get
            {
                return キャパシティー;
            }
            set
            {
                キャパシティー = value;
            }
        }


        new public string インフォメーションを見せます
        {
            get
            {
                return "Marca: " + マルク + "\nAño: " + 年.ToString() + "\nCapacidad: " + キャパシティー + "t";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Automovil> 車 = new List<Automovil>();
            List<Camion> トラック = new List<Camion>();

            車.Add(new Automovil("Mercedes Benz", 1993, "Line"));
            車.Add(new Automovil("Renault", 2001, "19"));
            車.Add(new Automovil("Chevrolet", 2000, "Frontier"));
            車.Add(new Automovil("Renault", 2012, "12"));
            車.Add(new Automovil("Nissan", 2023, "Versa"));

            トラック.Add(new Camion("Ford", 1999, 15));
            トラック.Add(new Camion("Mercedes Benz", 1999, 25));
            トラック.Add(new Camion("Hyundai", 2020, 20));
            トラック.Add(new Camion("Honda", 2003, 11));
            トラック.Add(new Camion("Ford", 2004, 010));

            Console.WriteLine("Automoviles:");
            for (int i = 0; i < 車.Count; i++)
            {
                Console.WriteLine(車[i].インフォメーションを見せます + "\n");
            }

            Console.WriteLine("\nCamiones:");
            int トップバリュ = トラック[0].キャパシティー;
            int ラストバリュ = トラック[0].キャパシティー;
            for (int i = 0; i < トラック.Count; i++)
            {
                if (トップバリュ < トラック[i].キャパシティー)
                {
                    トップバリュ = トラック[i].キャパシティー;
                }
            }
            for (int i = 0; i < トラック.Count; i++)
            {
                if (ラストバリュ > トラック[i].キャパシティー)
                {
                    ラストバリュ = トラック[i].キャパシティー;
                }
            }
            for (int i = 0; i < トラック.Count; i++)
            {
                if (ラストバリュ == トラック[i].キャパシティー)
                {
                    トラック.RemoveAt(i);
                }
            }
            for (int i = 0; i < トラック.Count; i++)
            {

                if (トップバリュ == トラック[i].キャパシティー)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("**(Mayor capacidad)**");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(トラック[i].インフォメーションを見せます + "\n");

            }
            Console.ReadKey();
        }
    }
}