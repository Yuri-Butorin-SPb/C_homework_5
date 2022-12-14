// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = GetRandomArray(10);
PrintArray(array, "Массив");
int evenSum = EvenNumberInArray(array);
Console.WriteLine(evenSum);


int EvenNumberInArray(int[]array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += 1;
        }
    }
    return sum;
}


int[] GetRandomArray (int size)
{
    Random random = new Random();
    

    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        int randomNumber = random.Next(100, 1000);
        randomArray[i] = randomNumber;
    }

    return randomArray;
}

void PrintArray(int[] array, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} - [ {str} ]");
}