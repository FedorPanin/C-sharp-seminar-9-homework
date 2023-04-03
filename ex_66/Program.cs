//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = Sum(m, n);
Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна {sum}");

int Sum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else if (m > n)
    {
        return 0;
    }
    else
    {
        return m + Sum(m + 1, n);
    }
}