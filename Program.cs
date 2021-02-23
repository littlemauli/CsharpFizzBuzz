using System;
using System.Collections.Generic;


namespace CsharpFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter < 300; counter++)
            {
                var toDisplay = new List<string>();
                GetThree(toDisplay, counter);
                GetFive(toDisplay, counter);
                GetSeven(toDisplay, counter);
                GetEleven(toDisplay, counter);
                GetThirteen(toDisplay, counter);
                GetSeventeen(toDisplay, counter);
                if (toDisplay.Count == 0)
                {
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine(string.Join("", toDisplay));
                }
            }

            // GetThreeFiveSeven(100); 

        }

        public static void GetThree(List<string> toDisplay, int counter)
        {
            if (counter % 3 == 0)
            {
                toDisplay.Add("Fizz");
            }
        }

        public static void GetFive(List<string> toDisplay, int counter)
        {
            if (counter % 5 == 0)
            {
                toDisplay.Add("Buzz");
            }
        }

        public static void GetSeven(List<string> toDisplay, int counter)
        {
            if (counter % 7 == 0)
            {
                toDisplay.Add("Bang");
            }
        }

        public static void GetEleven(List<string> toDisplay, int counter)
        {
            if (counter % 11 == 0)
            {

                toDisplay.Clear();
                toDisplay.Add("Bong");

            }
        }

        public static void GetThirteen(List<string> toDisplay, int counter)
        {
            bool result = false;

            if (counter % 13 == 0)
            {
                int IndexB = -1;
                for (var i = 0; i < toDisplay.Count; i++)
                {
                    if (result = toDisplay[i].Contains("B"))
                    {
                        IndexB = i;
                    }
                }
                if (IndexB >= 0)
                {
                    toDisplay.Insert(IndexB, "Fezz");
                }
                else
                {
                    toDisplay.Add("Fezz");
                }
            }
        }

        public static void GetSeventeen (List<string> toDisplay, int counter)
        {
           if( counter % 17 == 0)
           {
             toDisplay.Reverse();
            }
      
        }
        public static void GetThreeFiveSeven(int maxNumber)
        {
            for (int counter = 1; counter < maxNumber; counter++)
            {
                var toDisplay = new List<string>();
                GetThree(toDisplay, counter);
                GetFive(toDisplay, counter);
                GetSeven(toDisplay, counter);
                if (toDisplay.Count == 0)
                {
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine(string.Join("", toDisplay));
                }

            }

        }
    }
}
