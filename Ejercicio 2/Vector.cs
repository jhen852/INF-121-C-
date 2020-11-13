using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Vector
    {
        //Atributos del vector 
        //para declarar un vector tenemos que poner los corchetes delante de la variable del vector
        private int[] v;
        // n sera la variable que determine hasta donde ira nuestro vector
        private int n;

        //constructor
        public Vector(int n) {
            this.n = n;
            v = new int[this.n + 1];
            // new int 
        }

        public void LlenarVector() {
            Console.WriteLine("Introduzca {0} numeros :", n);
            for (int i = 1; i <= n; i++) {
                Console.Write("\tV[" + i + "]=");
                v[i] = int.Parse(Console.ReadLine());
            }
        }

        public void mostrarVector() {
            //declarar variable i 
            int i;
            Console.Write("V[");
            for (i = 1; i < n; i++) 
                Console.Write(v[i] + ",");
            Console.WriteLine(v[n] + "]");



        }
        


    }
}
