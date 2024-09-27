using System.Diagnostics.Tracing;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

          //  буква a e i o u
          //стойност 1 2 3 4 5

            string word = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];   // Access the character at index i

                switch (letter)
                {

                    case 'a':
                        sum += 1;
                        break;

                    case 'e':   
                        sum += 2; 
                        break;

                    case 'i':
                        sum += 3;
                        break;

                    case 'o':
                        sum += 4;
                        break;

                    case 'u':
                        sum += 5;
                        break;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
