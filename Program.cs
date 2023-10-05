using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7_ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año = 1900;
            int añoActual = 2023;

            Console.WriteLine("Años bisiestos desde 1900 hasta la actualidad");
            while (año <= añoActual)
            {
                if ((año % 4 == 0 && (año % 100 != 0 || año % 400 == 0)) || año == 1900)
                {
                    Console.WriteLine(año);
                }
                año++;
            }
            Console.ReadKey();
        }
    }
}   