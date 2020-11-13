using System;

namespace Guia_de_Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado E1 = new Empleado();
            E1.mostrar();
            //poner esa linea de codigo para que pueda correr con total normalidad 
            Console.ReadKey(); // para hacer una pausa
        }
    }
}
