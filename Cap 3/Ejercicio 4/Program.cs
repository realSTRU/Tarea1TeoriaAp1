using System;

namespace Program
{
    class Program
    {

        static void Main(){

            int Value;

            Console.WriteLine("Digite un numero:");
            Value = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (Value)
            {
                case 1:
                    Console.WriteLine("El numero que seleciono corresponde al dia Lunes");
                    break;
                case 2:
                    Console.WriteLine("El numero que seleciono corresponde al dia Martes");
                    break;
                case 3:
                    Console.WriteLine("El numero que seleciono corresponde al dia Miercoles");
                    break;
                case 4:
                    Console.WriteLine("El numero que seleciono corresponde al dia Jueves");
                    break;
                case 5:
                    Console.WriteLine("El numero que seleciono corresponde al dia Viernes");
                    break;
                case 6:
                    Console.WriteLine("El numero que seleciono corresponde al dia Sabado");
                    break;
                case 7:
                    Console.WriteLine("El numero que seleciono corresponde al dia Domingo");
                    break;

                default:
                    Console.WriteLine("El dia que selecciono no existe (Numero invalido)");
                    break;
            }
        }
        
    }
}
