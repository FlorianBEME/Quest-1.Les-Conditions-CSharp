using System;

namespace Quest_1.Les_Conditions_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            int Integer;
            Console.WriteLine("Enter Minimum");
            min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Max");
            max = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Integer");
            Integer = Int32.Parse(Console.ReadLine());

            int low, high;
            
            if (min < max)
            {
                low = min;
                high = max;
            }
            else
            {
                low = max;
                high = min;
            }
            if (Integer < low)
            {
                Console.WriteLine("You have entered {0} which is lower than {1} which is the minimum", Integer, low);
                Console.WriteLine("Resulting interger: {0}", low);
            }
            else if (Integer > high)
            {
                Console.WriteLine("You have entered {0} which is higher than {1} which is the maximum", Integer, high);
                Console.WriteLine("Resulting interger: {0}", high);
            }
            else
            {
                Console.WriteLine("The number is in the range");
                Console.WriteLine("Resulting number: {0}", Integer);
            }
        }
    }
}
