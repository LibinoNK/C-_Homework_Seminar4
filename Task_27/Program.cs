/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено не корректное число, попробуйте еще раз!");
    }
    return number;
}

int num = inputNumber("Введите число: ");

int Sum(int number)
{
    int sum = 0;
    int lastNum;
    while (number / 10 > 0 || number % 10 > 0)
    {
        lastNum = number % 10;
        number /= 10;
        sum += lastNum;
    }
    return sum;
}

int result = Sum(num);
System.Console.WriteLine($"Сумма цифр числа {num} равна {result}");