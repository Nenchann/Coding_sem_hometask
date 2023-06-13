Console.Clear();

Console.Write("Введите число для проверки <- ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 2) 
{
    System.Console.WriteLine("None");
}
else
{
    int current = 2;
    while (current <= num)
    {
        System.Console.Write($"{current} ");
        current += 2;
    }
}
