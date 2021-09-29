using System;

namespace Ficha_Programação1
{
    class Program
    {
        static void Main(string[] args)
        {
            float celcius , fahrenheit;
            Console.WriteLine("Escreva uma temperatura em Celsius para ser convertido em Fahrenheit");
            celcius = float.Parse(Console.ReadLine());
            fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine("Sua temperatura convertida em Fahrenheit é:{0}", fahrenheit);
            Console.ReadKey();
        }
    }
}
