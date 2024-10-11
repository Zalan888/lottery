using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    internal class Program
    {
        static int[] lottoNumbers = GenerateLottoNumbers();
        static void Main()
        {
            PrintLottoNumbers(lottoNumbers);
        }

        static int[] GenerateLottoNumbers()
        {
            Random random = new Random();
            int[] numbers = new int[5];
            int count = 0;

            while (count < 5)
            {
                int number = random.Next(1, 50); // Generate a number between 1 and 49
                if (Array.IndexOf(numbers, number) == -1) // Check for uniqueness
                {
                    numbers[count] = number;
                    count++;
                }
            }

            return numbers;
        }

        static void PrintLottoNumbers(int[] numbers)
        {
            Console.WriteLine("A lottó sorsolás számai: " + string.Join(", ", numbers));
        }
    }
}