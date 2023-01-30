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


// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

// Написать программу копирования массива