namespace Taks4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double n = Convert.ToDouble(Console.ReadLine()); //input n
            int a = 2;

            while (a < n)
            {
                a = a * 2;
            }


            if (n == a)

            {
                Console.WriteLine("Является степенью 2");
            }
            else

            {
                Console.WriteLine("Не является степенью 2");
            }

            Console.ReadKey();
        }
    }
}
