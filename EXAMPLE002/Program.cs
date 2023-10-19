// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string value = Console.ReadLine();

int TestValue (string num)
{
    if (num[0] == '-')
    {
        num = num.Substring(1);
    }
    int value;
    bool isNumber = int.TryParse(num, out value);
    
    if (isNumber == false )
    {
        value = -1;
    }
    
    return value;
}

void CreateThridNumber(int resultTestValue)
{
    if (resultTestValue == -1)
    {
        Console.WriteLine("вы ввели не число");
    }
    
    else if (resultTestValue < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        for(; resultTestValue >= 1000 ;)
        {
            resultTestValue /= 10;
        }
        Console.WriteLine($"третья цифра равна {resultTestValue % 10}");
    }

}
CreateThridNumber(TestValue(value));