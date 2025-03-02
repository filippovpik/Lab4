namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine()); //input n
            int i = 1;
            double a = 0;
            
            do
            {
                a = n % 10;
                n = n / 10;
                Console.Write(a);
                i++;
            } while (n > 0);



            Console.ReadKey();
        }
    }
}
