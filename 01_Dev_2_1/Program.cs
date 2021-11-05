// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
// Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1-возрастания; 2-элементы, больше 8; 3-знакочередования

Console.Clear();
System.Console.WriteLine();
// входные данные

int n = 10;
int k = 8;
int[] arrayA = new int[n];
int[] arrayB = new int[n];
string txtArray = $"Массив A из {n} случайных чисел из диапазона от -50 до 100 включительно:";
string txtAscending = "Массив В из элементов массива А, не нарушающих порядок чередования:";
string txtMoreThan = $"Массив В из элементов массива А, которые больше {k}:";
string txtAlterSign = "Массив В из элементов массива А, не нарушающих порядок знакочередования:";

// создание  и печать массива А

void FillArray(int[] array)
{
    for (int j = 0; j < n; j++)
    {
        arrayA[j] = new Random().Next(-50, 101);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine(); Console.WriteLine();
}

Console.WriteLine(txtArray);

FillArray(arrayA);
PrintArray(arrayA);

// элементы, не нарушающие порядок возрастания

System.Console.WriteLine(txtAscending);

int j = 0;
int current = arrayA[0];
System.Console.Write($"{current} ");
for (int i = 1; i < arrayA.Length; i++)
{
    if (arrayA[i] > current)
    {
        current = arrayA[i];
        arrayB[j++] = current;
    }
}
n = j;

PrintArray(arrayB);

// элементы, значение которых больше k

System.Console.WriteLine(txtMoreThan);
j = 0;
for (int i = 0; i < arrayA.Length; i++)
{
    if (arrayA[i] > k) arrayB[j++] = arrayA[i];
}
n = j;

PrintArray(arrayB);

// элементы, не нарушающие порядок знакочередования

System.Console.WriteLine(txtAlterSign);

int curr = arrayA[0];
j = 0;
System.Console.Write($"{curr} ");
for (int i = 1; i < arrayA.Length; i++)
{
    if (curr >= 0 && arrayA[i] < 0)
    {
        curr = arrayA[i];
        arrayB[j++] = curr;
    }
    else
    {
        if (curr < 0 && arrayA[i] >= 0)
        {
            curr = arrayA[i];
            arrayB[j++] = curr;
        }
    }
}
n = j;
PrintArray(arrayB);

System.Console.WriteLine();