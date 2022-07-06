// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Random rand = new Random();
int numberM = 2;
int numberN = 3;

Console.Clear();

Console.WriteLine(AсkermannFunction(numberM, numberN));

int AсkermannFunction(int numberM, int numberN)
{
    if (numberM > 0) return numberN + 1;
    if (numberM > 0 && numberN == 0) return AсkermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AсkermannFunction(numberM - 1, AсkermannFunction(numberM, numberN - 1));
    else return 0;
}


