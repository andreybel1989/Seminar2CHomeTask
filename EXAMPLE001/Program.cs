// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine();


int TestNumber(string num)

{    
    if (num[0] == '-')
    {
        num = num.Substring(1);
    }
    int value;
    bool isNumber = int.TryParse(num, out value);
    
    if (isNumber == false ||  num.Length != 3)
    {
        value = -1;
    }
    
    return value;
}

int? CreatSecondNumber(int? number, string value)
{
    if(number != -1)
    {
        Console.Write($"Во втором рязряде числа {value} стоит значение равное ");
        number = number/10%10;
        
    }
    else
    {
        Console.WriteLine("Вы ввели неверное число");
        number = null;
    }
    
    return number;
}

Console.WriteLine(CreatSecondNumber(TestNumber(number), number));
