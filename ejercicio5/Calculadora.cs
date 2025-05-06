using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPOO5
{
    public enum tipoOper
    {
        diferencia,
        cociente,
        producto,
        suma
        }
    internal class Calculadora
    {
        public string marca { get; set; }
        public int valor1 { get; set; }
        public int valor2 { get; set; }

        public void calcular (tipoOper operacion) {
            matematica procesar = new matematica ();
            switch (operacion)
            {
                case tipoOper.diferencia:
                {
                        Console.WriteLine($"El resultado es: {procesar.restar(this.valor1, this.valor2)}");
                        break;
                    }
                case tipoOper.producto:
                    {
                        Console.WriteLine($"El resultado es: {procesar.multiplicar(this.valor1, this.valor2)}");
                        break;
                    }
                case tipoOper.suma:
                    {
                        Console.WriteLine($"El resultado es: {procesar.sumar(this.valor1, this.valor2)}");
                        break;
                    }

                case tipoOper.cociente:
                    {
                        Console.WriteLine($"El resultado es: {procesar.dividir(this.valor1, this.valor2)}");
                        break;
                    }
            }
        }
    }
}
