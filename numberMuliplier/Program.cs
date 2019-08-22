﻿using System;
using System.Collections.Generic;

namespace numberMuliplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersList = "1,2,3,4,5";

            var newNums = numbersList.Split(",");

            Console.WriteLine("Do you want to multiply or square the numbers? Door '1' or '2'(press the number and return key)?");
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
                List<int> newList = new List<int>();

                foreach (string num in newNums)
                {
                    var intNum = int.Parse(num);

                    var sum = intNum * intNum;

                    newList.Add(sum);
                }

                newList.ForEach(Console.WriteLine);
            }
        }
    }
}
