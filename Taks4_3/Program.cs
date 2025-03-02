namespace Taks4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число a>0");
            int a = Convert.ToInt32(Console.ReadLine()); //input a

            Console.WriteLine("Введите целое число b>0");
            int b = Convert.ToInt32(Console.ReadLine()); //input b

            int res = 1;

            for (int i = 0; i <b ; i++)

            {
                res = res * a;
            }

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
