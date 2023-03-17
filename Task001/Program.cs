// Задача 24: Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число");
int A = Convert.ToInt32(Console.ReadLine());
Summa(A);
Console.WriteLine($"Сумма по 2 функции всех чисел от 1 до {A} равна {Summa2(A)}");




void Summa(int A)
{
    int sum = 0;
    for (int i=1; i<=A; i++)
        sum+=i;
    Console.WriteLine($"Сумма всех чисел от 1 до {A} равна {sum}");
}

int Summa2(int A)
{
    int sum = 0;
    for (int i=1; i<=A; i++)
        sum+=i;
    return sum;
}