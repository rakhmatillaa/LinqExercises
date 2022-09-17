class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List() { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };

        var correctedList = list.Distinct().ToList();

        foreach(var item in correctedList)
        {
            Console.WriteLine(item);
        }
    }
}
