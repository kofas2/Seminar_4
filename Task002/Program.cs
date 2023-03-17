// Задача 26: Напишите программу, которая принимает на вход целое или вещественное число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89,126 -> 5

Console.WriteLine("Введите целое или вещественное число: ");
double num = Convert.ToDouble(Console.ReadLine());
int count = 0;
TransNum(num);
int num2 = (int)TransNum2(num);
Console.WriteLine(num2);


void TransNum(double num)
{

    while (num % 1 > 0)
    {
        num *= 10;
    }
    while (num >= 1)
    {
        num /= 10;
        count++;
    }
    Console.WriteLine($"Количество цифр в числе равно: {count}");
}

double TransNum2(double num)
{

    while (num % 1 > 0)
    {
        num *= 10;
    }
    while (num >= 1)
    {
        num /= 10;
        count++;
    }
    return num;
}