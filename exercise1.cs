using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string str;
        Console.WriteLine("Enter the words: ");
        str = Console.ReadLine();

        var output = PrintingUpperCase(str);
        
        foreach (string u in output)
        {
            Console.WriteLine(u);
        }
        
        Console.ReadLine();
    }
    
    static IEnumerable<string> PrintingUpperCase(string mystr)
    {
        var words = mystr.Split(' ')
                    .Where(u => String.Equals(u, u.ToUpper(),
                    StringComparison.Ordinal));

        return words;
    }
}
