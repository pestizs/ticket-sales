using System;

namespace ticket_sales
{
    class Program
    {
        const int DISCOUNT_AGE = 18;
        const int TICKETS_REMAINING_CUTOFF = 100;
        static void Main(string[] args)
        {
            int age = 19;
            int ticketsRemaining = 111;
            bool NusCard = true;

            if (NusCard = true)
            {
                
                if (ticketsRemaining > TICKETS_REMAINING_CUTOFF)
                {
                    Console.WriteLine("You get a discount because you have a NUS card.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("There are not enought tickets left, ");
                    Console.WriteLine("So you must pay full price.");
                    Console.ReadLine();
                }

            }
            else
            {
                if (age < DISCOUNT_AGE)
                {
                    Console.WriteLine("You are young enought to get a discount.");
                    Console.ReadLine();
                    if (ticketsRemaining > TICKETS_REMAINING_CUTOFF)
                    {
                        Console.WriteLine("You get a discount.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("But there are not enought tickets left, ");
                        Console.WriteLine("So you must pay full price.");
                        Console.ReadLine();

                    }
                }
                else
                {
                    Console.WriteLine("Being {0} or older, you dont get a discount.", DISCOUNT_AGE);
                    Console.ReadLine();
                }
            }
            Console.WriteLine("This line always happens.");
            Console.ReadLine();



        }
    }
}
