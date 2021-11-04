// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1-возрастания
// 2-элементы, больше 8
// 3-знакочередования

//Console.ReadLine()


int n = 25;
int[] arrayA = new int[n];


void FillArray(int[] array)
{
    for (int i = 0; i < n; i++)
    {
        arrayA[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();Console.WriteLine();
}


FillArray(arrayA);
Console.WriteLine();Console.WriteLine($"Массив A из {(n)} случайных чисел из диапазона от -100 до 100 включительно:");
PrintArray(arrayA);