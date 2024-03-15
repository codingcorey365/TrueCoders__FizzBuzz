namespace FizzBuzzTrueCoders
{
    public class Problem
    {
        public void GivenNumbner(int n)
        {
            if (n % 3 == 0 && n % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }

            if (n % 5 == 0 && n % 3 != 0)
            {
                Console.WriteLine("Buzz");
            }

            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
        }
    }
}
