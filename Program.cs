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