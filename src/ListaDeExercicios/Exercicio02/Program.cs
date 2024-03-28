using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* *Converter a temperatura de graus Fahrenheit para graus Celsius.**
               -Exemplo de entrada: Temperatura em Fahrenheit = 68
               - Fórmula: Celsius = (Fahrenheit - 32) * 5 / 9
               - Exemplo de saída: A temperatura em Celsius é 20 °C.
            */

            int faren = 0;
            int celsius = 0;


            Console.WriteLine("Digite a temperatura em Farenheit: ");
            faren = Convert.ToInt16(Console.ReadLine());

            celsius = (faren - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Celcius é " +  celsius + "°C.");
        }
    }
}
