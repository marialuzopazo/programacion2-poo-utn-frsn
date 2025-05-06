using System;                          // Importa funcionalidades básicas (entrada/salida, etc.)
using System.Collections.Generic;     // Importa estructuras de datos genéricas (no se usa aquí)
using System.Linq;                    // Importa funciones LINQ (no se usa aquí)
using System.Text;                    // Importa funciones de texto (no se usa aquí)
using System.Threading.Tasks;        // Importa funciones para programación asincrónica (no se usa aquí)

namespace Ejer2                      // Define un espacio de nombres llamado Ejer2
{
    internal class Program           // Clase principal del programa
    {
        static void Main(string[] args)  // Método principal, punto de entrada del programa
        {
            string cadena;              // Variable para guardar entrada como texto
            string operador;            // Variable para guardar el operador matemático
            int n1, n2;                 // Variables para guardar los números ingresados

            Console.WriteLine("Ingrese el 1er valor:");    // Pide al usuario el primer número
            cadena = Console.ReadLine();                   // Lee la entrada del usuario como string
            while (int.TryParse(cadena, out n1) == false)  // Valida si la entrada es un número
            {
                Console.WriteLine("Intente nuevamente ingresar el 1er valor:"); // Pide reintento
                cadena = Console.ReadLine();                                     // Lee de nuevo
            }

            Console.WriteLine("Ingrese el 2do valor:");     // Pide el segundo número
            cadena = Console.ReadLine();                    // Lee la entrada
            while (int.TryParse(cadena, out n2) == false)   // Valida si es un número
            {
                Console.WriteLine("Intente nuevamente ingresar el 2do valor:"); // Reintento
                cadena = Console.ReadLine();                                    // Lee de nuevo
            }

            Console.WriteLine("Ingrese la operacion a realizar (+,-,*,/):");  // Pide operador
            operador = Console.ReadLine();                                    // Lee el operador
            while (!(operador == "+" || operador == "-" || operador == "*" || operador == "/")) // Valida operador
            {
                Console.WriteLine("Ingrese nuevamente la operacion a realizar (+,-,*,/):"); // Reintento
                operador = Console.ReadLine();                                              // Lee de nuevo
            }

            switch (operador)     // Ejecuta operación según el operador ingresado
            {
                case "+":       // Si es suma
                    {
                        Console.WriteLine($"La suma es: {sumar(n1, n2)}"); // Llama a sumar()
                        break;
                    }
                case "-":       // Si es resta
                    {
                        Console.WriteLine($"La diferencia es: {restar(n1, n2)}"); // Llama a restar()
                        break;
                    }
                case "*":       // Si es multiplicación
                    {
                        Console.WriteLine($"El producto es: {multiplicar(n1, n2)}"); // Llama a multiplicar()
                        break;
                    }
                case "/":       // Si es división
                    {
                        try // Intenta ejecutar el bloque
                        {
                            Console.WriteLine($"El cociente es: {dividir(n1, n2)}"); // Llama a dividir()
                        }
                        catch (Exception e) // Si ocurre error (como división por cero)
                        {
                            Console.WriteLine($"Se ha presentado un error: {e.Message}");    // Muestra mensaje
                            Console.WriteLine($"Fue originado por: {e.Source}");              // Muestra fuente
                            Console.WriteLine($"Recomienda: {e.HelpLink}");                   // Muestra ayuda
                        }
                        break;
                    }
            }

            Console.ReadKey(); // Espera que se presione una tecla antes de cerrar
        }

        static int sumar(int a, int b) // Función que suma dos enteros
        {
            int resultado;
            resultado = a + b;
            return resultado; // Retorna la suma
        }

        static int restar(int a, int b) // Función que resta dos enteros
        {
            int resultado;
            resultado = a - b;
            return resultado; // Retorna la diferencia
        }

        static int multiplicar(int a, int b) // Función que multiplica dos enteros
        {
            int resultado;
            resultado = a * b;
            return resultado; // Retorna el producto
        }

        static int dividir(int a, int b) // Función que divide dos enteros
        {
            int resultado;
            if (b != 0) // Si el divisor no es cero
            {
                resultado = a / b;
                return resultado; // Retorna el cociente
            }
            else
            {
                Exception er = new Exception("Imposible dividir por cero."); // Crea excepción personalizada
                er.Source = "Funcion de division";                          // Define el origen del error
                er.HelpLink = "www.calculos.com";                           // Define un enlace de ayuda
                throw er; // Lanza la excepción para que sea capturada
            }
        }
    }
}

