using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            string operador;
            int n1, n2;

            Console.WriteLine("Ingrese el 1er valor:");
            cadena = Console.ReadLine();
            while (int.TryParse(cadena, out n1) == false)
            {
                Console.WriteLine("Intente nuevamente ingresar el 1er valor:");
                cadena = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el 2do valor:");
            cadena = Console.ReadLine();
            while (int.TryParse(cadena, out n2) == false)
            {
                Console.WriteLine("Intente nuevamente ingresar el 2do valor:");
                cadena = Console.ReadLine();
            }

            Console.WriteLine("Ingrese la operacion a realizar (+,-,*,/):");
            operador = Console.ReadLine();
            while (!(operador == "+" || operador == "-" || operador == "*" || operador == "/"))
            {
                Console.WriteLine("Ingrese nuevamente la operacion a realizar (+,-,*,/):");
                operador = Console.ReadLine();
            }

            switch(operador)
            {
                case "+":
                    {
                        Console.WriteLine($"La suma es: {sumar(n1, n2)}");
                        break;                
                    }
                case "-":
                    {
                        Console.WriteLine($"La diferencia es: {restar(n1, n2)}");
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine($"El producto es: {multiplicar(n1, n2)}");
                        break;
                    }
                case "/":
                    {
                        /*
                        if (n2 != 0)
                        {
                            Console.WriteLine($"El cociente es: {n1 / n2}");
                        }
                        else
                        {
                            Console.WriteLine("No es posible dividir por cero.");
                        }
                        */
                        try
                        {
                            Console.WriteLine($"El cociente es: {dividir(n1, n2)}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Se ha presentado un error: {e.Message}");
                            Console.WriteLine($"Fue originado por: {e.Source}");
                            Console.WriteLine($"Recomienda: {e.HelpLink}");
                        }
                        break;
                    }

            }

            Console.ReadKey();
        }

        static int sumar(int a, int b)
        {
            int resultado;
            resultado = a + b;
            return resultado;
        }

        static int restar(int a, int b)
        {
            int resultado;
            resultado = a - b;
            return resultado;
        }

        static int multiplicar(int a, int b)
        {
            int resultado;
            resultado = a * b;
            return resultado;
        }

        static int dividir(int a, int b)
        {
            int resultado;
            if (b != 0)
            {
                resultado = a / b;
                return resultado;
            }
            else
            {
                Exception er = new Exception("Imposible dividir por cero.");
                er.Source = "Funcion de division";
                er.HelpLink = "www.calculos.com";
                throw er;
            }
        }

        /*
        static void sumar(int a, int b)
        {
            Console.WriteLine($"La suma es: {a + b}");
        }

        static void restar(int a, int b)
        {
            Console.WriteLine($"La diferencia es: {a - b}");
        }

        static void multiplicar(int a, int b)
        {
            Console.WriteLine($"El producto es: {a * b}");
        }

        static void dividir(int a, int b)
        {
            try
            {
                Console.WriteLine($"El cociente es: {a / b}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Se ha presentado un error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Operacion de division finalizada");
            }
        }
        */
    }
}
