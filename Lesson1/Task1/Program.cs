Console.Clear();

Console.Write("Введите первое число <- ");
string number1 = Console.ReadLine();
Console.Write("Введите второе число <- ");
string number2 = Console.ReadLine();

int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);

if (num1 > num2)
{
    Console.WriteLine($"{num1} больше чем {num2}");
}
else if (num1 == num2)
{
    Console.WriteLine($"{num2} равно {num1}");
}
else
{
    Console.WriteLine($"{num2} больше чем {num1}");
}