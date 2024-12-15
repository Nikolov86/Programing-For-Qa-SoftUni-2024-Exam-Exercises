namespace _7.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToArray();

            for (int i = 0; i < firstArray.Length -1; i++) 
            {
                bool isGreater = true;
                int firstElemet = firstArray[i];

                for (int j = +1; j < firstArray.Length; j++) 
                {
                    int rigthElemet = firstArray[j];

                    if (firstElemet <= rigthElemet) 
                    {
                        isGreater = false;
                        break;
                    }

                }
                if (isGreater) 
                {
                    Console.Write($"{firstElemet} ");
                }

            }
            Console.WriteLine(firstArray[firstArray.Length -1]);
        }
    }
}
