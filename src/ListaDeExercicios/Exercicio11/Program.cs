using System.Runtime.Serialization;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             **Realizar uma operação com base em dois valores inteiros A e B.**
               - Exemplo de entrada: A = 3, B = 3
               - Exemplo de saída: A + B = 6.
             */
            int A = 0;
            int B = 0;
            int soma = 0;

            Console.WriteLine("Digite um número: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            B = Convert.ToInt32(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("O resultado da soma de A e B é: " + soma);
                    

        }
    }
}
