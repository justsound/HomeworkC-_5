Console.Clear();

// // Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
/* double InputSome(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine()!);
}
double a = InputSome($"Введите число k1 из уравнения  y = k1 * x + b1");
double c = InputSome($"Введите число b1 из уравнения  y = k1 * x + b1");
Console.WriteLine($"y = {a} * x + {c};");
double b = InputSome($"Введите число k2 из уравнения  y = k2 * x + b2");
double d = InputSome($"Введите число b2 из уравнения  y = k2 * x + b2");
Console.WriteLine($"y = {b} * x + {d};");
if (a == b) Console.WriteLine("Прямые параллельны");
else
{
    double x = (d - c) / (a - b);
    double y = a * x + c;
    Console.WriteLine($"Координаты точки пересечения: х = {x}, y = {y}");
}
 */

// Показать числа Фибоначчи
/* Console.WriteLine("Введите значение до какого выводить числа: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
array[0] = 0;
array[1] = 1;
int i = 0;
while (i < size)
{
    if ((i == 1) || (i == 0)) i++;
    else 
    {
        array[i] = array[i - 1] + array[i - 2]    ;
       i++; 
    }
}

Console.WriteLine(string.Join(" ", array));
Console.WriteLine();
 */


// Написать программу масштабирования фигуры

int[] CreateArray(int size, int leftside, int rightside)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i ++)
        array[i] = new Random().Next(leftside, rightside);
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"({array[0]}, ");
    for (int i= 1; i < array.Length; i++)
    {
        if (i % 2 == 1) Console.Write ($"{array[i]})");
        if ( i % 2 == 0) Console.Write($"( {array[i]}, ");


    }
}
Console.WriteLine("Введите количество точек: ");
int count = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент масштабирования");
int k = int.Parse(Console.ReadLine()!);

int[] arr = CreateArray(count * 2, 0, 100);

PrintArray(arr);
void ChangeArray(int[] array, int k)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * k;
    }
}
Console.WriteLine();
ChangeArray(arr, k);
PrintArray(arr);
Console.WriteLine();
// Написать программу копирования массива
/* Console.WriteLine("Введите размер массива: ");
int[] CreateArray(int size, int leftside, int rightside)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i ++)
        array[i] = new Random().Next(leftside, rightside);
    return array;
}
int size = int.Parse(Console.ReadLine()!);
int[] arr = CreateArray(size, -100, 100);
Console.WriteLine(String.Join(", ", arr));
Console.WriteLine();
int[] copy = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    copy[i] = arr[i];
}
Console.WriteLine(String.Join(", ", copy)); */

// Вариант 2

/* int size = new Random().Next(10);
string[] arr = new string[size];
Console.WriteLine(size);
for (int i = 0; i < size; i ++)
{
    arr[i] = Console.ReadLine()!;
}
// for (int i = 0; i < size; i ++) Console.WriteLine(arr[i]);
string[] copy = new string[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    copy[i] = arr[i];
    Console.Write($"{copy[i]}, ");
}
Console.WriteLine(); */
