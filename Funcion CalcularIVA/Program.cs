using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcion_CalcularIVA
{
    class Program
    {
        /* 
            Consigna:
            ---------------------
            Crear la función para el ejercicio 1 que se llame CalcularIVA, 
            la cual debe recibir un parámetro de tipo numérico y devolver 
            el valor Final con IVA.
        */

        static void Main(string[] args)
        {
            float valor = ValidarEntrada(MostrarMensaje("Por favor introduzca el valor del producto."));

            MostrarMensaje("Con un IVA del 21% y un producto con el valor de $"
                + valor + ", el valor total es de: $" + CalcularIVA(valor));
        }

        static float CalcularIVA(float valor)
        {
            return valor + (valor / 100 * 21);
        }

        static string MostrarMensaje(string mensaje)
        {
            Console.Clear();

            Console.WriteLine("/////////////// TP2 - Ejercicio 3: Función de Calculo de IVA - Julián B. Ortega ///////////////");
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

            if (!float.TryParse(input, out float resultado))
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
