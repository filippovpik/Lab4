namespace Taks4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine()); //input n
            int i = 0;

            do
            {
                n = n / 10;
                i++;
            } while (n >= 1);


            Console.WriteLine("{0} цифр в числе", i);


            Console.ReadKey();
        }
    }
}
