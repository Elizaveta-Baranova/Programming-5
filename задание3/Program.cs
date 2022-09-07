// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

Console.Write("Введите количество элементов в масиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [n];
int max = numbers[0];
int min = numbers[0];
for (int i = 0; i < n; i++)
{
    numbers[i] = new Random().Next(1, 100);
    Console.Write(numbers[i] + " ");
    
}
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
{
    max = numbers[i];
}
if (numbers[i] <= numbers[0])
{
    min = numbers[i];
}
else
{
    min = numbers[0];
}
}

Console.WriteLine();
Console.WriteLine($"Максимальное число равно {max}, а минимальное - {min}.");
Console.WriteLine($"Разницу между максимальным и минимальным элементами массива равна {max - min}");