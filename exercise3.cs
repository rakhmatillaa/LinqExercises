using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    { 
     List<int> numberList=new List<int>() {1,-34,32,16,0,67,-4};
        
        var sortedNumbers = numberList.OrderBy(x => x);
        
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
        
    }
}
