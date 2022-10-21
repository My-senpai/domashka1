// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
string numberstr = Console.ReadLine() ??"";
int N = int.Parse(numberstr);
Console.WriteLine("Четные числа от 1 до " + N);
int i = 1;
bool not = true;

while (i <= N)
{
    if (i % 2 != 1)
    {
        Console.Write(i +" ");
        not = false;
    }
    i=i+1;
}
if (not)
    {
        Console.WriteLine("четных чисел нет");
    }