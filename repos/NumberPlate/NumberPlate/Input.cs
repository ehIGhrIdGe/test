using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;


namespace NumberPlate
{
    class Input
    {
        public string errorMessage;       
        public string[] operators;
        public string[] aText;
        public int[] numbers;
        public char[] spChar;
        public int nIndex;
        public int totalAmount;


        //メインの処理
        public void Main(string in_sText)
        {

            TextToArray(in_sText);

            if (!CheckTextLength(aText))
            {

                return;

            }
            
            if(!CheckText(aText))
            {

                return;

            }

            numbers = ToArrayNumber(in_sText);
            operators = ToArrayOperator(in_sText);

            Calculation(numbers, operators);

            Console.WriteLine("\n\n計算結果は「" + totalAmount.ToString() +  "」です。");

        }


        //入力された式全体の文字列を判定
        private bool CheckTextLength(string[] in_aText)
        {

            nIndex = in_aText.Length;

            if (nIndex % 2 != 1)
            {

                errorMessage = "入力された式は不正です。";
                Console.WriteLine(errorMessage);
                return false;

            }

            return true;

        }


        //入力された式を半角スペース区切りで格納
        private string[] TextToArray (string in_sText)
        {

            aText = in_sText.Split(' ');

            return aText;
        }


        //配列に格納した式をチェックする
        private bool CheckText(String[] in_aText)
        {

            spChar = new char[] { '+', '-', '*', '/' };

            //数字部分を判定
            for (nIndex = 0; nIndex < in_aText.Length; nIndex = nIndex + 2)
            {

                if (!int.TryParse(in_aText[nIndex], out int result))
                {

                    //文字が入っていた場合の厳密な原因を表示
                    foreach (char element in spChar)
                    {

                        if (in_aText[nIndex] == element.ToString())
                        {

                            errorMessage = "\n\n「" + in_aText[nIndex] + "」は演算子です。\n正しい数値を入れてください。";
                            Console.WriteLine(errorMessage);

                        }
                        else
                        {

                            errorMessage = "\n\n「" + in_aText[nIndex] + "」は文字列です。\n正しい数値を入れてください。";
                            Console.WriteLine(errorMessage);

                        }

                        return false;

                    }

                }

            }

            //演算子部分を判定
            for (nIndex = 1; nIndex < in_aText.Length; nIndex = nIndex + 2)
            {
                
                switch (in_aText[nIndex])
                {

                    case "+":
                        break;

                    case "-":
                        break;

                    case "*":
                        break;

                    case "/":
                        break;
                    default:
                        errorMessage = "「\n\n{element}」は演算子ではありません。\n正しい演算子を入れてください。";
                        Console.WriteLine("{errorMessage}");
                        return false;
                        
                }

            }

            return true;

        }


        //文字列の数字をint型に変換し、配列に格納
        private int[] ToArrayNumber(string in_sText)
        {

            nIndex = 0;
            spChar = new char[] { '+', '-', '*', '/' };

            string[] numText = in_sText.Split(spChar);

            numbers = new int[numText.Length];

            foreach (string txtNumber in numText)
            {

                numbers[nIndex] = int.Parse(txtNumber);
                nIndex++;

            }

            return numbers;

        }


        //文字列の演算子を演算子用配列に格納
        private string[] ToArrayOperator(string in_sText)
        {

            nIndex = 0;
            string pattern = @"[ ]+";

            in_sText = Regex.Replace(in_sText, @"[\d]", "").Trim();
            string[] opText = Regex.Split(in_sText, pattern);

            operators = new string[opText.Length];

            foreach (string operation in opText)
            {

                operators[nIndex] = operation;
                nIndex++;

            }

            return operators;

        }


        //実際の計算処理
        private int Calculation(int[] in_Numbers, string[] in_Operators)
        {

            totalAmount = numbers[0];

            foreach (int number in in_Numbers)
            {
                foreach(string operation in in_Operators)
                {
                    switch (operation)
                    {

                        case "+":
                            totalAmount = totalAmount + number;
                            break;

                        case "-":
                            totalAmount = totalAmount - number;
                            break;

                        case "*":
                            totalAmount = totalAmount * number;
                            break;

                        case "/":
                            totalAmount = totalAmount / number;
                            break;

                    }
                    break;
                }
            }

            return totalAmount;

        }

    } 

}