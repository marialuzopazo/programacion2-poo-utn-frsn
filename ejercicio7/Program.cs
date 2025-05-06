using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lista o colecciones
            Console.WriteLine("**** Lista de objetos de diferentes clases");
            List<figura> lista = new List<figura>();
            lista.Add(new Rectangulo(color.rojo, 10, 5, ubicacion.derecha));
            lista.Add(new Rectangulo(color.blanco, 7, 15, ubicacion.centro));
            lista.Add(new Rectangulo(color.azul, 3, 2, ubicacion.izquierda));
            lista.Add(new Rectangulo(color.azul, 8, 4, ubicacion.derecha));
            lista.Add(new Cuadrado(color.rojo, 10, ubicacion.derecha));
            lista.Add(new Cuadrado(color.blanco, 7, ubicacion.centro));

            foreach (figura fig in lista)
            {
                Console.WriteLine($"Perimetro: {fig.perimetro} Superf: {fig.superficie}");
            }

            Console.ReadKey();
        }
    }
}
