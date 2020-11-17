using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Vector
    {
        private int [] V;
        private int n;

        //Crear Constructores
        public Vector(int n) {
            this.n = n;
            V = new int[this.n + 1];
            //aqui  porque estoy sumando un uno porque creo que vamos a empezar nuestro for desde 1
        }

        public void LlenarVector() {
            Console.WriteLine("Introduzca {0} numeros ", n);
            for (int i = 1; i <= n; i++) {
                Console.Write("V["+i+"] = ");
                V[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public void mostrarVector() {
            Console.Write("\tV[");
            for (int i = 1; i <n; i++) 
                Console.Write(+V[i] + ",");
            Console.Write(V[n]+" ]");

        }

        //hacer la suma de de los elementos del vector
        public int SumaDeElementos() {
            int suma = 0;
            for (int i = 1; i <= n; i++) 
                suma = suma + V[i];
            
            return suma;
        }

        // metodo de ordenamiento BURBUJA

        public void OrdenarVector() {
            int i, j;
            Console.WriteLine("\nOrdenar el Vector");
            //Metodo de ordenacion Burbuja
            for (i = 1; i < n; i++) {
                for (j = i + 1; j <= n; j++) {
                    //y aqui vamos a preguntar cual es el mayor

                    if (V[i] > V[j]) {
                        V[i] = V[i] + V[j];
                        V[j] = V[i] - V[j];
                        V[i] = V[i] - V[j];
                    }
                }
            }
        }
       




    }
}
