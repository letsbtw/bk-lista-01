namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. **Gerar e escrever os números ímpares entre 100 e 200.**
                   - Exemplo de saída: 101, 103, 105, ..., 199.
             */

               for (int i = 101; i < 198; i++) {
                Console.Write(i + ", ");
                i++;
                }

               Console.Write("199.");
        }
    }
}
