using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomEvent
{
    class Program
    {
        private static bool IsPrime(int number)
        {
            for (int index = 2; index < number / 2; index++)
                if (number % index == 0)
                    return false;
            return true;
        }


        private static void LastPrime(object param)
        {
            int answer = 2;
            for(int index = 3; index < (int)param; index++)
            {
                if(IsPrime(index))
                {
                    answer = index;
                }
            }
            Console.WriteLine(answer);
        }

        private static void LastPrimeOptim(object param)
        {

            for (int i = (int)param - 1; i > 2; i--)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(2);
        }

        public static void Main()
        {
            
            Thread thread = new Thread(new ParameterizedThreadStart(LastPrime));
            Thread thread2 = new Thread(new ParameterizedThreadStart(LastPrimeOptim));
            thread.Start(100);
            thread2.Start(100);
            Console.ReadLine();
        }
    }
}
