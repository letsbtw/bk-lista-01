namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
                4. **Substituir múltiplos de 3 pela palavra "Fizz" e múltiplos de 5 pela palavra "Buzz" na contagem de 1 a 100.**
                Exemplo de saída: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, ...
             */

            bool fizz = false;
            bool buzz = false;
            bool fizzBuzz = false;
            
            for (int i = 1; i <= 100; i++) {

                fizz = i % 3 == 0 ? true : false;
                buzz = i % 5 == 0 ? true : false;
                fizzBuzz = i % 3 == 0 && i % 5 == 0 ? true : false;


                if(fizz)
                {
                    if(fizzBuzz)
                    {
                        Console.Write("FizzBuzz ");
                    }
                    else
                    {
                        Console.Write("Fizz ");
                    }
                } else if(buzz)
                {
                    if (fizzBuzz)
                    {
                        Console.Write("FizzBuzz ");
                    }
                    else
                    {
                        Console.Write("Buzz ");
                    }
                } else
                {
                    Console.Write(i + " ");
                }

            }


        }
    }
}
