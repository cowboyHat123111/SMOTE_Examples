namespace Even_or_Odd
{
    internal class Program
    {
        public static string EvenOrOdd(int number) => number % 2 == 0 ? "Even" : "Odd";

        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd(6));
        }
    }
}