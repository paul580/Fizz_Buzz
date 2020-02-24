using System;



namespace Fizz_Buzz

{

    class Program

    {

        static void Main(string[] args)

        {

            for(int Numero = 1; Numero < 100; Numero++)

            {

                if((Numero % 3) == 0 & (Numero % 5) == 0)

                Console.WriteLine("FizzBuzz");

                

                else

                 if((Numero % 3) == 0 )

                 Console.WriteLine("Fizz");

            

                 else

                  if((Numero % 5) == 0 )

                  Console.WriteLine("Buzz");

                  

                  else

                   Console.WriteLine(Numero);







            

            }



        }

    }

}
