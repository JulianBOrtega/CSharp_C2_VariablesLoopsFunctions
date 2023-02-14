using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIVA
{
    class Program
    {
        /* 
            Consigna:
            ---------------------
            Crea un programa que calcule el IVA de un producto. 
            El valor de este producto se pasará por teclado y nos 
            mostrará por pantalla el valor del IVA y su valor final. 
            El IVA es el 21 %. Por ejemplo, si introducimos 100 como 
            valor de producto, el IVA es 21 y el valor final es 121.
        */

        static void Main(string[] args)
        {
            float valor = ValidarEntrada(MostrarMensaje("Por favor introduzca el valor del producto."));
            const float IVA = 21;

            MostrarMensaje("Con un IVA del " + IVA + "% y un producto con el valor de $" 
                + valor + ", el valor total es de: $" + (valor + (valor / 100 * IVA)) );
        }

        static string MostrarMensaje(string mensaje)
        {
            Console.Clear();

            Console.WriteLine("/////////////// TP2 - Ejercicio 1: Calculo de IVA - Julián B. Ortega ///////////////");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(mensaje);
            Console.WriteLine();
            Console.WriteLine("------------------------- ");

            return Console.ReadLine();
        }

        static float ValidarEntrada(string input)
        {
            bool exito = false;

            if(!float.TryParse(input, out float resultado))
            {
                do
                {
                    input = MostrarMensaje("Entrada inválida. Por favor, introduzca un número.");
                    exito = float.TryParse(input, out resultado);
                } while (!exito);
            }

            return resultado;
        }
    }
}
