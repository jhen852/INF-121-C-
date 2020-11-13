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
            n = int.Parse(Console.ReadLine());
            V1 = new Vector(n);
            V1.LlenarVector();
            Console.WriteLine("Mostrando el Vector");
            V1.mostrarVector();
            Console.ReadKey();
        }
    }
}
