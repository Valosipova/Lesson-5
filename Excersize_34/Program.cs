//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] CreateRandomArray(int sizeArray, int start, int end)
{
    int[] randomArray = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        randomArray[i] = new Random().Next(start, end);
    }
    return randomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int AmountOfEvenNumbers(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
    }

    return result;
}

int[] threeDigitArray = CreateRandomArray(6, 100, 1000);
ShowArray(threeDigitArray);

int result = AmountOfEvenNumbers(threeDigitArray);
Console.WriteLine($"Количество чётных чисел в массиве = {result}");