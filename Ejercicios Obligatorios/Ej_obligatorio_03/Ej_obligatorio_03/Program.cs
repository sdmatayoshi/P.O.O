using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_03
{
    class Password
    {
        public string contraseña = "pepe_elpro82";
        public int longitud = 12;
       

        public Password()
        {
        }
        public Password(int longitud)
        {
            this.longitud = longitud;
        }
        public Password(string contraseña)
        {
            this.contraseña = contraseña;
        }
        public string Contraseña
        {
            get { return contraseña; }
           
        }
        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        public bool esFuerte()
        {
            
            return false;
        }
        public string generarPassword()
        {

            
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Password[] contra = new Password[1];
            contra[0] = new Password("holakheace");  
        }
    }
}
