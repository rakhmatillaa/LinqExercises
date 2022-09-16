using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
     List<int> numberList=new List<int>();
        numberList.Add(1);
        numberList.Add(-34);
        numberList.Add(32);
        numberList.Add(16);
        numberList.Add(0);
        numberList.Add(67);
        numberList.Add(-4);

        var sortedNumbers = numberList.OrderBy(x => x);

        foreach (int number in sortedNumbers)
            Console.WriteLine(number);
    }
}
