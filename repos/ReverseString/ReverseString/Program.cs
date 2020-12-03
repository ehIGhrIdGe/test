using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = "";

            do
            {
                Console.WriteLine();
                Console.WriteLine("plese write");
                inputText = Console.ReadLine();

                var largeText = inputText.ToUpper();
                var lowerText = inputText.ToLower();

                Console.WriteLine();
                Console.WriteLine(largeText);
                Console.WriteLine(lowerText);

                var reverseText = "";
                               
                for (var i = 1; i <= inputText.Length; i++)
                {
                    //文字列の末尾から代入するために、1ずつ引いている
                    reverseText = reverseText + inputText.Substring(inputText.Length - i, 1);
                }

                Console.WriteLine(reverseText);

                Console.WriteLine();
                var resultText = "";
                var upChar = "";
                var lowChar = "";
                var tempChar = "";
                for (var i = 0; i < inputText.Length; i++)
                {
                    //一文字を一時的に記憶させるため
                    tempChar = inputText.Substring(i, 1);
                    upChar = tempChar.ToUpper();
                    lowChar = tempChar.ToLower();

                    //記憶させた一文字が大文字か小文字かを判断するため
                    if (upChar.CompareTo(tempChar) != 0)
                    {
                        resultText = resultText + upChar;
                    }
                    else
                    {
                        resultText = resultText + lowChar;
                    }
                }
                Console.WriteLine(resultText);

            }
            while (inputText != "");

            Console.WriteLine("end");

        }
    }
}
