namespace _2.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                                      .Split(" ")
                                      .Select(int.Parse)
                                      .ToArray();

            int[] secondArray = Console.ReadLine()
                                      .Split(" ")
                                      .Select(int.Parse)
                                      .ToArray();

            foreach (int i in firstArray) 
            {
                if (secondArray.Contains(i))
                    Console.Write(i + " "); 
            }
        }
    }
}
