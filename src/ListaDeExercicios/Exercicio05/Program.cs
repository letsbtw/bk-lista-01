namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            **Calcular a média ponderada de duas provas realizadas por um aluno.**
           - Exemplo de entrada: Nota da primeira prova = 7, Peso da primeira prova = 0.4, Nota da segunda prova = 8, Peso da segunda prova = 0.6
           - Fórmula: Média ponderada = (Nota da primeira prova * Peso da primeira prova) + (Nota da segunda prova * Peso da segunda prova)
           - Exemplo de saída: A média ponderada do aluno é 7.6.

            */

            decimal grade1 = 0;
            decimal grade2 = 0;
            decimal peso1 = 0;
            decimal peso2 = 0;
            decimal total = 0;


            Console.WriteLine("Qual foi a nota da primeira prova?");
            grade1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual foi o peso da primeira prova?");
            peso1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual foi a nota da segunda prova?");
            grade2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual foi o peso da segunda prova?");
            peso2 = Convert.ToDecimal(Console.ReadLine());
        
            total = (grade1 * peso1) + (grade2 * peso2);
            

            Console.WriteLine("A nota do aluno por média ponderada será " + total);
        }
    }
}
