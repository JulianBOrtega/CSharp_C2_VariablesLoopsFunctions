using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDivisibles
{
    class Program
    {
        /* 
            Consigna:
            ---------------------
            Crea un programa muestre los números entre el 0 y el 100, 
            que no sean divisibles por 2. Usa un ciclo While.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("/////////////// TP2 - Ejercicio 2: Números no divisiles por 2, entre 0 y 100 - Julián B. Ortega ///////////////");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione enter para comenzar la operación.");
            Console.ReadKey();
            Console.WriteLine();

            int contador = 1;
            while(contador < 100)
            {
                if (contador % 2 != 0)
                {
                    Console.WriteLine(contador);
                    System.Threading.Thread.Sleep(50);
                }
                contador++;
            }

            Console.WriteLine();
            Console.WriteLine("Listo.");
            Console.WriteLine();
            Console.WriteLine("------------------------- ");
            Console.ReadKey();
        }
    }
}
