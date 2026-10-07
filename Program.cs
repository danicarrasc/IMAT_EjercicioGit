namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Divide(2, 8);
            Console.WriteLine($"The division of 2 and 8 is {result}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}