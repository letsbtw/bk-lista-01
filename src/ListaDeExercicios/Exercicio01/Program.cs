namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Calcular o volume de uma caixa retangular.
                - Exemplo de entrada: Altura = 5, Largura = 3, Comprimento = 2
                - Fórmula: Volume = Altura * Largura * Comprimento
                - Exemplo de saída: O volume da caixa é 30 unidades cúbicas.*/

            decimal altura = 0;
            decimal largura = 0;
            decimal comprimento = 0;
            decimal result = 0;

            Console.WriteLine("Digite a altura da sua caixa retângular: ");
            altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a largura da sua caixa retângular: ");
            largura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o comprimento da sua caixa retângular: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());


            result = altura * largura * comprimento;

            Console.WriteLine("O volume da sua caixa retângular é " + result + " unidades cúbicas.");
            
        }
    }
}
