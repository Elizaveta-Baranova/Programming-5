// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите количество элементов в масиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [n];
int index = 0;
int sum = 0;
for (int i = 0; i < n; i++)
{
    numbers[i] = new Random().Next(99, 1000);
    Console.Write(numbers[i] + " ");
    
}
for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] % 2 != 0)
{
    sum = sum + numbers[z];
    index++;
}
}
Console.WriteLine();
Console.WriteLine($"Сумма нечетных чисел равна {sum}.");