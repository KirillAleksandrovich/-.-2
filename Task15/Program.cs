// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void DaysOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("(Выходной, иди отдыхай.) -> да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Такого деня недели, не существует");
    }
    else Console.WriteLine("(Это не выходной день!) -> нет");
}

DaysOfTheWeek(dayNumber);
