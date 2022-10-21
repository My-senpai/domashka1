// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число");
string numberstr = Console.ReadLine() ??"";
int num = int.Parse(numberstr);

if (num % 2 == 0)
{
    Console.WriteLine($"число {num} делится без остатка");
}
else
{
    Console.WriteLine($"число {num} не делится без остатка");
}