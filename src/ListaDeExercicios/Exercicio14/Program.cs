namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * **Imprimir a sequência de Fibonacci até um número informado.**
               - Exemplo de entrada: Número = 50
               - Exemplo de saída: Sequência de Fibonacci até 50: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.
            */

            int numero=0;
            int prox = 0;
            int ant = 0;
            int atual = 1;

            Console.Write("Digite o último valor desejado para a sequência: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("0 ");
            Console.Write("1 ");

            for (int i = 1; i < numero; i++) {
                prox = ant + atual;
                if(prox <= numero)
                {
                    Console.Write(prox + " ");
                    ant = atual;
                    atual = prox;
                }
            }



        }
    }
}
