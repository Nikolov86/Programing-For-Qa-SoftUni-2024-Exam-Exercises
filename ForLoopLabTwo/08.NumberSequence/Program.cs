namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowNumber = int.Parse(Console.ReadLine());

            // Инициализиране с максимално и минимално възможните стойности
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 0; i < rowNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                // Проверка за най-малкото число
                if (number < minNumber)
                {
                    minNumber = number;
                }

                // Проверка за най-голямото число
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            // Отпечатване на резултата
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
