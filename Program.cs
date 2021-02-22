using System;
using System.Collections.Generic;


namespace CsharpFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int counter = 1; counter < 101; counter++)
            {
                Console.WriteLine(counter);
            }

            for (int counter = 1; counter < 101; counter++)
            {
                var toDisplay = new List<string>();
                GetThree(toDisplay, counter);
                if (toDisplay.Count == 0)
                {
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine(string.Join(",", toDisplay));
                    }
            }        

        }
        
        public static void GetThree(List<string> toDisplay, int counter)
        {
            if (counter % 3 == 0)
            {
                toDisplay.Add("Fizz");
            }
        }

    }
}
