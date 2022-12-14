// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = GetRandomArray(10);
PrintArray(array, "Массив");
int sum = SumNumbersOfArray(array);
Console.WriteLine(sum);




int SumNumbersOfArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}



int[] GetRandomArray (int size)
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