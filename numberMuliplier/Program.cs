using System;
using System.Collections.Generic;

namespace numberMuliplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter some numbers seperated by only commas");
            var numbersList = Console.ReadLine();

            var newNums = numbersList.Split(",");

            Console.WriteLine("Do you want to multiply or square the numbers? Press '1' or '2' (then press enter)?");
            var UserInput = Console.ReadLine();

            Console.WriteLine(" You entered: " + UserInput);

            if (UserInput == "1")
            {
                int sum = 1;

                foreach (string num in newNums)
                {
                    var intNum = int.Parse(num);
                    sum = sum * intNum;
                }
                Console.WriteLine("The Sum total of each number multiplied is " + sum);
            }
            else if (UserInput == "2")
            {
                List<string> newList = new List<string>();
                foreach (string num in newNums)
                {
                    var intNum = int.Parse(num);
                    var sum = intNum * intNum;
                    string stngNum = sum.ToString();

                    newList.Add(stngNum);
                    newList.Add(",");
                }
                newList.ForEach(Console.Write);
            }
        }
    }
}
