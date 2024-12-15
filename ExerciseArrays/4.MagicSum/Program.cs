using System.Globalization;

namespace _4.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                                      .Split(" ")
                                      .Select(int.Parse)
                                      .ToArray();

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < firstArray.Length -1; i++) 
            {
                int element = firstArray[i];

                if (element > magicNum) // if first element is bigger then magicNum
                {
                    continue;
                }

                for (int j = i+1; j < firstArray.Length; j++) 
                {
                    int nextElement = firstArray[j];
                    if (element + nextElement == magicNum) 
                    {
                        Console.WriteLine($"{element} {nextElement}");
                        break;
                    }
                }
            }


        }                             
    }
}
