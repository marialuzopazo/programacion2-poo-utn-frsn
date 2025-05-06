using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO1Bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano h1; //declarando
            h1 = new Humano(); //instanciando

            Humano h2 = new Humano("perez",50,"av. savio 99");   
           
            h1.apellido = "gomez";
            h1.edad = 50000;
            h1.direccion = "bolivar 222";
            
            Console.WriteLine($"Su apellido es: {h1.apellido}");
            Console.WriteLine($"Su edad es: {h1.edad}");
            Console.WriteLine($"Su direccion es: {h1.direccion}");

            Console.WriteLine($"Su apellido es: {h2.apellido}");
            Console.WriteLine($"Su edad es: {h2.edad}");
            Console.WriteLine($"Su direccion es: {h2.direccion}");

            Console.ReadKey();
        }
    }
}
