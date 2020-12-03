using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace NumberPlate
{
    class Program
    {
        static string sText;
        static string message;

        static void Main()
        {
            Input input = new Input();
            message = "これはコンソール電卓アプリです。\nスペース区切りで数字・演算子を入力してください。\n\n右に数式を入力：";

            Console.Write(message);
            sText = Console.ReadLine();

            
            input.Main(sText);
        }
    }
}
