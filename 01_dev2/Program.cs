// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1-возрастания
// 2-элементы, больше 8
// 3-знакочередования

//Console.ReadLine()


int n = 20;                                         // размер массива
int[] arrayA = new int[n];                          // объявление массива


void FillArray(int[] array)                         // метод заполнения массива
{
    for (int i = 0; i < n; i++)                     // количество элементов n, для каждого элемента:
    {
        arrayA[i] = new Random().Next(-100, 101);   // выбирается случайное число из диапазона от -100 до 100 включительно
    }
}

void PrintArray(int[] arr)                          // метод для вывода массива на печать
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine(); Console.WriteLine();
}

FillArray(arrayA);
Console.WriteLine(); Console.WriteLine($"Массив A из {(n)} случайных чисел из диапазона от -100 до 100 включительно:");
PrintArray(arrayA);

// Элементы массива А, не нарушающие порядок чередования

int current = arrayA[0];
System.Console.WriteLine("Элементы массива А, не нарушающие порядок чередования:");
System.Console.Write($"{current} ");
for (int i = 1; i < n; i++)
{
    if (arrayA[i] > current)
    {
        current = arrayA[i];
        System.Console.Write(current + " ");
    }
}
Console.WriteLine(); Console.WriteLine();

