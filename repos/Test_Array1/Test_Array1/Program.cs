using System;
using System.Linq;

namespace Test_Array1
{
    class Program
    {
        static void Main(string[] args)
        {

            //var intArray = new int[100];

            //for (var index = 0; index < intArray.Length; index++)
            //{
            //    intArray[index] = (index + 1) * (index + 1);
            //}


            //----------------配列演習（0未満100以上不正版）----------------//
            //var strStart = "";
            //var intStart = -1;
            //var result = int.TryParse(strStart, out intStart);

            ////startが数値がどうかを判断するため
            //while(result != true || intStart < 0 || intStart >= 100)
            //{
            //    Console.Write("Type to start IndexNumber : ");
            //    strStart = Console.ReadLine();
            //    result = int.TryParse(strStart, out intStart);
            //    if(result != true || intStart < 0 || intStart >= 100)
            //    {
            //        Console.WriteLine("startが不正です");
            //    }
            //}

            //var strCount = "";
            //var intCount = -1;
            //result = int.TryParse(strCount, out intCount);

            ////countが数値かどうかを判断するため
            //while (result != true || intCount < 0 || intCount >= 100)
            //{
            //    Console.Write("Type to start CountNumber : ");
            //    strCount = Console.ReadLine();
            //    result = int.TryParse(strCount, out intCount);
            //    if (result != true || intCount < 0 || intCount >=100)
            //    {
            //        Console.WriteLine("countが不正です");
            //    }
            //}

            //int sum = intArray[intStart] + intArray[intStart + intCount];
            //Console.WriteLine(sum);


            //----------------配列演習（100以上有効版）----------------//            
            //var strStart = "";
            //var intStart = -1;
            //var result = int.TryParse(strStart, out intStart);

            ////startが数値がどうかを判断するため
            //while (result != true || intStart < 0)
            //{
            //    Console.Write("Type to start IndexNumber : ");
            //    strStart = Console.ReadLine();
            //    result = int.TryParse(strStart, out intStart);
            //    if (result != true || intStart < 0)
            //    {
            //        Console.WriteLine("startが不正です");
            //    }
            //    else if (intStart >= 100)
            //    {
            //        intStart = intStart % 100;
            //    }
            //}

            //var strCount = "";
            //var intCount = -1;
            //result = int.TryParse(strCount, out intCount);

            ////countが数値かどうかを判断するため
            //while (result != true || intCount < 0)
            //{
            //    Console.Write("Type to start CountNumber : ");
            //    strCount = Console.ReadLine();
            //    result = int.TryParse(strCount, out intCount);
            //    if (result != true || intCount < 0)
            //    {
            //        Console.WriteLine("countが不正です");
            //    }
            //    else if (intCount >= 100)
            //    {
            //        intCount = intCount % 100;
            //    }
            //}

            //int sum = intArray[intStart] + intArray[intStart + intCount];
            //Console.WriteLine(sum);


            //----------------発展演習----------------//  
            var inputText = "";
            var splitText = inputText.Split(" ");
            var arrayNumbers = new int[splitText.Length];
            var chkNumResult = false;

            //何も入力がなかったり、数値以外が入力されたらループさせるため
            while(inputText == "" || chkNumResult != true)
            {
                Console.Write("\n\nPlease input number(Half-width space separator) : ");
                inputText = Console.ReadLine();

                if(inputText == "")
                {                    
                    Console.WriteLine("テキストが空白です。数字を入力してください");
                }
                else
                {
                    splitText = inputText.Split(" ");
                    arrayNumbers = new int[splitText.Length];

                    for (var i = 0; i < splitText.Length; i++)
                    {                                               
                        chkNumResult = int.TryParse(splitText[i],out arrayNumbers[i]);
                        if(chkNumResult != true)
                        {
                            Console.WriteLine("数値を入力してください。");
                            break;
                        }
                    }
                }
            }

            foreach (var item in arrayNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var tempNum = 0;
            var minNumIndex = 0;
            var resultNum = new int[splitText.Length];

            
            for (int i = 0; i < splitText.Length; i++)
            {
                //最小の値を移動させるための仮の箱を作り、仮の箱に値を代入するため
                var tempArrNum = new int[arrayNumbers.Length];
                for (int n = 0; n < arrayNumbers.Length; n++)
                {
                    tempArrNum[n] = arrayNumbers[n];
                }

                //tempNum の中で、最小の値を配列の「0番目」に移動させるため
                minNumIndex = Array.IndexOf(tempArrNum, tempArrNum.Min());
                if (minNumIndex != 0)
                {
                    while (minNumIndex != 0)
                    {
                        tempNum = tempArrNum[minNumIndex];
                        tempArrNum[minNumIndex] = tempArrNum[minNumIndex - 1];
                        tempArrNum[minNumIndex - 1] = tempNum;
                        minNumIndex = Array.IndexOf(tempArrNum, tempArrNum.Min());
                    }                    
                }
                resultNum[i] = tempArrNum[minNumIndex];

                //arrayNumbers の配列数を1減らすため
                arrayNumbers = new int[tempArrNum.Length -1];
                for (int n = 0; n < arrayNumbers.Length; n++)
                {
                    arrayNumbers[n] = tempArrNum[n + 1];
                }

                Console.WriteLine(resultNum[i]);
            }
        }
    }
}
