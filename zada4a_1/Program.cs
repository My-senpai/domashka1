// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Vvedi dva chisla");
string numberSTR1 = Console.ReadLine() ??"";
string numberSTR2 = Console.ReadLine() ??"";
int number1 = int.Parse(numberSTR1);
int number2 = int.Parse(numberSTR2);
Console.Write($"Большее число из {number1} и {number2}, это ");
if (number1 > number2)
{
    Console.Write(number1);
}
else
{
    Console.Write(number2);
}