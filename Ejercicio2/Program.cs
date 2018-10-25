using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese tamaño del arreglo");
            int largo = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[largo, largo];
            for (int i = 0; i < largo; i++)
            {
                for (int u = largo - 1; u > -1; u--)
                {
                    if ((i - u) < 0)
                    {
                        array[i, u] = " ";
                        Console.Write(array[i, u]);
                    }
                    else { Console.Write("#"); }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        
    }
}
