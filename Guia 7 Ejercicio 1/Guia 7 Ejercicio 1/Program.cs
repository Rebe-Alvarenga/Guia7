using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char key = '\0';
            bool inf = false;
            while (inf == false)
            {
                Menu();
                Console.WriteLine("Presione la tecla correspondiente a la opcion que necesitas...");
                key = Console.ReadKey().KeyChar;
                if (key == '\0')
                {
                    Console.WriteLine("No has seleccionado una opcion con tu teclado...");
                }
                else if (key != '\0')
                {
                    double x = 0, y = 0;
                    double res1;
                    switch (key)
                    {
                        case '1':
                            bool error = true;
                            while (error == true)
                            {
                                Console.Clear();
                                Menu();
                                try
                                {
                                    Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                                    x = double.Parse(Console.ReadLine());
                                    error = false;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                                    Console.WriteLine("Presione una tecla para volverlo a intentar...");
                                    Console.ReadKey();
                                    error = true;
                                }
                            }
                            //DENTRO DEL OPERADOR SE CONVIERTE DE GRADOS A RADIANES
                            res1 = Math.Sin(Math.PI * x / 180.0);
                            Console.WriteLine("El seno de " + x + " es " + Math.Round(res1, 5));
                            Console.WriteLine("Presione una tecla para volver al inicio...");
                            Console.ReadKey();
                            break;
                        case '2':
                            error = true;
                            while (error == true)
                            {
                                Console.Clear();
                                Menu();
                                try
                                {
                                    Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                                    x = double.Parse(Console.ReadLine());
                                    error = false;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                                    Console.WriteLine("Presione una tecla para volverlo a intentar...");
                                    Console.ReadKey();
                                    error = true;
                                }
                            }
                            //DENTRO DEL OPERADOR SE CONVIERTE DE GRADOS A RADIANES
                            res1 = Math.Cos(Math.PI * x / 180.0);
                            Console.WriteLine("El coseno de " + x + " es " + Math.Round(res1, 5));
                            Console.WriteLine("Presione una tecla para volver al inicio...");
                            Console.ReadKey();
                            break;
                        case '3':
                            error = true;
                            while (error == true)
                            {
                                Console.Clear();
                                Menu();
                                try
                                {
                                    Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                                    x = double.Parse(Console.ReadLine());
                                    error = false;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                                    Console.WriteLine("Presione una tecla para volverlo a intentar...");
                                    Console.ReadKey();
                                    error = true;
                                }
                            }
                            //DENTRO DEL OPERADOR SE CONVIERTE DE GRADOS A RADIANES
                            res1 = Math.Tan(Math.PI * x / 180.0);
                            Console.WriteLine("La tangente de " + x + " es " + Math.Round(res1, 5));
                            Console.WriteLine("Presione una tecla para volver al inicio...");
                            Console.ReadKey();
                            break;
                        case '4':
                            error = true;
                            while (error == true)
                            {
                                Console.Clear();
                                Menu();
                                try
                                {
                                    Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                                    x = double.Parse(Console.ReadLine());
                                    error = false;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                                    Console.WriteLine("Presione una tecla para volverlo a intentar...");
                                    Console.ReadKey();
                                    error = true;
                                }
                            }
                            res1 = Math.Sqrt(x);
                            Console.WriteLine("La raiz cuadrada de " + x + " es " + Math.Round(res1, 5));
                            Console.WriteLine("Presione una tecla para volver al inicio...");
                            Console.ReadKey();
                            break;
                        case '5':
                            error = true;
                            while (error == true)
                            {
                                Console.Clear();
                                Menu();
                                try
                                {
                                    Console.WriteLine("Ingrese un numero para darle valor a 'x' (base)...");
                                    x = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese un numero para darle valor a 'y' (potencia)...");
                                    y = double.Parse(Console.ReadLine());
                                    error = false;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                                    Console.WriteLine("Presione una tecla para volverlo a intentar...");
                                    Console.ReadKey();
                                    error = true;
                                }
                            }
                            res1 = Math.Pow(x, y);
                            Console.WriteLine(x + " elevado a " + y + " es " + Math.Round(res1, 5));
                            Console.WriteLine("Presione una tecla para volver al inicio...");
                            Console.ReadKey();
                            break;
                        case '6':
                            error = true;
                            while (error == true)
                            {
                                Console.Clear();
                                Menu();
                                try
                                {
                                    Console.WriteLine("Ingrese un numero para darle valor a 'x'...");
                                    x = double.Parse(Console.ReadLine());
                                    error = false;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error de formato. SOLO DEBE INGRESAR NUMEROS.");
                                    Console.WriteLine("Presione una tecla para volverlo a intentar...");
                                    Console.ReadKey();
                                    error = true;
                                }
                            }
                            res1 = x % 2;
                            if (res1 == 0)
                            {
                                Console.WriteLine(x + " es un numero par");
                            }
                            else if (res1 != 0)
                            {
                                Console.WriteLine(x + " es un numero impar");
                            }
                            Console.WriteLine("Presione una tecla para volver al inicio...");
                            Console.ReadKey();
                            break;
                        case '7':
                            Console.WriteLine("\nEL PROGRAMA SE CERRARA. PRESIONE UNA TECLA PARA CONTINUAR...");
                            Console.ReadKey();
                            return;
                    }
                }
            }

            void Menu()
            {
                Console.Clear();
                Console.WriteLine("***********************************************************************************************************************");
                Console.WriteLine("**                                           CALCULADORA MULTIFUNCIONAL                                              **");
                Console.WriteLine("***********************************************************************************************************************");
                Console.WriteLine("**                                         [1]Sin(x)   [2]Cos(x) [3]Tan(x)                                           **");
                Console.WriteLine("**                                         [4]Sqrt(x)  [5]x^y    [6]Par o impar                                      **");
                Console.WriteLine("**                                                     [7]Cerrar                                                     **");
                Console.WriteLine("***********************************************************************************************************************");
            }
        }
    }
}
