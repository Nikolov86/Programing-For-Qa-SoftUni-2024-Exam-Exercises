namespace _07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowNumb = int.Parse(Console.ReadLine());
            
            int sumNumbers = 0;

            for (int i = 0; i < rowNumb; i++) 
            {
                int number = int.Parse(Console.ReadLine());
                sumNumbers += number;

            }
            Console.WriteLine(sumNumbers);


        }
    }
}
