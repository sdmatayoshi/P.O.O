using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_medina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///varibel
            int recta; 
            recta = 5;

            int colum;
            colum = 2 ;

            string[,] datos;
            datos =new string[recta, colum];
            datos[0, 0] = "toby";
            datos[1, 0] = "ppepe";
            datos[2, 0] = "tedy";
            datos[3, 0] = "firulais";
            datos[4, 0] = "michi";
            datos[0, 1] = "12";
            datos[1, 1] = "5";
            datos[2, 1] = "10";
            datos[3, 1] = "9";
            datos[4, 1] = "14";

            for (int i = 0; i < recta; i++)
            {
                Console.WriteLine("la mascota {0} se llama {1} y pesa {2}k", i + 1, datos[i, 0], datos[i, 1]);
            }
                
        }
       
    }
}
