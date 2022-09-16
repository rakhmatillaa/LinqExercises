class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("abc");
        list.Add("qwe");
        list.Add("abc");
        list.Add("jkl");
        list.Add("zxc");
        list.Add("abc");
        list.Add("jkl");

        var correctedList = list.Distinct().ToList();

        foreach(var item in correctedList)
        {
            Console.WriteLine(item);
        }

    }
}
