//Петросян 4,1 средний уровень 22-Исп-2/1 
int[] a = new int[10];
int sum = 0, count = 0;
Console.WriteLine("Введит числа в массив:");
for (int i = 0; i < 10; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}
foreach (int i in a)
{
    if (i > 0)
    {
        count++;
        sum = sum + a[i];
    }
    else break;
}

Console.WriteLine($"Cумма элементов до отрицательного:{sum}");
Console.WriteLine($"Кол-во элементов до отрицательного:{count}");