string[] input_array()
{
    string[] tmpArr = Array.Empty<string>();

    while (true)
    {
        string? s = Console.ReadLine();
        if (s.Length is null)
        {
            Console.WriteLine("Пустая строка");
            return tmpArr;
        }
        else
        {
            Array.Resize(ref tmpArr, tmpArr.Length + 1);
            tmpArr[tmpArr.Length - 1] = s;
            Console.WriteLine("Непустая строка");
        }
    }

}

string[] ss = input_array();
foreach (string s in ss)
{
    Console.WriteLine(s);
}