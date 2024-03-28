namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***Calcular o consumo de combustível por quilômetro.**
            - Exemplo de entrada: Quilometragem inicial = 100 km, Quilometragem final = 200 km, Consumo de combustível = 20 litros
            - Fórmula: Consumo por km = Consumo de combustível / (Quilometragem final - Quilometragem inicial)
            - Exemplo de saída: O consumo de combustível por quilômetro é de 0.1 litros/km.
            */

            decimal kmStart = 0;
            decimal kmEnd = 0;
            decimal gasConsumption = 0;
            decimal result = 0;


            Console.WriteLine("Qual era a quilometragem quando a viagem começou?");
            kmStart = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual era a quilometragem quando a viagem terminou?");
            kmEnd = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual foi consumo total de gasolina?");
            gasConsumption = Convert.ToDecimal(Console.ReadLine());

            result = gasConsumption / (kmEnd - kmStart);

            Console.WriteLine("O consumo de combustível por quilômetro é de " + result + " litros/km");


        }
    }
}
