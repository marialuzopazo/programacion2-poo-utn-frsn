using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cua = new Cuadrado(color.azul,12,ubicacion.arriba);
            Rectangulo rec = new Rectangulo(color.rojo, 10, 5, ubicacion.derecha);

            Console.WriteLine("***** Datos del Cuadrado *****");
            cua.MostrarDatos();

            Console.WriteLine("***** Datos del Rectangulo *****");
            rec.MostrarDatos();


            Console.ReadKey();
        }
    }
}
