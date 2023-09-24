Console.WriteLine("Введите первое число");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третьте число");
int num_3 = int.Parse(Console.ReadLine());
int Max = num_1;
if (num_2 > Max)
{
Max = num_2;
}

if (num_3 > Max)
{
Max = num_3;
}

Console.WriteLine("Максимальное число:" + Max);

Console.ReadKey();