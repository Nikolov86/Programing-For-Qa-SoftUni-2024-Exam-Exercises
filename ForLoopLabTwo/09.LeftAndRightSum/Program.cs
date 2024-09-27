namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowNumber = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < rowNumber; i++)
            {

                int numbers = int.Parse(Console.ReadLine());

                leftSum += numbers;
            }


            for (int j = 0; j < rowNumber; j++)
            {
                int numbers = int.Parse(Console.ReadLine());
                rightSum += numbers;

            }

            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                int diff = Math.Abs(rightSum - leftSum);  // Absolute
                
                Console.WriteLine($"No, diff = {diff}");
            }





        }
    }
}
