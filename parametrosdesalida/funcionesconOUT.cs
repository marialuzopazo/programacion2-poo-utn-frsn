using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ✅ Solicitar 3 números al usuario
            // ✅ Validar que sean enteros usando TryParse
            // ✅ Llamar a una función que devuelva el mayor y el menor de los 3
            // ✅ Si hay al menos 2 números iguales, mostrar mensaje especial

            string cadena;  // Para guardar lo que escribe el usuario
            int n1, n2, n3; // Para guardar los tres números

            // 🔢 Ingreso y validación del primer número
            Console.WriteLine("Ingrese el 1er valor:");
            cadena = Console.ReadLine();
            while (int.TryParse(cadena, out n1) == false)
            {
                Console.WriteLine("Intente nuevamente ingresar el 1er valor:");
                cadena = Console.ReadLine();
            }

            // 🔢 Segundo número
            Console.WriteLine("Ingrese el 2do valor:");
            cadena = Console.ReadLine();
            while (int.TryParse(cadena, out n2) == false)
            {
                Console.WriteLine("Intente nuevamente ingresar el 2do valor:");
                cadena = Console.ReadLine();
            }

            // 🔢 Tercer número
            Console.WriteLine("Ingrese el 3er valor:");
            cadena = Console.ReadLine();
            while (int.TryParse(cadena, out n3) == false)
            {
                Console.WriteLine("Intente nuevamente ingresar el 3er valor:");
                cadena = Console.ReadLine();
            }

            // 📦 Variables para guardar el mayor y el menor
            int May, Men;

            // 🔍 Llamada a la función que determina mayor y menor
            if (mayormenor3(n1, n2, n3, out May, out Men) == true)
            {
                // ✅ Si son todos distintos, mostrar mayor y menor
                Console.WriteLine($"El mayor es: {May}");
                Console.WriteLine($"El menor es: {Men}");
            }
            else
            {
                // ❌ Si hay al menos dos números iguales
                Console.WriteLine($"Los números ingresados eran iguales");
            }

            Console.ReadKey(); // Espera que el usuario presione una tecla antes de cerrar
        }

        // 🔧 Función que compara dos números y devuelve el mayor
        static bool mayor(int a, int b, out int masGrande)
        {
            if (a == b)
            {
                masGrande = 0;
                return false; // ❌ Son iguales
            }
            else
            {
                // ✅ Se devuelve el mayor entre los dos
                masGrande = (a > b) ? a : b;
                return true;
            }
        }

        // 🔧 Función que compara tres números y devuelve el mayor y el menor
        static bool mayormenor3(int a, int b, int c, out int masGrande, out int masChico)
        {
            // ❌ Si hay al menos dos números iguales, se devuelve false
            if (a == b || a == c || b == c)
            {
                masGrande = 0;
                masChico = 0;
                return false;
            }
            else
            {
                // ✅ Comparación lógica para encontrar el mayor y el menor

                if (a > b)
                {
                    if (a > c)
                    {
                        masGrande = a;
                        masChico = (b < c) ? b : c;
                    }
                    else
                    {
                        masGrande = c;
                        masChico = b;
                    }
                }
                else
                {
                    if (b > c)
                    {
                        masGrande = b;
                        masChico = (a < c) ? a : c;
                    }
                    else
                    {
                        masGrande = c;
                        masChico = a;
                    }
                }

                return true; // ✅ Son los tres distintos
            }
        }

        // 🔧 Función que compara dos números y devuelve el mayor y el menor
        static bool mayormenor(int a, int b, out int masGrande, out int masChico)
        {
            if (a == b)
            {
                masGrande = 0;
                masChico = 0;
                return false; // ❌ Son iguales
            }
            else
            {
                // ✅ Se devuelven ambos valores: mayor y menor
                if (a > b)
                {
                    masGrande = a;
                    masChico = b;
                }
                else
                {
                    masGrande = b;
                    masChico = a;
                }
                return true;
            }
        }
    }
}

