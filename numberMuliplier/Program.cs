using System;
using System.Collections.Generic;

namespace numberMuliplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersList = "1,2,3,4,5";

            var newNums = numbersList.Split(",");

            int sum = 1;

            foreach (string num in newNums)
            {
                Console.WriteLine(num);

                var intNum = int.Parse(num);
                sum += sum * intNum;
                Console.WriteLine(sum);
            }
            Console.WriteLine(sum);

            List<int> NumList = new List<int>();
            NumList.Add(1);
            NumList.Add(2);
            NumList.Add(3);
            NumList.Add(4);
            NumList.Add(5);
        }
    }
}
