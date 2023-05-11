using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_obligatorio_04
{
    //public class Electrodomesticos
    //{
    //    public double precio_base_defecto = 100;
    //    public string color_defecto = "blanco";
    //    public char consumo_energetico_defecto = 'F';
    //    public double peso_defecto = 5;

    //    public Electrodomesticos()
    //    {
    //    }
    //    public Electrodomesticos(double precio_base_defecto, double peso_defecto)
    //    {
    //        this.precio_base_defecto = precio_base_defecto;
    //        this.peso_defecto = peso_defecto;
    //    }
    //    public Electrodomesticos(double precio_base_defecto, string color_defecto, char consumo_energetico_defecto, double peso_defecto)
    //    {
    //        this.precio_base_defecto = precio_base_defecto;
    //        this.color_defecto = color_defecto;
    //        this.consumo_energetico_defecto = consumo_energetico_defecto;
    //        this.peso_defecto = peso_defecto;
    //    }
    //    public double precio
    //    {
    //        get
    //        {
    //            return precio_base_defecto;
    //        }
    //    }
    //    public string color
    //    {
    //        get
    //        {
    //            return color_defecto;
    //        }
    //    }
    //    public char consumo_energetico
    //    {
    //        get
    //        {
    //            return consumo_energetico_defecto;
    //        }
    //    }
    //    public double peso
    //    {
    //        get
    //        {
    //            return peso_defecto;
    //        }
    //    }
    //    public comprobarConsumoEnergetico(char val)
    //    {
    //        //int comparison = consumo_energetico.CompareTo(val);

    //        if (val != 'A' || val != 'B' || val != 'C' || val != 'D' || val != 'E' || val != 'F')
    //        {
    //            return consumo_energetico_defecto;
    //        }
    //    }
    //    public comprobarColor(string color)
    //    {
    //        if (color != "blanco" || color != "negro" || color != "rojo" || color != "azul" || color != "gris")
    //        {
    //            return color_defecto;
    //        }
    //    }

    //    public precioFinal(char val, double peso)
    //    {
    //        //int comparison = consumo_energetico.CompareTo(val);

    //        if (val == 'A')
    //        {
    //            if (peso > 0 && peso < 19)
    //            {
    //                return 100 + 10;

    //            }
    //            else if (peso > 20 && peso < 49)
    //            {
    //                return 100 + 50;

    //            }
    //            else if (peso > 50 && peso < 19)
    //            {
    //                return 100 + 80;

    //            }
    //            else if (peso > 80)
    //            {
    //                return 100 + 100;

    //            }
    //        }
    //        else if (val == 'B')
    //        {
    //            if (peso > 0 && peso < 19)
    //            {
    //                return 80 + 10;

    //            }
    //            else if (peso > 20 && peso < 49)
    //            {
    //                return 80 + 50;

    //            }
    //            else if (peso > 50 && peso < 19)
    //            {
    //                return 80 + 80;

    //            }
    //            else if (peso > 80)
    //            {
    //                return 80 + 100;

    //            }
    //        }
    //        else if (val == 'C')
    //        {
    //            if (peso > 0 && peso < 19)
    //            {
    //                return 60 + 10;

    //            }
    //            else if (peso > 20 && peso < 49)
    //            {
    //                return 60 + 50;

    //            }
    //            else if (peso > 50 && peso < 19)
    //            {
    //                return 60 + 80;

    //            }
    //            else if (peso > 80)
    //            {
    //                return 60 + 100;

    //            }
    //        }
    //        else if (val == 'D')
    //        {
    //            if (peso > 0 && peso < 19)
    //            {
    //                return 50 + 10;

    //            }
    //            else if (peso > 20 && peso < 49)
    //            {
    //                return 50 + 50;

    //            }
    //            else if (peso > 50 && peso < 19)
    //            {
    //                return 50 + 80;

    //            }
    //            else if (peso > 80)
    //            {
    //                return 50 + 100;

    //            }
    //        }
    //        else if (val == 'E')
    //        {
    //            if (peso > 0 && peso < 19)
    //            {
    //                return 30 + 10;
    //            }
    //            else if (peso > 20 && peso < 49)
    //            {
    //                return 30 + 50;

    //            }
    //            else if (peso > 50 && peso < 19)
    //            {
    //                return 30 + 80;

    //            }
    //            else if (peso > 80)
    //            {
    //                return 30 + 100;

    //            }

    //        }
    //        else if (val == 'F')
    //        {
    //            if (peso > 0 && peso < 19)
    //            {
    //                return 10 + 10;
    //            }
    //            else if (peso > 20 && peso < 49)
    //            {
    //                return 10 + 50;

    //            }
    //            else if (peso > 50 && peso < 19)
    //            {
    //                return 10 + 80;

    //            }
    //            else if (peso > 80)
    //            {
    //                return 10 + 100;

    //            }

    //        }
    //    }
    //}
    //public class Lavadora : Electrodomesticos
    //{
    //    public double carga = 5;

    //    public Lavadora()
    //    {
    //    }
    //    public Lavadora(double precio_base_defecto, double peso_defecto)
    //    {
    //        this.precio_base_defecto = precio_base_defecto;
    //        this.peso_defecto = peso_defecto;
    //    }
    //    public Lavadora(double precio_base_defecto, string color_defecto, char consumo_energetico_defecto, double peso_defecto, double carga)
    //    {
    //        this.precio_base_defecto = precio_base_defecto;
    //        this.color_defecto = color_defecto;
    //        this.consumo_energetico_defecto = consumo_energetico_defecto;
    //        this.peso_defecto = peso_defecto;
    //        this.carga = carga;
    //    }
    //    public double carga_
    //    {
    //        get
    //        {
    //            return carga;
    //        }
    //    }
    //    public precioFinal(double carga)
    //    {
    //        if (carga > 30)
    //        {
    //            return 50;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //    public precioFinal(double carga)
    //    {
    //        if (carga > 30)
    //        {
    //            return 50;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //}
    //public class Televisión : Electrodomesticos
    //{
    //    public double resolucion = 20;
    //    public bool sintonizador_TDT = false;

    //    public Televisión()
    //    {
    //    }
    //    public Televisión(double precio_base_defecto, double peso_defecto)
    //    {
    //        this.precio_base_defecto = precio_base_defecto;
    //        this.peso_defecto = peso_defecto;
    //    }
    //    public Televisión(double precio_base_defecto, string color_defecto, char consumo_energetico_defecto, double peso_defecto, double resolucion)
    //    {
    //        this.precio_base_defecto = precio_base_defecto;
    //        this.color_defecto = color_defecto;
    //        this.consumo_energetico_defecto = consumo_energetico_defecto;
    //        this.peso_defecto = peso_defecto;
    //        this.resolucion = resolucion;
    //    }
    //    public double resolucion_
    //    {
    //        get
    //        {
    //            return resolucion;
    //        }
    //    }
    //    public bool sintonizador_TDT_
    //    {
    //        get
    //        {
    //            return sintonizador_TDT;
    //        }
    //    }
    //    public precioFinal(double resolucion, bool sintonizador_TDT)
    //    {
    //        if (resolucion > 40)
    //        {
    //            if (sintonizador_TDT == true)
    //            {
    //                return precio_base_defecto / 100 * 30 + 50;
    //            }
    //            else if (sintonizador_TDT == false)
    //            {
    //                return precio_base_defecto / 100 * 30;
    //            }
    //        }
    //        else if (sintonizador_TDT == true)
    //        {
    //            return 50;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //}

    class Electrodomestico
    {
        private float precio_base = 100;
        private string color = "blanco";
        private char consumo_energetico = 'F';
        private float peso = 5;
        public Electrodomestico() { }

        public Electrodomestico(float peso, float precio)
        {
            this.precio_base = precio;
            this.peso = peso;
        }
        public Electrodomestico(float precio, string color, float peso, char consumo_energetico)
        {
            this.precio_base = precio;
            this.peso = peso;
            comprobarConsumoEnergetico(consumo_energetico);
            comprobarColor(color);
        }
        public float Precio_base
        {
            get
            {
                return this.precio_base;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }
        }
        public char Consumo_energetico
        {
            get
            {
                return this.consumo_energetico;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        private void comprobarConsumoEnergetico(char c)
        {
            const string letras_posbles = "ABCDEF";
            if (letras_posbles.Contains(c))
            {
                this.consumo_energetico = c;
            }
            else
            {
                this.consumo_energetico = 'F';
            }
        }
        private void comprobarColor(string s)
        {
            const string colores_posibles = "BLANCONEGROROJOAZULGRIS";
            if (colores_posibles.Contains(s.ToUpper()))
            {
                this.color = s.ToUpper();
            }
            else
            {
                this.color = "BLANCO";
            }
        }
        public float precioFinal()
        {
            float precio = precio_base;
            switch (this.consumo_energetico)
            {
                case 'A':
                    precio_base += 100;
                    break;
                case 'B':
                    precio_base += 80;
                    break;
                case 'C':
                    precio_base += 60;
                    break;
                case 'D':
                    precio_base += 50;
                    break;
                case 'E':
                    precio_base += 30;
                    break;
                case 'F':
                    precio_base += 10;
                    break;
            }
            if (this.peso > 0 && this.peso < 19)
            {
                this.peso += 10;
            }
            else if (this.peso > 20 && this.peso < 49)
            {
                this.peso += 50;
            }
            else if (this.peso > 50 && this.peso < 79)
            {
                this.peso += 80;
            }
            else if (this.peso > 80)
            {
                this.peso += 100;
            }

            return precio;
        }

    }

    class Lavadora : Electrodomestico
    {
        private int carga = 5;
        public Lavadora() { }

        public Lavadora(float peso, float precio) : base(peso, precio) { }
        public Lavadora(float precio, string color, float peso, char consumo_energetico, int carga) : base(peso, color, peso, consumo_energetico)
        {
            this.carga = carga;
        }
        public int Carga
        {
            get
            {
                return this.carga;
            }
        }

        public float precioFinal()
        {
            float precio = base.precioFinal();
            if (this.carga > 30)
            {
                precio += 50;
            }
            return precio;
        }
    }
    class Television : Electrodomestico
    {
        private float resolucion = 20;
        private bool sintonizador = false;

        public Television() : base() { }
        public Television(float peso, float precio) : base(peso, precio) { }

        public Television(float precio, string color, float peso, char consumo_energetico, float resolucion, bool sintonizador) : base(precio, color, peso, consumo_energetico)
        {
            this.sintonizador = sintonizador;
            this.resolucion = resolucion;
        }
        public float Resolucion
        {
            get
            {
                return this.resolucion;
            }
        }
        public bool Sintonizador
        {
            get
            {
                return this.sintonizador;
            }
        }

        public float precioFinal()
        {
            float precio = base.precioFinal();
            if (this.sintonizador)
            {
                precio += 50;
            }
            if (this.resolucion > 40)
            {
                precio *= 1.30F;
            }
            return precio;
        }
    }
    class Ejecutable
    {
        static void Main(string[] args)
        {
            //Electrodomesticos[] electrodomestico = new Electrodomesticos
            //{
            //    (1000,"rojo",'D',50),
            //    (1000,"blanco",'A',50),
            //    (1000,"beige",'C',50),
            //    (1000,"negro",'G',50),
            //    (1000,"azul",'H',50),
            //    (1000,"verde",'S',50),
            //    (1000,"rojo",'C',50),
            //    (1000,"rojo",'E',50),
            //    (1000,"blanco",'E',50),
            //    (1000,"negro",'A',50)
            //}

            //for (int i = 0; i < electrodomestico.Count(); i++)
            //{
            //    Console.WriteLine(PrecioFinal(electrodomestico[i]))
            //}

            Electrodomestico[] electrodomesticos = new Electrodomestico[10];
            electrodomesticos[0] = new Television(10, 15);
            electrodomesticos[1] = new Lavadora(15, 58);
            electrodomesticos[2] = new Television(10, "blanco", 45, 'D', 20, true);
            electrodomesticos[3] = new Lavadora(85, "gris", 32, 'A', 29);
            electrodomesticos[4] = new Lavadora();
            electrodomesticos[5] = new Television();
            electrodomesticos[6] = new Television(15, 65);
            electrodomesticos[7] = new Lavadora(34, 77);
            electrodomesticos[8] = new Lavadora(23, 32);
            electrodomesticos[9] = new Television(98, "rojo", 65, 'B', 47, false);
            int televisores = 0, lavarropas = 0;
            List<Type> lista = new List<Type>();
            foreach (Electrodomestico e in electrodomesticos)
            {
                //e.precioFinal();


                if (e is Television)
                {
                    televisores++;
                }
                if (e is Lavadora)
                {
                    lavarropas++;
                }
            }
            Console.WriteLine("Televisores: {0} \n Lavarropas: {1} \n Electrodomesticos: {2}", televisores, lavarropas, televisores + lavarropas);
           
            foreach (Electrodomestico e in electrodomesticos)
            {
                if (!lista.Contains(e.GetType()))
                {
                    lista.Add(e.GetType());
                }
            }
            Console.WriteLine(lista.Count());
            


                Console.ReadKey();
        }
    }
}