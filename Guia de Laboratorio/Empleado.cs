using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_de_Laboratorio
{
    class Empleado
    {
        private String nombre;
        private int antiguedad;
        // No tenemos que poder void a un constructor porque no es metodo
        public Empleado() {
            nombre = "Jhenny";
            antiguedad = 5;
        }
        public void mostrar() {
            Console.WriteLine("\nNombre : "+nombre+
                "\nAntiguedad : "+antiguedad);
        }
    }
}
