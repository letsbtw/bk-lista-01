namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. **Identificar se um número é par ou ímpar.**
                - Exemplo de entrada: Número = 7
                - Exemplo de saída: O número é ímpar.
            */

            int numero = 0;
            bool par = false;

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            par = (numero % 2) == 0 ? true : false;

            if (par)
            {
                Console.WriteLine(numero + " é par.");
            } else
            {
                Console.WriteLine(numero + " é ímpar.");
            }



        }
    }
}
