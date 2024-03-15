

namespace FizzBuzzTrueCoders
{
    public class Program
    {
        static void Main(string[] args)
        {
            var method = new Problem();
            Console.WriteLine("Enter a number!");
            var userInput = int.TryParse(Console.ReadLine(), out int number);
            method.GivenNumbner(number);
        }
    }
}
