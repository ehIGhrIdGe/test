using System;

namespace testtet
{
    class Program
    {
        static void Main(string[] args)
        {

            //String[] line = System.Console.ReadLine().Trim().Split(' ');
            //var cash = int.Parse(line[0]);
            //var times = int.Parse(line[1]);
            //var intFee = new int[times];
            //var point = 0;

            //for (var i = 0; i < times; i++)
            //{
            //    var strFee = System.Console.ReadLine().Trim();
            //    intFee[i] = int.Parse(strFee);

            //    if (intFee[i] <= point)
            //    {
            //        point = point - intFee[i];
            //    }
            //    else
            //    {
            //        point = point + intFee[i] / 10;
            //        cash = cash - intFee[i];
            //    }

            //    System.Console.WriteLine($"{cash} {point}");
            //}


            //String[] line = System.Console.ReadLine().Trim().Split(' ');
            //String[] strFee = System.Console.ReadLine().Trim().Split(' ');
            //var cash = int.Parse(line[0]);
            //var times = int.Parse(line[1]);

            //var intFee = new int[times];
            //var point = 0;

            //for (var i = 0; i < times; i++)
            //{
            //    intFee[i] = int.Parse(strFee[i]);

            //    if (intFee[i] <= point)
            //    {
            //        point = point - intFee[i];
            //    }
            //    else
            //    {
            //        point = point + intFee[i] / 10;
            //        cash = cash - intFee[i];
            //    }

            //    System.Console.WriteLine($"{cash} {point}");
            //}


            //string[] line = System.Console.ReadLine().Trim().Split(' ');
            //var cash = int.Parse(line[0]);
            //var times = int.Parse(line[1]);
            //var intFee = new int[times];
            //var point = 0;

            //for (var i = 0; i < times; i++)
            //{
            //    var strFee = System.Console.ReadLine().Trim();
            //    intFee[i] = int.Parse(strFee);

            //    if (intFee[i] <= point)
            //    {
            //        point = point - intFee[i];
            //    }
            //    else
            //    {
            //        point = point + intFee[i] / 10;
            //        cash = cash - intFee[i];
            //    }

            //    System.Console.WriteLine(cash);
            //}


            var src = new int[] { 1, 2, 3 };
            int[] dest;

            dest = src;

            for(var i = 0; i < dest.Length; i++)
            {
                Console.WriteLine($"dest[{i}] => {dest[i]}");
            }

            dest[0] = 0;


            for (var i = 0; i < dest.Length; i++)
            {
                Console.WriteLine($"\nsrc[{i}] => {src[i]}");
            }

            for (var i = 0; i < dest.Length; i++)
            {
                Console.WriteLine($"\ndest[{i}] => {dest[i]}");
            }




        }
    }
}
