/*  Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


Console.WriteLine("Введите количество строк:");
var linesVol = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
var columnsVol = int.Parse(Console.ReadLine());
int[,] array = new int[linesVol, columnsVol];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));
    }
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
Console.WriteLine("Введите координату х:");
var numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату у:");
var numberB = int.Parse(Console.ReadLine());

if (numberA>linesVol && numberB>columnsVol)
{
    Console.WriteLine("Такого числа нет");
}
else
{
    object numberC = array.GetValue(numberA,numberB);
    Console.WriteLine($"Такое число есть {numberC}");
}
