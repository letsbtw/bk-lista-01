namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***Calcular o salário total de um vendedor.**
            - Exemplo de entrada: Salário base = R$ 1500, Total de vendas = R$ 5000, Comissão (5% sobre as vendas)
            - Fórmula: Salário total = Salário base + (Total de vendas * Comissão)
            - Exemplo de saída: O salário total do vendedor é R$ 2750.
            */

            decimal startWage = 0;
            decimal salesTotal = 0;
            decimal comission = 0;
            decimal total = 0;

            Console.WriteLine("Qual o salário inicial?");
            startWage = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual foi o total de vendas?");
            salesTotal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual a porcentagem de comissão?");
            comission = Convert.ToDecimal(Console.ReadLine());

            total = startWage + ((salesTotal * comission)/100);
            Console.WriteLine("O salário total do vendedor é R$ " + total);


        }
    }
}
