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
            // Mostramos un título en consola
            Console.WriteLine("**** Lista de objetos de diferentes clases");

            // Creamos una lista de objetos de tipo figura (la clase base)
            List<figura> lista = new List<figura>();

            // Agregamos distintos objetos a la lista (rectángulos y cuadrados)
            // Usamos polimorfismo: aunque la lista es de "figura", puede almacenar "Rectangulo" y "Cuadrado"
            lista.Add(new Rectangulo(color.rojo, 10, 5, ubicacion.derecha));
            lista.Add(new Rectangulo(color.blanco, 7, 15, ubicacion.centro));
            lista.Add(new Rectangulo(color.azul, 3, 2, ubicacion.izquierda));
            lista.Add(new Rectangulo(color.azul, 8, 4, ubicacion.derecha));
            lista.Add(new Cuadrado(color.rojo, 10, ubicacion.derecha));
            lista.Add(new Cuadrado(color.blanco, 7, ubicacion.centro));

            // Recorremos la lista y mostramos el perímetro y superficie de cada figura
            foreach (figura fig in lista)
            {
                Console.WriteLine($"Perimetro: {fig.perimetro} Superf: {fig.superficie}");
            }

            // Pausa para que no se cierre la consola
            Console.ReadKey();
        }
    }
}
