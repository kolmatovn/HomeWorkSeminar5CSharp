// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] startArray = GetArray(5, -100, 100);
Console.WriteLine(String.Join(" ", startArray));
GetSumOddNumbers(startArray);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void GetSumOddNumbers(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
            sumOdd += array[i];
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в массиве = {sumOdd}");
}