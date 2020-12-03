using System;
using System.Dynamic;
using System.Linq;

public class TestClass
{ }
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plese write");
            String inputTxet = Console.ReadLine();

            var largeText = inputTxet.ToUpper();
            var lowerText = inputTxet.ToLower();

            Console.WriteLine();
            Console.WriteLine(largeText);
            Console.WriteLine(lowerText);

            var reverseText = "";

            var i = inputTxet.Length;
            for (i = 1; i <= inputTxet.Length; i++)
            {
                reverseText = reverseText + inputTxet.Substring(inputTxet.Length - i,1);
            }

            Console.WriteLine(reverseText);
        }
    }
}
