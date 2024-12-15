namespace _3.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                                     .Split(" ")
                                     .Select(int.Parse)
                                     .ToArray();

            while (firstArray.Length > 1)
            {
                int[] condensedArray = new int[firstArray.Length - 1];

                for (int i = 0; i < firstArray.Length - 1; i++)
                {
                    condensedArray[i] = firstArray[i] + firstArray[i + 1];
                }

                firstArray = condensedArray;
            }

            Console.WriteLine(firstArray[0]);
        }
    }
}
