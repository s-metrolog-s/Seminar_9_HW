// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"

Random rand = new Random();
int numberM = rand.Next(1, 100);
int numberN = rand.Next(1, 100);
int multipleValue = 3;

while (numberN < numberM)
{
    numberM = rand.Next(1, 100);
    numberN = rand.Next(1, 100);
}

Console.Clear();
Console.WriteLine("**************************************************************");
Console.WriteLine($"Выводим все числа в промежутке {numberM} ... {numberN} кратные {multipleValue}:");
Console.WriteLine("**************************************************************");

ShowMultipleThree(numberM, numberN, multipleValue);

Console.WriteLine();
Console.WriteLine("**************************************************************");

void ShowMultipleThree(int numberM, int numberN, int value)
{
    int count = numberM;
    if (numberM > numberN) return;
    if (numberM % value == 0)
    {
        Console.Write(numberM + "\t");
    }

    ShowMultipleThree(numberM + 1, numberN, value);
}