// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputNumber(string text)
{
    System.Console.Write(text);
    string value = Console.ReadLine();
    int n = Convert.ToInt32(n);
    return n;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNumber($"A[{i}] = ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"A[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    return count;
    }
}

int len = InputNumber("Введите количество чисел =");
int[] massiv;
massiv = InputArray(len);
PrintArray(massiv);
Console.WriteLine($"Количество чисел больше 0 {CountPositiveNumbers(massiv)}");

