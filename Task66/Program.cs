// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120 
// M = 4; N = 8. -> 30

Random rand = new Random();
int numberM = 1; // rand.Next(1, 100);
int numberN = 15; // rand.Next(1, 100);

while (numberN < numberM)
{
    numberM = rand.Next(1, 100);
    numberN = rand.Next(1, 100);
}

Console.Clear();
Console.WriteLine("**************************************************************");
Console.WriteLine($"Выводим сумму чисел в промежутке {numberM} ... {numberN}:");
Console.WriteLine("**************************************************************");

Console.WriteLine($"Сумма чисел равна: {SumAllValues(numberM, numberN)}");

Console.WriteLine();
Console.WriteLine("**************************************************************");

int SumAllValues(int numberM, int numberN)
{
    if (numberM > numberN) return 0;
    return numberM += SumAllValues(numberM + 1, numberN);
}