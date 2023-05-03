using System;
namespace MathsTutor
{
    public static class Tutorial
    {
        public static void DisplayInstructions()
        {
            Console.Clear();
            Console.WriteLine("Instructions:");
            Console.WriteLine("1. Choose either 'Deal 3 cards' or 'Deal 5 cards' from the menu.");
            Console.WriteLine("2. The program will generate a math problem based on the cards dealt.");
            Console.WriteLine("3. Enter your answer for the problem.");
            Console.WriteLine("4. The program will tell you if your answer is correct or not.");
            Console.WriteLine("5. Choose another option or quit the application.");
        }
    }
}

