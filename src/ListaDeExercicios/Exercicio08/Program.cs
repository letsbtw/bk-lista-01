namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * **Ordenar três valores inteiros e diferentes em ordem decrescente.**
                - Exemplo de entrada: 5, 10, 3
                - Exemplo de saída: Os números em ordem decrescente são 10, 5, 3.
             */

            int[] ordem= new int[3];
            int[] decrescent= new int[3];
 
   

            for (int i=0;i <= 2; i++){
                Console.WriteLine("Digite um número: ");
                ordem[i]= Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 2; i >= 0; i--)
            {

                if ((ordem[i] > ordem[0] && ordem[i] > ordem[1]) || (ordem[i] > ordem[0] && ordem[i] > ordem[2]) || (ordem[i] > ordem[1] && ordem[i] > ordem[2]))
                {
                    decrescent[0] = ordem[i];
                }
                if ((ordem[i] > ordem[0] && ordem[i] < ordem[1]) || (ordem[i] < ordem[0] && ordem[i] > ordem[1]) || (ordem[i] > ordem[0] && ordem[i] < ordem[2]) || (ordem[i] < ordem[0] && ordem[i] > ordem[2] || (ordem[i] > ordem[1] && ordem[i] < ordem[2]) || (ordem[i] < ordem[1] && ordem[i] > ordem[2])))
                {
                    decrescent[1] = ordem[i];
                }
                if ((ordem[i] < ordem[0] && ordem[i] < ordem[1]) || (ordem[i] < ordem[0] && ordem[i] < ordem[2]) || (ordem[i] < ordem[1] && ordem[i] < ordem[2]))
                {
                    decrescent[2] = ordem[i];

                }
            }
            Console.Write(decrescent[0] + " " + decrescent[1] + " " + decrescent[2]);

        }
    }
}
