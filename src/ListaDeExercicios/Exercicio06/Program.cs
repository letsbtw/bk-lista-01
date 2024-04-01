namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            6. **Calcular a área de um terreno retangular.**
            - Exemplo de entrada: Comprimento do terreno = 10 metros, Largura do terreno = 5 metros
            - Fórmula: Área = Comprimento * Largura
            - Exemplo de saída: A área do terreno é 50 metros quadrados.
            */

            decimal comprimento = 0;
            decimal largura = 0;
            decimal total = 0;

            Console.WriteLine("Qual o comprimento em metros do seu terreno?");
            comprimento = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual a largura em metros do seu terreno?");
            largura = Convert.ToDecimal(Console.ReadLine());

            total = comprimento * largura;

            Console.WriteLine("A área do terreno é " + total + " metros quadrados.");


        }
    }
}
