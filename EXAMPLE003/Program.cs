// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели в дипазоне 1-7");

int numberOfDay = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(numberOfDay);
void WeekTester(int value)
{
    if (value < 1 || value > 7)
    {
        Console.WriteLine("введено неверное значение");
    }
    else if (value == 6 || value == 7)
    {
        Console.WriteLine("это выходной день");
    }
    else
    {
        Console.WriteLine("это рабочий день");
    }

}
WeekTester(numberOfDay);