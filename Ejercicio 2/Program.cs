using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vector");
            int n, suma;
            Vector V1;

            Console.WriteLine("Tamaño del Vector ");
            n = int.Parse(Console.ReadLine());
            V1 = new Vector(n);
            V1.LlenarVector();
            Console.WriteLine("Mostrando el Vector");
            V1.mostrarVector();
            V1.OrdenarVector();
            V1.mostrarVector();
            suma = V1.SumaDeElementos();
            Console.WriteLine("\nLa suma es "+suma);
            Console.ReadKey();
        }
    }
}
