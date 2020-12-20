using System;

namespace M1___CW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String characterName = "Ahmad";
            String superPower1 = "steel armor";
            String superPower2 = "night vision";
            int age = 15;
            double speed = 1.65;

            Console.WriteLine("My name is " +  characterName + " and my super powers are " + superPower1 + " and " + superPower2 + " . My age is " + age + " and my speed is " + speed);
            Console.WriteLine("");
            Console.WriteLine("My name is {0} and my super powers are {1} and {2} . My age is {3} and my speed is {4}", characterName, superPower1, superPower2, age, speed);
            
        }
    }
}
