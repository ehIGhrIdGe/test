using System;

namespace Method_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = new string[2];

            while(!Judgment(inputText))
            {
                Console.WriteLine("数字を入力してね");

                for (int i = 0; i < inputText.Length; i++)
                {
                    Console.Write($"{ i + 1} 番目の数字 : ");
                    inputText[i] = Console.ReadLine();
                }

            }

            var inputNumber = ConvertToInt(inputText);
            Console.WriteLine(Calculation(inputNumber));
        }

        static bool Judgment(string[] inputText)
        {
            foreach (var item in inputText)
            {
                bool result = int.TryParse(item, out int temp);

                if (!result)
                {
                    return false;
                }
            }  
            
            return true;            
        }

        static int[] ConvertToInt(string[] inputText)
        {
            var intArray = new int[inputText.Length];

            for (int i = 0; i < inputText.Length; i++)
            {
                intArray[i] = int.Parse(inputText[i]);
            }
            return intArray;
        }

        static string Calculation(int[] inputNumber)
        {
            var sum = "";
            var subtraction = "";
            var multiplication = "";
            var division = "";
            var surplus = "";

            if (inputNumber[1] == 0)
            {
                sum = Sum(inputNumber).ToString();
                subtraction = Subtraction(inputNumber).ToString();
                multiplication = Multiplication(inputNumber).ToString();
                division = $"0じょさんえらーです。結果は {Division(inputNumber)} です。";
                surplus = $"0じょさんえらーです。結果は {Surplus(inputNumber)} です。";

                return sum +"\n" + subtraction + "\n" + multiplication + "\n" + division + "\n" + surplus;
            }

            sum = Sum(inputNumber).ToString();
            subtraction = Subtraction(inputNumber).ToString();
            multiplication = Multiplication(inputNumber).ToString();
            division = Division(inputNumber).ToString();
            surplus = Surplus(inputNumber).ToString();

            return sum + "\n" + subtraction + "\n" + multiplication + "\n" + division + "\n" + surplus;
        }

        static int Sum(int[] inputNumber)
        {
            var sum = inputNumber[0]+inputNumber[1];
            return sum;
        }

        static int Subtraction(int[] inputNumber)
        {
            var subtraction = inputNumber[0]-inputNumber[1];
            return subtraction;
        }

        static int Multiplication(int[] inputNumber)
        {
            var multiplication = inputNumber[0]*inputNumber[1];
            return multiplication;
        }

        static int Division(int[] inputNumber)
        {
            if (inputNumber[1] == 0)
            {
                return 0;
            }
            var division = inputNumber[0]/inputNumber[1];
            return division;
        }

        static int Surplus(int[] inputNumber)
        {
            if (inputNumber[1] == 0)
            {
                return 0;
            }
            var Surplus = inputNumber[0]%inputNumber[1];
            return Surplus;
        }
    }
}
