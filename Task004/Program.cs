// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.WriteLine(Check(array));


void FillArray(int[] array)
{

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);    
}
}

void PrintArray(int[] array)
{
foreach (int index in array)
{
Console.Write(index);
}
}

bool Check (int[] array)
{
    bool t = false;
    int sum1 = 0;
    int sum2 = 0;
    foreach (int index in array)
    {
        if (index==0)
            sum1++;
        else if (index==1)
            sum2++;

    }
    if(sum1<sum2)
        t = true;
    return t;
}