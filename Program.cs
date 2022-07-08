using System;
using CustomMath;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            MathLib mathData = new MathLib(10, 20);
            Console.WriteLine(Math.Cbrt(19));
            Console.WriteLine($"Addition is {mathData.AddNumber()}");

            Console.WriteLine($"Subtraction is {mathData.SubNumber()}");

            Console.WriteLine("Enter your Name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your Name is {name} Birth Year is {2022 - age - 1}");

            var inputText = Console.ReadLine();
            var inputTextStr = Convert.ToString(inputText);
            File.AppendAllText("Test_create.txt", "\n" + inputText);

            var outputText = File.ReadAllText("Test_create.txt");
            Console.WriteLine($"The New text is {outputText}");

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}

