// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Введите количество элементов в масиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [n];
int index = 0;
for (int i = 0; i < n; i++)
{
    numbers[i] = new Random().Next(99, 1000);
    Console.Write(numbers[i] + " ");
    
}
for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] % 2 == 0)
{
    index++;
}
}
Console.WriteLine();
Console.WriteLine($"Всего {numbers.Length} чисел, {index} из них чётные."); 