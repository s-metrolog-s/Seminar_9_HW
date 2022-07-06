// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Random rand = new Random();
double numberM = 3;
double numberN = 5;

Console.Clear();
Console.WriteLine($"******************************************");
Console.WriteLine($"Даны два числа m: {numberM} и n: {numberN}");

Console.WriteLine($"Результат вычисления функции Аккермана");
Console.WriteLine($"будет равен: {AсkermannFunction(numberM, numberN)}");
Console.WriteLine($"******************************************");

double AсkermannFunction(double numberM, double numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberM > 0 && numberN == 0) return AсkermannFunction(numberM - 1, 1);
    else if (numberM > 0 && numberN > 0) return AсkermannFunction(numberM - 1, AсkermannFunction(numberM, numberN - 1));
    return 0;
}


