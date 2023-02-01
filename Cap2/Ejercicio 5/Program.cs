using System;

namespace Program
{

    class Program
    {


        static void Main()
        {

            double VDolar, VEuro;
            double Conversion;
            int opcion, cantidad;


            Console.WriteLine("Calculadora de cambio.\n*****************************************************\n1.Dolar a euro\n2.Euro a dolar");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch(opcion){

                case 1:
                    Console.WriteLine("Digite el valor al dia de dolar en euros:");
                    VEuro = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite la cantidad de dolares:");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Conversion = cantidad * VEuro;
                    Console.WriteLine($"dolares:{cantidad}\neuros:{Conversion}");
                    break;
                
                case 2:
                    Console.WriteLine("Digite el valor al dia de euros en dolares:");
                    VDolar = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite la cantidad de euros:");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Conversion = cantidad * VDolar;
                    Console.WriteLine($"euros:{cantidad}\ndolares:{Conversion}");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    Console.WriteLine("Cerrado el programa....");
                    Console.ReadKey();
                    break;

            }
        
        }
        
    }
}