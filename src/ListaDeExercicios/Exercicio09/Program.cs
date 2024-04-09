namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * **Calculo IMC
               - Exemplo de entrada: Peso = 70 kg, Altura = 1.75 
               - Fórmula: IMC = Peso / (Altura^2)
               - Exemplo de saída: IMC = 22.86 (Peso normal). 
             */


            double peso=0;
            double altura=0;
            double IMC = 0;
            bool baixo = false;
            bool normal = false;
            bool sobre = false;
            bool obeso = false;



            Console.WriteLine("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            IMC = peso / Math.Pow(altura,2);

            baixo = IMC < 18.5 ? true : false;
            normal = IMC > 18.5 && IMC < 24.9 ? true : false;
            sobre = IMC > 25 && IMC < 29.9 ? true : false;
            obeso = IMC > 30 && IMC < 34.9 ? true : false;

            if (baixo)
            {
                Console.WriteLine("Seu IMC é: " + IMC + ". Você está abaixo do peso ideal.");
            }
            if (normal)
            {
                Console.WriteLine("Seu IMC é: " + IMC + ". Você está com o seu peso ideal!");
            }
            if (sobre)
            {
                Console.WriteLine("Seu IMC é: " + IMC + ". Você está acima do peso ideal.");
            }
            if (obeso)
            {
                Console.WriteLine("Seu IMC é: " + IMC + ". Você está exibindo sinais de obesidade classe 1. Visite um médico assim que possível..");
            }

        }
    }
}
