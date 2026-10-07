namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(2, 0);
            Console.WriteLine($"The sum of 2 and 0 is {result}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}