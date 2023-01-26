/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Random rand = new Random();

int[] CreateArray()
{
    int[] numbers = new int[8];
    for (int i = 0; i < 8; i++)
    {
        int number = rand.Next(0, 101);
        numbers[i] = number;
    }
    return numbers;
}

int[] list = CreateArray();
System.Console.WriteLine(string.Join(", ", list));









//int result[] = CreateArray(numbers);
//System.Console.WriteLine(string.Join(", ", numbers));

/*Random rand = new Random();
int[] numbers = new int[8];


for (int i = 0; i < numbers.Length; i++)
{
    int number = rand.Next(0, 101);
    numbers[i] = number;
}

System.Console.WriteLine(string.Join(", ", numbers));*/