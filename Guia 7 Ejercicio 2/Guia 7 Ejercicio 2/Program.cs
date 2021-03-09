using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 0;
            Console.WriteLine("Ingrese un numero entre 1 a 15");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERROR CON EL FORMATO DEL NUMERO...");
                Console.WriteLine("Se cerrara la aplicacion...");
                Console.ReadKey();
                return;                    
            }
            if (num > 15 || num < 1)
            {
                Console.WriteLine("ERROR CON EL RANGO DEL NUMERO...");
                Console.WriteLine("Se cerrara la aplicacion...");
                Console.ReadKey();
                return;
            }
            else
            {
                do
                {
                    Console.Write('*');
                    i++;
                }
                while (i < num);
            }
            Console.ReadKey();
        }
    }
}
