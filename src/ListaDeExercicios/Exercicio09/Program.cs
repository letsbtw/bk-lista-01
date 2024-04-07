using System.Reflection.Emit;

namespace Estruturas03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    **Imprimir a sequência de Fibonacci até um número informado.**
           - Exemplo de entrada: Número = 50
           - Exemplo de saída: Sequência de Fibonacci até 50: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.
            */

            int j = 0;
            Console.WriteLine("Digite um número: ");
            j = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            int fib = 0;
            int a = 0;
            int b = 1;

            Console.Write("0, 1, ");
            do
            {
                fib = a + b;
                a = b;
                b = b++;
                Console.Write(fib);
            } while (fib < j);
           
            
        }
    }
}
