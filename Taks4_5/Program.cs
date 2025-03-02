namespace Taks4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в диапазоне [20;60]");
            int a = Convert.ToInt32(Console.ReadLine()); //input a


            while (a < 20 || a > 60)

            {
                Console.WriteLine("Введите число в диапазоне [20;60]");
                a = Convert.ToInt32(Console.ReadLine()); //input a
            }



            Console.WriteLine("Ok");

            Console.ReadKey();
        }
    }
}
