// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Привет!");
Console.WriteLine("Давай знакомиться? Как твоё имя?");
String username = Console.ReadLine();
Console.WriteLine($"Хорошо, {username}!");
Console.WriteLine($"{username}, если введёшь трёхзначное число, я покажу вторую цифру этого числа :)");
Console.WriteLine($"Если готов {username}, то вводи цифру: ");
int threeDigit = Convert.ToInt32(Console.ReadLine());
string stringNum = Convert.ToString(threeDigit);
Console.WriteLine("вторая цифра этого числа -> " + stringNum[1]);