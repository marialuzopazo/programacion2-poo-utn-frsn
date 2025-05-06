using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carpeta micar = new Carpeta("Matematica", false, color.negro);

            micar.etiqueta.apelNom = "Cecchi, David";
            micar.etiqueta.salon = "Labo 2";

            Console.WriteLine($"Materia: {micar.materia}");
            Console.WriteLine($"Apellido y Nombre: {micar.etiqueta.apelNom}");
            Console.WriteLine($"Aula: {micar.etiqueta.salon}");


            Console.ReadKey();
        }
    }
}
