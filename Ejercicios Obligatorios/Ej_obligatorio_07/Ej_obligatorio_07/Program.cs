using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_07
{
    class Raíces
    {
        int a;
        int b;
        int c;

        public Raíces()
        {
        }

        public Raíces(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string obtenerRaíces()
        {
            double x1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / 2 * a));
            double x2 = ((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / 2 * a));
            return ("Raíz 1 = "+x1.ToString()+" | Raíz 2 = "+x2.ToString());
        }
        public string obtenerRaíz()
        {
            double x = 0;
            double x1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))/2*a));
            double x2 = ((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))/2*a));
            if (x1.ToString()=="NaN" && x2.ToString() != "NaN")
            {
                x = x2;
            }
            else if (x2.ToString() == "NaN" && x1.ToString() != "NaN")
            {
                x = x1;
            }
            return ("Raíz = " + x.ToString());
        }
        public string getDiscriminante()
        {
            double disc = (Math.Pow(b,2)-(4*a*c));
            return ("Discriminante: "+disc.ToString());
        }
        public bool tieneRaíces()
        {
            bool ans = true;
            double x1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / 2 * a));
            double x2 = ((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / 2 * a));
            if (x1.ToString() == "NaN" && x2.ToString() == "NaN")
            {
                ans = false;
            }
            else
            {
                ans = true;
            }
            return ans;
        }
        public bool tieneRaíz()
        {
            bool ans = false;
            double x1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / 2 * a));
            double x2 = ((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c)) / 2 * a));
            if ((x1.ToString() == "NaN" && x2.ToString() != "NaN")|| (x1.ToString() != "NaN" && x2.ToString() == "NaN"))
            {
                ans = true;
            }else
            {
                ans = false;
            }
            return ans;
        }
        public string calcular()
        {
            return "EN PROCESO";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Raíces[] result = new Raíces[1];
            Console.Write("Escribe e valor del coeficiente a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Escribe e valor del coeficiente b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Escribe e valor del coeficiente c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            result[0] = new Raíces(a,b,c);
            Console.Clear();
            Console.WriteLine("Elija la operación a realizar:");
            Console.WriteLine("1. Obtener 2 raíces");
            Console.WriteLine("2. Obtener 1 raíz");
            Console.WriteLine("3. Obtener discriminante");
            Console.WriteLine("4. Verificar si existen 2 raices");
            Console.WriteLine("5. Verificar si existe una raíz");
            Console.WriteLine("6. Mostrar posibles soluciones");
            string opcion = (Console.ReadLine());
            if (opcion == "1")
            {
                Console.Clear();
                Console.Write(result[0].obtenerRaíces());
            }
            else if (opcion == "2")
            {
                Console.Clear();
                Console.Write(result[0].obtenerRaíz());
            }
            else if (opcion == "3")
            {
                Console.Clear();
                Console.Write(result[0].getDiscriminante());
            }
            else if (opcion == "4")
            {
                Console.Clear();
                bool ans =result[0].tieneRaíces();
                if (ans)
                {
                    Console.Write("La ecuación tiene 2 raíces");
                }
                else
                {
                    Console.Write("La ecuación no tiene raíces o solo existe una");
                }
            }
            else if (opcion == "5")
            {
                Console.Clear();
                bool ans = result[0].tieneRaíz();
                if (ans)
                {
                    Console.Write("La ecuación tiene una raíz");
                }
                else
                {
                    Console.Write("La ecuación no tiene raíces o existen más de una solución");
                }
            }
            else if (opcion == "6")
            {
                Console.Clear();
                Console.Write(result[0].calcular());
            }
            Console.ReadKey();
        }
    }
}
