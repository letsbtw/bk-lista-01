namespace Estruturas01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            **Gerar e escrever os números ímpares entre 100 e 200.**
            - Exemplo de saída: 101, 103, 105, ..., 199.
            */

            for (int i = 101; i < 200; i++) { 
                Console.WriteLine(i);
                i = i + 1;

            }
        }
    }
}
