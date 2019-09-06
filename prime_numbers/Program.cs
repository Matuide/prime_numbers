using System;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int prime_number;
            Console.WriteLine("enter a number");
            number = Console.ReadLine();
            prime_number = Convert.ToInt32(number);
            for (int x = 2; x < prime_number / 2; x++)
            {


                if ((prime_number % x) == 0)
                {

                    Console.WriteLine("your number is divisible by {0} so it is not prime", x);
                }
              //  else
                {
                 //   Console.WriteLine(" this number is prime");
                }

                    

            }
        }
        }
    }

