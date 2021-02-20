using System;

namespace CSharpVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Powder";

            int dogAge = 15;

            char nickName = 'D';

            bool lovesHiking = true;

            double tennisBalls = 16;

            decimal weight = 50.3m;

            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old and has {tennisBalls} tennis balls and weighs {weight} and it is {lovesHiking} that he loves to hike");

            Console.WriteLine($"");
        }
    }
}