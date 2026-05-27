using System;

namespace MethodClassAssignment
{
    // This class handles tip calculations
    class TipCalculator
    {
        // This method takes a bill amount and a table number
        // It doubles the bill to calculate the tip, then shows the table number
        public void CalculateTip(int billAmount, int tableNumber)
        {
            // Multiply the bill by 2 to get the tip amount
            int tip = billAmount * 2;

            // Show the tip amount on screen
            Console.WriteLine("Tip amount: " + tip);

            // Show the table number on screen
            Console.WriteLine("Table number: " + tableNumber);
        }
    }

    // This is the main class where the program begins
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new TipCalculator object so we can use it
            TipCalculator calc = new TipCalculator();

            // Call the method using two numbers in order
            Console.WriteLine("--- Calling by position ---");
            calc.CalculateTip(50, 3);

            // Call the method again using the parameter names
            Console.WriteLine("--- Calling by name ---");
            calc.CalculateTip(billAmount: 50, tableNumber: 3);

            // Keep the window open until Enter is pressed
            Console.ReadLine();
        }
    }
}