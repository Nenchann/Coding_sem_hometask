Console.Write("Введите число для проверки <- ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2 == 0) 
{
    System.Console.WriteLine($"Число {num} - чётное");
}
else
{
    System.Console.WriteLine($"Число {num} - нечётное");
}