using System;

namespace Ejemplo_2__Switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a tu calculadora");
            Console.WriteLine("Que operacion deseas hacer?");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");

            double opc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el primer número :");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número :");
            double n2 = Convert.ToDouble(Console.ReadLine());


            switch (opc)
                {
                    case (1):
                        double suma = n1 + n2;
                        Console.WriteLine("Tu resultado es: " + suma);
                        break;

                    case (2):
                        double resta = n1 + n2;
                        Console.WriteLine("Tu resultado es: " + resta);
                        break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    return;

                }
            
        }
    }
}


//if(opc!=1){ if (opc!=2){ Console.WriteLine("Opcion incorrecta"); Console.ReadKey(); return;}}
