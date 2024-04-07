namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            **Verificar se a soma de A + B é menor que C.**
            - Exemplo de entrada: A = 5, B = 3, C = 10
            - Exemplo de saída: A + B é menor que C.
            */

            int a = 0;
            int b = 0;
            int c = 0;
            int soma = 0;

            Console.WriteLine("Digite um número A: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite um número B: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite um número C: ");
            c = Convert.ToInt16(Console.ReadLine());

            soma = a + b;

            if (soma >= c)
            {
                Console.WriteLine(a + " + " + b + " não é menor que " + c);
            }
            else
            {
                Console.WriteLine(a + " + " + b + " é menor que " + c);
            }

        }
    }
}

