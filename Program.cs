using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_pares_y_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fin;

            Console.WriteLine("ingrese el numero inicial del rango ");
            inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero final del rango");
            fin = int.Parse(Console.ReadLine());

            Console.WriteLine("numeros pares dentro del rango");
            for (int i = inicio; i <= fin; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("numeros impares dentro del rango");
            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
