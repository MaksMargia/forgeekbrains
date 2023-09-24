Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int num2 = int.Parse(Console.ReadLine());
if(num1 > num2)
{
Console.WriteLine("Первое число больше второго");
}

else if (num1 < num2)
{
Console.WriteLine("Второе число больше первого");
}

else
{
Console.WriteLine("Числа равны");
}
Console.ReadKey();