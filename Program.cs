using System; // Allows us to use Console.WriteLine and other basic C# features.

namespace MethodAssignment
{
    // This class contains the method required for the assignment.
    class MathOperation
    {
        // This void method takes two integer parameters.
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer.
            int result = firstNumber * 2;

            // Display the result of the math operation.
            Console.WriteLine("The result of the math operation is: " + result);

            // Display the second integer to the screen.
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }

    class Program
    {
        // Main() is where the console application starts.
        static void Main(string[] args)
        {
            // Instantiate (create an object of) the MathOperation class.
            MathOperation mathObject = new MathOperation();

            // Call the method and pass in two numbers normally.
            mathObject.DoMath(10, 20);

            // Call the method again, specifying the parameters by name.
            mathObject.DoMath(firstNumber: 15, secondNumber: 30);

            // Keep the console window open until the user presses a key.
            Console.ReadKey();
        }
    }
}
