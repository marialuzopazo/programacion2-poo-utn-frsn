using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    internal class Program
    {
        /*
         🧠 OBJETIVO:
         - Crear procedimientos que:
            1. Cambien el contenido de una variable (por referencia)
            2. Intercambien dos valores
            3. Ordenen un arreglo (vector) de números enteros
        */

        static void Main(string[] args)
        {
            string apel, nom1, nom2;

            // -----------------------------------------
            // 🧪 1. PRUEBA DE CAMBIAR UNA VARIABLE POR REFERENCIA
            /*
            apel = "Gomez";
            cambiar(ref apel);  // Llama al procedimiento y le pasa la variable 'apel' por referencia
            Console.WriteLine($"Luego del proc: {apel}"); // Debería mostrar "Perez"
            */

            // -----------------------------------------
            // 🧪 2. PRUEBA DE INTERCAMBIO DE DOS VARIABLES POR REFERENCIA
            /*
            nom1 = "perez";
            nom2 = "gomez";
            intercambiar(ref nom1, ref nom2);  // Intercambia sus valores usando una variable auxiliar
            Console.WriteLine($"Nom1: {nom1}"); // Debería mostrar "gomez"
            Console.WriteLine($"Nom2: {nom2}"); // Debería mostrar "perez"
            */

            // -----------------------------------------
            // 🧪 3. ORDENAR UN VECTOR DE ENTEROS DE MAYOR A MENOR

            int[] vec = new int[3]; // Crear vector con 3 posiciones
            vec[0] = 15;
            vec[1] = 17;
            vec[2] = 12;

            // Llama al procedimiento de ordenamiento
            ordenar(vec);

            // Muestra los valores ordenados del vector
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine(vec[i]);
            }

            Console.ReadKey(); // Espera que el usuario presione una tecla antes de cerrar
        }

        // 🧩 Procedimiento que modifica una variable string pasada por referencia
        static void cambiar(ref string a)
        {
            Console.WriteLine($"Dentro del proc y ANTES del cambio: {a}");
            a = "Perez"; // Cambia el contenido de la variable
            Console.WriteLine($"Dentro del proc y DESPUES del cambio: {a}");
        }

        // 🔁 Procedimiento que intercambia dos strings usando una variable auxiliar
        static void intercambiar(ref string a, ref string b)
        {
            string aux;
            aux = a;
            a = b;
            b = aux;
        }

        // 📊 Procedimiento que ordena un vector de enteros de mayor a menor
        static void ordenar(int[] pila)
        {
            int aux;
            // Método de ordenamiento tipo burbuja (simple)
            for (int i = 0; i < pila.Length - 1; i++)
            {
                for (int j = i + 1; j < pila.Length; j++)
                {
                    // Si el elemento actual es menor que el siguiente, los intercambia
                    if (pila[i] < pila[j])
                    {
                        aux = pila[i];
                        pila[i] = pila[j];
                        pila[j] = aux;
                    }
                }
            }
        }
    }
}