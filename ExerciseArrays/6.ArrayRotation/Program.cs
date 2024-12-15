using System.Threading.Channels;

namespace _6.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToArray();

            int rotation = int.Parse(Console.ReadLine());

            if (rotation > firstArray.Length) 
            {
                rotation = rotation % firstArray.Length;
            }

            if (rotation != firstArray.Length)
            {

                for (int i = 0; i < rotation; i++)
                {
                    int firstElement = firstArray[0]; // save first element

                    for (int j = 1; j < firstArray.Length; j++)
                    {
                        firstArray[j - 1] = firstArray[j]; // 
                    }

                    firstArray[firstArray.Length - 1] = firstElement;
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));

        } 
    }
}
