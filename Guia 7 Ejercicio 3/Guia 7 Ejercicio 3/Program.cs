using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;
            try
            {
                Console.WriteLine("Ingrese el primer numero...");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero...");
                num2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error en el formato ingresado...");
                Console.WriteLine("El programa se cerrara al pulsar cualquier tecla...");
                Console.ReadKey();
                return;
            }
            if (num2 <= num1)
            {
                Console.WriteLine("El segundo numero ingresado (" + num2 + ") no puede ser menor o igual al primer numero (" + num1 + ")");
                Console.WriteLine("EL PROGRAMA SE CERRARA...");
                Console.ReadKey();
                return;
            }
            else
            {
                while (num1 != num2 + 1)
                {
                    res = num1 % 2;
                    if (res == 0)
                    {
                        Console.WriteLine(num1);
                    }
                    num1++;
                }
                Console.ReadKey();
            }
        }
    }
}
