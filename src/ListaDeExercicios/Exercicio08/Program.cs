namespace Estruturas02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            **Calcular o fatorial de um número e exibir o resultado.**
               - Exemplo de entrada: Número = 5
               - Exemplo de saída: 5! = 120.
            */
            int j = 0;
            

            Console.WriteLine("Digite o número o qual deseja calcular o fatorial: ");
            j = Convert.ToInt16(Console.ReadLine());
            int fat = j;

            for (int i = (j-1); i >1 ; i--)
            {
                fat = fat * i;
            }

            Console.WriteLine(j + "! = " + fat);

        }
    }
}
