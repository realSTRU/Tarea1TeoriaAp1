using System;

namespace Program
{


    class Program
    {
        static void Main(){
            
            int Value;

            Console.WriteLine("Digite un valor:");
            Value = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if(Value % 2 ==0){
                Console.WriteLine($"El numero {Value} es par");
            }
            else
            {
                Console.WriteLine($"El numero {Value} es impar");
            }
        }
    }
}