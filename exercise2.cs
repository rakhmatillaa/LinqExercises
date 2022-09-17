using System;
using System.Linq;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        List<string> wordList = new List<string>() { "ferry", "car", "plane", "bike", "programming", };
        Console.WriteLine("Words before alphabetical sorting:");

        foreach(string word in wordList)
        {
            Console.Write(word+" ");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Words after alphabetical sorting:");

        wordList.Sort((x, y) => string.Compare(x, y));
        
        foreach(string word in wordList)
        {
            Console.Write(word+" ");
        }
        Console.WriteLine("\n");

        foreach(var word in wordList)
        {
            if (word.Contains("e"))
            {
                Console.WriteLine(word);
            }
            else
            {
                continue;
            }
            
        }
    }
}
