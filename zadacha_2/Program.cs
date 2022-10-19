// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите три числа");
string num1str = Console.ReadLine() ??"";
string num2str = Console.ReadLine() ??"";
string num3str = Console.ReadLine() ??"";


int num1 = int.Parse(num1str);
int num2 = int.Parse(num2str);
int num3 = int.Parse(num3str);
int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine($"максимальное {max}");