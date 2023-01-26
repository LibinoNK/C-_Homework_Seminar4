/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

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

int A = inputNumber("Введите число А: ");
int B = inputNumber("Введите число В: ");

int Degree(int number, int deg)
{
    int result = 1;
    for (int i = 1; i <= deg; i++)
    {
        result *= number;
    }
    return result;
}

System.Console.WriteLine(Degree(A, B));