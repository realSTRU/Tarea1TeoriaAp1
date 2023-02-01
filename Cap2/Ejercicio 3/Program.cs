using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Digite el valor en grados:");
            double valor = Convert.ToDouble(Console.ReadLine());


            Console.Clear();
            Console.WriteLine($"El valor en grados {valor} en radianes ={ConvertToRadianes(valor)}");



        }

        static double ConvertToRadianes(double valor){

            return (valor*3.1416)/180;

        }

       
    }
}
