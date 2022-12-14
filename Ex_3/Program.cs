// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = GetRandomArray(10);
PrintArray(array, "Массив");
int max = MaxNumberOfArray(array);
int min = MinNumberOfArray(array);
Console.WriteLine($"Максимальное: {max}, Минимальное: {min}, Разница:  {max-min}");


int MaxNumberOfArray(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int MinNumberOfArray(int[] array)
{
    int min = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


int[] GetRandomArray(int size)
{
    Random random = new Random();


    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        int randomNumber = random.Next(0, 100);
        randomArray[i] = randomNumber;
    }

    return randomArray;
}

void PrintArray(int[] array, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}