string[] FillArray()
{
Console.WriteLine("Заполните массив по порядку");
string[] Array = new string[5];
for(int i = 0; i<5; i++ )
{
    Array[i] = Console.ReadLine()!;
}
return Array;
}

string[] Array = FillArray();
Console.WriteLine("Начальный массив:");
Console.WriteLine($"[{String.Join(",", Array)}]");

string[] ChangeArray(string[] Array)
{   
    int num = 0;
    for(int i = 0; i<5; i++ )
{
    if(Array[i].Length<=3)
    {
        num++;
    }
}
    string[] NewArray = new string[num];
    int k = 0;
    for(int i = 0; i<5; i++)
    {
        if(Array[i].Length <= 3)
        {
            NewArray[k] = Array[i];
            k++;
        }
    }
    return NewArray;
}

Console.WriteLine("Обработанный массив:");
Console.WriteLine($"[{String.Join(",", ChangeArray(Array))}]");