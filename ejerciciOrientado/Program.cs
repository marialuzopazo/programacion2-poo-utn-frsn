using System;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO1Bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 🔧 Crear objeto usando constructor vacío
            Humano h1 = new Humano(); // Valores por defecto: "Garcia", 20, ""

            // 🔧 Crear objeto usando constructor con todos los parámetros
            Humano h2 = new Humano("perez", 50, "av. savio 99");

            // 📝 Modificar manualmente los valores de h1
            h1.apellido = "gomez";
            h1.edad = 50000; // ❌ No se aplicará porque supera el límite (150)
            h1.direccion = "bolivar 222";

            // ✅ Mostrar datos del objeto h1
            Console.WriteLine($"Su apellido es: {h1.apellido}");
            Console.WriteLine($"Su edad es: {h1.edad}"); // Mostrará 20 (valor por defecto, porque 50000 fue ignorado)
            Console.WriteLine($"Su direccion es: {h1.direccion}");

            // ✅ Mostrar datos del objeto h2
            Console.WriteLine($"Su apellido es: {h2.apellido}");
            Console.WriteLine($"Su edad es: {h2.edad}");
            Console.WriteLine($"Su direccion es: {h2.direccion}");

            Console.ReadKey(); // Esperar para que la consola no se cierre automáticamente
        }
    }
}
