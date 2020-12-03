using System;

namespace Method_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var strEndNum = "";

            while(judgmentNum(strEndNum) < 0)
            {
                Console.Write("Please input Number");
                strEndNum = Console.ReadLine();

                Console.WriteLine(multiplicationTable_1(strEndNum));

                if(judgmentNum(strEndNum) < 0)
                {
                    Console.WriteLine("Please enter a number greater than 0");
                }
            }

            var end = judgmentNum(strEndNum);
            int[] reslut = multiplicationTable_2(end);
            foreach (var item in reslut)
            {
                Console.WriteLine(item);
            }

        }

        static bool multiplicationTable_1(string strEndNumber)
        {
            if(!int.TryParse(strEndNumber, out var endNumber))
            {
                return false;
            }

            if(endNumber < 0)
            {
                return false;
            }

            var resultNumber = new int[endNumber];

            for (int i = 0; i < endNumber; i++)
            {
                i = i * i; 
            }

            return true;
        }

        static int judgmentNum(string strEndNumber)
        {
            if (!int.TryParse(strEndNumber, out var endNumber))
            {
                return -1;
            }

            if (endNumber <= 0)
            {
                return -1;
            }

            return endNumber;
        }

        static int[] multiplicationTable_2(int endNumber)
        {
            int[] result = new int[endNumber * endNumber];
            var index = 0;

            for (int i = 1; i <= endNumber; i++)
            {
                for (int n = 1; n <= endNumber; n++)
                {
                    result[index] = i * n;
                    index++;
                }                
            }

            return result;
        }        
    }
}
