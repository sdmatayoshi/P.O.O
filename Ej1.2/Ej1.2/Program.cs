using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int maxnums = 201;
            List<string> numeros = new List<string>();
            for (int i = 1; i < maxnums; i++) {
                numeros.Add(i.ToString());
                Console.Write(" " + numeros[i-1] +" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("1. Insertar 0 antes del 10.");
            Console.WriteLine("2. Insertar 0 despues del 10.");
            Console.WriteLine("3. Insertar 0 antes y despues del 10.");
            Console.WriteLine("4. Eliminar primer y último elemento de la lista");
            Console.WriteLine("5. Eliminar segundo y anteúltimo elemento de la lista");
            opcion = Console.ReadLine();
            if(opcion == "1")
            {
                Console.Clear();
                for (int i = 1; i < maxnums; i++)
                {
                    if (numeros[i-1].EndsWith("10")) { 
                    Console.Write(" "+ "0" + " ");
                    }
                    Console.Write(" " + numeros[i - 1] + " ");
                }
            }else if (opcion == "2")
            {
                Console.Clear();
                for (int i = 1; i < maxnums; i++)
                {
                    Console.Write(" " + numeros[i - 1] + " ");
                    if (numeros[i - 1].EndsWith("10"))
                    {
                        Console.Write(" " + "0" + " ");
                    }
                }
            }
            else if (opcion == "3")
            {
                Console.Clear();
                for (int i = 1; i < maxnums; i++)
                {
                    if (numeros[i - 1].EndsWith("10"))
                    {
                        Console.Write(" " + "0" + " ");
                    }
                    Console.Write(" " + numeros[i - 1] + " ");
                    if (numeros[i - 1].EndsWith("10"))
                    {
                        Console.Write(" " + "0" + " ");
                    }
                }
            }
            else if (opcion == "4")
            {
                Console.Clear();
                numeros.RemoveAt(maxnums-2);
                numeros.RemoveAt(0);
                
                for (int i = 1; i < maxnums-2; i++)
                {
                    Console.Write(" " + numeros[i - 1] + " ");
                }
            }
            else if (opcion == "5")
            {
                Console.Clear();
                numeros.RemoveAt(maxnums - 3);
                numeros.RemoveAt(1);

                for (int i = 1; i < maxnums - 2; i++)
                {
                    Console.Write(" " + numeros[i - 1] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
