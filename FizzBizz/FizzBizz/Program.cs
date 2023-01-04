namespace FizzBizz
{
    public class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });

        }

        public static void FizzBuzz(int[] arrayNumbers) 
        {
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] % 3 == 0 && (arrayNumbers[i] % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (arrayNumbers[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (arrayNumbers[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine($"{arrayNumbers[i]}");
                }
            }
        }
    }
}