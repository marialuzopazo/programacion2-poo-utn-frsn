using System; // Importa funcionalidades básicas como Console
using System.Collections.Generic; // No se usa en este código
using System.Linq; // No se usa en este código
using System.Text; // No se usa en este código
using System.Threading.Tasks; // No se usa en este código

namespace Ejer3a // Define un espacio de nombres llamado Ejer3a
{
    internal class Program // Clase principal del programa
    {
        static void Main(string[] args) // Método principal donde inicia el programa
        {
            string nom, ape; // Declara dos variables tipo string: nom (nombre), ape (apellido)

            Console.WriteLine("Ingrese su nombre:"); // Pide al usuario que ingrese su nombre
            nom = Console.ReadLine(); // Guarda el nombre ingresado por el usuario

            Console.WriteLine("Ingrese su apellido:"); // Pide el apellido
            ape = Console.ReadLine(); // Guarda el apellido

            Console.WriteLine("****** UN PROCEDIMIENTO");
            formatear(nom, ape); // Llama a un procedimiento que muestra nombre y apellido formateado

            Console.WriteLine("****** UNA FUNCION");
            Console.WriteLine($"Adios {textoFormateado(nom, ape)}"); // Llama a una función que retorna el texto formateado y lo imprime

            string an; // Declara variable para guardar el resultado con `out`
            Console.WriteLine("****** UN PROCEDIMIENTO CON PARAMETRO DE SALIDA");
            formatearPlus(nom, ape, out an); // Llama a un procedimiento que asigna valor a 'an'
            Console.WriteLine($"Saludos {an}"); // Muestra el valor que se generó con `out`

            string buenas, chau; // Declara dos variables para usar como `out`
            Console.WriteLine("****** UN PROCEDIMIENTO CON 2 PARAMETROS DE SALIDA");
            formatearPlusPlus(nom, ape, out buenas, out chau); // Llama a un procedimiento con dos salidas
            Console.WriteLine($"{buenas}"); // Imprime saludo
            Console.WriteLine($"{chau}"); // Imprime despedida

            Console.WriteLine("****** UNA FUNCION CON 1 PARAMETRO DE SALIDA");
            if (textoFormateadoPlus(nom, ape, out an)) // Llama a una función que verifica si los datos están completos y devuelve un `bool`
            {
                Console.WriteLine($"Su apelnom es: {an}"); // Si está todo bien, muestra el texto formateado
            }
            else
            {
                Console.WriteLine("Apellido y/o el Nombre, no han sido completados"); // Si hay datos vacíos, muestra mensaje de error
            }

            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar
        }

        static void formatear(string n, string a) // Procedimiento (void) que muestra el nombre formateado
        {
            string apelnom = a + ", " + n; // Concatena apellido y nombre
            Console.WriteLine($"formateado es: {apelnom}"); // Muestra el resultado
        }

        static string textoFormateado(string n, string a) // Función que devuelve el texto formateado
        {
            string apelnom = a + ", " + n; // Concatena apellido y nombre
            return apelnom; // Devuelve el resultado
        }

        static void formatearPlus(string n, string a, out string apelnom) // Procedimiento con parámetro de salida
        {
            apelnom = a + ", " + n; // Asigna valor al parámetro de salida
        }

        static void formatearPlusPlus(string n, string a, out string hola, out string adios) // Procedimiento con 2 parámetros de salida
        {
            string apelnom = a + ", " + n; // Formatea el texto
            hola = $"Buenas tardes: {apelnom}"; // Asigna saludo
            adios = $"Saludos: {apelnom}"; // Asigna despedida
        }

        static bool textoFormateadoPlus(string n, string a, out string apelnom) // Función con verificación y salida
        {
            if (a == string.Empty || n == string.Empty) // Verifica si alguno de los campos está vacío
            {
                apelnom = string.Empty; // Devuelve vacío si hay error
                return false; // Retorna falso si faltan datos
            }
            else
            {
                apelnom = a + ", " + n; // Formatea si todo está bien
                return true; // Retorna true si está todo correcto
            }
        }

    }
}

