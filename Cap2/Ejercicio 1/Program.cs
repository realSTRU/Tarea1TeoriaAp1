using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            


            Console.WriteLine("Digite la cantidad de lados del poligono:");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el valor de la longitud de los lados:");
            double v = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"El valor del perimetro del poligono con {l} lados es :{perimetro(l,v)}");
        }

        static double perimetro(int lados, double valor){

            double Acumulador = 0;

            for(int i = 0 ; i < lados; i++){
                
                Acumulador+= valor;
                
            }

            return Acumulador;

        }
    }
}
