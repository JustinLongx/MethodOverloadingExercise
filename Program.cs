using System.ComponentModel;

namespace MethodOverloadingExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add(2,4);
            Add(.5m,.5m);
            Add(2,1,false);
        }

        //Create a method named Add, that accepts two integers and returns the sum of those two integers.

        public static void Add(int num1, int num2)
        {
            var anwser = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {anwser}");
        }

        //Now create an overload of the Add method to account for being able to add two decimals together.

        public static void Add(decimal num1, decimal num2)
        {
            var anwser = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {anwser}");
        }

        //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean.
        //If the boolean parameter is equal to true,
        //the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
        //You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”

        public static void Add(int num1, int num2, bool dollars)
        {
            var sum = num1 + num2;
            if (sum > 1)
            {
                dollars = true;
                Console.WriteLine($"{sum} dollars");

            }
            else
            {
                dollars = false;
                Console.WriteLine($"{sum} dollar");
            }
        }


    }
}
