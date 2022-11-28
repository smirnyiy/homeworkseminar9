﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNumbers (int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNumbers (n-1);
    
}

Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*
int SumNumbersMN (int n, int m)

{
    if (n == m)
    {
        return n;
    }
    if (n > m)
    {
        return m + SumNumbersMN(n, m + 1);
    }
    return n + SumNumbersMN(n + 1, m);
}

Console.WriteLine("Input number m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbersMN(n, m));
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

/*
int Ackerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;

    }
    else if ((n != 0) && (m == 0))
    {
        return Ackerman(n - 1, 1);
    }
    return Ackerman(n - 1, Ackerman(n, m - 1));
}

Console.Write("Введите первое число m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({n},{m}) = {Ackerman(n, m)}");
*/