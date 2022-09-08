// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введи число: ");
int random = Convert.ToInt32(Console.ReadLine());
string randomNum = Convert.ToString(random);
if (randomNum.Length > 2)
{
    Console.WriteLine("третья цифра -> " + randomNum[2]);
}
else
{
    Console.Write("-> третьей цифры нет");
}
