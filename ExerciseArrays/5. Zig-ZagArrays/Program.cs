namespace _5._Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] firstArray = new int[number];
            int[] secondArray = new int[number];

            for (int i = 0; i < number; i++)
            {
                int[] intput = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToArray();

                int firstIndex = intput[0];
                int secondIndex = intput[1];

                if (i % 2 == 0) //
                {
                    firstArray[i] = firstIndex;
                    secondArray[i] = secondIndex;
                }
                else
                {
                    firstArray[i] = secondIndex;
                    secondArray[i] = firstIndex;
                }
                Console.WriteLine(string.Join(" ", firstArray)); // print Array
                Console.WriteLine(string.Join(" ", secondArray)); // print Array
            }
        }
    }
}
