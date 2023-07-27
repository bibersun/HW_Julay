string[] input_array()
{
    Console.WriteLine("Введите построчно значения ячеек массива, окончание ввода - Enter на пустой строке");
    string[] tmpArr = Array.Empty<string>();
    while (true)
    {
        string? sTmp = Console.ReadLine();
        string s = sTmp is null ? String.Empty : sTmp;
        if (s.Length == 0)
        {
            return tmpArr;
        }
        else
        {
            Array.Resize(ref tmpArr, tmpArr.Length + 1);
            tmpArr[tmpArr.Length - 1] = s;
        }
    }
}
string[] s = input_array();
Console.WriteLine("Введенный массив:");
string inputArr = "[\"" + string.Join("\", \"", s) + "\"]";
Console.WriteLine(inputArr);
string[] EndArray = Array.FindAll(s, x => x.Length <= 3);

Console.WriteLine("Итоговый массив:");
string strEndArr = "[\"" + string.Join("\", \"", EndArray) + "\"]";
Console.WriteLine(strEndArr);
