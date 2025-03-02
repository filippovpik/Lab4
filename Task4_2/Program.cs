namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            int n = Convert.ToInt32(Console.ReadLine()); //input n
            double fact = 1.0;

            for (double i = 2.0; i <= n; i++)

            {
                fact = fact + 1/i;
            }

            Console.WriteLine(fact);

            Console.ReadKey();
        }
    }
}
