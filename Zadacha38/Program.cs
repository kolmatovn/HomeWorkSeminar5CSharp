// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());

int[] startArray = GetArray(length, min, max);
Console.WriteLine(String.Join(" ", startArray));
GetMaxMinDif(startArray, max, min);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random num = new Random();
    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
        res[i] = num.Next(minValue, maxValue + 1);
    }
    return res;
}

void GetMaxMinDif(int[] array, int minValueDif, int maxValueDif)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValueDif)
        {
            minValueDif = array[i];
        }
        if (array[i] > maxValueDif)
        {
            maxValueDif = array[i];
        }
    }
    Console.WriteLine($"Разница между Max и Min = {maxValueDif - minValueDif}");
}